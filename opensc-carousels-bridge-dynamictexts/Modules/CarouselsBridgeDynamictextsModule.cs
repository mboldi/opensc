using OpenSC.Model;
using OpenSC.Model.Carousels.DynamicTextFunctions;
using OpenSC.Model.Variables;

namespace OpenSC.Modules
{

    [Module("carosels-bridge-dynamictexts", "Carosels (bridge to dynamic texts)", "TODO")]
    [DependsOnModule(typeof(CarouselsModelModule))]
    public class CarouselsBridgeDynamictextsModule : DynamictextsBridgeModuleBase<CarouselsModelModule>
    {

        protected override void registerDynamicTextFunctions()
        {
            DynamicTextFunctionRegister.Instance.RegisterFunction(new CarouselText());
        }

    }

}
