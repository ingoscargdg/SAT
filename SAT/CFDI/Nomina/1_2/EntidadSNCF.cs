using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class EntidadSNCF
    {
        [XmlAttribute("OrigenRecurso")]
        public String OrigenRecurso { get; set; }

        [XmlAttribute("MontoRecursoPropio")]
        public Decimal MontoRecursoPropio { get; set; }
    }
}