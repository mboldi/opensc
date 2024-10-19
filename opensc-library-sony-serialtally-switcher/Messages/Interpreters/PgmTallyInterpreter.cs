using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SonySerialTally
{
    internal class PgmTallyInterpreter : IMessageInterpreter
    {
        private Switcher switcher;

        public PgmTallyInterpreter(Switcher switcher)
        {
            this.switcher = switcher;
        }

        public bool CanInterpret(byte commandByte) => commandByte == ProtocolStrings.TALLY_EFF;

        public void InterpretLine(byte[] line)
        {
            
        }
    }
}
