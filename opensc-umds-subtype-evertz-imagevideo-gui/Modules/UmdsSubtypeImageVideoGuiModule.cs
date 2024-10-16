using OpenSC.GUI.Menus;
using OpenSC.GUI.UMDs;
using OpenSC.Model.UMDs.ImageVideo;

namespace OpenSC.Modules
{

    [Module("umds-subtype-evertz-imagevideo-gui", "UMDs / Evertz ImageVideo (GUI)", "TODO")]
    [DependsOnModule(typeof(UmdsSubtypeImageVideoModelModule))]
    public class UmdsSubtypeImageVideoGuiModule : SubtypeGuiModuleBase<UmdsSubtypeImageVideoModelModule>
    {

        public override void Initialize()
        {
            base.Initialize();
            registerMenus();
        }

        protected override void registerPersistableWindowTypes()
        { }

        protected override void registerSubtypeEditorWindowTypes()
        {
            UmdEditorFormTypeRegister.Instance.RegisterFormType<ImageVideoDisplay, ImageVideoDisplayUmdEditorForm>();
        }

        public const string TOPMENUGROUP_ID = UmdsGuiModule.TOPMENUGROUP_ID;
        public const string TOPMENU_LABEL = UmdsGuiModule.TOPMENU_LABEL;
        public const string MENUGROUP_ID = "subtypes";
        public const int MENUGROUP_WEIGHT = UmdsGuiModule.MENUGROUP_WEIGHT + 10;
        public const string SUBMENU_LABEL = "Evertz ImageVideo";
        public const string SUBMENU_GROUP_ID = "base";
        public const int SUBMENU_GROUP_WEIGHT = 10;
        public const string SUBMENU_ITEM_SCREENLIST_LABEL = "Unit list";

        protected void registerMenus()
        {
            MenuItem topMenu = MenuManager.Instance.TopMenu[TOPMENUGROUP_ID][TOPMENU_LABEL];
            MenuItemGroup menuGroup = topMenu[MENUGROUP_ID];
            menuGroup.Weight = MENUGROUP_WEIGHT;
            MenuItem subMenu = menuGroup[SUBMENU_LABEL];
            MenuItemGroup subMenuGroup = subMenu[SUBMENU_GROUP_ID];
            subMenuGroup.Weight = SUBMENU_GROUP_WEIGHT;
            subMenuGroup[SUBMENU_ITEM_SCREENLIST_LABEL].ClickHandler = (menu, tag) => new ImageVideoUnitList().ShowAsChild();
        }

    }

}
