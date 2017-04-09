using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class OtrosPagos{

        [XmlElement("OtroPago")]
        public List<OtroPago> OtroPago;

        public void AddOtroPago(OtroPago otroPago)
        {
            if (this.OtroPago == null)
            {
                this.OtroPago = new List<OtroPago>();
            }
            this.OtroPago.Add(otroPago);
        }
    }
}