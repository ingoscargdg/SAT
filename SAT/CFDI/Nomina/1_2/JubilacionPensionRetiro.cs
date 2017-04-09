using System;
using System.Xml;
using System.Xml.Serialization;
namespace SAT.CFDI.Nomina._1._2
{ 

public class JubilacionPensionRetiro{

        [XmlAttribute("TotalUnaExhibicion")]
        public Decimal TotalUnaExhibicion { get; set; }

        [XmlAttribute("TotalParcialidad")]
        public Decimal TotalParcialidad { get; set; }

        [XmlAttribute("MontoDiario")]
        public Decimal MontoDiario { get; set; }

        [XmlAttribute("IngresoAcumulable")]
        public Decimal IngresoAcumulable { get; set; }

        [XmlAttribute("IngresoNoAcumulable")]
        public Decimal IngresoNoAcumulable { get; set; }

    }
}