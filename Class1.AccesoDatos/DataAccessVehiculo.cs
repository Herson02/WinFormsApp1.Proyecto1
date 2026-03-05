using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Class1.Entidades;

namespace Class1.AccesoDatos
{
    public class DataAccessVehiculo
    {
        private static int contadorCategoriasVehiculos = 0;

        public static CategoriasVehiculos[] ArregloCategoriasVehiculos = new CategoriasVehiculos[20];

        public static bool AgregarCategoriaVehiculo(CategoriasVehiculos pCategoriaVehiculo)
        {
            if (contadorCategoriasVehiculos >= ArregloCategoriasVehiculos.Length)
                throw new Exception("No se pueden registrar más Categorias de Vehículos. Arreglo lleno.");

            ArregloCategoriasVehiculos[contadorCategoriasVehiculos] = pCategoriaVehiculo;
            contadorVehiculos++;
            return true;

        }

        public static CategoriasVehiculos[] ListarCategoriaVehiculo()
        {
            return ArregloCategoriasVehiculos;
        }

        private static int contadorVehiculos = 0;

        public static Vehiculos[] ArregloVehiculos = new Vehiculos[50];

        public static bool AgregarVehiculo(Vehiculos pVehiculo)
        {
            if (contadorVehiculos >= ArregloVehiculos.Length)
                throw new Exception("No se pueden registrar más vehículos. Arreglo lleno.");

            ArregloVehiculos[contadorVehiculos] = pVehiculo;
            contadorVehiculos++;
            return true;

        }

        public static Vehiculos[] ListarVehiculo()
        {
            return ArregloVehiculos;
        }
    }
}
