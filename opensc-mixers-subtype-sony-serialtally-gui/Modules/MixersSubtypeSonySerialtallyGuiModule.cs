using OpenSC.GUI.Mixers;
using OpenSC.Model.Mixers.SonySerialTally;

namespace OpenSC.Modules
{

    [Module("mixers-subtype-sony-serialtally", "Mixers / Sony Serial Tally (GUI)", "TODO")]
    [DependsOnModule(typeof(MixersSubtypeSonySerialtallyModelModule))]
    public class BooleantalliesGuiModule : SubtypeGuiModuleBase<MixersSubtypeSonySerialtallyModelModule>
    {

        protected override void registerPersistableWindowTypes()
        { }

        protected override void registerSubtypeEditorWindowTypes()
        {
            MixerEditorFormTypeRegister.Instance.RegisterFormType<SonySerialTallyMixer, SonySerialtallyMixerEditorForm>();
        }

    }

}
