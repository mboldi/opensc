using OpenSC.Library.SWP08Router;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    public class TCPConnectionHandler : IConnectionHandler
    {
        //private TcpSocketLineByLineReceiver lineReceiver;
        private Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

        #region IP Address & port
        private string ipAddress;
        private int port;

        public string IpAddress
        {
            get
            {
                return ipAddress.ToString() + ":" + port.ToString();
            }

            set
            {
                if (value == null) return;
                if (ipAddress != null && port != null &&
                    value == ipAddress.ToString() + ":" + port.ToString())
                    return;
                bool wasConnected = Connected;
                if (wasConnected)
                    Disconnect();
                var addressBits = value.Split(':');

                ipAddress = addressBits[0];
                port = int.Parse(addressBits[1]);

                if (wasConnected)
                    Connect();
            }
        }

        override public void Dispose()
        {
            try
            {
                if (socket.Connected)
                    socket.Disconnect(false);
                FireConnectionChanged(socket.Connected);
                socket.Dispose();
            }
            catch (ObjectDisposedException) { }
        }

        #endregion
        public TCPConnectionHandler(string ipAddressWithPort)
        {
            IpAddress = ipAddressWithPort;
        }

        public TCPConnectionHandler(string ipAddress, int port)
        {
            IpAddress = ipAddress.ToString() + ":" + port.ToString();
        }

        #region Connection state
        private bool connected;

        public bool Connected
        {
            get => connected;
            set
            {
                if (value == connected)
                    return;

                connected = value;
                FireConnectionChanged(value);
                if (value)
                    connectedHandler();
                else
                    disconnectedHandler();
            }
        }

        private void connectedHandler()
        {
            startDisconnectDetectorThread();
        }

        private void disconnectedHandler()
        {
            stopDisconnectDetectorThread();
        }

        public override bool getConnectState()
        {
            return Connected;
        }

        #endregion


        #region Connecting, disconnecting
        override public void Connect()
        {

            if (Connected)
                throw new AlreadyConnectedException();

            if (string.IsNullOrWhiteSpace(ipAddress))
                return;

            try
            {
                socket.ReceiveTimeout = -1;
                socket.BeginConnect(ipAddress, port, connectedCallback, null);
            }
            catch (SocketException)
            { }
        }

        private void connectedCallback(IAsyncResult ar)
        {
            if (socket.Connected)
            {
                Connected = true;
                socketReceive();
            }
        }

        override public void Disconnect()
        {
            if (Connected && (socket.Connected))
                socket.Disconnect(true);
            stopDisconnectDetectorThread();
            Connected = false;
        }

        public class AlreadyConnectedException : Exception
        {

            public AlreadyConnectedException()
            { }

            public AlreadyConnectedException(string message) : base(message)
            { }

            public AlreadyConnectedException(string message, Exception innerException) : base(message, innerException)
            { }

        }
        #endregion

        #region Receiving
        private void socketReceive()
        {
            if (!(Connected && socket.Connected))
                return;
            try
            {
                socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, receiveCallback, null);
            }
            catch (SocketException)
            {
                Connected = false;
            }
        }

        private const int BUFFER_SIZE = 1024;
        private byte[] buffer = new byte[BUFFER_SIZE];
        StringBuilder bufferBuilder = new StringBuilder();

        private void receiveCallback(IAsyncResult ar)
        {

            try
            {
                int charsRead = socket.EndReceive(ar);      //TODO modify to bytes
                Byte[] receivedBytes = buffer.Take(charsRead).ToArray();

                processReceivedCommand(receivedBytes);

                socketReceive();
            }
            catch (SocketException)
            {
                Connected = false;
            }
            catch (ObjectDisposedException)
            {
                Connected = false;
            }

        }

        private void processReceivedCommand(byte[] line)
        {
            FireMessageReceived(line);
        }
        #endregion

        #region Sending

        override public void SendMessage(Byte[] DATA)
        {
            try
            {
                socket.BeginSend(DATA, 0, DATA.Length, SocketFlags.None, sendCallback, null);
            }
            catch (SocketException)
            {
                Connected = false;
            }
        }

        private void sendCallback(IAsyncResult ar)
        { }
        #endregion

        #region Disconnect detection
        private Thread disconnectDetectorThread;

        private void startDisconnectDetectorThread()
        {
            exitDisconnectDetectorThreadMethod = false;
            disconnectDetectorThread = new Thread(disconnectDetectorThreadMethod)
            {
                IsBackground = true
            };
            disconnectDetectorThread.Start();
        }

        private void stopDisconnectDetectorThread()
        {
            if (disconnectDetectorThread != null)
            {
                exitDisconnectDetectorThreadMethod = true;
                disconnectDetectorThread = null;
            }
        }

        private bool exitDisconnectDetectorThreadMethod = false;

        private void disconnectDetectorThreadMethod()
        {
            while (!exitDisconnectDetectorThreadMethod)
            {
                Thread.Sleep(1000);
                if (!socket.IsConnected())
                {
                    Connected = false;
                    break;
                }
            }
        }
        #endregion

        public override string getAddressString()
        {
            return ipAddress.ToString() + ":" + port.ToString();
        }
    }
}
