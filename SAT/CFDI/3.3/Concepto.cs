using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Concepto//: IDeserializationCallback
    {
        [XmlAttribute("ClaveProdServ")]
        public string ClaveProdServ { get; set; }

        [XmlAttribute("NoIdentificacion")]
        public string NoIdentificacion { get; set; }

        [XmlAttribute("Cantidad",DataType ="decimal")]
        public decimal Cantidad { get; set; }

        [XmlAttribute("ClaveUnidad")]
        public string ClaveUnidad { get; set; }

        [XmlAttribute("Unidad")]
        public string Unidad { get; set; }

        [XmlAttribute("Descripcion")]
        public string Descripcion { get; set; }

        [XmlAttribute("ValorUnitario", DataType = "decimal")]
        public decimal ValorUnitario { get; set; }

        [XmlAttribute("Importe", DataType = "decimal")]
        public decimal Importe { get { return this.ValorUnitario * this.Cantidad; }
                                 set { } }

        [XmlAttribute("Descuento", DataType = "decimal")]
        public decimal Descuento { get; set; }

        //[XmlAttribute("Impuestos")]
        public Impuestos Impuestos;

        //[XmlAttribute("InformacionAduanera")]
        public List<InformacionAduanera> InformacionAduanera;

        //[XmlAttribute("CuentaPredial")]
        public CuentaPredial CuentaPredial;

        //[XmlAttribute("ComplementoConcepto")]
        public string ComplementoConcepto;

        //[XmlAttribute("Parte")]
        public List<Parte> Parte;

        //public void OnDeserialization(object sender)
        //{
        //    this.Importe = this.ValorUnitario * this.Cantidad;
        //}
        //public void AddImpuestos(Impuestos impuestos)
        //{
        //    if (Impuestos == null)
        //    {
        //        Impuestos = new List<Impuestos>();
        //    }
        //    Impuestos.Add(impuestos);
        //}
    }
}
