 using System.Xml.Serialization;
using System.Xml;


namespace SAT.Contabilidad._1._1
{
    public class Cta
    {
        [XmlAttribute("CodAgrup")]
        public string CodAgrup { get; set; }

        [XmlAttribute("NumCta")]
        public string NumCta { get; set; }

        [XmlAttribute("Desc")]
        public string Desc { get; set; }

        [XmlAttribute("SubCtaDe")]
        public string SubCtaDe { get; set; }

        [XmlAttribute("Nivel")]
        public int Nivel { get; set; }

        [XmlAttribute("Natur")]
        public string Natur { get; set; }
    }
}
