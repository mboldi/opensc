using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenSC.Library.TaskSchedulerQueue;
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
            connectionHandler.Disconnect();

            connectionHandler = newConnectionHandler;
            connectionHandler.ConnectionChanged += value => this.Connected = value;
            connectionHandler.MessageReceived += lineReceived;
        }


        #region Videorouter properties
        private int inputCount;

        public int InputCount
        {
            get => inputCount;
            internal set
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
            internal set
            {
                if (value == outputCount)
                    return;
                outputCount = value;
                crosspoints = new int?[outputCount];
                OutputCountChanged?.Invoke(outputCount);
            }
        }

        public delegate void OutputCountChangedDelegate(int outputCount);
        public event OutputCountChangedDelegate OutputCountChanged;

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
            get => connectionHandler.getConnectState();
            internal set {
                connected = value;

                if (value)
                    requestScheduler.Start();
                else
                    requestScheduler.Stop();

                ConnectionStateChanged?.Invoke(connected);
            }
        }

        public delegate void ConnectionStateChangedDelegate(bool state);
        public event ConnectionStateChangedDelegate ConnectionStateChanged;

        public void Connect() => this.connectionHandler.Connect();

        public void Disconnect() => this.connectionHandler.Disconnect();

        public class NotConnectedException : Exception
        {
            public NotConnectedException() { }
            public NotConnectedException(string message) : base(message) { }
            public NotConnectedException(string message, Exception innerException) : base(message, innerException) { }
        }
        #endregion

        #region Crosspoints
        private int?[] crosspoints = null;

        internal void NotifyCrosspointChanged(Crosspoint crosspoint)
        {
            CrosspointChanged?.Invoke(crosspoint);
        }

        internal delegate void CrosspointChangedDelegate(Crosspoint crosspoint);
        internal event CrosspointChangedDelegate CrosspointChanged;

        public int? GetCrosspoint(int output)
        {
            if ((output < 0) || (output >= OutputCount))
                throw new ArgumentOutOfRangeException();
            return crosspoints[output];
        }

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

        private void checkCrosspointBeforeSet(Crosspoint crosspoint)
        {
            if ((crosspoint.Dest == null) || (crosspoint.Dest < 0) || (crosspoint.Dest >= OutputCount))
                throw new ArgumentOutOfRangeException();
            if ((crosspoint.Source == null) || (crosspoint.Source < 0) || (crosspoint.Source >= InputCount))
                throw new ArgumentOutOfRangeException();
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
        internal void AckLastRequest() => requestScheduler.LastDequeuedTaskReady(true);
        internal void NakLastRequest() => requestScheduler.LastDequeuedTaskReady(false);
        #endregion


        #region Protocol implementation
        private IMessageInterpreter currentInterpreter = null;
        private IMessageInterpreter[] knownInterpeters = null;

        private void createInterpreters()
        {
            knownInterpeters = new IMessageInterpreter[]
            {
                new ConnectedCommandInterpreter(),
                new DualControllerStatusInterpreter(this)
            };
        }

        private void lineReceived(byte[] line)
        {
            if (line.Length == 0)
            {
                if (currentInterpreter != null)
                {
                    currentInterpreter.BlockEnd();
                    currentInterpreter = null;
                }
                return;
            }
            if (currentInterpreter == null)
            {
                var asd = knownInterpeters.FirstOrDefault();

                currentInterpreter = knownInterpeters.FirstOrDefault(mi => mi.CanInterpret(line[2]));
                return;
            }
            if (currentInterpreter != null)
            {
                try
                {
                    currentInterpreter.InterpretLine(line);
                }
                catch (MessageInterpreterException) { }
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


        #endregion
    }
    
}
