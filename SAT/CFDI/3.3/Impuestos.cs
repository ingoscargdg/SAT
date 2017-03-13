
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Impuestos
    {

        //[XmlAttribute("Traslados")]
        public List<Traslado> Traslados;

        //[XmlAttribute("Retenciones")]
        public List<Retencion> Retenciones;

        public void AddTrasladados(Traslado traslado)
        {
            if (this.Traslados == null)
            {
                this.Traslados = new List<Traslado>();
            }
            this.Traslados.Add( traslado);
        }

        public void AddRetenidos(Retencion retencion)
        {
            if(this.Retenciones == null)
            {
                this.Retenciones = new List<Retencion>();
            }
            this.Retenciones.Add(retencion);
        }


    }
}
