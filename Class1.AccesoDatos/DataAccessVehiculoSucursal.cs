using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Class1.Entidades;

namespace Class1.AccesoDatos
{
    public class DataAccessVehiculoSucursal
    {
        private static int contadorVehiculoxSucursal = 0;

        public static VehiculoxSucursal[] ArregloVehiculosxSucursal = new VehiculoxSucursal[100];

        public static bool AgregarVehiculosxSucursal(VehiculoxSucursal pVehiculoxSucursal)
        {
            ArregloVehiculosxSucursal[contadorVehiculoxSucursal] = pVehiculoxSucursal;
            contadorVehiculoxSucursal++;
            return true;

        }

        public static VehiculoxSucursal[] ListarVehiculoxSucursal()
        {
            return ArregloVehiculosxSucursal;
        }
    }
}

