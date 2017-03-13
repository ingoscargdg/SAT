
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class ImpuestosComprobante
    {
        [XmlAttribute("TotalImpuestosRetenidos", DataType = "decimal")]
        public decimal TotalImpuestosRetenidos;

        [XmlAttribute("TotalImpuestosTrasladados", DataType = "decimal")]
        public decimal TotalImpuestosTrasladados;

        //[XmlAttribute("Retenciones")]
        public List<Retencion> Retenciones;

        //[XmlAttribute("Traslados")]
        public List<Traslado> Traslados;

        

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
