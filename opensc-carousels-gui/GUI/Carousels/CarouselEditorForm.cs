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

    public partial class CarouselEditorForm : ModelEditorFormBase, IModelEditorForm<Carousel>
    {

        public IModelEditorForm GetInstance(object modelInstance) => GetInstanceT(modelInstance as Carousel);
        public IModelEditorForm<Carousel> GetInstanceT(Carousel modelInstance) => new CarouselEditorForm(modelInstance);

        public CarouselEditorForm() : base() => InitializeComponent();
        public CarouselEditorForm(Carousel Carousel) : base(Carousel) => InitializeComponent();

        protected override IModelEditorFormDataManager createManager()
            => new ModelEditorFormDataManager<Carousel, Carousel>(this, CarouselDatabase.Instance);

        protected override void loadData()
        {
            base.loadData();
            Carousel Carousel = (Carousel)EditedModel;
            if (Carousel == null)
                return;
            initElementsTable();
        }

        protected override void validateFields()
        {
            base.validateFields();
            Carousel Carousel = (Carousel)EditedModel;
            if (Carousel == null)
                return;
        }

        protected override void writeFields()
        {
            base.writeFields();
            Carousel Carousel = (Carousel)EditedModel;
            if (Carousel == null)
                return;
        }

        private CustomDataGridView<CarouselElement> elementsTableCDGV;

        private void initElementsTable()
        {

            elementsTableCDGV = createTable<CarouselElement>(labelsTableContainerPanel, ref elementsTable);
            CustomDataGridViewColumnDescriptorBuilder<CarouselElement> builder;

            // Column: text
            builder = getColumnDescriptorBuilderForTable<CarouselElement>(elementsTableCDGV);
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Text");
            builder.Width(200);
            builder.InitializerMethod((element, cell) => { cell.Value = element.Text; });
            builder.TextEditable(true);
            builder.CellEndEditHandlerMethod((element, cell, eventargs) =>
            {
                try
                {
                    element.Text = cell.Value?.ToString();
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message, "Data validation error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cell.Value = element.Text;
                }
            });
            builder.BuildAndAdd();

            // Column: time
            builder = getColumnDescriptorBuilderForTable<CarouselElement>(elementsTableCDGV);
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Time (100 ms)");
            builder.Width(100);
            builder.InitializerMethod((element, cell) => { cell.Value = element.Time.ToString(); });
            builder.TextEditable(true);
            builder.CellEndEditHandlerMethod((element, cell, eventargs) =>
            {
                try
                {
                    int time = int.Parse(cell.Value?.ToString());
                    if (time <= 0)
                        throw new ArgumentException("Time value must be an integer greater than 0!");
                    element.Time = time;
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message, "Data validation error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cell.Value = element.Text;
                }
            });
            builder.BuildAndAdd();

            // Column: delete button
            builder = getColumnDescriptorBuilderForTable<CarouselElement>(elementsTableCDGV);
            builder.Type(DataGridViewColumnType.Button);
            builder.Header("Delete");
            builder.Width(70);
            builder.ButtonText("Delete");
            builder.CellContentClickHandlerMethod((element, cell, e) => {
                string msgBoxText = $"Do you really want this element?\r\n[{element.Text}]?";
                var confirm = MessageBox.Show(msgBoxText, "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                    ((Carousel)EditedModel).Elements.Remove(element);
            });
            builder.BuildAndAdd();

            // Bind collection
            elementsTableCDGV.BoundCollection = ((Carousel)EditedModel).Elements;

        }

        public CustomDataGridView<T> createTable<T>(Control container, ref DataGridView originalTableMember)
            where T : class
        {
            var customTable = new CustomDataGridView<T>();
            container.Controls.Clear();
            container.Controls.Add(customTable);
            customTable.Dock = DockStyle.Fill;
            originalTableMember = customTable;
            return customTable;
        }

        private CustomDataGridViewColumnDescriptorBuilder<T> getColumnDescriptorBuilderForTable<T>(CustomDataGridView<T> table)
            where T : class
            => new(table);

        private void addElementButton_Click(object sender, EventArgs e)
        {
            Carousel carousel = ((Carousel)EditedModel);
            carousel.Elements.Add(carousel.CreateElement());
        }

        private void elementsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
