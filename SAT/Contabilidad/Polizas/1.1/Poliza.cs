using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System;

namespace SAT.Contabilidad.Polizas._1._1
{
    public class Poliza
    {
        [XmlAttribute("NumUnIdenPol")]
        public string NumUnIdenPol
        { get; set; }

        [XmlAttribute("Fecha", DataType = "date")]
        public DateTime Fecha
        { get; set; }

        [XmlAttribute("Concepto")]
        public string Concepto
        { get; set; }

        [XmlElement("Transaccion")]
        public Transaccion Transaccion;

        //public void AddComprNal(ComprNal Nal)
        //{
        //    if (ComprNal == null)
        //    {
        //        ComprNal = new List<ComprNal>();
        //    }
        //    ComprNal.Add(Nal);
        //}
    }
}
