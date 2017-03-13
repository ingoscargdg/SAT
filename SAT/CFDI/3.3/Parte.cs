using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI._3._3
{
    public class Parte
    {
        [XmlAttribute("ClaveProdServ")]
        public string ClaveProdServ { get; set; }

        [XmlAttribute("NoIdentificacion")]
        public string NoIdentificacion { get; set; }

        [XmlAttribute("Cantidad", DataType = "decimal")]
        public decimal Cantidad { get; set; }

        [XmlAttribute("Unidad")]
        public string Unidad { get; set; }

        [XmlAttribute("Descripcion")]
        public string Descripcion { get; set; }

        [XmlAttribute("ValorUnitario", DataType = "decimal")]
        public decimal ValorUnitario { get; set; }

        [XmlAttribute("Importe", DataType = "decimal")]
        private decimal Importe;

        public void OnDeserialization(object sender)
        {
            this.Importe = this.ValorUnitario * this.Cantidad;
        }

        //[XmlAttribute("InformacionAduanera")]
        public InformacionAduanera InformacionAduanera;

    }
}
