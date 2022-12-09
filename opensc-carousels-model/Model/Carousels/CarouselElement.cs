using OpenSC.Model.General;
using OpenSC.Model.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Carousels
{

    public partial class CarouselElement : ObjectBase
    {

        public CarouselElement(Carousel carousel)
        {
            Carousel = carousel;
        }

        public Carousel Carousel { get; init; }

        #region Property: Text
        [AutoProperty]
        [AutoProperty.AfterChange(nameof(_time_afterChange))]
        private string text;

        private void _time_afterChange(string oldValue, string newValue) => Carousel.NotifyCarouselTextChanged(this, newValue);
        #endregion

        #region Property: Time
        [AutoProperty]
        private int time = 10;
        #endregion

    }

}
