using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI._3._3
{
    public class Complemento
    {
        [XmlElement(ElementName = "ComercioExterior",Namespace ="http://www.sat.gob.mx/ComercioExterior11")]
        public ComercioExterior._1._1.ComercioExterior ComercioExterior;

    }
}
