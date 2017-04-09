using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class SubsidioAlEmpleo{

        [XmlAttribute("SubsidioCausado")]
        public Decimal SubsidioCausado { get; set; }

    }
}