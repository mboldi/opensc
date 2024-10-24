using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SonySerialTally
{
    internal class PgmTallyInterpreter : IMessageInterpreter
    {
        private Switcher switcher;

        public PgmTallyInterpreter(Switcher switcher)
        {
            this.switcher = switcher;
        }

        public bool CanInterpret(byte commandByte) => commandByte == ProtocolStrings.TALLY_EFF;

        public void InterpretLine(byte[] line)
        {
            byte tallyTypeByte = line[2];

            SonyTallyType tallyType;
            byte tallyGroup = 1;

            int input = line[0];

            if(tallyTypeByte % 2 == 1)
            {
                tallyType = SonyTallyType.RED;
            } else
            {
                tallyType = SonyTallyType.GREEN;
            }

            // 256 bit mode

            int numOfTallies = line[0] - 7;                 // - EFF, type, FFhex, 4 x compressed status byte

            if(numOfTallies == 0)
            {
                return;
            }

            int startInIndex = 193;
            int byteIndex = 8;

            for (int currStatusByteIndex = 4; currStatusByteIndex <= 7; currStatusByteIndex++)
            {
                byte currStatusByte = line[currStatusByteIndex];

                for (int i = 0; i < NumOfOnes(currStatusByte); i++)
                {
                    byte currTallyData = line[byteIndex];
                    var currByteBits = new BitArray(new byte[] { line[currStatusByteIndex] });

                    for ( int statusBitI = 0;  statusBitI <= 7; statusBitI++)
                    {
                        if(currByteBits[statusBitI])
                        {
                            int inIndex = startInIndex + ByteToNthBitOn(currTallyData);

                            switcher.FireTallyStateChange(tallyGroup, tallyType, inIndex, true);
                        }

                        startInIndex += 8;
                    }

                    byteIndex += 1;
                    startInIndex -= 120;
                }
            }
        }

        private int ByteToNthBitOn(byte b)
        {
            int i = 0;
            while(Math.Pow(2, i) != b || i > 8)
            {
                i++;
            }

            return i;
        }

        private int NumOfOnes(byte b)
        {
            var bits = new BitArray(new Byte[] { b });

            int n = 0;

            for(int i = 0;i < 8;i++)
            {
                if (bits.Get(i)) n++;
            }

            return n;
        }
    }
}
