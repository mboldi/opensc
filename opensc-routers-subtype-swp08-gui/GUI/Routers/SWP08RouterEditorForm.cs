using OpenSC.GUI.GeneralComponents.DropDowns;
using OpenSC.Model.Routers;
using OpenSC.Model.SerialPorts;
using System;

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


    }
}
