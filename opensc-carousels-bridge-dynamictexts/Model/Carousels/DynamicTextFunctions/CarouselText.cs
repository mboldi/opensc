using OpenSC.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Carousels.DynamicTextFunctions
{

    [DynamicTextFunction(nameof(CarouselText), "The current text of a carousel.")]
    public class CarouselText : DynamicTextFunctionBase<CarouselText.Substitute>
    {

        [DynamicTextFunctionArgument(0, "ID of the carousel.")]
        public class Arg0 : DynamicTextFunctionArgumentDatabaseItem<Carousel>
        {
            public Arg0() : base(CarouselDatabase.Instance)
            { }
        }

        public class Substitute : DynamicTextFunctionSubstituteBase
        {

            private Carousel carousel;

            public override void Init(object[] argumentObjects)
            {

                Carousel carousel = argumentObjects[0] as Carousel;
                if (carousel == null)
                {
                    CurrentValue = "?";
                    return;
                }
                this.carousel = carousel;

                carousel.CurrentTextChanged += carouselCurrentTextChanged;
                CurrentValue = carousel.CurrentText ?? "?";

            }

            private void carouselCurrentTextChanged(Carousel carousel, string oldText, string newText)
            {
                if (carousel == this.carousel)
                    CurrentValue = newText ?? "?";
            }

        }

    }

}
