using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Class1.Entidades;

namespace Class1.AccesoDatos
{
    public class DataAccessCliente
    {
        private static int contadorCliente = 0;

        public static Cliente[] ArregloClientes = new Cliente[5];

        public static bool AgregarCliente(Cliente pCliente)
        {
            ArregloClientes[contadorCliente] = pCliente;
            contadorCliente++;
            return true;

        }

        public static Cliente[] ListarCliente()
        {
            return ArregloClientes;
        }
    }
}
