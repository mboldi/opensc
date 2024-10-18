using OpenSC.Model.Mixers;
using OpenSC.Model.Mixers.SonySerialTally;
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
        }

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<Mixer, SonySerialTallyMixer>(this, MixerDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            ipAddressInput.Text = sonyMixer.IpAddress;
            autoReconnectCheckbox.Checked = sonyMixer.AutoReconnect;
            sonyMixer.ConnectionStateChanged += connectionStateChangedHandler;
            connectButton.Enabled = !sonyMixer.ConnectionState;
            disconnectButton.Enabled = sonyMixer.ConnectionState;
        }

        protected override void writeFields()
        {
            base.writeFields();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            sonyMixer.IpAddress = ipAddressInput.Text;
            sonyMixer.AutoReconnect = autoReconnectCheckbox.Checked;
        }

        protected override void validateFields()
        {
            base.validateFields();
            SonySerialTallyMixer sonyMixer = (SonySerialTallyMixer)EditedModel;
            if (sonyMixer == null)
                return;
            sonyMixer.ValidateIpAddress(ipAddressInput.Text);
        }

        private void connectButton_Click(object sender, EventArgs e) => (EditedModel as SonySerialTallyMixer)?.Connect();
        private void disconnectButton_Click(object sender, EventArgs e) => (EditedModel as SonySerialTallyMixer)?.Disconnect();

        private void connectionStateChangedHandler(SonySerialTallyMixer mixer, bool oldState, bool newState)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => connectionStateChangedHandler(mixer, oldState, newState)));
                return;
            }
            connectButton.Enabled = !newState;
            disconnectButton.Enabled = newState;
        }

    }

}
