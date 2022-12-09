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

            CustomDataGridViewColumnDescriptorBuilder<Carousel> builder;

            // Column: GlobalID, ID, name
            globalIdColumnCreator(table, builderGetterMethod);
            idColumnCreator(table, builderGetterMethod);
            nameColumnCreator(table, builderGetterMethod);

            // Column: current text
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Current text");
            builder.Width(200);
            builder.UpdaterMethod((carousel, cell) => { cell.Value = (carousel.CurrentText ?? "-"); });
            builder.AddChangeEvent(nameof(Carousel.CurrentText));

            // Column: elements
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Elements");
            builder.Width(70);
            builder.DividerWidth(DEFAULT_DIVIDER_WIDTH);
            builder.UpdaterMethod((carousel, cell) => { cell.Value = carousel.Elements.Count; });
            builder.ExternalUpdateEventSubscriberMethod((carousel, updateInvoker) => { 
                ObservableEnumerableItemsChangedDelegate<CarouselElement> handler = (_) => updateInvoker();
                carousel.Elements.ItemsAdded += handler;
                carousel.Elements.ItemsRemoved += handler;
            });

            // Column: previous button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.ImageButton);
            builder.Header("");
            builder.Width(40);
            builder.ButtonImage(BUTTON_IMAGE_PREVIOUS);
            builder.ButtonImagePadding(DEFAULT_IMAGE_BUTTON_PADDING);
            builder.CellContentClickHandlerMethod((carousel, cell, e) => carousel.Previous());

            // Column: next button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.ImageButton);
            builder.Header("");
            builder.Width(40);
            builder.ButtonImage(BUTTON_IMAGE_NEXT);
            builder.ButtonImagePadding(DEFAULT_IMAGE_BUTTON_PADDING);
            builder.CellContentClickHandlerMethod((carousel, cell, e) => carousel.Next());

            // Column: reset button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.ImageButton);
            builder.Header("");
            builder.Width(40);
            builder.DividerWidth(DEFAULT_DIVIDER_WIDTH);
            builder.ButtonImage(BUTTON_IMAGE_RESET);
            builder.ButtonImagePadding(DEFAULT_IMAGE_BUTTON_PADDING);
            builder.CellContentClickHandlerMethod((carousel, cell, e) => carousel.Reset());

            // Column: edit, delete
            editButtonColumnCreator(table, builderGetterMethod);
            deleteButtonColumnCreator(table, builderGetterMethod);

        }

        private static readonly Bitmap BUTTON_IMAGE_NEXT = Icons._16_carousel_next;
        private static readonly Bitmap BUTTON_IMAGE_PREVIOUS = Icons._16_carousel_previous;
        private static readonly Bitmap BUTTON_IMAGE_RESET = Icons._16_carousel_reset;

    }

}