using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 
public class Emisor
    {
        [XmlAttribute("Curp")]
        public string Curp { get; set; }

        [XmlAttribute("RegistroPatronal")]
        public String RegistroPatronal { get; set; }

        [XmlAttribute("RfcPatronOrigen")]
        public String RfcPatronOrigen { get; set; }

        [XmlElement("EntidadSNCF")]
        public EntidadSNCF EntidadSNCF;
    }
}