using OpenSC.GUI.GeneralComponents.DropDowns;
using OpenSC.Model.Mixers;
using OpenSC.Model.Mixers.SonySerialTally;
using OpenSC.Model.SerialPorts;
using OpenSC.Model.SonySerialTally;
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
            serialPortComboBox.CreateAdapterAsDataSource(SerialPortDatabase.Instance, port => port.Name, true, "(not connected)");
            serialPortComboBox.ReceiveObjectDrop().FilterByType<SerialPort>();

            matrixSizeComboBox.Items.Add("128x128");
            matrixSizeComboBox.Items.Add("256x256");
        }

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<Mixer, SonySerialTallyMixer>(this, MixerDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            
        }

        protected override void writeFields()
        {
            base.writeFields();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            
        }

        protected override void validateFields()
        {
            base.validateFields();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            
        }

        private void connectButton_Click(object sender, EventArgs e) 
        {
        
        }
        private void disconnectButton_Click(object sender, EventArgs e)
        {

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
