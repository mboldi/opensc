﻿using System;
using System.Collections.Generic;

namespace BMD.Videohub
{

    public class BlackMagicVideohub
    {

        public BlackMagicVideohub(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        private string ipAddress;

        public string IpAddress
        {
            get { return ipAddress; }
            set
            {
                if (value == ipAddress)
                    return;
                bool wasConnected = connected;
                if (wasConnected)
                    Disconnect();
                ipAddress = value;
                if (wasConnected)
                    Connect();
            }
        }

        #region Videohub model properties
        private int inputCount;

        public int InputCount
        {
            get => inputCount;
            set
            {
                if (value == inputCount)
                    return;
                inputCount = value;
                InputCountChanged?.Invoke(inputCount);
            }
        }

        public delegate void InputCountChangedDelegate(int inputCount);
        public event InputCountChangedDelegate InputCountChanged;

        private int outputCount;

        public int OutputCount
        {
            get => outputCount;
            set
            {
                if (value == outputCount)
                    return;
                outputCount = value;
                crosspoints = new int?[outputCount];
                locks = new LockState?[outputCount];
                OutputCountChanged?.Invoke(outputCount);
            }
        }

        public delegate void OutputCountChangedDelegate(int outputCount);
        public event OutputCountChangedDelegate OutputCountChanged;

        private string modelName;

        public string ModelName
        {
            get => modelName;
            set
            {
                if (value == modelName)
                    return;
                modelName = value;
                ModelNameChanged?.Invoke(modelName);
            }
        }

        public delegate void ModelNameChangedDelegate(string modelName);
        public event ModelNameChangedDelegate ModelNameChanged;
        #endregion

        #region Connecting, disconnecting, connection state
        private bool connected;

        public bool Connected
        {
            get { return connected; }
            private set
            {
                if (value == connected)
                    return;
                connected = value;
                ConnectionStateChanged?.Invoke(connected);
            }
        }

        public delegate void ConnectionStateChangedDelegate(bool state);
        public event ConnectionStateChangedDelegate ConnectionStateChanged;

        public void Connect()
        {
            createReceiver();
            socketReceiver.Connect();
        }

        public void Disconnect()
        {
            socketReceiver?.Disconnect();
        }

        public class NotConnectedException : Exception
        {

            public NotConnectedException()
            { }

            public NotConnectedException(string message) : base(message)
            { }

            public NotConnectedException(string message, Exception innerException) : base(message, innerException)
            { }

        }
        #endregion

        #region Crosspoints
        private int?[] crosspoints = null;

        List<Crosspoint> pendingCrosspointChangeRequests = new List<Crosspoint>();

        public void SetCrosspoint(int output, int input)
        {

            if (!Connected)
                throw new NotConnectedException();
            if ((output < 0) || (output >= OutputCount))
                throw new ArgumentOutOfRangeException();
            if ((input < 0) || (input >= InputCount))
                throw new ArgumentOutOfRangeException();

            pendingCrosspointChangeRequests.Clear();
            pendingCrosspointChangeRequests.Add(new Crosspoint(output, input));

            socketReceiver.SendLine(BLOCK_START_VIDEO_OUTPUT_ROUTING);
            socketReceiver.SendLine(string.Format("{0} {1}", output, input));
            socketReceiver.SendLine("");

        }

        public void SetCrosspoints(IEnumerable<Crosspoint> crosspoints)
        {

            if (!Connected)
                throw new NotConnectedException();
            foreach (Crosspoint crosspoint in crosspoints)
            {
                if ((crosspoint.Destination < 0) || (crosspoint.Destination >= OutputCount))
                    throw new ArgumentOutOfRangeException();
                if ((crosspoint.Source < 0) || (crosspoint.Source >= InputCount))
                    throw new ArgumentOutOfRangeException();
            }

            pendingCrosspointChangeRequests.Clear();
            socketReceiver.SendLine(BLOCK_START_VIDEO_OUTPUT_ROUTING);
            foreach (Crosspoint crosspoint in crosspoints)
            {
                socketReceiver.SendLine(string.Format("{0} {1}", crosspoint.Destination, crosspoint.Source));
                pendingCrosspointChangeRequests.Add(crosspoint);
            }
            socketReceiver.SendLine("");

        }

        public int? GetCrosspoint(int output)
        {
            if ((output < 0) || (output >= OutputCount))
                throw new ArgumentOutOfRangeException();
            return crosspoints[output];
        }

        public void QueryAllCrosspoints()
        {
            if (!Connected)
                return;
            if (pendingCrosspointChangeRequests.Count != 0)
                return;
            socketReceiver.SendLine(BLOCK_START_VIDEO_OUTPUT_ROUTING);
            socketReceiver.SendLine("");
        }

        public delegate void CrosspointChangedDelegate(int output, int? input);
        public event CrosspointChangedDelegate CrosspointChanged;

        private void updateCrosspoint(int output, int input)
        {
            if (output >= outputCount)
                return;
            int? inputNullable = (input < inputCount) ? (int?)input : null;
            crosspoints[output] = inputNullable;
            CrosspointChanged?.Invoke(output, inputNullable);
        }

        public record Crosspoint(int Destination, int Source);
        #endregion

        #region Locks
        private LockState?[] locks = null;

        LockChangeRequest pendingLockChangeRequest = null;

        public void SetLockState(int output, bool state)
        {

            if (!Connected)
                throw new NotConnectedException();
            if ((output < 0) || (output >= OutputCount))
                throw new ArgumentOutOfRangeException();

            pendingLockChangeRequest = new LockChangeRequest()
            {
                Destination = output,
                State = state
            };

            socketReceiver.SendLine(BLOCK_START_VIDEO_OUTPUT_LOCKS);
            socketReceiver.SendLine(string.Format("{0} {1}", output, state ? 'O' : 'U'));
            socketReceiver.SendLine("");

        }

        public LockState? GetLockState(int output)
        {
            if ((output < 0) || (output >= OutputCount))
                throw new ArgumentOutOfRangeException();
            return locks[output];
        }

        public enum LockState
        {
            Unlocked,
            Owned,
            Taken
        }

        public void QueryAllLockStates()
        {
            if (!Connected)
                return;
            if (pendingCrosspointChangeRequests.Count != 0)
                return;
            socketReceiver.SendLine(BLOCK_START_VIDEO_OUTPUT_LOCKS);
            socketReceiver.SendLine("");
        }

        public delegate void LockChangedDelegate(int output, LockState state);
        public event LockChangedDelegate LockChanged;

        private void updateLockState(int output, LockState state)
        {
            if (output >= outputCount)
                return;
            locks[output] = state;
            LockChanged?.Invoke(output, state);
        }

        private class LockChangeRequest
        {
            public int Destination;
            public bool State;
        }
        #endregion

        #region TCP receiver/sender socket
        private const int BMD_VIDEOHUB_PROTOCOL_TCP_PORT = 9990;

        private TcpSocketLineByLineReceiver socketReceiver = null;

        private void createReceiver()
        {
            if (socketReceiver != null)
                disposeReceiver();
            socketReceiver = new TcpSocketLineByLineReceiver(ipAddress, BMD_VIDEOHUB_PROTOCOL_TCP_PORT);
            socketReceiver.LineReceived += lineReceivedOnTcpSocket;
            socketReceiver.ConnectedStateChanged += connectionStateOfTcpSocketChanged;
        }

        private void disposeReceiver()
        {
            socketReceiver.Dispose();
            socketReceiver = null;
        }
        private void connectionStateOfTcpSocketChanged(bool state)
        {
            if (state == false)
                Connected = false;
        }
        #endregion

        #region Protocol implementation
        private const string BLOCK_START_VIDEOHUB_DEVICE = "VIDEOHUB DEVICE:";
        private const string BLOCK_START_VIDEO_OUTPUT_ROUTING = "VIDEO OUTPUT ROUTING:";
        private const string BLOCK_START_VIDEO_OUTPUT_LOCKS = "VIDEO OUTPUT LOCKS:";
        private const string ACK = "ACK";

        private const string VHD_KEY_DEVICE_PRESENT = "Device present";
        private const string VHD_KEY_MODEL_NAME = "Model name";
        private const string VHD_KEY_VIDEO_INPUTS = "Video inputs";
        private const string VHD_KEY_VIDEO_OUTPUTS = "Video outputs";

        private BlockType currentBlockType = BlockType.Unknown;

        private void lineReceivedOnTcpSocket(string line)
        {
            switch (currentBlockType)
            {
                case BlockType.Unknown:
                    processLineAtBlockUnknown(line);
                    break;
                case BlockType.VideohubDevice:
                    processLineAtBlockVideohubDevice(line);
                    break;
                case BlockType.VideoOutputRouting:
                    processLineAtBlockVideoOutputRouting(line);
                    break;
                case BlockType.VideoOutputLocks:
                    processLineAtBlockVideoOutputLocks(line);
                    break;
            }
        }

        private void processLineAtBlockUnknown(string line)
        {

            if (line == BLOCK_START_VIDEOHUB_DEVICE)
            {
                currentBlockType = BlockType.VideohubDevice;
                return;
            }

            if (line == BLOCK_START_VIDEO_OUTPUT_ROUTING)
            {
                currentBlockType = BlockType.VideoOutputRouting;
                return;
            }

            if (line == BLOCK_START_VIDEO_OUTPUT_LOCKS)
            {
                currentBlockType = BlockType.VideoOutputLocks;
                return;
            }

            if (line == ACK)
            {
                if (pendingCrosspointChangeRequests.Count != 0)
                {
                    foreach (Crosspoint crosspoint in pendingCrosspointChangeRequests)
                    updateCrosspoint(crosspoint.Destination, crosspoint.Source);
                    pendingCrosspointChangeRequests.Clear();
                }
                return;
            }

        }

        private void processLineAtBlockVideohubDevice(string line)
        {

            if (line == string.Empty)
            {
                currentBlockType = BlockType.Unknown;
                return;
            }

            string[] parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
            if (parts.Length == 2)
            {
                switch (parts[0])
                {
                    case VHD_KEY_DEVICE_PRESENT:
                        Connected = (parts[1] == "true");
                        break;
                    case VHD_KEY_MODEL_NAME:
                        ModelName = parts[1];
                        break;
                    case VHD_KEY_VIDEO_INPUTS:
                        if (int.TryParse(parts[1], out int inputCount))
                            InputCount = inputCount;
                        break;
                    case VHD_KEY_VIDEO_OUTPUTS:
                        if (int.TryParse(parts[1], out int outputCount))
                            OutputCount = outputCount;
                        break;
                }
            }

        }

        private void processLineAtBlockVideoOutputRouting(string line)
        {

            if (line == string.Empty)
            {
                currentBlockType = BlockType.Unknown;
                return;
            }

            string[] parts = line.Split(' ');
            if ((parts.Length == 2) && int.TryParse(parts[0], out int dst) && int.TryParse(parts[1], out int src))
                updateCrosspoint(dst, src);

        }

        private void processLineAtBlockVideoOutputLocks(string line)
        {
            if (line == string.Empty)
            {
                currentBlockType = BlockType.Unknown;
                return;
            }
            string[] parts = line.Split(' ');
            if ((parts.Length == 2) && int.TryParse(parts[0], out int dst) && LOCK_STATE_LETTERS.TryGetValue(parts[1], out LockState state))
                updateLockState(dst, state);
        }

        private static readonly Dictionary<string, LockState> LOCK_STATE_LETTERS = new Dictionary<string, LockState>()
        {
            { "U", LockState.Unlocked },
            { "O", LockState.Owned },
            { "L", LockState.Taken },
        };

        private enum BlockType
        {
            Unknown,
            VideohubDevice,
            VideoOutputRouting,
            VideoOutputLocks
        }
        #endregion


    }

}
