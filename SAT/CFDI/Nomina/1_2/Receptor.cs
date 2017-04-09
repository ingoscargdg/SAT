using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAT.CFDI.Nomina._1._2
{ 

public class Receptor{

            [XmlAttribute("Curp")]
            public String Curp { get; set; }

            [XmlAttribute("NumSeguridadSocial")]
            public String NumSeguridadSocial { get; set; }

            [XmlAttribute("FechaInicioRelLaboral")]
            public string FechaInicioRelLaboral { get; set; }

            [XmlAttribute("Antigüedad")]
            public String Antigüedad { get; set; }

            [XmlAttribute("TipoContrato")]
            public String TipoContrato { get; set; }

            [XmlAttribute("Sindicalizado")]
            public String Sindicalizado { get; set; }

            [XmlAttribute("TipoJornada")]
            public String TipoJornada { get; set; }

            [XmlAttribute("TipoRegimen")]
            public String TipoRegimen { get; set; }

            [XmlAttribute("NumEmpleado")]
            public String NumEmpleado { get; set; }

            [XmlAttribute("Departamento")]
            public String Departamento { get; set; }

            [XmlAttribute("Puesto")]
            public String Puesto { get; set; }

            [XmlAttribute("RiesgoPuesto")]
            public String RiesgoPuesto { get; set; }

            [XmlAttribute("PeriodicidadPago")]
            public String PeriodicidadPago { get; set; }

            [XmlAttribute("Banco")]
            public String Banco { get; set; }

            [XmlAttribute("CuentaBancaria")]
            public string CuentaBancaria { get; set; }

            [XmlAttribute("SalarioBaseCotApor")]
            public Decimal SalarioBaseCotApor { get; set; }

            [XmlAttribute("SalarioDiarioIntegrado")]
            public Decimal SalarioDiarioIntegrado { get; set; }

            [XmlAttribute("ClaveEntFed")]
            public String ClaveEntFed { get; set; }

            [XmlElement("SubContratacion")]
            public SubContratacion SubContratacion;

    }
}