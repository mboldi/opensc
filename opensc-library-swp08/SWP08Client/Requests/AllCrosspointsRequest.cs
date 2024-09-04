using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class AllCrosspointsRequest : Request
    {
        byte matrix, level;

        public AllCrosspointsRequest(byte matrix, byte level) 
        {
            this.matrix = matrix;
            this.level = level;
        }

        protected override void _send() => sendCommand(new CrosspointDumpRequestCommand(matrix, level));
    }
}
