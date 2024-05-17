
using OpenSC.Model;
using OpenSC.Model.Routers;
using System.Collections.Generic;

namespace OpenSC
{
    [TypeLabel("Pro-Bel SW-P-08")]
    [TypeCode("swp08")]
    public class SWP08Router : Router
    {

        public override RouterInput CreateInput(string name, int index)
        {
            throw new System.NotImplementedException();
        }

        public override RouterOutput CreateOutput(string name, int index)
        {
            throw new System.NotImplementedException();
        }

        protected override void queryAllStates()
        {
            throw new System.NotImplementedException();
        }

        protected override void requestCrosspointUpdateImpl(RouterOutput output, RouterInput input)
        {
            throw new System.NotImplementedException();
        }

        protected override void requestCrosspointUpdatesImpl(IEnumerable<RouterCrosspoint> crosspoints)
        {
            throw new System.NotImplementedException();
        }

        protected override void requestLockOperationImpl(RouterOutput output, RouterOutputLockType lockType, RouterOutputLockOperationType lockOperationType)
        {
            throw new System.NotImplementedException();
        }
    }
}
