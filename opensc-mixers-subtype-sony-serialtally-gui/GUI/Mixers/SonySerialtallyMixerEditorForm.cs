using OpenSC.GUI.GeneralComponents.DropDowns;
using OpenSC.Library.SonySerialTally;
using OpenSC.Model.Mixers;
using OpenSC.Model.Mixers.SonySerialTally;
using OpenSC.Model.SerialPorts;
using System;

namespace OpenSC.GUI.Mixers
{

    public partial class SonySerialtallyMixerEditorForm : MixerEditorFormBase, IModelEditorForm<Mixer>
    {

        public IModelEditorForm GetInstance(object modelInstance) => GetInstanceT(modelInstance as Mixer);
        public IModelEditorForm<Mixer> GetInstanceT(Mixer modelInstance) => new SonySerialtallyMixerEditorForm(modelInstance);

        public SonySerialtallyMixerEditorForm() : base() => InitializeComponent();

        public SonySerialtallyMixerEditorForm(Mixer mixer) : base(mixer)
        {
            InitializeComponent();
            if ((mixer != null) && !(mixer is SonySerialTallyMixer))
                throw new ArgumentException($"Type of mixer should be {nameof(SonySerialTallyMixer)}.", nameof(mixer));

            initDropDowns();
        }
        private void initDropDowns()
        {
            serialPortDropdown.CreateAdapterAsDataSource(SerialPortDatabase.Instance, port => port.Name, true, "(not connected)");
            serialPortDropdown.ReceiveObjectDrop().FilterByType<SerialPort>();

            tallySizeDropdown.Items.Add(ProtocolStrings.TALLY_SIZE_128);
            tallySizeDropdown.Items.Add(ProtocolStrings.TALLY_SIZE_256);
            tallySizeDropdown.SelectedIndex = 0;

            redTallySelectorDropdown.Items.Add(SonyTallyType.RED);
            redTallySelectorDropdown.Items.Add(SonyTallyType.GREEN);
            redTallySelectorDropdown.Items.Add(SonyTallyType.YELLOW);
            redTallySelectorDropdown.SelectedIndex = 0;

            greenTallySelectorDropdown.Items.Add(SonyTallyType.RED);
            greenTallySelectorDropdown.Items.Add(SonyTallyType.GREEN);
            greenTallySelectorDropdown.Items.Add(SonyTallyType.YELLOW);
            greenTallySelectorDropdown.SelectedIndex = 0;

            matrixSizeDropdown.Items.Add(ProtocolStrings.MATRIX_MODE_STANDARD);
            matrixSizeDropdown.Items.Add(ProtocolStrings.MATRIX_MODE_SMALLER);
            matrixSizeDropdown.Items.Add(ProtocolStrings.MATRIX_MODE_MLSX1);
            matrixSizeDropdown.Items.Add(ProtocolStrings.MATRIX_MODE_XVSG1);
            matrixSizeDropdown.SelectedIndex = 0;
        }

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<Mixer, SonySerialTallyMixer>(this, MixerDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;

            serialPortDropdown.SelectByValue(sonyMixer.ComPort);

            switch(sonyMixer.TallyDataSize)
            {
                case SonyTallyDataSize.Matrix128:
                    tallySizeDropdown.SelectedIndex = 0;
                    break;
                case SonyTallyDataSize.Matrix256:
                    tallySizeDropdown.SelectedIndex = 1;
                    break;
            }

            switch (sonyMixer.MatrixMode)
            {
                case SonySwitcherMatrixMode.STANDARD:
                    matrixSizeDropdown.SelectedIndex = 0;
                    break;
                case SonySwitcherMatrixMode.SMALLER:
                    matrixSizeDropdown.SelectedIndex = 1;
                    break;
                case SonySwitcherMatrixMode.MLSX1:
                    matrixSizeDropdown.SelectedIndex = 2;
                    break;
                case SonySwitcherMatrixMode.XVSG1:
                    matrixSizeDropdown.SelectedIndex = 3;
                    break;
            }

            switch (sonyMixer.RedTallySourceType)
            {
                case SonyTallyType.RED:
                    redTallySelectorDropdown.SelectedIndex = 0;
                    break;
                case SonyTallyType.GREEN:
                    redTallySelectorDropdown.SelectedIndex = 1;
                    break;
                case SonyTallyType.YELLOW:
                    redTallySelectorDropdown.SelectedIndex = 3;
                    break;
            }

            redTallyGroupSelectorNumeric.Value = sonyMixer.RedTallySourceGroup;


            switch (sonyMixer.GreenTallySourceType)
            {
                case SonyTallyType.RED:
                    greenTallySelectorDropdown.SelectedIndex = 0;
                    break;
                case SonyTallyType.GREEN:
                    greenTallySelectorDropdown.SelectedIndex = 1;
                    break;
                case SonyTallyType.YELLOW:
                    greenTallySelectorDropdown.SelectedIndex = 3;
                    break;
            }

            greenTallyGroupSelectorNumeric.Value = sonyMixer.GreenTallySourceGroup;


        }

        protected override void writeFields()
        {
            base.writeFields();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;

            sonyMixer.ComPort = serialPortDropdown.SelectedValue as SerialPort;

            if (tallySizeDropdown.SelectedItem.ToString() == ProtocolStrings.TALLY_SIZE_128)
            {
                sonyMixer.TallyDataSize = SonyTallyDataSize.Matrix128;
            } else if (tallySizeDropdown.SelectedItem.ToString() == ProtocolStrings.TALLY_SIZE_256)
            {
                sonyMixer.TallyDataSize = SonyTallyDataSize.Matrix256;
            }


            if (matrixSizeDropdown.SelectedItem.ToString() == ProtocolStrings.MATRIX_MODE_STANDARD)
            {
                sonyMixer.MatrixMode = SonySwitcherMatrixMode.STANDARD;
            } else if (matrixSizeDropdown.SelectedItem.ToString() == ProtocolStrings.MATRIX_MODE_SMALLER)
            {
                sonyMixer.MatrixMode = SonySwitcherMatrixMode.SMALLER;
            } else if (matrixSizeDropdown.SelectedItem.ToString() == ProtocolStrings.MATRIX_MODE_MLSX1)
            {
                sonyMixer.MatrixMode = SonySwitcherMatrixMode.MLSX1;
            } else if (matrixSizeDropdown.SelectedItem.ToString() == ProtocolStrings.MATRIX_MODE_XVSG1)
            {
                sonyMixer.MatrixMode = SonySwitcherMatrixMode.XVSG1;
            }


            if (redTallySelectorDropdown.SelectedItem.ToString() == SonyTallyType.RED.ToString())
            {
                sonyMixer.RedTallySourceType = SonyTallyType.RED;
            } else if (redTallySelectorDropdown.SelectedItem.ToString() == SonyTallyType.GREEN.ToString())
            {
                sonyMixer.RedTallySourceType = SonyTallyType.GREEN;
            } else if (redTallySelectorDropdown.SelectedItem.ToString() == SonyTallyType.YELLOW.ToString())
            {
                sonyMixer.RedTallySourceType = SonyTallyType.YELLOW;
            }

            sonyMixer.RedTallySourceGroup = (int)redTallyGroupSelectorNumeric.Value;


            if (greenTallySelectorDropdown.SelectedItem.ToString() == SonyTallyType.RED.ToString())
            {
                sonyMixer.GreenTallySourceType = SonyTallyType.RED;
            }
            else if (greenTallySelectorDropdown.SelectedItem.ToString() == SonyTallyType.GREEN.ToString())
            {
                sonyMixer.GreenTallySourceType = SonyTallyType.GREEN;
            }
            else if (greenTallySelectorDropdown.SelectedItem.ToString() == SonyTallyType.YELLOW.ToString())
            {
                sonyMixer.GreenTallySourceType = SonyTallyType.YELLOW;
            }

            sonyMixer.GreenTallySourceGroup = (int)greenTallyGroupSelectorNumeric.Value;

        }

        protected override void validateFields()
        {
            base.validateFields();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            
        }

        private void connectionStateChangedHandler(SonySerialTallyMixer mixer, bool oldState, bool newState)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => connectionStateChangedHandler(mixer, oldState, newState)));
                return;
            }
        }

    }

}
