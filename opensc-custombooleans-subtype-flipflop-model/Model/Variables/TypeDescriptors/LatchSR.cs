﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Variables.TypeDescriptors
{

    public class LatchSR : FlipFlopTypeDescriptor
    {

        public static FlipFlopTypeDescriptor Instance { get; } = new LatchSR();
        public override bool Input1Used => true;
        public override bool Input2Used => true;
        public override string Input1Name => "Set";
        public override string Input2Name => "Reset";
        public override bool Input1Invertable => true;
        public override bool Input2Invertable => true;

        public override string GetDescription(string input1identifier, bool input1inverted, string input2identifier, bool input2inverted)
            => $"SR latch set (priority) by {edge(input1inverted)} [{identifier(input1identifier)}] and reset by {edge(input2inverted)} [{identifier(input2identifier)}].";

        protected override bool _calculateState(bool current, bool input1, bool input1edge, bool input2, bool input2edge)
        {
            if (input1)
                return true;
            if (input2)
                return false;
            return current;
        }

    }

}
