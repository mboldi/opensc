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
        public static byte SWP08_CMD_CROSSPOINT_INTERROGATE = 1;
        public static byte SWP08_CMD_CONNECT = 2;
        public static byte SWP08_CMD_CROSSPOINT_TALLY = 3;
        public static byte SWP08_CMD_CONNECTED = 4;
        public static byte SWP08_CMD_DUAL_CTRL_STATUS = 8;
        public static byte SWP08_CMD_CROSSPOINT_DUMP_REQ = 21;
        public static byte SWP08_CMD_CROSSPOINT_DUMP = 22;
        public static byte SWP08_CMD_CROSSPOINT_DUMP_WORD = 23;

        // Only for XD and ECLIPSE router ranges
        public static byte SWP08_CMD_CONNECT_ON_GO = 120;
        public static byte SWP08_CMD_GO = 121;
        public static byte SWP08_CMD_CONNECT_ON_GO_ACK = 122;
        public static byte SWP08_CMD_GO_DONE_ACK = 123;
        #endregion
    }
}
