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
                if (value == ipAddress.ToString() + ":" + port.ToString())
                    return;
                bool wasConnected = connected;
                if (wasConnected)
                    Disconnect();
                ipAddress = value;
                if (wasConnected)
                    Connect();
            }
        }


        #endregion

        private bool connected;

        public bool Connected
        {
            get
            {
                return connected;
            }
        }

        public TCPConnectionHandler(string ipAddressWithPort) { 
            IpAddress = ipAddressWithPort;
        }

        public TCPConnectionHandler(string ipAddress, int port) {
            IpAddress = ipAddress.ToString() + ":" + port.ToString();
        }

        public void Disconnect()
        {
            
        }

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
