using Class1.AccesoDatos;
using Class1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.LogicaNegocio
{
    // private DataAccess AD = new DataAccess() Con esto tendr'ia que estar creando cada objeto como new
    //En lugar de esto mejor usar static es como utilizar una sola copia de arreglo en memoria
    public class ClienteLN
    { 
        public bool Agregar(Cliente pCliente)
        {
            if (pCliente == null) return false;

            if (string.IsNullOrEmpty(pCliente.NombreCompleto))
            {
                throw new Exception("El nombre del cliente est'a vac'io. ");
            }
            return DataAccessCliente.AgregarCliente(pCliente);
        }

        public Cliente[] ListarClientes()
        { 
           return DataAccessCliente.ListarCliente();
        }
            
    }
}

//Video en el minuto 1:26:36