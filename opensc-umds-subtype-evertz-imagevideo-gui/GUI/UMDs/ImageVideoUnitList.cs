using OpenSC.GUI.GeneralComponents.Tables;
using OpenSC.GUI.WorkspaceManager;
using OpenSC.Model.UMDs.ImageVideo;
using System.Drawing;

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

            // Column: IP/Port
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("IP:port");
            builder.Width(100);
            builder.UpdaterMethod((imagevideoUnit, cell) => { cell.Value = $"{imagevideoUnit.IpAddress}:{imagevideoUnit.Port}"; });
            builder.AddChangeEvent(nameof(ImageVideoUnit.IpAddress));

            // Column: connection state
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.TextBox);
            builder.Header("State");
            builder.Width(100);
            builder.DividerWidth(DEFAULT_DIVIDER_WIDTH);
            builder.UpdaterMethod((bmdSmartViewUnit, cell) => {
                if (bmdSmartViewUnit.Connected)
                {
                    cell.Style.BackColor = CELL_BG_CONNECTED;
                    cell.Value = "connected";
                }
                else
                {
                    cell.Style.BackColor = CELL_BG_DISCONNECTED;
                    cell.Value = "disconnected";
                }
            });
            builder.AddChangeEvent(nameof(ImageVideoUnit.Connected));

            // Column: connect button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.Button);
            builder.Header("Connect");
            builder.Width(70);
            builder.ButtonText("Connect");
            builder.CellContentClickHandlerMethod(async (imagevideoUnit, cell, e) => await imagevideoUnit.Connect());

            // Column: disconnect button
            builder = builderGetterMethod();
            builder.Type(DataGridViewColumnType.Button);
            builder.Header("Disconnect");
            builder.Width(70);
            builder.DividerWidth(DEFAULT_DIVIDER_WIDTH);
            builder.ButtonText("Disconnect");
            builder.CellContentClickHandlerMethod((imagevideoUnit, cell, e) => imagevideoUnit.Disconnect());

            // Column: edit, delete
            editButtonColumnCreator(table, builderGetterMethod);
            deleteButtonColumnCreator(table, builderGetterMethod);

        }

        private static readonly Color CELL_BG_CONNECTED = Color.LightPink;
        private static readonly Color CELL_BG_DISCONNECTED = Color.LightPink;

    }

}