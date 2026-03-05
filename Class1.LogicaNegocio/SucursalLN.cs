using Class1.AccesoDatos;
using Class1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.LogicaNegocio
{
    public class SucursalLN 
    {
        public bool Agregar(Sucursal pSucursal)
        {
            if (pSucursal == null)
                throw new Exception("La sucursal es nula.");

            if (pSucursal.IdSucursal <= 0)
                throw new Exception("El Id de la sucursal debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(pSucursal.NombreSucursal))
                throw new Exception("El nombre de la sucursal es obligatorio.");

            if (string.IsNullOrWhiteSpace(pSucursal.Direccion))
                throw new Exception("La dirección de la sucursal es obligatoria.");

            if (string.IsNullOrWhiteSpace(pSucursal.TelefonoSucursal))
                throw new Exception("El teléfono de la sucursal es obligatorio.");

            // vendedor encargado obligatorio
            if (pSucursal.VendedorEncargado == null)
                throw new Exception("Debe asignar un vendedor encargado a la sucursal.");

            // Id de sucursal único
            foreach (var s in DataAccessSucursal.ArregloSucursales)
            {
                if (s != null && s.IdSucursal == pSucursal.IdSucursal)
                    throw new Exception("Ya existe una sucursal con ese Id.");
            }

            return DataAccessSucursal.AgregarSucursal(pSucursal);
        }

        public Sucursal[] Listar()
        {
            return DataAccessSucursal.ListarSucursal();
        }
    }
}
