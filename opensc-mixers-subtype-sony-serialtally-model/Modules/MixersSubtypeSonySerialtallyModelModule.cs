using OpenSC.Model;
using OpenSC.Model.Mixers;
using OpenSC.Model.Mixers.SonySerialTally;

namespace OpenSC.Modules
{

    [Module("mixers-subtype-sony-serialtally-model", "Mixers / Sony Serial Tally (model)", "TODO")]
    [DependsOnModule(typeof(MixersModelModule))]
    public class MixersSubtypeSonySerialtallyModelModule : SubtypeModelModuleBase<MixersModelModule>
    {

        protected override void registerModelTypes()
        {
            MixerTypeRegister.Instance.RegisterType<SonySerialTallyMixer>();
        }

        protected override void registerSerializers()
        { }

    }

}
