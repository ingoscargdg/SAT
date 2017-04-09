using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class OtroPago{

        [XmlAttribute("TipoOtroPago")]
        public String TipoOtroPago { get; set; }

        [XmlAttribute("Clave")]
        public String Clave { get; set; }

        [XmlAttribute("Concepto")]
        public String Concepto { get; set; }

        [XmlAttribute("Importe")]
        public Decimal Importe { get; set; }

        [XmlElement("SubsidioAlEmpleo")]
        public SubsidioAlEmpleo SubsidioAlEmpleo;

        [XmlElement("CompensacionSaldosAFavor")]
        public CompensacionSaldosAFavor CompensacionSaldosAFavor;
    }
}