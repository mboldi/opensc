using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    public record Crosspoint(short Dest, short Source)
    {
        public Byte[] getProtocolString()
        {
            List<Byte> SrcDestWithMult = new List<Byte>();

            SrcDestWithMult.Add(SWPHelpers.generateMultiplier(Dest, Source));

            SrcDestWithMult.Add((byte)(Dest % 128));

            SrcDestWithMult.Add((byte)(Source % 128));

            return SrcDestWithMult.ToArray();
        }

        public override string ToString()
        {
            return "Crosspoint: { Dest: " + Dest.ToString() + ", Source: " + Source.ToString() + " }";
        }

    }
}
