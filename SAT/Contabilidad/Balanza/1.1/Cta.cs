using System.Xml.Serialization;
using System.Xml;


namespace SAT.Contabilidad.Balanza._1._1
{
    public class Cta
    {
        [XmlAttribute("NumCta")]
        public string NumCta { get; set; }

        [XmlAttribute("SaldoIni", DataType = "decimal")]
        public string Desc { get; set; }

        [XmlAttribute("Debe", DataType = "decimal")]
        public string SubCtaDe { get; set; }

        [XmlAttribute("Haber", DataType = "decimal")]
        public int Nivel { get; set; }

        [XmlAttribute("SaldoFin", DataType = "decimal")]
        public string Natur { get; set; }
    }
}
