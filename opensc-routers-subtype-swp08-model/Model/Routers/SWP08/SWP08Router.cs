
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

namespace OpenSC
{
    [TypeLabel("Pro-Bel SW-P-08")]
    [TypeCode("swp08")]
    public partial class SWP08Router : Router
    {
        private new const string LOG_TAG = "Router/SW-P-08";


        private static byte DLE = hexToByte("10");
        private static byte STX = hexToByte("02");
        private static byte ETX = hexToByte("03");

        private static Byte[] ACK = { DLE, hexToByte("06") };       // Acknowledge message
        private static Byte[] NAK = { DLE, hexToByte("15") };       // No acknowledge message

        private static Byte[] SOM = { DLE, STX };                   // Start of message
        private static Byte[] EOM = { DLE, ETX };                   // End of message

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


        #region Helper functions



        // Everything indexed from 0!
        Byte[] createCrosspointConnectMessage(byte matrix, byte level, Int16 dest, Int16 source)
        {
            List<Byte> dataBytes = new List<Byte>();

            // Command byte
            dataBytes.Add(hexToByte("02"));

            // Matrix - Level
            dataBytes.Add((byte)(level + 16 * matrix));

            dataBytes.Add(generateMultiplier(dest, source));

            dataBytes.Add((byte)(dest % 128));

            dataBytes.Add((byte)(source % 128));

            return dataBytes.ToArray();
        }


        Byte[] packageMessage(Byte[] DATA)
        {
            List<Byte> message = new List<Byte>();


            byte BTC = (byte)DATA.Length;
            var CHK = calcCHK(DATA, BTC);

            message.AddRange(DATA);

            message.Add(BTC);
            message.Add((byte)CHK);

            for (int i = 0; i < message.Count; i++)
            {
                if (message[i] == DLE)
                {
                    message.Insert(++i, DLE);
                }
            }

            // Start of message
            message.Insert(0, STX);
            message.Insert(0, DLE);

            // End of message
            message.Add(DLE);
            message.Add(ETX);

            return message.ToArray();
        }


        private Byte calcBTC(Byte[] DATA)
        {
            return (byte)DATA.Length;
        }

        private SByte calcCHK(Byte[] DATA, Byte BTC)
        {
            SByte CHK = 0;

            Byte sumBytes = 0;

            foreach (Byte b in DATA)
            {
                sumBytes += b;
            }

            sumBytes += BTC;

            return twosComplement(sumBytes);
        }


        private SByte twosComplement(Byte inByte)
        {
            return (sbyte)(~inByte + 1);
        }

        private Byte generateMultiplier(Int16 dest, Int16 source)
        {
            return (byte)(source / 128 + 16 * (dest / 128));
        }

        private static Byte hexToByte(String hexString)
        {
            if (hexString.Length != 2) throw new Exception("Not valid input!");

            return byte.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }

        private static Byte[] hexToByteArray(String hexString)
        {
            List<Byte> outBytes = new List<Byte>();

            for (int i = 0; i < hexString.Length / 2; i++)
            {
                outBytes.Add(hexToByte(hexString.Substring(i * 2, 2)));
            }

            return outBytes.ToArray();
        }
        #endregion
    }
}
