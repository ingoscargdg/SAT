using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.ComercioExterior._1._1
{

    public class Destinatario
    {

        [XmlAttribute("NumRegIdTrib")]
        public String NumRegIdTrib { get; set; }

        [XmlAttribute("Nombre")]
        public String Nombre { get; set; }

        Domicilio Domicilio;

    }
}