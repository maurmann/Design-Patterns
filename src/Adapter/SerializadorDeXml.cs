using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class SerializadorDeXml
    {
        public string Serializar(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
