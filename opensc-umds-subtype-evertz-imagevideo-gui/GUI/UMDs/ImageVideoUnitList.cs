using OpenSC.GUI.GeneralComponents.Tables;
using OpenSC.GUI.WorkspaceManager;
using OpenSC.Model.UMDs.ImageVideo;

namespace OpenSC.GUI.UMDs
{

    [WindowTypeName("umds.imagevideounitlist")]
    public partial class ImageVideoUnitList : ModelListFormBase
    {

        protected override string SubjectSingular { get; } = "ImageVideo unit";
        protected override string SubjectPlural { get; } = "ImageVideo units";

        protected override IModelEditorForm ModelEditorForm => new ImageVideoUnitEditorForm();

        protected override IItemListFormBaseManager createManager()
            => new ModelListFormBaseManager<ImageVideoUnit>(this, ImageVideoUnitDatabase.Instance, baseColumnCreator);

        private void baseColumnCreator(CustomDataGridView<ImageVideoUnit> table, ItemListFormBaseManager<ImageVideoUnit>.ColumnDescriptorBuilderGetterDelegate builderGetterMethod)
        {

            CustomDataGridViewColumnDescriptorBuilder<ImageVideoUnit> builder;

            // Column: GlobalID, ID, name
            globalIdColumnCreator(table, builderGetterMethod);
            idColumnCreator(table, builderGetterMethod);
            nameColumnCreator(table, builderGetterMethod);

            // Column: state image
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("IP:port");
            builder.Width(100);
            builder.UpdaterMethod((imagevideoUnit, cell) => { cell.Value = $"{imagevideoUnit.IpAddress}:{imagevideoUnit.Port}"; });
            builder.AddChangeEvent(nameof(ImageVideoUnit.IpAddress));

            // Column: state label
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("Index");
            builder.Width(60);
            builder.DividerWidth(DEFAULT_DIVIDER_WIDTH);
            builder.UpdaterMethod((imagevideoScreen, cell) => { cell.Value = imagevideoScreen.Index; });
            builder.AddChangeEvent(nameof(ImageVideoUnit.Index));

            // Column: edit, delete
            editButtonColumnCreator(table, builderGetterMethod);
            deleteButtonColumnCreator(table, builderGetterMethod);

        }

    }

}