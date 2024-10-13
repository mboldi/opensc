using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointDumpRequestCommand : ICommand
    {
        private byte matrix;
        private byte level;

        public CrosspointDumpRequestCommand()
        {
            matrix = 0;
            level = 0;
        }

        public CrosspointDumpRequestCommand(byte matrix, byte level)
        {
            this.matrix = matrix;
            this.level = level;
        }

        public byte[] getCommand()
        {
            List<Byte> dataBytes = new List<Byte>();

            // Command byte
            dataBytes.Add(ProtocolStrings.SWP08_CMD_CROSSPOINT_DUMP_REQ);

            // Matrix - Level
            dataBytes.Add((byte)(level + 16 * matrix));

            return dataBytes.ToArray();
        }
    }
}
