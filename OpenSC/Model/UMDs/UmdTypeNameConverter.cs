﻿using OpenSC.Model.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.UMDs
{
    class UmdTypeNameConverter : TypeNameConverterBase
    {

        private Dictionary<string, Type> KNOWN_TYPES = new Dictionary<string, Type>()
        {
            { "mccurdy", typeof(McCurdy.McCurdyUMD1) },
            { "tsl31", typeof(TSL31.TSL31) },
        };

        protected override Dictionary<string, Type> knownTypes => KNOWN_TYPES;

    }
}
