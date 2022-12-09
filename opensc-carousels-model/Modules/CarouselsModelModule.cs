using OpenSC.Model;
using OpenSC.Model.Persistence;
using OpenSC.Model.Carousels;

namespace OpenSC.Modules
{

    [Module("carousels-model", "Carousels (model)", "TODO")]
    [DependsOnModule(typeof(CarouselsModelModule))]
    public class CarouselsModelModule : BasetypeModuleBase
    {

        protected override void registerDatabases()
        {
            MasterDatabase.Instance.RegisterSingletonDatabase(typeof(CarouselDatabase));
            MasterDatabase.Instance.RegisterSingletonDatabase(typeof(CarouselSyncGroupDatabase));
        }

        protected override void registerSerializers()
        {
            SerializerRegister.RegisterSerializer(new CarouselElementXmlSerializer());
        }

    }

}
