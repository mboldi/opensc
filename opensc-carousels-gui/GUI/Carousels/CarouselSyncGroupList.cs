using OpenSC.GUI.GeneralComponents;
using OpenSC.GUI.GeneralComponents.Tables;
using OpenSC.GUI.Helpers.Converters;
using OpenSC.GUI.WorkspaceManager;
using OpenSC.Model;
using OpenSC.Model.Carousels;
using OpenSC.Model.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OpenSC.GUI.Carousels
{

    [WindowTypeName("carousels.carouselsyncgrouplist")]
    public partial class CarouselSyncGroupList : ModelListFormBase
    {

        protected override string SubjectSingular { get; } = "carousel sync group";
        protected override string SubjectPlural { get; } = "carousel sync groups";

        protected override IModelEditorForm ModelEditorForm { get; } = new CarouselSyncGroupEditorForm();

        protected override IItemListFormBaseManager createManager()
            => new ModelListFormBaseManager<CarouselSyncGroup>(this, CarouselSyncGroupDatabase.Instance, baseColumnCreator);

        public CarouselSyncGroupList() => InitializeComponent();

        private void baseColumnCreator(CustomDataGridView<CarouselSyncGroup> table, ItemListFormBaseManager<CarouselSyncGroup>.ColumnDescriptorBuilderGetterDelegate builderGetterMethod)
        {

            CustomDataGridViewColumnDescriptorBuilder<CarouselSyncGroup> builder;

            // Column: GlobalID, ID, name
            globalIdColumnCreator(table, builderGetterMethod);
            idColumnCreator(table, builderGetterMethod);
            nameColumnCreator(table, builderGetterMethod);

            // Column: previous button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.ImageButton);
            builder.Header("");
            builder.Width(40);
            builder.ButtonImage(BUTTON_IMAGE_PREVIOUS);
            builder.ButtonImagePadding(DEFAULT_IMAGE_BUTTON_PADDING);
            builder.CellContentClickHandlerMethod((carouselSyncGroup, cell, e) => carouselSyncGroup.Previous());

            // Column: next button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.ImageButton);
            builder.Header("");
            builder.Width(40);
            builder.ButtonImage(BUTTON_IMAGE_NEXT);
            builder.ButtonImagePadding(DEFAULT_IMAGE_BUTTON_PADDING);
            builder.CellContentClickHandlerMethod((carouselSyncGroup, cell, e) => carouselSyncGroup.Next());

            // Column: reset button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.ImageButton);
            builder.Header("");
            builder.Width(40);
            builder.DividerWidth(DEFAULT_DIVIDER_WIDTH);
            builder.ButtonImage(BUTTON_IMAGE_RESET);
            builder.ButtonImagePadding(DEFAULT_IMAGE_BUTTON_PADDING);
            builder.CellContentClickHandlerMethod((carouselSyncGroup, cell, e) => carouselSyncGroup.Reset());

            // Column: edit, delete
            editButtonColumnCreator(table, builderGetterMethod);
            deleteButtonColumnCreator(table, builderGetterMethod);

        }

        private static readonly Bitmap BUTTON_IMAGE_NEXT = Icons._16_carousel_next;
        private static readonly Bitmap BUTTON_IMAGE_PREVIOUS = Icons._16_carousel_previous;
        private static readonly Bitmap BUTTON_IMAGE_RESET = Icons._16_carousel_reset;

    }

}