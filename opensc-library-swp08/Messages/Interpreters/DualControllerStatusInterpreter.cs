using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class DualControllerStatusInterpreter : IMessageInterpreter
    {
        private SWP08Client swpClient;

        public DualControllerStatusInterpreter(SWP08Client client)
        {
            swpClient = client;
        }

        public void BlockEnd() => swpClient.AckLastRequest();

        public bool CanInterpret(byte commandByte) => commandByte == ProtocolStrings.SWP08_CMD_DUAL_CTRL_STATUS;

        public void InterpretLine(byte[] line)
        {
            swpClient.SendCommand(new AckCommand());
            swpClient.AckLastRequest();
        }
    }
}
