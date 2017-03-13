using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System;


namespace SAT.Contabilidad.Polizas._1._1
{
    public class CompExt
    {
        [XmlAttribute("UUID_CFDI")]
        public string UUID_CFDI{ get; set; }

        [XmlAttribute("RFC")]
        public string RFC { get; set; }

        [XmlAttribute("MontoTotal")]
        public decimal MontoTotal{ get; set; }

        [XmlAttribute("Moneda")]
        public string Moneda { get; set; }

        [XmlAttribute("TipCamb")]
        public string TipCamb{ get; set; }

    }
}
