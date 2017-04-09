using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class HorasExtra{

        [XmlAttribute("Dias")]
        public Int32 Dias { get; set; }

        [XmlAttribute("TipoHoras")]
        public String TipoHoras { get; set; }

        [XmlAttribute("HorasExtra")]
        public Int32 Horas { get; set; }

        [XmlAttribute("ImportePagado")]
        public Decimal ImportePagado { get; set; }

    }
}