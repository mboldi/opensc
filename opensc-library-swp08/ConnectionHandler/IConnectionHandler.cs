using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    public interface IConnectionHandler
    {
        public delegate void DisconnectedDelegate();
        public event DisconnectedDelegate Disconnected;

        public delegate void MessageReceivedDelegate();
        public event MessageReceivedDelegate MessageReceived;

        public bool ConnectTo(string address);

        public void Close();

        public void SendMessage(string message);
    }
}
