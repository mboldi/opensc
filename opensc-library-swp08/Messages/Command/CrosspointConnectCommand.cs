using OpenSC.Model.General;
using System;
using System.Collections.Generic;

namespace OpenSC.Library.SWP08Router
{
    internal class CrosspointConnectCommand : ICommand
    {
        private byte matrix = 0;
        private byte level = 0;

        private Crosspoint crosspoint;

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

        public CrosspointConnectCommand withCrosspoint(Crosspoint crosspoint)
        {
            this.crosspoint = crosspoint;

            return this;
        }

        public Byte[] getCommand()
        {
            List<Byte> dataBytes = new List<Byte>();

            // Command byte
            dataBytes.Add(ProtocolStrings.SWP08_CMD_CONNECT);

            // Matrix - Level
            dataBytes.Add((byte)(level + 16 * matrix));

            // Add crosspoints with multiplier
            dataBytes.AddRange(crosspoint.getProtocolString());

            return dataBytes.ToArray();
        }

    }
}
