using OpenSC.Model.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSC.Model.UMDs.ImageVideo
{

    [DatabaseName(ImageVideoUnitDatabase.DBNAME)]
    [XmlTagNames("units", "unit")]
    public class ImageVideoUnitDatabase: DatabaseBase<ImageVideoUnit>
    {
        public static ImageVideoUnitDatabase Instance { get; } = new ImageVideoUnitDatabase();
        public const string DBNAME = "imagevideo_units";
    }

}
