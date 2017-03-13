using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class InformacionAduanera
    {
        [XmlAttribute("NumeroPedimento")]
        public string NumeroPedimento { get; set; }

    }
}
