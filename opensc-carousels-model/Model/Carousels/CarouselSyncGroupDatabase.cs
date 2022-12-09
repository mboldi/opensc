using OpenSC.Model.Persistence;

namespace OpenSC.Model.Carousels
{
    [DatabaseName(CarouselSyncGroupDatabase.DBNAME)]
    [XmlTagNames("carousel_sync_groups", "carousel_sync_group")]
    public class CarouselSyncGroupDatabase : DatabaseBase<CarouselSyncGroup>
    {
        public static CarouselSyncGroupDatabase Instance { get; } = new CarouselSyncGroupDatabase();
        public const string DBNAME = "carousel_sync_groups";
    }
}
