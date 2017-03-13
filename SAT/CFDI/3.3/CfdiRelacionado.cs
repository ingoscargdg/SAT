using System.Xml.Serialization;
using System.Xml;

namespace SAT.CFDI._3._3
{
    public class CfdiRelacionado
    {

        [XmlAttribute("UUID")]
        public string UUID { get; set; }
    }
}
