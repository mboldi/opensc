using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenSC.Model.Carousels
{
    public partial class CarouselSyncGroup : ModelBase
    {

        #region Instantiation, restoration
        public override void TotallyRestored()
        {
            base.TotallyRestored();
            Start();
        }

        public override void Removed()
        {
            base.Removed();
            assignedCarousels.ForEach(c => c.SyncGroupRemoved());
            Stop();
        }

        protected override void afterUpdate()
        {
            base.afterUpdate();
            Start();
        }
        #endregion

        #region Owner database
        public override sealed IDatabaseBase OwnerDatabase { get; } = CarouselSyncGroupDatabase.Instance;
        #endregion

        #region Assigned carousels
        private List<Carousel> assignedCarousels = new();

        internal void SubscribeAssignedCarousel(Carousel carousel)
        {
            if (assignedCarousels.Contains(carousel))
                return;
            assignedCarousels.Add(carousel);
        }

        internal void UnsubscribeAssignedCarousel(Carousel carousel)
            => assignedCarousels.Remove(carousel);
        #endregion

        #region Stepping
        public void Next()
            => assignedCarousels.ForEach(c => c.Next(true));

        public void Previous()
           => assignedCarousels.ForEach(c => c.Previous(true));

        public void Reset()
           => assignedCarousels.ForEach(c => c.Reset(true));

        public void TimeStep()
            => assignedCarousels.ForEach(c => c.TimeStep());

        public void Start()
        {
            if (timeStepperTask != null)
                return;
            Reset();
            timeStepperTaskCancellationTokenSource = new();
            timeStepperTaskCancellationToken = timeStepperTaskCancellationTokenSource.Token;
            timeStepperTask = Task.Run(timeStepperTaskMethod, timeStepperTaskCancellationToken);
        }

        public void Stop()
        {
            if (timeStepperTask == null)
                return;
            timeStepperTaskCancellationTokenSource.Cancel();
        }

        private Task timeStepperTask;
        private CancellationTokenSource timeStepperTaskCancellationTokenSource;
        private CancellationToken timeStepperTaskCancellationToken;

        private async Task timeStepperTaskMethod()
        {
            while (!timeStepperTaskCancellationToken.IsCancellationRequested)
            {
                await Task.Delay(100, timeStepperTaskCancellationToken);
                if (!timeStepperTaskCancellationToken.IsCancellationRequested)
                    TimeStep();
            }
            timeStepperTaskCancellationTokenSource.Dispose();
            timeStepperTaskCancellationTokenSource = null;
            timeStepperTask = null;
        }
        #endregion

    }

}
