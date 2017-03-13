
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace SAT.Contabilidad.AuxiliarFolios._1._1
{
    public class RepAuxFol
    {
        private string _NumUnIdenPol;

        private string _Fecha;
        [XmlAttribute("NumUnIdenPol")]
        public string NumUnIdenPol
        { get; set; }

        [XmlAttribute("Fecha", DataType = "date")]
        public DateTime Fecha
        { get; set; }

        [XmlElement("ComprNal")]

        public List<CompNal> ComprNal;
        public void AddComprNal(CompNal Nal)
        {
            if (ComprNal == null)
            {
                ComprNal = new List<CompNal>();
            }
            ComprNal.Add(Nal);
        }
    }
}

