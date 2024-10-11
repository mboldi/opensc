using Microsoft.CodeAnalysis.CSharp.Syntax;
using OpenSC.Library.SWP08Router;
using OpenSC.Model.SerialPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace OpenSC.Library.SWP08Router
{
    public class SerialConnectionHandler : IConnectionHandler
    {
        private SerialPort serialPort = null;

        public SerialConnectionHandler(SerialPort serialPort)
        {
            this.serialPort = serialPort;

        }

        public override void Connect()
        {
            /*
            if (!serialPort.Initialized)
            {
                serialPort.Init();
            }
            */
        }

        public override void Disconnect()
        {
            /*
            if(serialPort.Initialized)
            {
                serialPort.DeInit();
            }
            */
        }

        public override void Dispose()
        {
            
        }

        public override string getAddressString()
        {
            return serialPort.ToString();
        }

        public override bool getConnectState()
        {
            return serialPort.Initialized;
        }

        public override void SendMessage(byte[] message)
        {
            if (serialPort.Initialized)
            {
                DateTime validUntil = DateTime.Now + TimeSpan.FromSeconds(2);
                serialPort.SendData(message, validUntil);
            }
        }
    }
}
