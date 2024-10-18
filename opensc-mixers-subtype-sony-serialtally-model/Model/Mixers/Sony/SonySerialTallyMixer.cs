using OpenSC.Logger;
using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenSC.Model.Mixers.SonySerialTally
{

    [TypeLabel("Sony Switcher")]
    [TypeCode("sony-serial")]
    public class SonySerialTallyMixer : Mixer
    {

        private const string LOG_TAG = "Mixer/SonySerial";

        public SonySerialTallyMixer()
        {
            initSwitcher();
        }

        public override void RestoredOwnFields()
        {
            base.RestoredOwnFields();
            initSwitcher();
        }

        public override void Removed()
        {

            base.Removed();

            deinitSwitcher();

        }

        

        private void initSwitcher()
        {
            
            State = MixerState.Warning;
            StateString = "disconnected";
        }

        private void deinitSwitcher()
        {
            
        }

        #region Property: SerialPort
        public event PropertyChangedTwoValuesDelegate<SonySerialTallyMixer, string> SerialPortChanged;


        [AutoProperty]
        [PersistAs("serial_port")]
        public SerialPort SerialPort;



        #endregion


        

        

    }

}