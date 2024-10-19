using System;
using System.Collections.Generic;

namespace OpenSC.Library.SonySerialTally
{
    internal class MessageBuilder
    {
        private ICommand command;
        private SonySwitcherRow effect;
        
        public MessageBuilder() { }

        public MessageBuilder withCommand(ICommand command)
        {
            this.command = command;

            return this;
        }

        public MessageBuilder withEffect(SonySwitcherRow row)
        {
            this.effect = row;

            return this;
        }

        public Byte[] BuildMessage()
        {
            List<Byte> message = new List<Byte>();
            
            switch(effect)
            {
                case SonySwitcherRow.PP:
                    message.Add(ProtocolStrings.EFF_PP);
                    break;
                case SonySwitcherRow.ME1:
                    message.Add(ProtocolStrings.EFF_ME1);
                    break;
                case SonySwitcherRow.ME2:
                    message.Add(ProtocolStrings.EFF_ME2);
                    break;
                case SonySwitcherRow.ME3:
                    message.Add(ProtocolStrings.EFF_ME3);
                    break;
                case SonySwitcherRow.ME4:
                    message.Add(ProtocolStrings.EFF_ME4);
                    break;
                case SonySwitcherRow.ME5:
                    message.Add(ProtocolStrings.EFF_ME5);
                    break;
            }

            message.AddRange(command.getCommandBytesWithCode());

            byte byteCount = (byte) message.Count;
            message.Insert(0, byteCount);                                     // Byte count

            return message.ToArray();
        }

    }
}
