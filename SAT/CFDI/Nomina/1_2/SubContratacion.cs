using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class SubContratacion{

        [XmlAttribute("RfcLabora")]
        public String RfcLabora { get; set; }

        [XmlAttribute("PorcentajeTiempo")]
        public Decimal PorcentajeTiempo { get; set; }

    }
}