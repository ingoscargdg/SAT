using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;

namespace SAT.Contabilidad.AuxiliarCuenta._1._1
{
    public class Cuenta
    {
        [XmlAttribute("NumCta")]
        public string NumCta { get; set; }

        [XmlAttribute("DesCta")]
        public string DesCta { get; set; }

        [XmlAttribute("SaldoIni", DataType = "decimal")]
        public string Desc { get; set; }

        [XmlAttribute("SaldoFin", DataType = "decimal")]
        public string Natur { get; set; }

        [XmlElement("DetalleAux")]
        public List<DetalleAux> DetalleAux;

        public void addCtas(List<DetalleAux> Detallecuentas)
        {
            if (this.DetalleAux == null)
            {
                this.DetalleAux = Detallecuentas;
            }
            else
            {
                this.DetalleAux.AddRange(Detallecuentas);
            }
        }

        public void addCta(DetalleAux Detallecuenta)
        {
            if (this.DetalleAux == null)
            {
                this.DetalleAux = new List<DetalleAux>();
            }

            this.DetalleAux.Add(Detallecuenta);
        }

    }
}
