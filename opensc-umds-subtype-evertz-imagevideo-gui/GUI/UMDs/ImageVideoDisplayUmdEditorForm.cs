using OpenSC.GUI.GeneralComponents.DropDowns;
using OpenSC.Model.UMDs;
using OpenSC.Model.UMDs.ImageVideo;
using System;

namespace OpenSC.GUI.UMDs
{

    public partial class ImageVideoDisplayUmdEditorForm : UmdEditorFormBase, IModelEditorForm<Umd>
    {

        public IModelEditorForm GetInstance(object modelInstance) => GetInstanceT(modelInstance as Umd);
        public IModelEditorForm<Umd> GetInstanceT(Umd modelInstance) => new ImageVideoDisplayUmdEditorForm(modelInstance);

        public ImageVideoDisplayUmdEditorForm(): base() => InitializeComponent();

        public ImageVideoDisplayUmdEditorForm(Umd umd) : base(umd)
        {
            InitializeComponent();
            if ((umd != null) && !(umd is ImageVideoDisplay))
                throw new ArgumentException($"Type of UMD should be {nameof(ImageVideoDisplay)}.", nameof(umd));
            initScreenDropDown();
        }

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<Umd, ImageVideoDisplay>(this, UmdDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            ImageVideoDisplay imageVideoDisplay = (ImageVideoDisplay)EditedModel;
            if (imageVideoDisplay == null)
                return;
            screenDropDown.SelectByValue(imageVideoDisplay.Unit);
            indexNumericInput.Value = imageVideoDisplay.Index;
        }

        protected override void writeFields()
        {
            base.writeFields();
            ImageVideoDisplay imageVideoDisplay = (ImageVideoDisplay)EditedModel;
            if (imageVideoDisplay == null)
                return;
            imageVideoDisplay.Unit = screenDropDown.SelectedValue as ImageVideoUnit;
            imageVideoDisplay.Index = (int)indexNumericInput.Value;
        }

        protected override void validateFields()
        {
            base.validateFields();
            ImageVideoDisplay imageVideoDisplay = (ImageVideoDisplay)EditedModel;
            if (imageVideoDisplay == null)
                return;
            imageVideoDisplay.ValidateIndex((int)indexNumericInput.Value);
        }

        private void initScreenDropDown()
        {
            screenDropDown.CreateAdapterAsDataSource(ImageVideoUnitDatabase.Instance, null, true, "(not associated)");
            screenDropDown.ReceiveObjectDrop().FilterByType<ImageVideoUnit>();
        }

    }

}
