using OpenSC.Model.Mixers.SonySerialTally;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BMD.Switcher
{

    public class Switcher
    {

        SonySerialTallyMixer mixer;

        public Switcher(SonySerialTallyMixer mixer)
        {
            this.mixer = mixer;
        }


    }

}
