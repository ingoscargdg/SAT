using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class CompensacionSaldosAFavor{

        [XmlAttribute("SaldoAFavor")]
        public Decimal SaldoAFavor { get; set; }

        [XmlAttribute("Año")]
        public Int16 Año { get; set; }

        [XmlAttribute("RemanenteSalFav")]
        public Decimal RemanenteSalFav { get; set; }
    }
}