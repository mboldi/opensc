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
    public partial class Carousel : ModelBase
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
            // remove event subscriptions
        }

        protected override void afterUpdate()
        {
            base.afterUpdate();
            Start();
        }
        #endregion

        #region Owner database
        public override sealed IDatabaseBase OwnerDatabase { get; } = CarouselDatabase.Instance;
        #endregion

        #region Element collection
        [PersistAs("elements")]
        [PersistAs(null, 1)]
        private ObservableList<CarouselElement> elements = new();
        public ObservableList<CarouselElement> Elements => elements;

        public CarouselElement CreateElement() => new(this);
        #endregion

        #region Property: CurrentElement
        [AutoProperty]
        [AutoProperty.AfterChange(nameof(_currentElement_afterChange))]
        private CarouselElement currentElement;

        private void _currentElement_afterChange()
            => CurrentText = CurrentElement?.Text;
        #endregion

        #region Property: CurrentText
        [AutoProperty]
        private string currentText;
        #endregion

        #region Property: TimeSyncManualStepping
        [AutoProperty]
        [PersistAs("time_sync_manual_stepping")]
        private bool timeSyncManualStepping = false;
        #endregion

        #region Property: SyncGroup
        [AutoProperty]
        [AutoProperty.BeforeChange(nameof(_syncGroup_beforeChange))]
        [AutoProperty.AfterChange(nameof(_syncGroup_afterChange))]
        [PersistAs("sync_group")]
        private CarouselSyncGroup syncGroup;

        private void _syncGroup_beforeChange(CarouselSyncGroup oldSyncGroup, CarouselSyncGroup newSyncGroup)
        {
            if (oldSyncGroup != null)
            {
                oldSyncGroup.UnsubscribeAssignedCarousel(this);
                if (newSyncGroup == null)
                    Start();
            }
        }

        private void _syncGroup_afterChange(CarouselSyncGroup oldSyncGroup, CarouselSyncGroup newSyncGroup)
        {
            if (newSyncGroup != null)
            {
                if (oldSyncGroup == null)
                    Stop();
                newSyncGroup.SubscribeAssignedCarousel(this);
            }
        }

        internal void SyncGroupRemoved()
            => SyncGroup = null;
        #endregion

        #region Element property changed event
        internal void NotifyCarouselTextChanged(CarouselElement element, string newText)
        {
            if (element == CurrentElement)
                CurrentText = newText;
        }
        #endregion

        #region Stepping
        private int? nextElementOnTimeSync = null;

        public void Next(bool timeSync = false)
        {
            if (timeSyncManualStepping || timeSync)
            {
                nextElementOnTimeSync = currentElementIndex + 1;
            }
            else
            {
                currentElementIndex++;
                selectByIndex();
            }
        }

        public void Previous(bool timeSync = false)
        {
            if (timeSyncManualStepping || timeSync)
            {
                nextElementOnTimeSync = currentElementIndex - 1;
            }
            else
            {
                currentElementIndex--;
                selectByIndex();
            }
        }

        public void Reset(bool timeSync = false)
        {
            if (timeSyncManualStepping || timeSync)
            {
                nextElementOnTimeSync = 0;
            }
            else
            {
                currentElementIndex = 0;
                selectByIndex();
            }
        }

        private void selectByIndex()
        {
            int elementCount = elements.Count;
            if ((currentElementIndex >= elementCount) || (currentElementIndex < 0))
                currentElementIndex = 0;
            currentElementElapsedTime = 0;
            CurrentElement = (elementCount > 0) ? elements[currentElementIndex] : null;
        }

        public void TimeStep()
        {
            if (nextElementOnTimeSync != null)
            {
                currentElementIndex = (int)nextElementOnTimeSync;
                selectByIndex();
                nextElementOnTimeSync = null;
                return;
            }
            if (currentElement == null)
            {
                Next();
                return;
            }
            currentElementElapsedTime++;
            if ((currentElement != null) && (currentElementElapsedTime >= currentElement.Time))
                Next();
        }

        private int currentElementIndex = 0;
        private int currentElementElapsedTime = 0;

        public void Start()
        {
            if (syncGroup != null)
                return;
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
