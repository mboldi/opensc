
using OpenSC.Logger;
using OpenSC.Model;
using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.Routers;
using OpenSC.Model.Routers.SWP08;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Threading;
using OpenSC.Library.SWP08Router;

namespace OpenSC
{
    [TypeLabel("Pro-Bel SW-P-08")]
    [TypeCode("swp08")]
    public partial class SWP08Router : Router
    {
        private new const string LOG_TAG = "Router/SW-P-08";


        #region Property: Connection mode
        public event PropertyChangedTwoValuesDelegate<SWP08Router, RouterConnectionMode> ConnectionModeChanged;

        private RouterConnectionMode connectionMode;

        [PersistAs("connection_mode")]
        public RouterConnectionMode ConnectionMode
        {
            get => connectionMode;
            set => this.setProperty(ref connectionMode, value, ConnectionModeChanged,
                null, null, null);
        }
        #endregion

        #region Property: Ip Address
        public event PropertyChangedTwoValuesDelegate<SWP08Router, string> IpAddressChanged;

        private string ipAddress;

        [PersistAs("ip_address")]
        public string IpAddress
        {
            get => ipAddress;
            set => this.setProperty(ref ipAddress, value, IpAddressChanged,
                null, null, ValidateIpAddress);
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
            set => this.setProperty(ref autoReconnect, value, AutoReconnectChanged);
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

        public void Connect() { }

        #region Property: Serial Port
        [AutoProperty]
        [AutoProperty.BeforeChange(nameof(_serial_port_beforeChange))]
        [AutoProperty.AfterChange(nameof(_serial_port_afterChange))]
        [PersistAs("serial_port")]
        private SerialPort serialPort;

        public SerialPort SerPort
        {
            get; set;
        }

        private void _serial_port_beforeChange(SerialPort oldValue, SerialPort newValue, BeforeChangePropertyArgs args)
        {
            if (oldValue != null)
            {
                oldValue.ReceivedDataAsciiLine -= receivedLineFromSerialPort;
                oldValue.InitializedChanged -= serialPortInitializedChangedHandler;
            }
        }

        private void _serial_port_afterChange(SerialPort oldValue, SerialPort newValue)
        {
            if (newValue != null)
            {
                newValue.ReceivedDataAsciiLine += receivedLineFromSerialPort;
                newValue.InitializedChanged += serialPortInitializedChangedHandler;
                initSerial();
            }
        }

        private void serialPortInitializedChangedHandler(SerialPort port, bool oldState, bool newState)
        {
            if (newState)
            {
                initSerial();
                Connected = true;
            } else
            {
                Connected = false;
            }
        }

        private void initSerial()
        {
            queryAllStates();
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
                AfterChangePropertyDelegate<bool> afterChangeDelegate = (ov, nv) =>
                {
                    if (nv)
                    {
                        State = RouterState.Ok;
                        StateString = "connected";
                        string logMessage = string.Format("Connected to an SW-P-08 router (ID: {0}) {1}.", ID, 
                            ConnectionMode == RouterConnectionMode.Serial ? "on serial port " + SerPort : "with IP " + IpAddress);
                        LogDispatcher.I(LOG_TAG, logMessage);
                    }
                    else
                    {
                        State = RouterState.Warning;
                        StateString = "disconnected";
                        string logMessage = string.Format("Disconnected from an SW-P-08 router (ID: {0}) {1}.", ID,
                            ConnectionMode == RouterConnectionMode.Serial ? "on serial port " + SerPort : "with IP " + IpAddress);
                        LogDispatcher.I(LOG_TAG, logMessage);
                    }
                };
                this.setProperty(ref connected, value, ConnectionStateChanged, null, afterChangeDelegate);
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
            
        }

        protected override void requestCrosspointUpdateImpl(RouterOutput output, RouterInput input)
        {
            throw new System.NotImplementedException();
        }

        protected override void requestCrosspointUpdatesImpl(IEnumerable<RouterCrosspoint> crosspoints)
        {
            throw new System.NotImplementedException();
        }

        protected override void requestLockOperationImpl(RouterOutput output, RouterOutputLockType lockType, RouterOutputLockOperationType lockOperationType)
        {
            throw new System.NotImplementedException();
        }

        #region Serial communication & handling
        private void receivedLineFromSerialPort(SerialPort port, string asciiLine)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
