using OpenSC.Model;
using OpenSC.Model.UMDs;
using OpenSC.Model.UMDs.ImageVideo;

namespace OpenSC.Modules
{

    [Module("umds-subtype-evertz-imagevideo-model", "UMDs / Evertz ImageVideo (model)", "TODO")]
    [DependsOnModule(typeof(UmdsModelModule))]
    public class UmdsSubtypeImageVideoModelModule : SubtypeModelModuleBase<UmdsModelModule>
    {

        public override void Initialize()
        {
            base.Initialize();
            MasterDatabase.Instance.RegisterSingletonDatabase(typeof(ImageVideoUnitDatabase));
        }

        protected override void registerModelTypes()
        {
            UmdTypeRegister.Instance.RegisterType<ImageVideoDisplay>();
        }

        protected override void registerSerializers()
        { }

    }

}
