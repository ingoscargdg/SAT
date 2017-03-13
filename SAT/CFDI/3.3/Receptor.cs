using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Receptor
    {
        [XmlAttribute("Rfc")]
        public string Rfc { get; set; }

        [XmlAttribute("Nombre")]
        public string Nombre { get; set; }

        [XmlAttribute("ResidenciaFiscal")]
        public string ResidenciaFiscal { get; set; }

        [XmlAttribute("NumRegIdTrib")]
        public string NumRegIdTrib { get; set; }

        [XmlAttribute("UsoCFDI")]
        public string UsoCFDI { get; set; }
    }
}
