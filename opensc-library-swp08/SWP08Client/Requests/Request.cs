using OpenSC.Library.TaskSchedulerQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Library.SWP08Router
{
    internal abstract class Request : QueuedTask<bool>
    {
        public Request() => ValidUntil = DateTime.Now + ValidTime;

        public virtual TimeSpan ValidTime { get; } = new(0, 0, 2);
        public DateTime ValidUntil { get; init; }
        protected override bool IsValid => (ValidUntil >= DateTime.Now);

        protected virtual void _ack() { }
        protected virtual void _nak() { }

        private SWP08Client client;
        public void Send(SWP08Client client)
        {
            this.client = client;
            _send();
        }
        protected abstract void _send();

        protected void sendBlock(Byte command, Byte[] data) => client.sendCommand(command, data);

        protected override void _ready(bool result)
        {
            base._ready(result);
            if (result)
                _ack();
            else
                _nak();
        }
    }
}
