using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.ComercioExterior._1._1
{

    public class Mercancia
    {

        [XmlAttribute("NoIdentificacion")]
        public String NoIdentificacion { get; set; }

        [XmlAttribute("FraccionArancelaria")]
        public String FraccionArancelaria { get; set; }

        [XmlAttribute("CantidadAduana")]
        public Decimal CantidadAduana { get; set; }

        [XmlAttribute("UnidadAduana")]
        public String UnidadAduana { get; set; }

        [XmlAttribute("ValorUnitarioAduana")]
        public Decimal ValorUnitarioAduana { get; set; }

        [XmlAttribute("ValorDolares")]
        public Decimal ValorDolares { get; set; }

        DescripcionesEspecificas DescripcionesEspecificas;

    }
}