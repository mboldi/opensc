using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class MessageBuilder
    {
        private ICommand command;
        
        public MessageBuilder() { }

        public MessageBuilder withCommand(ICommand command)
        {
            this.command = command;

            return this;
        }

        public Byte[] BuildMessage()
        {
            List<Byte> message = new List<Byte>();
            var DATA = command.getCommand();

            byte BTC = (byte)DATA.Length;
            var CHK = SWPHelpers.calcCHK(DATA, BTC);

            message.AddRange(DATA);

            message.Add(BTC);
            message.Add((byte)CHK);

            for (int i = 0; i < message.Count; i++)
            {
                if (message[i] == ProtocolStrings.DLE)
                {
                    message.Insert(++i, ProtocolStrings.DLE);
                }
            }

            // Start of message
            message.Insert(0, ProtocolStrings.STX);
            message.Insert(0, ProtocolStrings.DLE);

            // End of message
            message.Add(ProtocolStrings.DLE);
            message.Add(ProtocolStrings.ETX);

            return message.ToArray();
        }

    }
}
