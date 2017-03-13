using System.IO;
using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Digital
    {
        public static string serializarXml(object c)
        {
            XmlSerializer xs = new XmlSerializer(c.GetType());
            StringWriter sw = new StringWriter();
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            xs.Serialize(sw, c, ns);
            string serializado = sw.ToString();
            sw.Close();
            return serializado;
        } 
    }
}
