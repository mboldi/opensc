using OpenSC.GUI.GeneralComponents.DropDowns;
using OpenSC.Model.Routers;
using OpenSC.Model.Routers.SWP08;
using OpenSC.Model.SerialPorts;
using System;
using System.Drawing;

namespace OpenSC.GUI.Routers
{
    public partial class SWP08RouterEditorForm : RouterEditorFormBase, IModelEditorForm<Router>
    {

        public IModelEditorForm GetInstance(object modelInstance) => GetInstanceT(modelInstance as Router);
        public IModelEditorForm<Router> GetInstanceT(Router modelInstance) => new SWP08RouterEditorForm(modelInstance);

        public SWP08RouterEditorForm() : base() => InitializeComponent();

        public SWP08RouterEditorForm(Router router): base(router)
        {
            InitializeComponent();

            if ((router != null) && !(router is SWP08Router))
                throw new ArgumentException($"Type of router should be {nameof(SWP08Router)}.", nameof(router));

            initDropDowns();
        }

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<Router, SWP08Router>(this, RouterDatabase.Instance);


        private void initDropDowns()
        {
            serialPortDropDown.CreateAdapterAsDataSource(SerialPortDatabase.Instance, port => port.Name, true, "(not connected)");
            serialPortDropDown.ReceiveObjectDrop().FilterByType<SerialPort>();
        }

        protected override void loadData()
        {
            base.loadData();
            SWP08Router swpRouter = (SWP08Router)EditedModel;
            if (swpRouter == null)
                return;

            switch(swpRouter.ConnectionMode)
            {
                case RouterConnectionMode.Serial:
                    serialControlRadioButton.Checked = true;
                    ethernetControlRadioButton.Checked = false;

                    break;
                case RouterConnectionMode.IP:
                    ethernetControlRadioButton.Checked = true;
                    serialControlRadioButton.Checked = false;

                    break;
            }

            swpRouter.ConnectionModeChanged += connectionModeChangedHandler;

            ipAddressInput.Text = swpRouter.IpAddress;
            autoReconnectCheckBox.Checked = swpRouter.AutoReconnect;
            swpRouter.ConnectionStateChanged += connectionStateChangedHandler;
            connectButton.Enabled = !swpRouter.Connected;
            disconnectButton.Enabled = swpRouter.Connected;
        }

        private void connectionModeChangedHandler(SWP08Router router, RouterConnectionMode oldState, RouterConnectionMode newState)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => connectionModeChangedHandler(router, oldState, newState)));
                return;
            }

            if(newState == RouterConnectionMode.Serial)
            {
                serialControlRadioButton.Checked = true;
                ethernetControlRadioButton.Checked = false;
            } else
            {
                ethernetControlRadioButton.Checked = true;
                serialControlRadioButton.Checked = false;
            }
        }

        private void connectionStateChangedHandler(SWP08Router router, bool oldState, bool newState)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => connectionStateChangedHandler(router, oldState, newState)));
                return;
            }
            connectButton.Enabled = !newState;
            disconnectButton.Enabled = newState;
        }

    }
}
