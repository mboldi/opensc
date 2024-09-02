using OpenSC.Library.SWP08Router;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Messages.Command
{
    internal class AckCommand : ICommand
    {
        public byte[] getCommand()
        {
            return new byte[] { 16, 6};
        }
    }
}
