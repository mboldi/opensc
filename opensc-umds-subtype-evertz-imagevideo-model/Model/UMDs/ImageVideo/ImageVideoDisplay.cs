using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.UMDs.ImageVideo
{
    [TypeLabel("Evertz ImageVideo")]
    [TypeCode("imagevideo")]
    public partial class ImageVideoDisplay : Umd
    {

        #region Property: Unit
        [AutoProperty]
        [AutoProperty.AfterChange(nameof(UpdateEverything))]
        [PersistAs("unit")]
        private ImageVideoUnit unit;
        #endregion

        #region Property: Index
        [AutoProperty]
        [AutoProperty.AfterChange(nameof(UpdateEverything))]
        [AutoProperty.Validator(nameof(ValidateIndex))]
        [PersistAs("index")]
        private int index = 1;

        public void ValidateIndex(int index)
        {
            if ((index < 1) || (index > 2048))
                throw new ArgumentOutOfRangeException();
        }
        #endregion

        #region Info
        public override UmdTextInfo[] TextInfo => new UmdTextInfo[]
        {
           new("Text", false, true, true, UmdTextAlignment.Left)
        };

        public override UmdTallyInfo[] TallyInfo => new UmdTallyInfo[]
        {
            new("Tally", UmdTallyInfo.ColorSettingMode.LocalChangeable, Color.Red)
        };
        #endregion

        #region Sending data to hardware
        protected override void calculateTextFields()
        {
            string text = UseFullStaticText ? FullStaticText : Texts[0].CurrentValue;
            DisplayableCompactText = text;
            DisplayableRawText = text;
        }

        protected override void calculateTallyFields()
        {
            tallyStateToHardware = Tallies[0].CurrentState ? "1" : "0";
        }

        private string tallyStateToHardware;

        protected string getAlignmentString()
        {
            var alignment = UseFullStaticText ? AlignmentWithFullStaticText : Texts[0].Alignment;

            string alignmentString = "1";
            switch (alignment)
            {
                case UmdTextAlignment.Left:
                    alignmentString = "0";
                    break;
                case UmdTextAlignment.Center:
                    alignmentString = "1";
                    break;
                case UmdTextAlignment.Right:
                    alignmentString = "2";
                    break;
            }

            return alignmentString;
        }

        protected override void sendTextsToHardware() => sendData(true);
        protected override void sendTalliesToHardware() => sendData(false);
        protected override void sendEverythingToHardware() => sendData(true);

        protected virtual string getCommandStringToSend(bool sendText = true)
        {
            string command = "";

            command += string.Format("%{0}D", Index);                       // PiP ID
            command += string.Format("%1S");                                // valami

            if(sendText)
            {
                var alignment = getAlignmentString();

                command += string.Format("%{0}J", alignment);               // alignment
                command += DisplayableRawText;                              // label text
            }

            command += string.Format("%16S1={0}", tallyStateToHardware);    // tally

            command += "%Z";                                                // vége

            return command;
        }

        private void sendData(bool sendText) => unit?.SendDisplayCommand(getCommandStringToSend(sendText));
       
        #endregion

    }

}
