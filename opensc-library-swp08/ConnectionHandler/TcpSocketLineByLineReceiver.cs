using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace OpenSC.Library.SWP08Router
{

    internal class TcpSocketLineByLineReceiver : IDisposable
    {

        private Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

        private string ipAddress;
        private int port;

        public TcpSocketLineByLineReceiver(string ipAddress, int port)
        {
            if ((port >= 1) || (port < 65535))
            {
                this.ipAddress = ipAddress;
                this.port = port;
            }
        }

        public void Dispose()
        {
            try
            {
                if(socket.Connected)
                    socket.Disconnect(false);
                ConnectedStateChanged?.Invoke(socket.Connected);
                socket.Dispose();
            }
            catch (ObjectDisposedException) { }
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
                ConnectedStateChanged?.Invoke(value);
                if (value)
                    connectedHandler();
                else
                    disconnectedHandler();
            }
        }

        public delegate void ConnectedStateChangedDelegate(bool state);
        public event ConnectedStateChangedDelegate ConnectedStateChanged;

        private void connectedHandler()
        {
            startDisconnectDetectorThread();
        }

        private void disconnectedHandler()
        {
            stopDisconnectDetectorThread();
        }
        #endregion

        #region Connecting, disconnecting
        public void Connect()
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

        public void Disconnect()
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

        public delegate void LineReceivedDelegate(Byte[] line);
        public event LineReceivedDelegate LineReceived;

        private void processReceivedCommand(Byte[] line)
        {
            LineReceived?.Invoke(line);
        }
        #endregion

        #region Sending

        public void Send(Byte[] DATA)
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

    }

}
