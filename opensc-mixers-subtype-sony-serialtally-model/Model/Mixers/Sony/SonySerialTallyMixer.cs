using OpenSC.Library.SonySerialTally;
using OpenSC.Logger;
using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SourceGenerators;
using System;

namespace OpenSC.Model.Mixers.SonySerialTally
{

    [TypeLabel("Sony Switcher")]
    [TypeCode("sony-serial")]
    public class SonySerialTallyMixer : Mixer
    {

        private const string LOG_TAG = "Mixer/SonySerial";

        private Switcher sonySwitcher;

        public SonySerialTallyMixer()
        {
            sonySwitcher = new Switcher();

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
            State = MixerState.Unknown;
            StateString = "disconnected";

            if (ComPort != null)
            {
                ComPort.InitializedChanged += handlePortInitChanged;
                ComPort.ReceivedDataBytes += handleIncomingMessage;
            }

            sonySwitcher.TallyStateChanged += handleTallyStateChange;
            sonySwitcher.SendMessageTrigger += sendMessage;
        }

        private void deinitSwitcher()
        {
            if (ComPort != null)
            {
                ComPort.InitializedChanged -= handlePortInitChanged;
                ComPort.ReceivedDataBytes -= handleIncomingMessage;
            }

            sonySwitcher.TallyStateChanged -= handleTallyStateChange;
            sonySwitcher.SendMessageTrigger -= sendMessage;
        }

        #region SerialPort & Sending/Receiving
        public event PropertyChangedTwoValuesDelegate<SonySerialTallyMixer, string> SerialPortChanged;

        private SerialPort comPort;

        [PersistAs("serial_port")]
        public SerialPort ComPort
        {
            get => comPort;
            set {
                var ov = comPort;

                if (ov != null)
                {
                    ov.InitializedChanged -= handlePortInitChanged;
                    ov.ReceivedDataBytes -= handleIncomingMessage;
                }

                comPort = value;

                if (comPort != null)
                {
                    comPort.InitializedChanged += handlePortInitChanged;
                    comPort.ReceivedDataBytes += handleIncomingMessage;
                }
            }
        }

        private void handlePortInitChanged(SerialPort item, bool oldValue, bool newValue)
        {
            if(!oldValue && newValue)
            {
                ComPort.BreakForTime(1);
            }
        }

        private void handleIncomingMessage(SerialPort port, byte[] data)
        {
            sonySwitcher.HandleIncomingMessage(data);
        }

        private void sendMessage(byte[] message)
        {
            DateTime validUntil = DateTime.Now + TimeSpan.FromSeconds(2);
            comPort.SendData(message, validUntil);
        }

        #endregion

        #region Tally & Matrix properties
        private SonyTallyDataSize tallyDataSize;

        [PersistAs("tally_data_size")]
        public SonyTallyDataSize TallyDataSize
        {
            get => tallyDataSize;
            set => tallyDataSize = value;
        }


        private SonyTallyType redTallySourceType;

        [PersistAs("red_tally_source_type")]
        public SonyTallyType RedTallySourceType
        {
            get => redTallySourceType;
            set => redTallySourceType = value;
        }


        private int redTallySourceGroup = 1;

        [PersistAs("red_tally_source_group")]
        public int RedTallySourceGroup
        {
            get => redTallySourceGroup;
            set => redTallySourceGroup = value;
        }


        private SonyTallyType greenTallySourceType;

        [PersistAs("green_tally_source_type")]
        public SonyTallyType GreenTallySourceType
        {
            get => greenTallySourceType; 
            set => greenTallySourceType = value;
        }


        private int greenTallySourceGroup = 1;

        [PersistAs("green_tally_source_group")]
        public int GreenTallySourceGroup
        {
            get => greenTallySourceGroup; 
            set => greenTallySourceGroup = value;
        }


        private SonySwitcherMatrixMode matrixMode;

        [PersistAs("matrix_mode")]
        public SonySwitcherMatrixMode MatrixMode
        {
            get => matrixMode; 
            set => matrixMode = value;
        }

        #endregion


        private void handleTallyStateChange(byte group, SonyTallyType type, int inputIndex, bool tallyState)
        {
            if(group == RedTallySourceGroup && type == RedTallySourceType)
            {
                if(inputIndex < Inputs.Count)
                {
                    Inputs[inputIndex].RedTally = tallyState;
                }
            }

            if (group == GreenTallySourceGroup && type == GreenTallySourceType)
            {
                if (inputIndex < Inputs.Count)
                {
                    Inputs[inputIndex].GreenTally = tallyState;
                }
            }
        }
    }

}