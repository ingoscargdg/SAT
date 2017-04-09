using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class Deducciones{

        [XmlAttribute("TotalOtrasDeducciones")]
        public Decimal TotalOtrasDeducciones { get; set; }

        [XmlIgnore]
        public Decimal? _TotalImpuestosRetenidos { get; set; }

        [XmlAttribute("TotalImpuestosRetenidos")]
        public string _TotalImpuestosRetenidosTotalImpuestosRetenidos {
            get { return _TotalImpuestosRetenidos.HasValue ? XmlConvert.ToString(_TotalImpuestosRetenidos.HasValue) : null; }
            set { _TotalImpuestosRetenidos = !string.IsNullOrWhiteSpace(value) ? XmlConvert.ToDecimal(value) : (Decimal?)null; }
        }

        //[XmlAttribute("TotalImpuestosRetenidos")]
        //public Decimal TotalImpuestosRetenidos { get; set; }

        [XmlElement("Deduccion")]
        public List<Deduccion> Deduccion;

        public void AddDeduccion(Deduccion deduccion)
        {
            if (this.Deduccion == null)
            {
                this.Deduccion = new List<Deduccion>();
            }
            this.Deduccion.Add(deduccion);
        }
    }
}