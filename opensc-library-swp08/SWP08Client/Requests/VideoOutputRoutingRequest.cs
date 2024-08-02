using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class VideoOutputRoutingRequest : Request
    {
        private Crosspoint crosspoint;

        public VideoOutputRoutingRequest(Crosspoint crosspoint) => this.crosspoint = crosspoint;

        protected override void _send()
            => sendBlock(ProtocolStrings.SWP08_CMD_CONNECT, crosspoint.getProtocolString());
    }
}
