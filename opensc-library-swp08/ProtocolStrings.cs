using System;

namespace OpenSC.Library.SWP08Router
{
    internal class ProtocolStrings
    {

        #region Basic Bytes
        public static Byte[] ACK = { DLE, SWPHelpers.hexToByte("06") };         // Acknowledge message
        public static Byte[] NAK = { DLE, SWPHelpers.hexToByte("15") };         // No acknowledge message

        public static byte DLE = SWPHelpers.hexToByte("10");
        public static byte STX = SWPHelpers.hexToByte("02");
        public static byte ETX = SWPHelpers.hexToByte("03");
        #endregion

        #region Message start/end
        private static Byte[] SOM = { DLE, STX };                               // Start of message
        private static Byte[] EOM = { DLE, ETX };                               // End of message
        #endregion

    }
}
