using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.ComercioExterior._1._1
{

    public class DescripcionesEspecificas
    {

        [XmlAttribute("Marca")]
        public String Marca { get; set; }

        [XmlAttribute("Modelo")]
        public String Modelo { get; set; }

        [XmlAttribute("SubModelo")]
        public String SubModelo { get; set; }

        [XmlAttribute("NumeroSerie")]
        public String NumeroSerie { get; set; }


    }
}