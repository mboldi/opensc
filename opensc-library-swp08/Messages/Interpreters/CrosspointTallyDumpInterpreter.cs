using OpenSC.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointTallyDumpInterpreter : IMessageInterpreter
    {
        private SWP08Client client;
        private byte matrix, level = 0;

        public CrosspointTallyDumpInterpreter(SWP08Client client, byte matrix, byte level)
        {
            this.client = client;
            this.matrix = matrix;
            this.level = level;
        }

        public void BlockEnd() {}

        public bool CanInterpret(byte commandByte) => commandByte == ProtocolStrings.SWP08_CMD_CROSSPOINT_DUMP;

        public void InterpretLine(byte[] line)
        {
            LogDispatcher.I("SW-P-08/DumpInterpreter", "Line received: " + BitConverter.ToString(line).Replace("-", ""));

            byte _matrix = (byte)(line[1] / 16);
            byte _level = (byte)(line[1] % 16);

            if (matrix != _matrix || level != _level) return;

            byte numOfTallies = (byte)(line[2]);
            short firstDest = (short)(line[3]);

            LogDispatcher.I("SW-P-08/DumpInterpreter", "Num of dump elements: " + numOfTallies);

            for (byte i = 0; i < numOfTallies; i++)
            {
                Crosspoint newCrosspoint = new Crosspoint(
                (short)(firstDest + i),
                (short)(line[4+i]));

                LogDispatcher.I("SW-P-08/DumpInterpreter", "Current crosspoint: " + (line[4 + i]) + "->" + (firstDest + i));

                client.NotifyCrosspointChanged(newCrosspoint);
            }
        }
    }
}
