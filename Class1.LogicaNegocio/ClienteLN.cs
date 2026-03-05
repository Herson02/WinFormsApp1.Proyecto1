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
            /*if (pCliente == null) return false;

            if (string.IsNullOrEmpty(pCliente.NombreCompleto))
            {
                throw new Exception("El nombre del cliente est'a vac'io. ");
            }
            return DataAccessCliente.AgregarCliente(pCliente);*/

            // 1. Validar nulo
            if (pCliente == null)
                throw new Exception("El cliente es nulo.");

            // 2. Id > 0
            if (pCliente.Id <= 0)
                throw new Exception("El Id del cliente debe ser mayor que 0.");

            // 3. Identificación obligatoria
            if (string.IsNullOrWhiteSpace(pCliente.Identificacion))
                throw new Exception("La identificación del cliente es obligatoria.");

            // 4. Nombre obligatorio
            if (string.IsNullOrWhiteSpace(pCliente.NombreCompleto))
                throw new Exception("El nombre del cliente es obligatorio.");

            // 5. Fecha de nacimiento razonable (ejemplo: no futura)
            if (pCliente.FechaNacimiento > DateTime.Today)
                throw new Exception("La fecha de nacimiento no puede ser futura.");

            // 6. NO permitir identificación duplicada
            foreach (var c in DataAccessCliente.ArregloClientes)
            {
                if (c != null && c.Identificacion == pCliente.Identificacion)
                    throw new Exception("Ya existe un cliente con esa identificación.");
            }

            // 7. Llamar a la capa de datos
            return DataAccessCliente.AgregarCliente(pCliente);
        }

        public Cliente[] Listar()
        { 
           return DataAccessCliente.ListarCliente();
        }
            
    }
}

//Video en el minuto 1:26:36