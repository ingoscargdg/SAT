using System;
using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class ExpedidoEn : IDireccion
    {
        [XmlAttribute]
        public string calle { get; set; }

        [XmlAttribute]
        public string noExterior { get; set; }

        [XmlAttribute]
        public string noInterior { get; set; }

        [XmlAttribute]
        public string colonia { get; set; }

        [XmlAttribute]
        public string localidad { get; set; }

        [XmlAttribute]
        public string referencia { get; set; }

        [XmlAttribute]
        public string municipio { get; set; }

        [XmlAttribute]
        public string estado { get; set; }

        [XmlAttribute]
        public string pais { get; set; }

        [XmlAttribute]
        public string codigoPostal { get; set; }

    }
}
