using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace SAT.CFDI._3._3
{
    public class CfdiRelacionados
    {
        [XmlAttribute("TipoRelacion")]
        public string TipoRelacion { get; set; }

        List<CfdiRelacionado> CfdiRelacionado;

        public void addCtas(List<CfdiRelacionado> cfdiRelacionados)
        {
            if (this.CfdiRelacionado == null)
            {
                this.CfdiRelacionado = cfdiRelacionados;
            }
            else
            {
                this.CfdiRelacionado.AddRange(cfdiRelacionados);
            }
        }

        public void addCta(CfdiRelacionado cfdiRelacionado)
        {
            if (this.CfdiRelacionado == null)
            {
                this.CfdiRelacionado = new List<CfdiRelacionado>();
            }

            this.CfdiRelacionado.Add(cfdiRelacionado);
        }
    }
}
