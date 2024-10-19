using OpenSC.Library.TaskSchedulerQueue;
using System;

namespace OpenSC.Library.SonySerialTally
{
    internal abstract class Request : QueuedTask<bool>
    {
        public Request() => ValidUntil = DateTime.Now + ValidTime;

        public virtual TimeSpan ValidTime { get; } = new(0, 0, 2);
        public DateTime ValidUntil { get; init; }
        protected override bool IsValid => (ValidUntil >= DateTime.Now);

        protected virtual void _ack() { }
        protected virtual void _nak() { }

        private Switcher switcher;
        public void Send(Switcher switcher)
        {
            this.switcher = switcher;
            _send();
        }
        protected abstract void _send();

        protected void sendCommand(SonySwitcherRow switcherRow, ICommand command) => switcher.SendMessage(new MessageBuilder()
                                                                                                            .withEffect(switcherRow)
                                                                                                            .withCommand(command)
                                                                                                            .BuildMessage());

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
