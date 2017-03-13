using System.Xml.Serialization;
using System.Xml;

namespace SAT.Contabilidad.AuxiliarCuenta._1._1
{
    public class DetalleAux
    {
        [XmlAttribute("Fecha", DataType = "date")]
        public string Fecha { get; set; }

        [XmlAttribute("NumUnIdenPol")]
        public string Version { get; set; }

        [XmlAttribute("Concepto")]
        public string Concepto { get; set; }

        [XmlAttribute("Debe", DataType = "decimal")]
        public string Desc { get; set; }

        [XmlAttribute("Haber", DataType = "decimal")]
        public string Natur { get; set; }
    }
}
