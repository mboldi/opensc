﻿using OpenSC.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Timers.DynamicTextFunctions
{
    public class TimerHhMmSs : IDynamicTextFunction
    {
        public string FunctionName => nameof(TimerHhMmSs);

        public string Description => "HH:MM::SS format of elapsed/remaining time of a timer.";

        public int ParameterCount => 1;

        public DynamicTextFunctionArgumentType[] ArgumentTypes => new DynamicTextFunctionArgumentType[]
        {
            DynamicTextFunctionArgumentType.Integer
        };

        public string[] ArgumentDescriptions => new string[]
        {
            "ID of the timer."
        };

        public IDynamicTextFunctionSubstitute GetSubstitute(object[] arguments)
        {
            Timer timer = TimerDatabase.Instance.GetTById((int)arguments[0]);
            return new Substitute(timer);
        }

        public class Substitute: DynamicTextFunctionSubstituteBase
        {

            private Timer timer;

            public Substitute(Timer timer)
            {
                if (timer == null)
                {
                    CurrentValue = "??:??:??";
                    return;
                }
                this.timer = timer;
                timer.SecondsChanged += timerSecondsChangedHandler;
                CurrentValue = timer.TimeSpan.ToString(@"hh\:mm\:ss");
            }

            private void timerSecondsChangedHandler(Timer timer, int oldValue, int newValue)
            {
                CurrentValue = timer.TimeSpan.ToString(@"hh\:mm\:ss");
            }
            
        }

    }
}
