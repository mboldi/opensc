using OpenSC.Model.Routers;
using System;

namespace OpenSC.Modules
{
    [Module("routers-subtype-swp08-model", "Routers / Pro-Bel SW-P-08 (model)", "TODO")]
    [DependsOnModule(typeof(RoutersModelModule))]
    public class RoutersSubtypeSwp08ModelModule : SubtypeModelModuleBase<RoutersModelModule>
    {
        protected override void registerModelTypes()
        {
            RouterTypeRegister.Instance.RegisterType<SWP08Router>();
        }

        protected override void registerSerializers()
        {
            
        }
    }
}
