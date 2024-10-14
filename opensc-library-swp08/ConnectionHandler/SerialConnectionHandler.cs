using OpenSC.Model.General;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SourceGenerators;
using System;

namespace OpenSC.Library.SWP08Router
{
    public class SerialConnectionHandler : IConnectionHandler
    {
        
        private SerialPort port = null;

        private SerialPort Port
        {
            get => port;
            set
            {
                var ov = Port;
                
                _serialPort_beforeChange(ov, value);
                port = value;
                _serialPort_afterChange(ov, value);
            }
        }

        public SerialConnectionHandler(SerialPort serialPort)
        {
            Port = serialPort;

            //Console.WriteLine("initialized with port " + serialPort.ComPortName);
        }

        private void _serialPort_beforeChange(SerialPort oldValue, SerialPort newValue)
        {
            if (oldValue != null)
            {
                oldValue.ReceivedDataBytes -= receivedLineFromPort;
                oldValue.InitializedChanged -= portInitializedChangedHandler;
            }
        }


        private void _serialPort_afterChange(SerialPort oldValue, SerialPort newValue)
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
            FireConnectionChanged(newValue);
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
            return Port.ToString();
        }

        public override bool getConnectState()
        {
            return Port.Initialized;
        }

        public override void SendMessage(byte[] message)
        {
            if (Port.Initialized)
            {
                DateTime validUntil = DateTime.Now + TimeSpan.FromSeconds(2);
                Port.SendData(message, validUntil);
            }
        }
    }
}
