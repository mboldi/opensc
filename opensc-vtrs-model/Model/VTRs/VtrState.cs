﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.VTRs
{
    public enum VtrState
    {
        Stopped,
        Cued,
        Paused,
        Playing,
        Rewinding,
        FastForwarding,
        Recording
    }
}
