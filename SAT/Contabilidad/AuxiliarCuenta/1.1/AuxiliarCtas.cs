using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Schema;

namespace SAT.Contabilidad.AuxiliarCuenta._1._1
{
    [XmlRootAttribute("AuxiliarCtas", Namespace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarCtas")]
    public class AuxiliarCtas
    {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarCtas/AuxiliarCtas_1_1.xsd";

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

        [XmlElement("Cuenta")]
        public List<Cuenta> Cuenta;

        public AuxiliarCtas()
        {
            this.Version = "1.1";
        }

        public void addCtas(List<Cuenta> cuentas)
        {
            if (this.Cuenta == null)
            {
                this.Cuenta = cuentas;
            }
            else
            {
                this.Cuenta.AddRange(cuentas);
            }
        }

        public void addCta(Cuenta cuenta)
        {
            if (this.Cuenta == null)
            {
                this.Cuenta = new List<Cuenta>();
            }

            this.Cuenta.Add(cuenta);
        }

    }
}
