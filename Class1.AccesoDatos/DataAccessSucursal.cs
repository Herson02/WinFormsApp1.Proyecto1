using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Class1.Entidades;

namespace Class1.AccesoDatos
{
    public class DataAccessSucursal
    {
        private static int contadorSucursal = 0;

        public static Sucursal[] ArregloSucursales = new Sucursal[5];

        public static bool AgregarSucursal(Sucursal pSucursal)
        {
            ArregloSucursales[contadorSucursal] = pSucursal;
            contadorSucursal++;
            return true;

        }

        public static Sucursal[] ListarSucursal()
        {
            return ArregloSucursales;
        }
    }
}
