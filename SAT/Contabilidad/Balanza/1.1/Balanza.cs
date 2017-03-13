using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Schema;

namespace SAT.Contabilidad.Balanza._1._1
{
    [XmlRootAttribute("BCE", Namespace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion")]
    public class Balanza
    {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarFolios/AuxiliarFolios_1_2.xsd";

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlAttribute("RFC")]
        public string RFC { get; set; }

        [XmlAttribute("Mes")]
        public string Mes { get; set; }

        [XmlAttribute("Anio")]
        public string Anio { get; set; }

        [XmlAttribute("TipoEnvio")]
        public string TipoEnvio { get; set; }

        [XmlAttribute("FechaModBal",DataType ="date")]
        public string FechaModBal { get; set; }

        [XmlAttribute]
        public string Sello { get; set; }

        [XmlAttribute]
        public string noCertificado { get; set; }

        [XmlAttribute]
        public string Certificado { get; set; }

        [XmlElement("Ctas")]
        public List<Cta> Ctas;

        public Balanza()
        {
            this.Version = "1.1";
        }

        public void addCtas(List<Cta> ctas)
        {
            if (this.Ctas == null)
            {
                this.Ctas = ctas;
            }
            else
            {
                this.Ctas.AddRange(ctas);
            }
        }

        public void addCta(Cta cta)
        {
            if (this.Ctas == null)
            {
                this.Ctas = new List<Cta>();
            }

            this.Ctas.Add(cta);
        }
    }
}
