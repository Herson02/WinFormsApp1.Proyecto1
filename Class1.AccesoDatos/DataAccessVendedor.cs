using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Class1.Entidades;

namespace Class1.AccesoDatos
{
    public class DataAccessVendedor
    {
        private static int contadorVendedor = 0;

        public static Vendedor[] ArregloVendedores = new Vendedor[20];

        public static bool AgregarEmpleado(Vendedor pVendedor)
        {
            if (contadorVendedor >= ArregloVendedores.Length)
                throw new Exception("No se pueden registrar más vendedores. Arreglo lleno.");
            ArregloVendedores[contadorVendedor] = pVendedor;
            contadorVendedor++;
            return true;

        }

        public static Vendedor[] ListarVendedor()
        {
            return ArregloVendedores;
        }
    }
}
