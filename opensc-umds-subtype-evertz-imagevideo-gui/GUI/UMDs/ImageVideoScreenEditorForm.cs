using OpenSC.Model.UMDs.ImageVideo;
using System;
using System.Windows.Forms;

namespace OpenSC.GUI.UMDs
{

    public partial class ImageVideoScreenEditorForm : ModelEditorFormBase, IModelEditorForm<ImageVideoUnit>
    {

        public IModelEditorForm GetInstance(object modelInstance) => GetInstanceT(modelInstance as ImageVideoUnit);
        public IModelEditorForm<ImageVideoUnit> GetInstanceT(ImageVideoUnit modelInstance) => new ImageVideoScreenEditorForm(modelInstance);

        public ImageVideoScreenEditorForm() : base() => InitializeComponent();
        public ImageVideoScreenEditorForm(ImageVideoUnit tsl50screen) : base(tsl50screen) =>InitializeComponent();

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<ImageVideoUnit, ImageVideoUnit>(this, ImageVideoUnitDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            ImageVideoUnit imageVideoUnit = (ImageVideoUnit)EditedModel;
            if (imageVideoUnit == null)
                return;
            ipAddressInput.Text = imageVideoUnit.IpAddress;
            portNumericInput.Value = imageVideoUnit.Port;
            indexNumericInput.Value = imageVideoUnit.Index;
        }

        protected override void validateFields()
        {
            base.validateFields();
            ImageVideoUnit imageVideoUnit = (ImageVideoUnit)EditedModel;
            if (imageVideoUnit == null)
                return;
            imageVideoUnit.IpAddress = ipAddressInput.Text;
            imageVideoUnit.Port = (int)portNumericInput.Value;
            imageVideoUnit.Index = (int)indexNumericInput.Value;
        }

        protected override void writeFields()
        {
            base.writeFields();
            ImageVideoUnit imageVideoUnit = (ImageVideoUnit)EditedModel;
            if (imageVideoUnit == null)
                return;
            imageVideoUnit.ValidatePort((int)portNumericInput.Value);
            imageVideoUnit.ValidateIndex((int)indexNumericInput.Value);
        }

    }

}
