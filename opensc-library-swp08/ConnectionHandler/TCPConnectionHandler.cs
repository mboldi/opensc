using OpenSC.Library.SWP08Router;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    public class TCPConnectionHandler : IConnectionHandler
    {
        private TcpSocketLineByLineReceiver lineReceiver;

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

        #endregion

        public bool Connected
        {
            get
            {
                if(lineReceiver == null) return false;

                return lineReceiver.Connected;
            }
        }

        public override bool getConnectState()
        {
            return Connected;
        }

        public TCPConnectionHandler(string ipAddressWithPort) { 
            IpAddress = ipAddressWithPort;

            lineReceiver = new TcpSocketLineByLineReceiver(ipAddress, port);

            lineReceiver.ConnectedStateChanged += state => FireConnectionChanged(state);
        }

        public TCPConnectionHandler(string ipAddress, int port) {
            IpAddress = ipAddress.ToString() + ":" + port.ToString();

            lineReceiver = new TcpSocketLineByLineReceiver(ipAddress, port);

            lineReceiver.ConnectedStateChanged += state => FireConnectionChanged(state);
        }

        override public void Disconnect() => lineReceiver.Disconnect();

        override public void Connect() => lineReceiver.Connect();

        override public void SendMessage(Byte[] message) => lineReceiver.Send(message);

        public override string getAddressString()
        {
            return ipAddress.ToString() + ":" + port.ToString();
        }
    }
}
