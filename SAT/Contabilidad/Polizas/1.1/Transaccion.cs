using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System;

namespace SAT.Contabilidad.Polizas._1._1
{
    public class Transaccion
    {
        [XmlAttribute("NumCta")]
        public string NumCta { get; set; }

        [XmlAttribute("DesCta")]
        public string DesCta { get; set; }

        [XmlAttribute("Concepto")]
        public string Concepto { get; set; }

        [XmlAttribute("Debe", DataType = "decimal")]
        public string Desc { get; set; }

        [XmlAttribute("Haber", DataType = "decimal")]
        public string Natur { get; set; }

        [XmlElement("CompNal")]
        public List<CompNal> CompNal;

        [XmlElement("CompExt")]
        public List<CompExt> CompExt;

        [XmlElement("Cheque")]
        public List<Cheque> Cheque;

        [XmlElement("Transferencia")]
        public List<Transferencia> Transferencia;

        [XmlElement("OtrMetodoPago")]
        public List<OtrMetodoPago> OtrMetodoPago;

        public void AddCompNal(List<CompNal> compNals)
        {
            if (this.CompNal == null)
            {
                this.CompNal = compNals;
            }
            else
            {
                this.CompNal.AddRange(compNals);
            }
        }

        public void addCta(CompNal compNal)
        {
            if (this.CompNal == null)
            {
                this.CompNal = new List<CompNal>();
            }

            this.CompNal.Add(compNal);
        }

        public void AddCompNal(List<CompExt> CompExts)
        {
            if (this.CompExt == null)
            {
                this.CompExt = CompExts;
            }
            else
            {
                this.CompExt.AddRange(CompExts);
            }
        }

        public void addCta(CompExt compExt)
        {
            if (this.CompExt == null)
            {
                this.CompExt = new List<CompExt>();
            }

            this.CompExt.Add(compExt);
        }

        public void AddCheque(List<Cheque> cheques)
        {
            if (this.Cheque == null)
            {
                this.Cheque = cheques;
            }
            else
            {
                this.Cheque.AddRange(cheques);
            }
        }

        public void addCheque(Cheque cheque)
        {
            if (this.Cheque == null)
            {
                this.Cheque = new List<Cheque>();
            }

            this.Cheque.Add(cheque);
        }

        public void AddTransferencia(List<Transferencia> transferencias)
        {
            if (this.Transferencia == null)
            {
                this.Transferencia = transferencias;
            }
            else
            {
                this.Transferencia.AddRange(transferencias);
            }
        }

        public void addTransferencia(Transferencia transferencia)
        {
            if (this.Transferencia == null)
            {
                this.Transferencia = new List<Transferencia>();
            }

            this.Transferencia.Add(transferencia);
        }

        public void AddOtrMetodoPago(List<OtrMetodoPago> otrMetodoPagos)
        {
            if (this.OtrMetodoPago == null)
            {
                this.OtrMetodoPago = otrMetodoPagos;
            }
            else
            {
                this.OtrMetodoPago.AddRange(otrMetodoPagos);
            }
        }

        public void addOtrMetodoPago(OtrMetodoPago otrMetodoPago)
        {
            if (this.OtrMetodoPago == null)
            {
                this.OtrMetodoPago = new List<OtrMetodoPago>();
            }

            this.OtrMetodoPago.Add(otrMetodoPago);
        }

    }
}
