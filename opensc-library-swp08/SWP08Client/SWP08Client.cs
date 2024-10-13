using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenSC.Library.TaskSchedulerQueue;
using OpenSC.Messages.Interpreters;
using OpenSC.Model.SerialPorts;

namespace OpenSC.Library.SWP08Router
{
    public class SWP08Client
    {

        private IConnectionHandler connectionHandler;

        public SWP08Client(IConnectionHandler newConnectionHandler, byte matrix, byte level) {
            requestScheduler = new(sendRequest, invalidRequest);

            this.matrix = matrix;
            this.level = level;

            connectionHandler = newConnectionHandler;
            connectionHandler.ConnectionChanged += value => this.Connected = value;
            connectionHandler.MessageReceived += lineReceived;

            createInterpreters();
        }

        public void setConnectionHandler(IConnectionHandler newConnectionHandler)
        {
            if (connectionHandler != null)
            {
                connectionHandler.ConnectionChanged -= handleConnectionChange;
                connectionHandler.MessageReceived -= lineReceived;

                connectionHandler.Disconnect();
            }

            connectionHandler = newConnectionHandler;

            if (connectionHandler != null)
            {

                connectionHandler.ConnectionChanged += handleConnectionChange;
                connectionHandler.MessageReceived += lineReceived;
            }

            this.Connected = false;
        }

        private void handleConnectionChange(bool value)
        {
            this.Connected = value;
        }

        #region Video router properties

        private byte matrix, level;

        public byte Matrix
        {
            get;
            set;
        }

        public byte Level
        {
            get;
            set;
        }
        #endregion


        #region Connecting, disconnecting, connection state
        private bool connected;

        public bool Connected
        {
            get {
                if (connectionHandler == null) 
                    return false;

                return connectionHandler.getConnectState();
            }
            internal set {
                connected = value;

                if (value)
                    requestScheduler.Start();
                else if(requestScheduler.Running)
                    requestScheduler.Stop();

                ConnectionStateChanged?.Invoke(connected);
            }
        }

        public delegate void ConnectionStateChangedDelegate(bool state);
        public event ConnectionStateChangedDelegate ConnectionStateChanged;

        public void Connect() => this.connectionHandler.Connect();

        public void Disconnect() => this.connectionHandler.Disconnect();

        public bool HasConnectionHandler() => this.connectionHandler != null;

        public class NotConnectedException : Exception
        {
            public NotConnectedException() { }
            public NotConnectedException(string message) : base(message) { }
            public NotConnectedException(string message, Exception innerException) : base(message, innerException) { }
        }
        #endregion

        #region Crosspoints

        internal void NotifyCrosspointChanged(Crosspoint crosspoint)
        {
            CrosspointChanged?.Invoke(crosspoint);
        }

        public delegate void CrosspointChangedDelegate(Crosspoint crosspoint);
        public event CrosspointChangedDelegate CrosspointChanged;


        public void SetCrosspoint(short output, short input) => SetCrosspoint(new Crosspoint(output, input));

        internal void SetCrosspoint(Crosspoint crosspoint)
        {
            //checkCrosspointBeforeSet(crosspoint);
            scheduleRequest(new CrosspointConnectRequest(matrix, level, crosspoint));
        }

        public void SetCrosspoints(IEnumerable<Crosspoint> crosspoints)
        {
            foreach (var crosspoint in crosspoints)
            {
                //checkCrosspointBeforeSet(crosspoint);
                scheduleRequest(new CrosspointConnectRequest(matrix, level, crosspoint));
            }
        }


        public void QueryAllCrosspoints() => scheduleRequest(new AllCrosspointsRequest(matrix, level));
        #endregion


        #region Request scheduler
        private readonly TaskQueue<Request, bool> requestScheduler;
        private void sendRequest(Request request) => request.Send(this);
        private void invalidRequest(Request request) => Debug.WriteLine($"Dropped an invalid request for SW-P-08 protocol [{connectionHandler.getAddressString()}]");
        private void scheduleRequest(Request request)
        {
            requestScheduler.Enqueue(request);

            return;
        }
        internal void AckLastRequest()
        {
            requestScheduler.LastDequeuedTaskReady(true);
            currentInterpreter = null;
        }
        internal void NakLastRequest() => requestScheduler.LastDequeuedTaskReady(false);
        #endregion


        #region Protocol implementation
        private IMessageInterpreter currentInterpreter = null;
        private IMessageInterpreter[] knownInterpeters = null;

        private void createInterpreters()
        {
            knownInterpeters = new IMessageInterpreter[]
            {
                new ConnectedCommandInterpreter(this, matrix, level),
                new AckInterpreter(this),
                new DualControllerStatusInterpreter(this),
                new CrosspointTallyDumpInterpreter(this, matrix, level)
            };
        }

        private void lineReceived(byte[] line)
        {
            if (line.Length == 0) return;

            byte commandByte = (byte)(line[1] == 6 ? 99 : line[2]);

            currentInterpreter = knownInterpeters.FirstOrDefault(mi => mi.CanInterpret(commandByte));


            if (currentInterpreter != null)
            {
                try
                {
                    currentInterpreter.InterpretLine(unpackMessage(line));
                }
                catch (MessageInterpreterException) {
                    
                }
            } else
            {
                AckLastRequest();
            }
        }

        public void SendCommand(ICommand command)
        {
            connectionHandler.SendMessage(command.getCommand());
        }
        public void SendBlock(Byte[] messageData)
        {
            connectionHandler.SendMessage(messageData);
        }

        private Byte[] unpackMessage(Byte[] messageData)
        {
            List<Byte> unpackedMessage = new List<Byte>();

            Byte lastByte = 0;

            for (int i = 2; i < messageData.Length-2; i++)      // +/-2 to remove SOM & EOM
            {
                byte currByte = messageData[i];

                if(currByte == ProtocolStrings.DLE)             // replace DLE DLE with DLE
                {
                    if(lastByte == ProtocolStrings.DLE)
                    {
                        unpackedMessage.Add(currByte);
                    }
                } else
                {
                    unpackedMessage.Add(currByte);
                }

                lastByte = currByte;
            }

            // TODO Check checksum
            // TODO Check byte count

            return unpackedMessage.ToArray();
        }


        #endregion
    }
    
}
