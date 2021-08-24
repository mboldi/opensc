﻿using OpenSC.Model;

namespace OpenSC.Modules
{

    [Module("umds-subtype-tsl31-model", "UMDs / TSL 3.1 (model)", "TODO")]
    [DependsOnModule(typeof(UmdsModelModule))]
    public class UmdsSubtypeTsl31ModelModule : SubtypeModelModuleBase<UmdsModelModule>
    {

        protected override void registerModelTypes()
        {
           // TODO : register TSL31
        }

    }

}
