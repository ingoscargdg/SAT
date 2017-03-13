using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Emisor
    {
        [XmlAttribute("Rfc")]
        public string Rfc { get; set; }

        [XmlAttribute("Nombre")]
        public string Nombre { get; set; }

        [XmlAttribute("RegimenFiscal")]
        public string RegimenFiscal { get; set; }
    }
}
