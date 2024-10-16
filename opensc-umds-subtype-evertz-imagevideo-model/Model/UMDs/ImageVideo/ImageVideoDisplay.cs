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
            if ((index < 0) || (index > 65534))
                throw new ArgumentOutOfRangeException();
        }
        #endregion

        #region Info
        public override UmdTextInfo[] TextInfo => new UmdTextInfo[]
        {
           new("Text", false, true, false, UmdTextAlignment.Left)
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
            textBytesToHardware = Encoding.ASCII.GetBytes(text);
            DisplayableCompactText = text;
            DisplayableRawText = text;
        }

        protected byte[] textBytesToHardware = Array.Empty<byte>();

        protected override void calculateTallyFields()
        {
            tallyByteToHardware = 0;
            for (int i = 0, t = 32; i < TallyInfo.Length; i++, t /= 2)
                if (Tallies[i].CurrentState)
                    tallyByteToHardware += (byte)t;
        }

        private byte tallyByteToHardware;

        protected override void sendTextsToHardware() => sendData(true);
        protected override void sendTalliesToHardware() => sendData(false);
        protected override void sendEverythingToHardware() => sendData(true);

        protected virtual byte[] getAllBytesToSend(bool sendText = true)
        {
            throw new NotImplementedException();
        }

        private void sendData(bool sendText) 
        {
            
            // => unit?.SendDisplayData(getAllBytesToSend(sendText));
        }
        #endregion

    }

}
