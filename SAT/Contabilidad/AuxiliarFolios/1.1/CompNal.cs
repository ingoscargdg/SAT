
using System.Xml.Serialization;
using System.Xml;

namespace SAT.Contabilidad.AuxiliarFolios._1._1
{
    public class CompNal
    {
        private string _TipCamb;
        [XmlAttribute("UUID_CFDI")]
        public string UUID_CFDI
        { get; set; }

        [XmlAttribute("MontoTotal")]
        public decimal MontoTotal
        { get; set; }

        [XmlAttribute("RFC")]
        public string RFC
        { get; set; }

        [XmlAttribute("MetPagoAux")]
        public string MetPagoAux
        { get; set; }

        [XmlAttribute("Moneda")]
        public string Moneda
        { get; set; }

        [XmlAttribute("TipCamb")]
        public string TipCamb
        { get; set; }
    }
}

