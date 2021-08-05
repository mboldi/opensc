﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Routers.Virtual
{

    [TypeLabel("Virtual router")]
    [TypeCode("virtual")]
    class VirtualRouter : Router
    {

        public VirtualRouter()
        {
            State = RouterState.Ok;
            StateString = "OK";
        }

        public override void RestoredOwnFields()
        {
            base.RestoredOwnFields();
            State = RouterState.Ok;
            StateString = "OK";
            queryAllCrosspoints();
        }

        protected override void requestCrosspointUpdateImpl(RouterOutput output, RouterInput input)
            => notifyCrosspointChanged(output, input);

        protected override void queryAllCrosspoints()
        {
            Random r = new Random();
            int c = Inputs.Count;
            foreach (RouterOutput output in Outputs)
                notifyCrosspointChanged(output, (c > 0) ? Inputs[r.Next(c - 1)] : null);
        }

        protected override void requestLockOperationImpl(RouterOutput output, RouterOutputLockOperationType operationType)
        { }

        #region Input and output instantiation
        public override RouterInput CreateInput(string name, int index) => new RouterInput(name, this, index);
        public override RouterOutput CreateOutput(string name, int index) => new RouterOutput(name, this, index);
        #endregion

    }

}
