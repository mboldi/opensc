using OpenSC.GUI.GeneralComponents;
using OpenSC.GUI.GeneralComponents.Tables;
using OpenSC.GUI.Helpers.Converters;
using OpenSC.GUI.WorkspaceManager;
using OpenSC.Model;
using OpenSC.Model.Carousels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OpenSC.GUI.Carousels
{

    [WindowTypeName("carousels.carousellist")]
    public partial class CarouselList : ModelListFormBase
    {

        protected override string SubjectSingular { get; } = "carousel";
        protected override string SubjectPlural { get; } = "carousels";

        protected override IModelEditorForm ModelEditorForm { get; } = new CarouselEditorForm();

        protected override IItemListFormBaseManager createManager()
            => new ModelListFormBaseManager<Carousel>(this, CarouselDatabase.Instance, baseColumnCreator);

        public CarouselList() => InitializeComponent();

        private void baseColumnCreator(CustomDataGridView<Carousel> table, ItemListFormBaseManager<Carousel>.ColumnDescriptorBuilderGetterDelegate builderGetterMethod)
        {
            // Column: GlobalID, ID, name
            globalIdColumnCreator(table, builderGetterMethod);
            idColumnCreator(table, builderGetterMethod);
            nameColumnCreator(table, builderGetterMethod);
            // Column: edit, delete
            editButtonColumnCreator(table, builderGetterMethod);
            deleteButtonColumnCreator(table, builderGetterMethod);
        }

    }

}