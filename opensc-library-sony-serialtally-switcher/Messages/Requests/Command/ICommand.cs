﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SonySerialTally
{
    public interface ICommand
    {
        public Byte[] getCommandBytesWithCode();
    }
}
