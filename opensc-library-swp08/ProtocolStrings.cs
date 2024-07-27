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
        public static Byte[] SOM = { DLE, STX };                               // Start of message
        public static Byte[] EOM = { DLE, ETX };                               // End of message
        #endregion


        #region Command bytes
        public static byte SWP08_CMD_INTERROGATE = SWPHelpers.hexToByte("01");
        public static byte SWP08_CMD_CONNECT = SWPHelpers.hexToByte("02");
        public static byte SWP08_CMD_TALLY = SWPHelpers.hexToByte("03");
        public static byte SWP08_CMD_CONNECTED = SWPHelpers.hexToByte("04");
        public static byte SWP08_CMD_CONNECT_ON_GO = SWPHelpers.hexToByte("05");
        public static byte SWP08_CMD_GO = SWPHelpers.hexToByte("06");
        public static byte SWP08_CMD_CONNECT_ON_GO_ACK = SWPHelpers.hexToByte("12");
        public static byte SWP08_CMD_GO_DONE_ACK = SWPHelpers.hexToByte("01");
        #endregion
    }
}
