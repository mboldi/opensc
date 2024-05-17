using OpenSC.GUI.Routers;

namespace OpenSC.Modules
{
    [Module("routers-subtype-swp08-gui", "Routers / Pro-Bel SW-P-08 (GUI)", "TODO")]
    [DependsOnModule(typeof(RoutersSubtypeSwp08ModelModule))]
    public class RoutersSubtypeSwp08GuiModule : SubtypeGuiModuleBase<RoutersSubtypeSwp08ModelModule>
    {
        protected override void registerPersistableWindowTypes()
        {
            
        }

        protected override void registerSubtypeEditorWindowTypes()
        {
            RouterEditorFormTypeRegister.Instance.RegisterFormType<SWP08Router, SWP08RouterEditorForm>();
        }
    }
}
