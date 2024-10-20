﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    public abstract class IConnectionHandler: IDisposable
    {
        public delegate void ConnectionChangedDelegate(bool state);
        public event ConnectionChangedDelegate ConnectionChanged;

        public delegate void MessageReceivedDelegate(Byte[] message);
        public event MessageReceivedDelegate MessageReceived;

        public abstract void Connect();

        public abstract void Disconnect();

        public abstract void SendMessage(Byte[] message);

        public abstract bool getConnectState();

        public abstract string getAddressString();

        public abstract void Dispose();

        protected void FireConnectionChanged(bool state)
        {
            ConnectionChanged?.Invoke(state);
        }
        
        protected void FireMessageReceived(Byte[] message)
        {
            MessageReceived?.Invoke(message);
        }
    }
}
