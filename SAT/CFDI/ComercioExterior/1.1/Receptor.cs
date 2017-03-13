using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.ComercioExterior._1._1
{

    public class Receptor
    {

        [XmlAttribute("NumRegIdTrib")]
        public String NumRegIdTrib { get; set; }

        Domicilio Domicilio;

    }
}