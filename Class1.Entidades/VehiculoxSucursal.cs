using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class VehiculoxSucursal
    {
        public Sucursal Sucursal { get; set; }
        public Vehiculos Vehiculo { get; set; }
        public int Cantidad { get; set; }

        public VehiculoxSucursal() { }

        public VehiculoxSucursal(Sucursal pSucursal, Vehiculos pVehiculo, int pCantidad)
        {
            Sucursal = pSucursal;
            Vehiculo = pVehiculo;
            Cantidad = pCantidad;
        }
    }
}
