using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointInterrogateRequest : Request
    {
        byte matrix, level;
        short dest;

        public CrosspointInterrogateRequest(byte matrix, byte level, short dest)
        {
            this.matrix = matrix;
            this.level = level;
            this.dest = dest;
        }

        protected override void _send() => sendCommand(new CrosspointInterrogateCommand(matrix, level, dest));
    }
}
