using OpenSC.Logger;
using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenSC.Model.UMDs.ImageVideo
{

    public partial class ImageVideoUnit : ModelBase
    {

        #region Instantiation, restoration
        public override void RestoredOwnFields()
        {
            base.RestoredOwnFields();
            updateEndpoint();
        }

        public override void Removed()
        {
            base.Removed();

            stopSocketStatusCheckTask();
            disposeExistingSocket();

            IpAddressChanged = null;
            PortChanged = null;
            AutoConnectChanged = null;
            AutoReconnectChanged = null;
            ConnectedChanged = null;
        }
        #endregion

        #region OwnerDatabase
        public override IDatabaseBase OwnerDatabase => ImageVideoUnitDatabase.Instance;
        #endregion

        #region Property: IpAddress
        [AutoProperty]
        [AutoProperty.AfterChange(nameof(updateEndpoint))]
        [PersistAs("ipaddress")]
        private string ipAddress;
        #endregion

        #region Property: Port
        [AutoProperty]
        [AutoProperty.AfterChange(nameof(updateEndpoint))]
        [AutoProperty.Validator(nameof(ValidatePort))]
        [PersistAs("port")]
        private int port = 9800;

        public void ValidatePort(int port)
        {
            if ((port < 0) || (port > 65534))
                throw new ArgumentOutOfRangeException();
        }
        #endregion

        #region Property: AutoConnect
        public event PropertyChangedTwoValuesDelegate<ImageVideoUnit, bool> AutoConnectChanged;

        [PersistAs("auto_connect")]
        private bool autoConnect = true;

        public bool AutoConnect
        {
            get => autoConnect;
            set => this.setProperty(ref autoConnect, value, AutoConnectChanged, null, (ov, nv) => {
                if (nv)
                    shouldBeConnected = true;
            });
        }
        #endregion

        #region Property: AutoReconnect
        public event PropertyChangedTwoValuesDelegate<ImageVideoUnit, bool> AutoReconnectChanged;

        [PersistAs("auto_reconnect")]
        private bool autoReconnect = true;

        public bool AutoReconnect
        {
            get => autoReconnect;
            set => this.setProperty(ref autoReconnect, value, AutoReconnectChanged);
        }
        #endregion

        #region Property: AutoReconnectInterval
        public event PropertyChangedTwoValuesDelegate<ImageVideoUnit, int> AutoReconnectIntervalChanged;

        [PersistAs("auto_reconnect_interval")]
        private int autoReconnectInterval = 5;

        public int AutoReconnectInterval
        {
            get => autoReconnectInterval;
            set => this.setProperty(ref autoReconnectInterval, value, AutoReconnectIntervalChanged);
        }
        #endregion

        #region Property: Connected
        public event PropertyChangedTwoValuesDelegate<ImageVideoUnit, bool> ConnectedChanged;

        private bool connected = false;

        public bool Connected
        {
            get => connected;
            private set => this.setProperty(ref connected, value, ConnectedChanged);
        }
        #endregion

        #region Socket - connection basics
        private Socket tcpSocket;

        public async Task Connect()
        {
            if (ipEndpoint == null)
            {
                Connected = false;
                return;
            }
            shouldBeConnected = true;
            disposeExistingSocket();
            tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                await tcpSocket.ConnectAsync(ipEndpoint);
                Connected = tcpSocket.Connected;
                LogDispatcher.I("ImageVideo", string.Format("Connected to  Imagevideo unit with IP {0}:{1}", IpAddress, Port));
            } catch (Exception ex)
            {
                LogDispatcher.W("ImageVideo", string.Format("Couldn't connect to  Imagevideo unit with IP {0}:{1}", IpAddress, Port));
            }
        }

        public void Disconnect()
        {
            shouldBeConnected = false;
            if (tcpSocket != null)
            {
                try
                {
                    tcpSocket.DisconnectAsync(new());
                }
                catch { }
            }
            disposeExistingSocket();
        }

        public async void Reconnect()
        {
            Disconnect();
            await Connect();
        }

        private void disposeExistingSocket()
        {
            if (tcpSocket == null)
                return;
            try
            {
                tcpSocket.Dispose();
            }
            catch { }
            tcpSocket = null;
            Connected = false;
        }
        #endregion

        #region Socket - status checking, auto connection and reconnection
        bool shouldBeConnected = false;
        int timeSinceLastConnectAttempt = -1;

        private async Task socketStatusCheckTaskMethod()
        {
            while (true)
            {
                try
                {
                    if (Connected)
                    {
                        checkSocketStatus();
                    }
                    else if (shouldBeConnected)
                    {
                        if ((timeSinceLastConnectAttempt < 0) || (timeSinceLastConnectAttempt >= autoReconnectInterval))
                        {
                            await Connect();
                            timeSinceLastConnectAttempt = 0;
                        }
                        else
                        {
                            timeSinceLastConnectAttempt++;
                        }
                    }
                    await Task.Delay(1000);
                }
                catch (OperationCanceledException)
                { }
            }
        }

        private CancellationTokenSource socketStatusCheckTasCancellationTokenSource;
        private Task socketStatusCheckTask;

        private void startSocketStatusCheckTask()
        {
            socketStatusCheckTasCancellationTokenSource = new();
            socketStatusCheckTask = Task.Run(socketStatusCheckTaskMethod);
        }

        private async void stopSocketStatusCheckTask()
        {
            if (socketStatusCheckTask == null)
                return;
            try
            {
                socketStatusCheckTasCancellationTokenSource.Cancel();
                await socketStatusCheckTask;
                socketStatusCheckTask.Dispose();
                socketStatusCheckTask = null;
                socketStatusCheckTasCancellationTokenSource.Dispose();
                socketStatusCheckTasCancellationTokenSource = null;
            }
            catch (ObjectDisposedException)
            { }
        }

        private void notifySocketDisconnected()
        {
            timeSinceLastConnectAttempt = 0;
            disposeExistingSocket();
        }

        private bool checkSocketStatus()
        {
            try
            {
                return tcpSocket.Poll(1, SelectMode.SelectWrite);
            }
            catch (SocketException)
            {
                return false;
            }
            catch (ObjectDisposedException)
            {
                return false;
            }
        }
        #endregion

        #region Socket - sending
        private void sendTcpPacket(string packet)
        {
            if (tcpSocket == null)
                return;
            byte[] data = Encoding.ASCII.GetBytes(packet);
            try
            {
                tcpSocket.Send(data, 0, data.Length, SocketFlags.None);
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode == SocketError.NotConnected)
                    notifySocketDisconnected();
            }
        }

        internal void SendDisplayCommand(string command)
        {
            if(Connected)
                sendTcpPacket(command);
        }
        #endregion

        #region Socket - endpoint
        private IPEndPoint ipEndpoint;

        private void updateEndpoint()
        {
            bool wasConnected = Connected;
            if (!IPAddress.TryParse(ipAddress, out IPAddress typedIpAddress))
            {
                ipEndpoint = null;
                return;
            }
            ipEndpoint = new IPEndPoint(typedIpAddress, port);
            if (wasConnected)
                Reconnect();
        }

        string ipAddressBeforeUpdate;
        int portBeforeUpdate;

        private void ipEndpointBeforeUpdate()
        {
            ipAddressBeforeUpdate = ipAddress;
            portBeforeUpdate = port;
        }

        private void ipEndpointAfterUpdate()
        {
            if ((ipAddressBeforeUpdate != ipAddress) || (portBeforeUpdate != port))
                updateEndpoint();
        }
        #endregion

    }

}
