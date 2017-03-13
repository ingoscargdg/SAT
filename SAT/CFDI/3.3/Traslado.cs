using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Traslado
    {
        //[XmlAttribute("Base", DataType = "decimal")]
        [XmlAttribute("Base")]
        public string Base { get; set; }

        [XmlAttribute("Impuesto", DataType = "string")]
        public string Impuesto { get; set; }

        [XmlAttribute("TipoFactor")]
        public string TipoFactor { get; set; }

        [XmlAttribute("TasaOCuota")]
        public string TasaOCuota { get; set; }

        [XmlAttribute("Importe", DataType = "decimal")]
        public decimal Importe { get; set; }
    }
}
