using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Schema;

namespace SAT.Contabilidad.Polizas._1._1
{
    [XmlRootAttribute("PLZ", Namespace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1//PolizasPeriodo")]
    public class Polizas
    {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo/PolizasPeriodo_1_1.xsd";

        [XmlAttribute("Version")]
        public string Version { get; set; }

        [XmlAttribute("RFC")]
        public string RFC { get; set; }

        [XmlAttribute("Mes")]
        public string Mes { get; set; }

        [XmlAttribute("Anio")]
        public string Anio { get; set; }

        [XmlAttribute("TipoSolicitud")]
        public string TipoSolicitud { get; set; }

        [XmlAttribute("NumOrden")]
        public string NumOrden { get; set; }

        [XmlAttribute("NumTramite")]
        public string NumTramite { get; set; }

        [XmlAttribute]
        public string Sello { get; set; }

        [XmlAttribute]
        public string noCertificado { get; set; }

        [XmlAttribute]
        public string Certificado { get; set; }

        [XmlElement("Transaccion")]
        public List<Transaccion> Transaccion;

        public Polizas()
        {
            this.Version = "1.1";
        }

        public void addTransacciones(List<Transaccion> transacciones)
        {
            if (this.Transaccion == null)
            {
                this.Transaccion = transacciones;
            }
            else
            {
                this.Transaccion.AddRange(transacciones);
            }
        }

        public void addTransaccion(Transaccion transaccion)
        {
            if (this.Transaccion == null)
            {
                this.Transaccion = new List<Transaccion>();
            }

            this.Transaccion.Add(transaccion);
        }
    }
}
