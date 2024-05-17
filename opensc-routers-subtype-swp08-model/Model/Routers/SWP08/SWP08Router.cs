
using OpenSC.Model;
using OpenSC.Model.Routers;
using System;
using System.Collections.Generic;

namespace OpenSC
{
    [TypeLabel("Pro-Bel SW-P-08")]
    [TypeCode("swp08")]
    public class SWP08Router : Router
    {
        private new const string LOG_TAG = "Router/SW-P-08";

        private static byte DLE = hexToByte("10");
        private static byte STX = hexToByte("02");
        private static byte ETX = hexToByte("03");

        private static Byte[] ACK = { DLE, hexToByte("06") };       // Acknowledge message
        private static Byte[] NAK = { DLE, hexToByte("15") };       // No acknowledge message

        private static Byte[] SOM = { DLE, STX };                   // Start of message
        private static Byte[] EOM = { DLE, ETX };                   // End of message

        public override RouterInput CreateInput(string name, int index)
        {
            return new RouterInput(name, this, index);
        }

        public override RouterOutput CreateOutput(string name, int index)
        {
            return new RouterOutput(name, this, index);
        }

        protected override void queryAllStates()
        {
            
        }

        protected override void requestCrosspointUpdateImpl(RouterOutput output, RouterInput input)
        {
            throw new System.NotImplementedException();
        }

        protected override void requestCrosspointUpdatesImpl(IEnumerable<RouterCrosspoint> crosspoints)
        {
            throw new System.NotImplementedException();
        }

        protected override void requestLockOperationImpl(RouterOutput output, RouterOutputLockType lockType, RouterOutputLockOperationType lockOperationType)
        {
            throw new System.NotImplementedException();
        }


        #region Helper functions

        // Everything indexed from 0!
        Byte[] crosspointConnectMessage(byte matrix, byte level, Int16 dest, Int16 source)
        {
            List<Byte> dataBytes = new List<Byte>();

            // Command byte
            dataBytes.Add(hexToByte("02"));

            // Matrix - Level
            dataBytes.Add((byte)(level + 16 * matrix));

            dataBytes.Add(generateMultiplier(dest, source));

            dataBytes.Add((byte)(dest % 128));

            dataBytes.Add((byte)(source % 128));

            return dataBytes.ToArray();
        }


        Byte[] packageMessage(Byte[] DATA)
        {
            List<Byte> message = new List<Byte>();


            byte BTC = (byte)DATA.Length;
            var CHK = calcCHK(DATA, BTC);

            message.AddRange(DATA);

            message.Add(BTC);
            message.Add((byte)CHK);

            for (int i = 0; i < message.Count; i++)
            {
                if (message[i] == DLE)
                {
                    message.Insert(++i, DLE);
                }
            }

            // Start of message
            message.Insert(0, STX);
            message.Insert(0, DLE);

            // End of message
            message.Add(DLE);
            message.Add(ETX);

            return message.ToArray();
        }


        private Byte calcBTC(Byte[] DATA)
        {
            return (byte)DATA.Length;
        }

        private SByte calcCHK(Byte[] DATA, Byte BTC)
        {
            SByte CHK = 0;

            Byte sumBytes = 0;

            foreach (Byte b in DATA)
            {
                sumBytes += b;
            }

            sumBytes += BTC;

            return twosComplement(sumBytes);
        }


        private SByte twosComplement(Byte inByte)
        {
            return (sbyte)(~inByte + 1);
        }

        private Byte generateMultiplier(Int16 dest, Int16 source)
        {
            return (byte)(source / 128 + 16 * (dest / 128));
        }

        private static Byte hexToByte(String hexString)
        {
            if (hexString.Length != 2) throw new Exception("Not valid input!");

            return byte.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }

        private static Byte[] hexToByteArray(String hexString)
        {
            List<Byte> outBytes = new List<Byte>();

            for (int i = 0; i < hexString.Length / 2; i++)
            {
                outBytes.Add(hexToByte(hexString.Substring(i * 2, 2)));
            }

            return outBytes.ToArray();
        }
        #endregion
    }
}
