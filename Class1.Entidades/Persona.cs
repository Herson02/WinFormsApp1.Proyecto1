using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class Persona
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _identificacion;

        public string Identificacion
        {
            get { return _identificacion; }
            set { _identificacion = value; }
        }

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get { return _nombreCompleto;  }
            set { _nombreCompleto = value; }
        }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value;  }
        }

        private DateTime _fechaInclusionSistema;
        public DateTime FechaInclusionSistema
        {
            get { return _fechaInclusionSistema; }
            set { _fechaInclusionSistema = value; }
        }

        public Persona()
        {

        }

        public Persona(int pId, string pIdentificacion, string pNombreCompleto, DateTime pFechaNacimiento,
                       DateTime pFechaInclusionSistema)
        {
            Id = pId; //Creo deberia de ser Identificacion ya que el atributo _id es privado
                       //y solo se puede acceder a el dentro de la misma clase
            Identificacion= pIdentificacion;
            NombreCompleto= pNombreCompleto;
            FechaNacimiento= pFechaNacimiento;
            FechaInclusionSistema= pFechaInclusionSistema;
        }
    }
}
