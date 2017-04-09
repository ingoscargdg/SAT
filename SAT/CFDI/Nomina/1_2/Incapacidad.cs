using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class Incapacidad{

        [XmlAttribute("DiasIncapacidad")]
        public Int32 DiasIncapacidad { get; set; }

        [XmlAttribute("TipoIncapacidad")]
        public String TipoIncapacidad { get; set; }

        [XmlAttribute("ImporteMonetario")]
        public Decimal ImporteMonetario { get; set; }
       
    }
}