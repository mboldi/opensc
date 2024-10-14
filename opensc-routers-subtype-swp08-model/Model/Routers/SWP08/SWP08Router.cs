
using OpenSC.Logger;
using OpenSC.Model;
using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Threading;
using OpenSC.Library.SWP08Router;
using System.Numerics;
using System.Linq;

namespace OpenSC.Model.Routers.SWP08
{
    [TypeLabel("Pro-Bel SW-P-08")]
    [TypeCode("swp08")]
    public partial class SWP08Router : Router
    {
        private new const string LOG_TAG = "Router/SW-P-08";

        private SWP08Client swpClient = null;

        public SWP08Router() 
        {
            initSWPRouter();
        }

        private void initSWPRouter()
        {
            if(connectionMode == RouterConnectionMode.IP)
            {
                swpClient = new SWP08Client(new TCPConnectionHandler(IpAddress), (byte)matrix, (byte)level);
            } else if (connectionMode == RouterConnectionMode.Serial)
            {
                swpClient = new SWP08Client(new SerialConnectionHandler(serialPort), (byte)matrix, (byte)level);
            }
            

            swpClient.ConnectionStateChanged += ConnectionStateChangedHandler;
            swpClient.CrosspointChanged += HandleCrosspointChange;

            if(AutoReconnect)
            {
                swpClient.Connect();
            }
        }

        public override void RestoredOwnFields()
        {
            base.RestoredOwnFields();

            initSWPRouter();
            startAutoReconnectThread();
        }

        public override void Removed()
        {
            base.Removed();

            Disconnect();
            swpClient.ConnectionStateChanged -= ConnectionStateChangedHandler;
            swpClient.CrosspointChanged -= HandleCrosspointChange;
            swpClient = null;

            IpAddressChanged = null;
            ConnectionStateChanged = null;
            AutoReconnectChanged = null;

            autoReconnectThreadWorking = false;
            autoReconnectThread = null;
        }

        private void HandleCrosspointChange(Crosspoint crosspoint)
        {
            if (crosspoint == null)
                return;
            try
            {
                notifyCrosspointChanged(crosspoint.Dest, crosspoint.Source);
            }
            catch { }
        }

        private void ConnectionStateChangedHandler(bool newState)
        {
            Connected = newState;

            if(Connected)
            {
                queryAllStates();
            } else if(autoReconnect)
            {
                startAutoReconnectThread();
            }
        }

        #region Property: Connection mode
        public event PropertyChangedTwoValuesDelegate<SWP08Router, RouterConnectionMode> ConnectionModeChanged;

        private RouterConnectionMode connectionMode;

        [PersistAs("connection_mode")]
        public RouterConnectionMode ConnectionMode
        {
            get => connectionMode;
            set
            {
                if (connectionMode != value)
                {
                    ConnectionModeChanged?.Invoke(this, connectionMode, value);
                    connectionMode = value;

                    switch (connectionMode)
                    {
                        case RouterConnectionMode.Serial:
                            swpClient.setConnectionHandler(new SerialConnectionHandler(SerialPort));
                            break;
                        case RouterConnectionMode.IP:
                            swpClient.setConnectionHandler(new TCPConnectionHandler(IpAddress));
                            break;
                    }
                }
            }
        }
        #endregion

        #region Property: Ip Address
        public event PropertyChangedTwoValuesDelegate<SWP08Router, string> IpAddressChanged;

        private string ipAddress;

        [PersistAs("ip_address")]
        public string IpAddress
        {
            get => ipAddress;
            set
            {
                if (ipAddress != value)
                {
                    ipAddress = value;

                    if(connectionMode == RouterConnectionMode.IP)
                    {
                        if(swpClient == null)
                            swpClient = new SWP08Client(new TCPConnectionHandler(IpAddress), (byte)matrix, (byte)level);
                        else 
                            swpClient.setConnectionHandler(new TCPConnectionHandler(IpAddress));
                    }
                }
            }
        }

        public void ValidateIpAddress(string ipAddress)
        {
            // ... throw new ArgumentException();
        }
        #endregion

        #region Auto reconnect
        public event PropertyChangedTwoValuesDelegate<SWP08Router, bool> AutoReconnectChanged;

        private bool autoReconnect;

        [PersistAs("auto_reconnect")]
        public bool AutoReconnect
        {
            get => autoReconnect;
            set {
                bool ov = autoReconnect;

                autoReconnect = value;

                if(!ov && autoReconnect)
                {
                    startAutoReconnectThread();
                } else if(ov && !autoReconnect)
                {
                    autoReconnectThreadWorking = false;
                    autoReconnectThread.Interrupt();
                }
            }
        }


        private const int RECONNECT_TRY_INTERVAL = 10000;

        private Thread autoReconnectThread = null;
        private bool autoReconnectThreadWorking = false;

        private void startAutoReconnectThread()
        {
            autoReconnectThread = new Thread(autoReconnectThreadMethod)
            {
                IsBackground = true
            };
            autoReconnectThreadWorking = true;
            autoReconnectThread.Start();
        }

        private void autoReconnectThreadMethod()
        {

            string logMessage = string.Format("Trying auto reconnect to an SW-P-08 router (ID: {0}) with IP {1}...",
                ID,
                IpAddress);
            LogDispatcher.I(LOG_TAG, logMessage);

            if (autoReconnect && !connected)
                Connect();
            while (autoReconnectThreadWorking && autoReconnect && !connected)
            {
                Thread.Sleep(RECONNECT_TRY_INTERVAL);
                if (autoReconnect && !connected)
                    Connect();
            }

        }
        #endregion


        public void Connect()
        {
            if(connected) return;

            if(!swpClient.HasConnectionHandler() && connectionMode == RouterConnectionMode.IP)
            {
                swpClient.setConnectionHandler(new TCPConnectionHandler(IpAddress));
            }

            swpClient.Connect();
        }

        public void Disconnect()
        {
            swpClient.Disconnect();
        }

        #region Property: Serial Port
        [PersistAs("serial_port")]
        private SerialPort serialPort;

        public SerialPort SerialPort
        {
            get => serialPort;
            set
            {
                serialPort = value;

                if(connectionMode == RouterConnectionMode.Serial)
                {
                    swpClient.setConnectionHandler(new SerialConnectionHandler(SerialPort));
                }
            }
        }
        #endregion

        #region Property: Connected
        public event PropertyChangedTwoValuesDelegate<SWP08Router, bool> ConnectionStateChanged;

        private bool connected;

        public bool Connected
        {
            get => connected;
            set
            {
                bool ov = connected;

                if (value)
                {
                    State = RouterState.Ok;
                    StateString = "connected";
                    string logMessage = string.Format("Connected to an SW-P-08 router (ID: {0}) {1}.", ID, 
                        ConnectionMode == RouterConnectionMode.Serial ? "on serial port " + SerialPort : "with IP " + IpAddress);
                    LogDispatcher.I(LOG_TAG, logMessage);
                }
                else
                {
                    State = RouterState.Warning;
                    StateString = "disconnected";
                    string logMessage = string.Format("Disconnected from an SW-P-08 router (ID: {0}) {1}.", ID,
                        ConnectionMode == RouterConnectionMode.Serial ? "on serial port " + SerialPort : "with IP " + IpAddress);
                    LogDispatcher.I(LOG_TAG, logMessage);
                }

                ConnectionStateChanged?.Invoke(this, ov, value);
                connected = value;
            }
        }


        #endregion

        #region Matrix & Level

        private int matrix = 0;
        private int level = 0;

        [PersistAs("matrix")]
        public int Matrix
        {
            get { return matrix; }
            set
            {
                if (value >= 0 && value < 16)
                {
                    matrix = value;
                    swpClient.Matrix = (byte)matrix;
                }
            }
        }

        [PersistAs("level")]
        public int Level
        {
            get { return level; }
            set
            {
                if (value >= 0 && value < 16)
                {
                    level = value;
                    swpClient.Level = (byte)level;
                }
            }
        }
        #endregion

        public override RouterInput CreateInput(string name, int index)
        {
            return new RouterInput(name, this, index);
        }

        public override RouterOutput CreateOutput(string name, int index)
        {
            return new RouterOutput(name, this, index);
        }

        protected override void queryAllStates()
        {
            swpClient.QueryAllCrosspoints();
        }

        protected override void requestCrosspointUpdateImpl(RouterOutput output, RouterInput input)
        {
            var crosspointList = new List<RouterCrosspoint>();
            crosspointList.Add(new RouterCrosspoint(output, input));

            requestCrosspointUpdatesImpl(crosspointList);
        }

        protected override void requestCrosspointUpdatesImpl(IEnumerable<RouterCrosspoint> crosspoints)
        {
            if(crosspoints.Any(cp => cp.Output.Index > short.MaxValue || cp.Input.Index > short.MaxValue)) throw new ArgumentOutOfRangeException();

            IEnumerable<Crosspoint> swpCrosspoints = crosspoints.Select(crosspoint => new Crosspoint((short)crosspoint.Output.Index, (short)crosspoint.Input.Index));

            swpClient.SetCrosspoints(swpCrosspoints);
        }

        protected override void requestLockOperationImpl(RouterOutput output, RouterOutputLockType lockType, RouterOutputLockOperationType lockOperationType)
        {
            throw new System.NotImplementedException();
        }

    }
}
