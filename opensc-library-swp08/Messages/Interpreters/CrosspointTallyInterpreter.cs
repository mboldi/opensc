using OpenSC.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointTallyInterpreter : IMessageInterpreter
    {
        private SWP08Client client;
        private byte matrix, level = 0;

        public CrosspointTallyInterpreter(SWP08Client client, byte matrix, byte level)
        {
            this.client = client;
            this.matrix = matrix;
            this.level = level;
        }

        public void BlockEnd() {}

        public bool CanInterpret(byte commandByte) => commandByte == ProtocolStrings.SWP08_CMD_CROSSPOINT_TALLY;

        public void InterpretLine(byte[] line)
        {
            byte _matrix = (byte)(line[1] / 16);
            byte _level = (byte)(line[1] % 16);

            if (matrix != _matrix || level != _level) return;

            Crosspoint newCrosspoint = new Crosspoint(
                (short)(SWPHelpers.destFromMult(line[2]) * 128 + line[3]),
                (short)(SWPHelpers.srcFromMult(line[2]) * 128 + line[4]));

            client.NotifyCrosspointChanged(newCrosspoint);

            client.AckLastRequest();
        }
    }
}
