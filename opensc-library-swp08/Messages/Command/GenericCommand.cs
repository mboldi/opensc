using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class GenericCommand: ICommand
    {
        private Byte command;
        private Byte[] data;

        public GenericCommand(Byte command, Byte[] data) {
            this.command = command;
            this.data = data;
        }

        public byte[] getCommand()
        {
            List<Byte> dataBytes = new List<Byte>();

            // Command byte
            dataBytes.Add(command);

            // Add data
            dataBytes.AddRange(data);

            return dataBytes.ToArray();
        }
    }
}
