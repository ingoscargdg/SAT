using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class SeparacionIndemnizacion{

        [XmlAttribute("TotalPagado")]
        public Decimal TotalPagado { get; set; }

        [XmlAttribute("NumAñosServicio")]
        public Int32 NumAñosServicio { get; set; }

        [XmlAttribute("UltimoSueldoMensOrd")]
        public Decimal UltimoSueldoMensOrd { get; set; }

        [XmlAttribute("IngresoAcumulable")]
        public Decimal IngresoAcumulable { get; set; }

        [XmlAttribute("IngresoNoAcumulable")]
        public Decimal IngresoNoAcumulable { get; set; }

    }
}