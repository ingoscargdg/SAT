using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System;

namespace SAT.Contabilidad.Polizas._1._1
{
    public class Cheque
    {
        [XmlAttribute("Num")]
        public string Num { get; set; }

        [XmlAttribute("BanEmisNal")]
        public string BanEmisNal { get; set; }

        [XmlAttribute("BanEmisExt")]
        public string BanEmisExt{ get; set; }

        [XmlAttribute("CtaOri")]
        public string CtaOri { get; set; }

        [XmlAttribute("Fecha", DataType = "date")]
        public string Fecha { get; set; }

        [XmlAttribute("Benef")]
        public string Benef { get; set; }

        [XmlAttribute("RFC")]
        public string RFC { get; set; }

        [XmlAttribute("Monto", DataType = "decimal")]
        public decimal Monto { get; set; }

        [XmlAttribute("Moneda")]
        public string Moneda { get; set; }

        [XmlAttribute("TipCamb", DataType = "decimal")]
        public decimal TipCamb { get; set; }
    }
}
