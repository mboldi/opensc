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

            // Start of message
            message.AddRange(ProtocolStrings.SOM);

            message.AddRange(DATA);

            message.Add(BTC);
            message.Add((byte)CHK);

            for (int i = 2; i < message.Count; i++)
            {
                if (message[i] == ProtocolStrings.DLE)
                {
                    message.Insert(++i, ProtocolStrings.DLE);
                }
            }

            // End of message
            message.AddRange(ProtocolStrings.EOM);

            return message.ToArray();
        }

    }
}
