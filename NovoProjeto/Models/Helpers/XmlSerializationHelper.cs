using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NovoProjeto.Models.Helpers
{
    public static class XmlSerializationHelper
    {
        public static string SerializandoXml<T>(T obj)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        StringWriter stringWriter = new StringWriter();
        serializer.Serialize(stringWriter, obj);
        return stringWriter.ToString();
    }
    public static T DeserializandoParaXml<T>(string xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StringReader stringReader = new StringReader(xml))
        {
            return (T)serializer.Deserialize(stringReader);
        }
    }
    }
}