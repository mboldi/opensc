using System;
using System.Collections.Generic;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointConnectCommand : ICommand
    {
        private byte matrix = 0;
        private byte level = 0;

        private Int16 destination = 0;
        private Int16 source = 0;

        public CrosspointConnectCommand() { }

        public CrosspointConnectCommand withMatrixId(byte matrixId)
        {
            this.matrix = matrixId;

            return this;
        }

        public CrosspointConnectCommand withMatrixLevel(byte level)
        {
            this.level = level;

            return this;
        }

        public CrosspointConnectCommand withDestination(Int16 dest)
        {
            this.destination = dest;

            return this;
        }

        public CrosspointConnectCommand withSource(Int16 src)
        {
            this.source = src;

            return this;
        }

        public Byte[] getCommand()
        {
            List<Byte> dataBytes = new List<Byte>();

            // Command byte
            dataBytes.Add(ProtocolStrings.SWP08_CMD_CONNECT);

            // Matrix - Level
            dataBytes.Add((byte)(level + 16 * matrix));

            dataBytes.Add(SWPHelpers.generateMultiplier(destination, source));

            dataBytes.Add((byte)(destination % 128));

            dataBytes.Add((byte)(source % 128));

            return dataBytes.ToArray();
        }

    }
}
