using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointConnectRequest : Request
    {
        byte matrix, level;
        Crosspoint crosspoint;

        public CrosspointConnectRequest(byte matrix, byte level, Crosspoint crosspoint)
        {
            this.matrix = matrix;
            this.level = level;
            this.crosspoint = crosspoint;
        }

        protected override void _send() => sendCommand(new CrosspointConnectCommand(matrix, level).withCrosspoint(crosspoint));
    }
}
