using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class Percepciones{

        [XmlAttribute("TotalSueldos")]
        public Decimal TotalSueldos { get; set; }

        [XmlAttribute("TotalSeparacionIndemnizacion")]
        public Decimal TotalSeparacionIndemnizacion { get; set; }

        [XmlAttribute("TotalJubilacionPensionRetiro")]
        public Decimal TotalJubilacionPensionRetiro { get; set; }

        [XmlAttribute("TotalGravado")]
        public Decimal TotalGravado { get; set; }

        [XmlAttribute("TotalExento")]
        public Decimal TotalExento { get; set; }

        [XmlElement("Percepcion")]
        public List<Percepcion> Percepcion;

        [XmlElement("JubilacionPensionRetiro")]
        public JubilacionPensionRetiro JubilacionPensionRetiro;

        [XmlElement("SeparacionIndemnizacion")]
        public SeparacionIndemnizacion SeparacionIndemnizacion;

        public void AddPercepcion(Percepcion percepcion)
        {
            if (this.Percepcion == null)
            {
                this.Percepcion =  new List<Percepcion>();
            }
            this.Percepcion.Add(percepcion);
        }
    }
}