using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal interface IConnectionHandler
    {
        public delegate void DisconnectedDelegate();
        public event DisconnectedDelegate Disconnected;

        public delegate void MessageReceivedDelegate();
        public event MessageReceivedDelegate MessageReceived;

        public bool Connect();

        public void Disconnect();

        public void SendMessage(string message);
    }
}
