using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class AccionesOTitulos{

        [XmlAttribute("ValorMercado")]
        public Decimal ValorMercado { get; set; }

        [XmlAttribute("PrecioAlOtorgarse")]
        public Decimal PrecioAlOtorgarse { get; set; }
    }
}