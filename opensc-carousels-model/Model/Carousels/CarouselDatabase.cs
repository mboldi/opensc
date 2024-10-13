using OpenSC.Model.Persistence;

namespace OpenSC.Model.Carousels
{
    [DatabaseName(CarouselDatabase.DBNAME)]
    [XmlTagNames("carousels", "carousel")]
    public class CarouselDatabase : DatabaseBase<Carousel>
    {
        public static CarouselDatabase Instance { get; } = new CarouselDatabase();
        public const string DBNAME = "carousels";
    }
}
