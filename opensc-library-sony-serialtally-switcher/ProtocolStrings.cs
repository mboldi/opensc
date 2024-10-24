using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SonySerialTally
{
    public class ProtocolStrings
    {
        public static readonly byte SELECT = 48;               // 30 hex

        public static readonly byte ACK = 132;                 // 84 hex
        public static readonly byte NAK = 133;                 // 85 hex

        // Effects address
        public static readonly byte EFF_PP  = 0;                // 00 hex
        public static readonly byte EFF_ME1 = 1;               // 01 hex
        public static readonly byte EFF_ME2 = 2;               // 02 hex
        public static readonly byte EFF_ME3 = 3;               // 03 hex
        public static readonly byte EFF_ME4 = 4;               // 04 hex
        public static readonly byte EFF_ME5 = 5;               // 05 

        #region M/E Xpt
        public static readonly byte XPT_BKGD_A_BUS_W = 192;        // C0 hex
        public static readonly byte XPT_BKGD_A_BUS_R = 64;         // 40 hex
        public static readonly byte XPT_BKGD_B_BUS_W = 193;        // C1 hex
        public static readonly byte XPT_BKGD_B_BUS_R = 65;         // 41 hex

        public static readonly byte XPT_KEY_1_FILL_BUS_W = 199;    // C7 hex
        public static readonly byte XPT_KEY_1_FILL_BUS_R = 71;     // 47 hex
        public static readonly byte XPT_KEY_1_SOURCE_BUS_W = 200;  // C8 hex
        public static readonly byte XPT_KEY_1_SOURCE_BUS_R = 72;   // 48 hex
        public static readonly byte XPT_KEY_2_FILL_BUS_W = 205;    // CD hex
        public static readonly byte XPT_KEY_2_FILL_BUS_R = 77;     // 4D hex
        public static readonly byte XPT_KEY_2_SOURCE_BUS_W = 206;  // CE hex
        public static readonly byte XPT_KEY_2_SOURCE_BUS_R = 78;   // 4E hex
        // ... more to come

        #endregion


        #region AUX XPT
        // Read/Write command same as for M/Es
        public static readonly byte XPT_AUX_1 = 48;                // 30 hex
            // Other Aux:s come with 1-1 increase in byte value eg. AUX 10 is 39 hex (57 dec)
            
        public static readonly byte XPT_EDIT_PVW = 63;             // 3F hex

        public static readonly byte XPT_AUX_CMD_W = 192;           // C0 hex
        public static readonly byte XPT_AUX_CMD_R = 64;            // 40 hex
        #endregion

        #region Commands for transitions
        // Licence required
        public static readonly byte TRANS_MODE_CMD = 10;           // 10 hex
        public static readonly byte[] TRANS_TYPE_B34 = {17,0};     // 11, 00 hex
        public static readonly byte[] TRANS_CANCEL_B34 = {25,0};   // 19, 00 hex

        public static readonly byte TRANS_MP2_MAIN_W = 240;        // F0 hex
        public static readonly byte TRANS_MP2_MAIN_R = 112;        // 70 hex
        public static readonly byte TRANS_MP2_SUB_W = 241;         // F1 hex
        public static readonly byte TRANS_MP2_SUB_R = 113;         // 71 hex
        public static readonly byte TRANS_MP2_BOTH_W = 242;        // F2 hex
        public static readonly byte TRANS_MP2_BOTH_R = 114;        // 72 hex

        public static readonly byte TRANS_TYPE_MIX = 2;            // 02 hex
        public static readonly byte TRANS_TYPE_WIPE = 4;           // 04 hex
        public static readonly byte TRANS_TYPE_NAM = 8;            // 08 hex
        public static readonly byte TRANS_TYPE_SUPER_MIX = 16;     // 10 hex
        public static readonly byte TRANS_TYPE_PST_BKGD_MIX = 18;  // 12 hex
        public static readonly byte TRANS_TYPE_DME_WIPE = 32;      // 20 hex
        #endregion

        #region KEYS
        public static readonly byte KEYS_READ_CMD = 26;            // 1A hex

        public static readonly byte KEYS_KEY_ON = 218;             // DA hex
        public static readonly byte KEYS_KEY_OFF = 154;            // 9A hex

        public static readonly byte XPT_KEY_1 = 16;                // 10 hex
        // Other Key:s come with 20h-20h increase in byte value eg. Key 2 is 30 hex (48 dec), Key 3 is 50 hex
        // up to Key 8 (F0 hex)
        #endregion

        #region Serial Tally
        public static readonly byte TALLY_EFF = 36;                // 24 hex
        public static readonly byte TALLY_CMD_B3 = 255;            // FF hex

        public static readonly byte TALLY_GP_1_RED_W = 209;        // D1 hex
        public static readonly byte TALLY_GP_1_RED_R = 81;         // 51 hex
        public static readonly byte TALLY_GP_1_GREEN_W = 21;      // D2 hex
        public static readonly byte TALLY_GP_1_GREEN_R = 82;       // 52 hex
        public static readonly byte TALLY_GP_2_RED_W = 211;        // D3 hex
        public static readonly byte TALLY_GP_2_RED_R = 83;         // 53 hex
        public static readonly byte TALLY_GP_2_GREEN_W = 212;      // D4 hex
        public static readonly byte TALLY_GP_2_GREEN_R = 84;       // 54 hex
        public static readonly byte TALLY_GP_3_RED_W = 213;        // D5 hex
        public static readonly byte TALLY_GP_3_RED_R = 85;         // 55 hex
        public static readonly byte TALLY_GP_3_GREEN_W = 214;      // D6 hex
        public static readonly byte TALLY_GP_3_GREEN_R = 86;       // 56 hex
        public static readonly byte TALLY_GP_4_RED_W = 215;        // D7 hex
        public static readonly byte TALLY_GP_4_RED_R = 87;         // 57 hex
        public static readonly byte TALLY_GP_4_GREEN_W = 216;      // D8 hex
        public static readonly byte TALLY_GP_4_GREEN_R = 88;       // 58 hex
        public static readonly byte TALLY_GP_5_RED_W = 217;        // D9 hex
        public static readonly byte TALLY_GP_5_RED_R = 89;         // 59 hex
        public static readonly byte TALLY_GP_5_GREEN_W = 218;      // DA hex
        public static readonly byte TALLY_GP_5_GREEN_R = 90;       // 5A hex
        public static readonly byte TALLY_GP_6_RED_W = 219;        // DB hex
        public static readonly byte TALLY_GP_6_RED_R = 91;         // 5B hex
        public static readonly byte TALLY_GP_6_GREEN_W = 220;      // DC hex
        public static readonly byte TALLY_GP_6_GREEN_R = 92;       // 5C hex
        public static readonly byte TALLY_GP_7_RED_W = 221;        // DD hex
        public static readonly byte TALLY_GP_7_RED_R = 93;         // 5D hex
        public static readonly byte TALLY_GP_7_GREEN_W = 222;      // DE hex
        public static readonly byte TALLY_GP_7_GREEN_R = 94;       // 5E hex
        public static readonly byte TALLY_GP_8_RED_W = 223;        // DF hex
        public static readonly byte TALLY_GP_8_RED_R = 95;         // 5F hex
        public static readonly byte TALLY_GP_8_GREEN_W = 224;      // E0 hex
        public static readonly byte TALLY_GP_8_GREEN_R = 96;       // 60 hex

        // Yellow nly on XVS!
        public static readonly byte TALLY_GP_1_YELLO_W = 161;      // A1 hex
        public static readonly byte TALLY_GP_1_YELLO_R = 33;       // 21 hex
        public static readonly byte TALLY_GP_2_YELLO_W = 162;      // A2 hex
        public static readonly byte TALLY_GP_2_YELLO_R = 34;       // 22 hex
        public static readonly byte TALLY_GP_3_YELLO_W = 163;      // A3 hex
        public static readonly byte TALLY_GP_3_YELLO_R = 35;       // 23 hex
        public static readonly byte TALLY_GP_4_YELLO_W = 164;      // A4 hex
        public static readonly byte TALLY_GP_4_YELLO_R = 36;       // 24 hex
        public static readonly byte TALLY_GP_5_YELLO_W = 165;      // A5 hex
        public static readonly byte TALLY_GP_5_YELLO_R = 37;       // 25 hex
        public static readonly byte TALLY_GP_6_YELLO_W = 166;      // A6 hex
        public static readonly byte TALLY_GP_6_YELLO_R = 38;       // 26 hex
        public static readonly byte TALLY_GP_7_YELLO_W = 167;      // A7 hex
        public static readonly byte TALLY_GP_7_YELLO_R = 39;       // 27 hex
        public static readonly byte TALLY_GP_8_YELLO_W = 168;      // A8 hex
        public static readonly byte TALLY_GP_8_YELLO_R = 30;       // 28 hex



        public static readonly byte[] TALLY_RED_W_GROUPS = 
        {
            TALLY_GP_1_RED_W,
            TALLY_GP_2_RED_W,
            TALLY_GP_3_RED_W,
            TALLY_GP_4_RED_W,
            TALLY_GP_5_RED_W,
            TALLY_GP_6_RED_W,
            TALLY_GP_7_RED_W,
            TALLY_GP_8_RED_W
        };

        public static readonly byte[] TALLY_RED_R_GROUPS =
        {
            TALLY_GP_1_RED_R,
            TALLY_GP_2_RED_R,
            TALLY_GP_3_RED_R,
            TALLY_GP_4_RED_R,
            TALLY_GP_5_RED_R,
            TALLY_GP_6_RED_R,
            TALLY_GP_7_RED_R,
            TALLY_GP_8_RED_R
        };

        public static readonly byte[] TALLY_GREEN_W_GROUPS =
        {
            TALLY_GP_1_GREEN_W,
            TALLY_GP_2_GREEN_W,
            TALLY_GP_3_GREEN_W,
            TALLY_GP_4_GREEN_W,
            TALLY_GP_5_GREEN_W,
            TALLY_GP_6_GREEN_W,
            TALLY_GP_7_GREEN_W,
            TALLY_GP_8_GREEN_W
        };

        public static readonly byte[] TALLY_GREEN_R_GROUPS =
        {
            TALLY_GP_1_GREEN_R,
            TALLY_GP_2_GREEN_R,
            TALLY_GP_3_GREEN_R,
            TALLY_GP_4_GREEN_R,
            TALLY_GP_5_GREEN_R,
            TALLY_GP_6_GREEN_R,
            TALLY_GP_7_GREEN_R,
            TALLY_GP_8_GREEN_R
        };

        // Yellow nly on XVS!
        public static readonly byte[] TALLY_YELLOW_W_GROUPS =
        {
            TALLY_GP_1_YELLO_W,
            TALLY_GP_2_YELLO_W,
            TALLY_GP_3_YELLO_W,
            TALLY_GP_4_YELLO_W,
            TALLY_GP_5_YELLO_W,
            TALLY_GP_6_YELLO_W,
            TALLY_GP_7_YELLO_W,
            TALLY_GP_8_YELLO_W
        };

        public static readonly byte[] TALLY_YELLOW_R_GROUPS =
        {
            TALLY_GP_1_YELLO_R,
            TALLY_GP_2_YELLO_R,
            TALLY_GP_3_YELLO_R,
            TALLY_GP_4_YELLO_R,
            TALLY_GP_5_YELLO_R,
            TALLY_GP_6_YELLO_R,
            TALLY_GP_7_YELLO_R,
            TALLY_GP_8_YELLO_R
        };

        #endregion

        #region Virtual GPI
        public static readonly byte[] VGPI_OUT_READY = {2,38,1};   // 02, 26, 01 hex

        public static readonly byte VGPI_EFF = 38;                 // 26 hex

        public static readonly byte VGPI_IN_W = 128;               // 80 hex
        public static readonly byte VGPI_OUT_W = 129;              // 81 hex
        public static readonly byte VGPI_OUT_R = 1;                // 01 hex
        #endregion


        #region Source name setup

        public static readonly byte SRC_NAME_EFF = 32;             // 20 hex
        public static readonly byte[] SRC_NAME_R_B2_3 = {112, 80}; // 70, 50 hex
        public static readonly byte[] SRC_NAME_W_B2_3 = {240, 80}; // F0, 50 hex

        #endregion

        #region UI strings
        public static readonly string TALLY_SIZE_128 = "128x128";
        public static readonly string TALLY_SIZE_256 = "256x256";

        public static readonly string MATRIX_MODE_STANDARD = "Standard - 320x348";
        public static readonly string MATRIX_MODE_SMALLER = "274x254";
        public static readonly string MATRIX_MODE_MLSX1 = "MLS-X1 - 320x348";
        public static readonly string MATRIX_MODE_XVSG1 = "XVS-G1 - 320x348";

        #endregion

    }
}
