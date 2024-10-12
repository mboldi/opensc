using Microsoft.CodeAnalysis.CSharp.Syntax;
using OpenSC.Library.SWP08Router;
using OpenSC.Model.General;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SourceGenerators;
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
        [AutoProperty]
        [AutoProperty.BeforeChange(nameof(_serialPort_beforeChange))]
        [AutoProperty.AfterChange(nameof(_serialPort_afterChange))]
        private SerialPort serialPort = null;

        public SerialConnectionHandler(SerialPort serialPort)
        {
            this.serialPort = serialPort;

        }

        private void _serialPort_beforeChange(SerialPort oldValue, SerialPort newValue, BeforeChangePropertyArgs args)
        {
            if (oldValue != null)
            {
                oldValue.ReceivedDataBytes -= receivedLineFromPort;
                oldValue.InitializedChanged -= portInitializedChangedHandler;
            }
        }


        private void _serialPort_afterChange(SerialPort oldValue, SerialPort newValue, BeforeChangePropertyArgs args)
        {
            if (newValue != null)
            {
                newValue.ReceivedDataBytes += receivedLineFromPort;
                newValue.InitializedChanged += portInitializedChangedHandler;
                // initSerial();
            }
        }

        private void receivedLineFromPort(SerialPort port, byte[] data)
        {
            FireMessageReceived(data);
        }

        private void portInitializedChangedHandler(SerialPort item, bool oldValue, bool newValue)
        {
            
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
