using OpenSC.Library.TaskSchedulerQueue;
using System.Diagnostics;

namespace OpenSC.Library.SonySerialTally
{

    public class Switcher
    {

        #region Messaging
        public void HandleIncomingMessage(byte[] message)
        {

        }

        public delegate void SendMessageTriggerDelegate(byte[] message);
        public event SendMessageTriggerDelegate SendMessageTrigger;

        public void SendMessage(byte[] commandBytes)
        {
            SendMessageTrigger(commandBytes);
        }

        #endregion

        #region Connection

        private void handleConnectionStateChanged()
        {

        }

        #endregion

        #region Request scheduler
        private readonly TaskQueue<Request, bool> requestScheduler;
        private void sendRequest(Request request) => request.Send(this);
        private void invalidRequest(Request request) => Debug.WriteLine($"Dropped an invalid request for Sony Serial Tally");
        private void scheduleRequest(Request request)
        {
            requestScheduler.Enqueue(request);
        }
        internal void AckLastRequest()
        {
            requestScheduler.LastDequeuedTaskReady(true);
        }
        internal void NakLastRequest() => requestScheduler.LastDequeuedTaskReady(false);
        #endregion

        #region Tally

        public delegate void TallyStateChangedDelegate(byte group, SonyTallyType type, int inputIndex, bool tallyState);
        public event TallyStateChangedDelegate TallyStateChanged;

        internal void FireTallyStateChange(byte group, SonyTallyType type, int inputIndex, bool tallyState)
        {
            TallyStateChanged?.Invoke(group, type, inputIndex, tallyState);
        }

        #endregion

    }

}
