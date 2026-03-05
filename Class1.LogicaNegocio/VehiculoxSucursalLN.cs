using Class1.AccesoDatos;
using Class1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.LogicaNegocio
{
    public class VehiculoXSucursalLN
    {
        public bool Agregar(VehiculoxSucursal pVxS)
        {
            if (pVxS == null)
                throw new Exception("El registro de vehículo por sucursal es nulo.");

            if (pVxS.Sucursal == null)
                throw new Exception("Debe seleccionar una sucursal.");

            if (pVxS.Vehiculo == null)
                throw new Exception("Debe seleccionar un vehículo.");

            if (pVxS.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor que 0.");

            // sucursal debe estar activa
            if (!pVxS.Sucursal.SucursalActiva)
                throw new Exception("No se pueden asignar vehículos a una sucursal inactiva.");

            // (Opcional) evitar duplicar la misma combinación Sucursal + Vehículo
            foreach (var item in DataAccessVehiculoSucursal.ArregloVehiculosxSucursal)
            {
                if (item != null &&
                    item.Sucursal.IdSucursal == pVxS.Sucursal.IdSucursal &&
                    item.Vehiculo.IdVehiculos == pVxS.Vehiculo.IdVehiculos)
                {
                    throw new Exception("Ya existe un registro para ese vehículo en esa sucursal.");
                }
            }

            return DataAccessVehiculoSucursal.AgregarVehiculosxSucursal(pVxS);
        }

        public VehiculoxSucursal[] Listar()
        {
            return DataAccessVehiculoSucursal.ListarVehiculoxSucursal();
        }
    }
}
