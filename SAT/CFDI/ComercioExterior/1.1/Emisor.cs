using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.ComercioExterior._1._1
{

    public class Emisor
    {

        [XmlAttribute("Curp")]
        public String Curp { get; set; }

        public Domicilio Domicilio;

    }
}