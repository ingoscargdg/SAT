using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.ComercioExterior._1._1
{

    public class Domicilio
    {

        [XmlAttribute("Calle")]
        public String Calle { get; set; }

        [XmlAttribute("NumeroExterior")]
        public String NumeroExterior { get; set; }

        [XmlAttribute("NumeroInterior")]
        public String NumeroInterior { get; set; }

        [XmlAttribute("Colonia")]
        public String Colonia { get; set; }

        [XmlAttribute("Localidad")]
        public String Localidad { get; set; }

        [XmlAttribute("Referencia")]
        public String Referencia { get; set; }

        [XmlAttribute("Municipio")]
        public String Municipio { get; set; }

        [XmlAttribute("Estado")]
        public String Estado { get; set; }

        [XmlAttribute("Pais")]
        public String Pais { get; set; }

        [XmlAttribute("CodigoPostal")]
        public String CodigoPostal { get; set; }
    }
}