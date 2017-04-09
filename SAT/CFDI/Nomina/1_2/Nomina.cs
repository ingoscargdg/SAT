using System;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

namespace SAT.CFDI.Nomina._1._2
{
    [XmlRootAttribute("Nomina", Namespace = "http://www.sat.gob.mx/nomina12")]
    public class Nomina
    {
        [XmlAttribute("Version")]
        public String Version { get; set; }

        [XmlAttribute("TipoNomina")]
        public String TipoNomina { get; set; }

        [XmlAttribute("FechaPago")]
        public string FechaPago { get; set; }

        [XmlAttribute("FechaInicialPago")]
        public string FechaInicialPago { get; set; }

        [XmlAttribute("FechaFinalPago")]
        public string FechaFinalPago { get; set; }

        [XmlAttribute("NumDiasPagados")]
        public Decimal NumDiasPagados { get; set; }

        [XmlAttribute("TotalPercepciones")]
        public Decimal TotalPercepciones { get { return (this.Percepciones.TotalSueldos + this.Percepciones.TotalSeparacionIndemnizacion + this.Percepciones.TotalJubilacionPensionRetiro); } set { } }

        [XmlAttribute("TotalDeducciones")]
        public Decimal TotalDeducciones { get { return (this.Deducciones.TotalOtrasDeducciones + Convert.ToDecimal(this.Deducciones._TotalImpuestosRetenidos)); } set { } }

        [XmlAttribute("TotalOtrosPagos")]
        public Decimal TotalOtrosPagos { get { return (this.OtrosPagos == null ? 0 : this.OtrosPagos.OtroPago.Sum(s => s.Importe)); } set { } }

        //public Decimal TotalOtrosPagos { get { return this.OtrosPagos.OtroPago.Importe;} set{} }
        [XmlElement("Emisor")]
        public Emisor Emisor;

        [XmlElement("Receptor")]
        public Receptor Receptor;

        [XmlElement("Percepciones")]
        public Percepciones Percepciones;

        [XmlElement("Deducciones")]
        public Deducciones Deducciones;

        [XmlElement("OtrosPagos")]
        public OtrosPagos OtrosPagos;

        [XmlElement("Incapacidades")]
        public Incapacidades Incapacidades;

        public Nomina()
        {
            this.Version = "1.2";
        }
    }
}