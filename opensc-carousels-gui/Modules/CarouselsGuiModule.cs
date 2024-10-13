using OpenSC.GUI.Menus;
using OpenSC.GUI.Carousels;
using OpenSC.GUI.WorkspaceManager;

namespace OpenSC.Modules
{

    [Module("carousels-gui", "Carousels (GUI)", "TODO")]
    [DependsOnModule(typeof(CarouselsModelModule))]
    public class CarouselsGuiModule : BasetypeGuiModuleBase<CarouselsModelModule>
    {

        protected override void registerPersistableWindowTypes()
        {
            WindowTypeRegister.RegisterWindowType<CarouselList>();
            WindowTypeRegister.RegisterWindowType<CarouselSyncGroupList>();
        }

        public const string TOPMENUGROUP_ID = MenuManager.GROUP_ID_MODULES;
        public const string TOPMENU_LABEL = "Variables";
        public const string MENUGROUP_ID = "carousels";
        public const int MENUGROUP_WEIGHT = MenuManager.GROUP_WEIGHT_BASE + 10;
        public const string SUBMENU_CAROUSELLIST_LABEL = "Carousel list";
        public const string SUBMENU_CAROUSELSYNCGROUPLIST_LABEL = "Carousel sync group list";

        protected override void registerMenus()
        {
            MenuItem topMenu = MenuManager.Instance.TopMenu[TOPMENUGROUP_ID][TOPMENU_LABEL];
            MenuItemGroup menuGroup = topMenu[MENUGROUP_ID];
            menuGroup.Weight = MENUGROUP_WEIGHT;
            menuGroup[SUBMENU_CAROUSELLIST_LABEL].ClickHandler = (menu, tag) => new CarouselList().ShowAsChild();
            menuGroup[SUBMENU_CAROUSELSYNCGROUPLIST_LABEL].ClickHandler = (menu, tag) => new CarouselSyncGroupList().ShowAsChild();
        }

    }

}
