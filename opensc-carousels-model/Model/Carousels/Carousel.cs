using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        #region Element property changed event
        internal void NotifyCarouselTextChanged(CarouselElement element, string newText)
        {
            if (element == CurrentElement)
                CurrentText = newText;
        }
        #endregion

        #region Stepping
        public void Next()
        {
            currentElementIndex++;
            currentElementElapsedTime = 0;
            selectByIndex();
        }

        public void Previous()
        {
            currentElementIndex--;
            currentElementElapsedTime = 0;
            selectByIndex();
        }

        public void Reset()
        {
            currentElementIndex = 0;
            currentElementElapsedTime = 0;
            selectByIndex();
        }

        private void selectByIndex()
        {
            int elementCount = elements.Count;
            if ((currentElementIndex >= elementCount) || (currentElementIndex < 0))
                currentElementIndex = 0;
            CurrentElement = (elementCount > 0) ? elements[currentElementIndex] : null;
        }

        public void TimeStep()
        {
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
            if (timeStepperTask != null)
                return;
            Reset();
            timeStepperTask = Task.Run(timeStepperTaskMethod);
        }

        private Task timeStepperTask = null;

        private async Task timeStepperTaskMethod()
        {
            while (true)
            {
                await Task.Delay(100);
                TimeStep();
            }
        }
        #endregion


    }

}
