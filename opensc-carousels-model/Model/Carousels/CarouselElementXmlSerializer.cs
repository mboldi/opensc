using OpenSC.Model.Persistence;
using System;
using System.Xml;
using System.Xml.Linq;

namespace OpenSC.Model.Carousels
{

    public class CarouselElementXmlSerializer : IValueXmlSerializer
    {

        public Type Type => typeof(CarouselElement);

        private const string TAG_NAME = "element";
        private const string ATTRIBUTE_TEXT = "text";
        private const string ATTRIBUTE_TIME = "time";

        public object DeserializeItem(XmlNode serializedItem, object parentItem, object[] indicesOrKeys)
        {
            if (serializedItem.LocalName != TAG_NAME)
                return null;
            CarouselElement element = ((Carousel)parentItem).CreateElement();
            element.Text = serializedItem.Attributes[ATTRIBUTE_TEXT]?.Value;
            if (int.TryParse(serializedItem.Attributes[ATTRIBUTE_TIME]?.Value, out int timeInt))
                element.Time = timeInt;
            return element;
        }

        public XElement SerializeItem(object item, object parentItem, object[] indicesOrKeys)
        {
            CarouselElement element = item as CarouselElement;
            if (element == null)
                return null;
            XElement xmlElement = new(TAG_NAME);
            xmlElement.SetAttributeValue(ATTRIBUTE_TEXT, element.Text);
            xmlElement.SetAttributeValue(ATTRIBUTE_TIME, element.Time);
            return xmlElement;
        }
        
    }

}
