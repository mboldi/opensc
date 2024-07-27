using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal class SWPHelpers
    {

        public static Byte calcBTC(Byte[] DATA)
        {
            return (byte)DATA.Length;
        }

        public static SByte calcCHK(Byte[] DATA, Byte BTC)
        {
            Byte sumBytes = 0;

            foreach (Byte b in DATA)
            {
                sumBytes += b;
            }

            sumBytes += BTC;

            return twosComplement(sumBytes);
        }


        public static SByte twosComplement(Byte inByte)
        {
            return (sbyte)(~inByte + 1);
        }

        public static Byte generateMultiplier(Int16 dest, Int16 source)
        {
            return (byte)(source / 128 + 16 * (dest / 128));
        }

        public static Byte hexToByte(String hexString)
        {
            if (hexString.Length != 2) throw new Exception("Not valid input!");

            return byte.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }

        public static Byte[] hexToByteArray(String hexString)
        {
            List<Byte> outBytes = new List<Byte>();

            for (int i = 0; i < hexString.Length / 2; i++)
            {
                outBytes.Add(hexToByte(hexString.Substring(i * 2, 2)));
            }

            return outBytes.ToArray();
        }

        // Everything indexed from 0!        
    }
}
