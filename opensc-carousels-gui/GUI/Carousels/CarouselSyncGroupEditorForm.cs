using OpenSC.GUI.GeneralComponents.Tables;
using OpenSC.Model;
using OpenSC.Model.General;
using OpenSC.Model.Carousels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenSC.GUI.Carousels
{

    public partial class CarouselSyncGroupEditorForm : ModelEditorFormBase, IModelEditorForm<CarouselSyncGroup>
    {

        public IModelEditorForm GetInstance(object modelInstance) => GetInstanceT(modelInstance as CarouselSyncGroup);
        public IModelEditorForm<CarouselSyncGroup> GetInstanceT(CarouselSyncGroup modelInstance) => new CarouselSyncGroupEditorForm(modelInstance);

        public CarouselSyncGroupEditorForm() : base() => InitializeComponent();
        public CarouselSyncGroupEditorForm(CarouselSyncGroup carouselSyncGroup) : base(carouselSyncGroup) => InitializeComponent();

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<CarouselSyncGroup, CarouselSyncGroup>(this, CarouselSyncGroupDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            CarouselSyncGroup carouselSyncGroup = (CarouselSyncGroup)EditedModel;
            if (carouselSyncGroup == null)
                return;
        }

        protected override void validateFields()
        {
            base.validateFields();
            CarouselSyncGroup carouselSyncGroup = (CarouselSyncGroup)EditedModel;
            if (carouselSyncGroup == null)
                return;
        }

        protected override void writeFields()
        {
            base.writeFields();
            CarouselSyncGroup carouselSyncGroup = (CarouselSyncGroup)EditedModel;
            if (carouselSyncGroup == null)
                return;
        }

    }

}
