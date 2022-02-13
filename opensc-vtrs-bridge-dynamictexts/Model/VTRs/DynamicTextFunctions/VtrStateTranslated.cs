﻿using OpenSC.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.VTRs.DynamicTextFunctions
{

    [DynamicTextFunction(nameof(VtrStateTranslated), "The state of a VTR with the given translations.")]
    public class VtrStateTranslated : DynamicTextFunctionBase<VtrStateTranslated.Substitute>
    {

        [DynamicTextFunctionArgument(0, "ID of the VTR.")]
        public class Arg0 : DynamicTextFunctionArgumentDatabaseItem<Vtr>
        {
            public Arg0() : base(VtrDatabase.Instance)
            { }
        }

        [DynamicTextFunctionArgument(1, "Translation for state 'stopped'.")]
        public class Arg1 : DynamicTextFunctionArgumentString
        { }

        [DynamicTextFunctionArgument(2, "Translation for state 'paused'.")]
        public class Arg2 : DynamicTextFunctionArgumentString
        { }

        [DynamicTextFunctionArgument(3, "Translation for state 'playing'.")]
        public class Arg3 : DynamicTextFunctionArgumentString
        { }

        [DynamicTextFunctionArgument(4, "Translation for state 'rewinding'.")]
        public class Arg4 : DynamicTextFunctionArgumentString
        { }

        [DynamicTextFunctionArgument(5, "Translation for state 'fastforwarding'.")]
        public class Arg5 : DynamicTextFunctionArgumentString
        { }

        [DynamicTextFunctionArgument(6, "Translation for state 'recording'.")]
        public class Arg6 : DynamicTextFunctionArgumentString
        { }

        public class Substitute : VtrState.Substitute
        {

            private string translationForStopped;
            private string translationForPaused;
            private string translationForPlaying;
            private string translationForRewinding;
            private string translationForFastForwarding;
            private string translationForRecording;

            public override void Init(object[] argumentObjects)
            {
                translationForStopped = (string)argumentObjects[1];
                translationForPaused = (string)argumentObjects[2];
                translationForPlaying = (string)argumentObjects[3];
                translationForRewinding = (string)argumentObjects[4];
                translationForFastForwarding = (string)argumentObjects[5];
                translationForRecording = (string)argumentObjects[6];
                base.Init(argumentObjects);
            }

            protected override string convertStateToString(VTRs.VtrState state)
            {
                switch (state)
                {
                    case VTRs.VtrState.Stopped:
                        return translationForStopped;
                    case VTRs.VtrState.Paused:
                        return translationForPaused;
                    case VTRs.VtrState.Playing:
                        return translationForPlaying;
                    case VTRs.VtrState.Rewinding:
                        return translationForRewinding;
                    case VTRs.VtrState.FastForwarding:
                        return translationForFastForwarding;
                    case VTRs.VtrState.Recording:
                        return translationForRecording;
                }
                return base.convertStateToString(state);
            }

        }

    }

}
