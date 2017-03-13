using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Runtime.Serialization;
using System;

namespace SAT.CFDI._3._3
{
    [XmlRootAttribute("Comprobante", Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Comprobante 
    {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        [DataMember(Order = 0)]
        public string xsiSchemaLocation
        { get
            {
                string _xsiSchemaLocation = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd";
                if (this.Complemento != null)
                    if (this.Complemento.ComercioExterior != null)
                        _xsiSchemaLocation = _xsiSchemaLocation + " http://www.sat.gob.mx/ComercioExterior11 http://www.sat.gob.mx/sitio_internet/cfd/ComercioExterior11/ComercioExterior11.xsd";
                return _xsiSchemaLocation;
            }
            set { }
        }
        //public string xsiSchemaLocation = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd";

        [XmlAttribute("Version")]
        [DataMember(Order = 1)]
        public string Version { get; set; }

        [XmlAttribute("Serie")]
        [DataMember(Order = 2)]
        public string Serie { get; set; }

        [XmlAttribute("Folio")]
        public int Folio { get; set; }

        [XmlAttribute("Fecha")]
        public string Fecha { get; set; }

        [XmlAttribute("Sello")]
        public string Sello { get; set; }

        [XmlAttribute("FormaPago")]
        public string FormaPago { get; set; }

        [XmlAttribute("NoCertificado")]
        public string NoCertificado { get; set; }

        [XmlAttribute("Certificado")]
        public string Certificado { get; set; }

        [XmlAttribute("CondicionesDePago")]
        public string CondicionesDePago { get; set; }

        [XmlAttribute("SubTotal")]
        public decimal Subtotal { get; set; }

        [XmlAttribute("Descuento")]
        public decimal Descuento { get; set; }

        [XmlAttribute("Moneda")]
        public string Moneda { get; set; }

        [XmlAttribute("TipoCambio")]
        public decimal TipoCambio { get; set; }

        [XmlAttribute("Total")]
        public decimal Total { get; set; }

        [XmlAttribute("TipoDeComprobante")]
        public string TipoDeComprobante { get; set; }

        [XmlAttribute("MetodoPago")]
        public string MetodoPago { get; set; }

        [XmlAttribute("LugarExpedicion")]
        public string LugarExpedicion { get; set; }

        [XmlAttribute("Confirmacion")]
        public string Confirmacion { get; set; }

        [XmlElement("CfdiRelacionados")]
        public CfdiRelacionado CfdiRelacionados;

        [XmlElement("Emisor")]
        public Emisor Emisor;

        [XmlElement("Receptor")]
        public Receptor Receptor;

        //[XmlElement("Conceptos")]
        public List<Concepto> Conceptos;

        //[XmlElement("Impuestos")]
        public ImpuestosComprobante Impuestos;

        //[XmlElement("Complemento")]
        public Complemento Complemento;

        //[XmlElement("Addenda")]
        public string Addenda;

        public Comprobante()
        {
            this.Version = "3.3";
        }

       
        //private string ArchivoCer;

        //private string ArchivoKey;

        //private string PassKey;

        //      public Comprobante(string ArchivoCer, string ArchivoKey, string PassKey)
        //{
        //    this.version = "3.2";
        //    this.ArchivoCer = ArchivoCer;
        //    this.ArchivoKey = ArchivoKey;
        //    this.PassKey = PassKey;

        //    string certificado;
        //    certificado = Alis.Utils.Common.getCadenaCertificado(ArchivoCer);
        //    this.certificado= certificado;
        //}

        public void AddEmisor(Emisor emisor)
        {
            this.Emisor = emisor;
        }

        public void AddReceptor(Receptor receptor)
        {
            this.Receptor = receptor;
        }

        public void AddConceptos(List<Concepto> conceptos)
        {
            this.Conceptos = conceptos;
        }

        public void AddConcepto(Concepto concepto)
        {
            if(this.Conceptos == null)
            {
                this.Conceptos = new List<Concepto>();
            }

            this.Conceptos.Add(concepto);
        }
    }
}
