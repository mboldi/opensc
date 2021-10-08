﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Persistence
{
    [AttributeUsage(AttributeTargets.Field)]
    public class TempForeignKeyAttribute: Attribute
    {
        public string DatabaseName { get; private set; }
        public string OriginalFieldName { get; private set; }
        public TempForeignKeyAttribute(string OriginalFieldName)
        {
            this.DatabaseName = DatabaseName;
            this.OriginalFieldName = OriginalFieldName;
        }
    }
}
