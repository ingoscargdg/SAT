using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SAT.CFDI.Nomina._1._2
{ 

public class Incapacidades{

        [XmlElement("Incapacidad")]
        public List<Incapacidad> Incapacidad;

        public void AddIncapacidad(Incapacidad incapacidad)
        {
            if (this.Incapacidad == null)
            {
                this.Incapacidad = new List<Incapacidad>();
            }
            this.Incapacidad.Add(incapacidad);
        }
    }
}