using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class CuentaPredial
    {
        [XmlAttribute("Numero")]
        public string Numero { get; set; }
    }
}
