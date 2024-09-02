using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class ConnectedCommandInterpreter : IMessageInterpreter
    {
        public void BlockEnd() {}

        public bool CanInterpret(byte commandByte) => commandByte == ProtocolStrings.SWP08_CMD_CONNECTED;

        public void InterpretLine(byte[] line)
        {
            throw new NotImplementedException();
        }
    }
}
