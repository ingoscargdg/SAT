using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml.Schema;

namespace SAT.CFDI.ComercioExterior._1._1
{
    [XmlRootAttribute("ComercioExterior11", Namespace = "http://www.sat.gob.mx/ComercioExterior11")]
    public class ComercioExterior
    {
        //[XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        //public string xsiSchemaLocation = "http://www.sat.gob.mx/ComercioExterior11 http://www.sat.gob.mx/sitio_internet/cfd/ComercioExterior11/ComercioExterior11.xsd";

        [XmlAttribute("Version")]
        public String Version { get; set; }

        [XmlAttribute("MotivoTraslado")]
        public String MotivoTraslado { get; set; }

        [XmlAttribute("TipoOperacion")]
        public String TipoOperacion { get; set; }

        [XmlAttribute("ClaveDePedimento")]
        public String ClaveDePedimento { get; set; }

        [XmlAttribute("CertificadoOrigen")]
        public Int32 CertificadoOrigen { get; set; }

        [XmlAttribute("NumCertificadoOrigen")]
        public String NumCertificadoOrigen { get; set; }

        [XmlAttribute("NumeroExportadorConfiable")]
        public String NumeroExportadorConfiable { get; set; }

        [XmlAttribute("Incoterm")]
        public String Incoterm { get; set; }

        [XmlAttribute("Subdivision")]
        public Int32 Subdivision { get; set; }

        [XmlAttribute("Observaciones")]
        public String Observaciones { get; set; }

        [XmlAttribute("TipoCambioUSD")]
        public Decimal TipoCambioUSD { get; set; }

        [XmlAttribute("TotalUSD")]
        public Decimal TotalUSD { get; set; }

        public Emisor Emisor;

        public Propietario Propietario;

        public Receptor Receptor;

        public Destinatario Destinatario;

        public List<Mercancia> Mercancias;

        public ComercioExterior()
        {
            this.Version = "1.1";
        }

    }
}