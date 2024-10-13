using OpenSC.Library.TaskSchedulerQueue;
using System;

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

        protected void sendCommand(Byte command, Byte[] data) => client.SendCommand(new GenericCommand(command, data));

        protected void sendCommand(ICommand command) => client.SendBlock(new MessageBuilder().withCommand(command).BuildMessage());

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
