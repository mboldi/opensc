using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal interface IMessageInterpreter
    {
        public bool CanInterpret(Byte commandByte);
        public void InterpretLine(byte[] line);
        public void BlockEnd();
    }
}
