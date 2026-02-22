using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class Cliente:Persona
    {
        private bool _clienteActivo;
        public bool ClienteActivo
        {
            get { return _clienteActivo; }
            set { _clienteActivo = value; }
        }
        public Cliente()
        {

        }

        public Cliente(int pIdCliente, string pIdentificacion, string pNombreCompletoCliente, DateTime pFechaNacimiento,
                      DateTime pFechaRegistro, bool pClienteActivo)
        {
            Id = pIdCliente; //Creo deberia de ser Identificacion ya que el atributo _id es privado
                      //y solo se puede acceder a el dentro de la misma clase
            Identificacion = pIdentificacion;
            NombreCompleto = pNombreCompletoCliente;
            FechaNacimiento = pFechaNacimiento;
            FechaInclusionSistema = pFechaRegistro;
            ClienteActivo = pClienteActivo;
        }
    }
}
