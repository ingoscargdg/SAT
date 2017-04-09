using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{

    public class Percepcion
    {

        [XmlAttribute("TipoPercepcion")]
        public String TipoPercepcion { get; set; }

        [XmlAttribute("Clave")]
        public String Clave { get; set; }

        [XmlAttribute("Concepto")]
        public String Concepto { get; set; }

        [XmlAttribute("ImporteGravado")]
        public Decimal ImporteGravado { get; set; }

        [XmlAttribute("ImporteExento")]
        public Decimal ImporteExento { get; set; }

        [XmlElement("AccionesOTitulos")]
        public AccionesOTitulos AccionesOTitulos;

        [XmlElement("HorasExtra")]
        public HorasExtra HorasExtra;
    }
}