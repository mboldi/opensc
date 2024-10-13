using OpenSC.Library.SWP08Router;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointInterrogateCommand : ICommand
    {
        private byte matrix, level = 0;
        private short dest = 0;

        public CrosspointInterrogateCommand(byte matrix, byte level, short dest)
        {
            this.matrix = matrix;
            this.level = level;
            this.dest = dest;
        }

        public byte[] getCommand()
        {
            List<Byte> cmdBytes = new List<Byte>();

            // Command byte
            cmdBytes.Add(ProtocolStrings.SWP08_CMD_CROSSPOINT_INTERROGATE);

            // Matrix - Level
            cmdBytes.Add((byte)(level + 16 * matrix));

            // Multiplier
            cmdBytes.Add(SWPHelpers.generateMultiplier(dest, 0));
            
            // Destination
            cmdBytes.Add((byte)(dest % 128));

            return cmdBytes.ToArray();
        }
    }
}
