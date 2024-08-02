using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class AllCrosspointsRequest : Request
    {
        protected override void _send() => sendBlock(ProtocolStrings.SWP08_CMD_CROSSPOINT_DUMP_REQ, new byte[0]);
    }
}
