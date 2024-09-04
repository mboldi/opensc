using OpenSC.Library.SWP08Router;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Messages.Interpreters
{
    internal class AckInterpreter : IMessageInterpreter
    {
        private SWP08Client _client;

        public AckInterpreter(SWP08Client client)
        {
            _client = client;
        }

        public void BlockEnd() => _client.AckLastRequest();
        public bool CanInterpret(byte commandByte) => commandByte == 99;
        public void InterpretLine(byte[] line) => _client.AckLastRequest();
    }
}
