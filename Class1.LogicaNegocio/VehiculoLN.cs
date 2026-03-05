using Class1.Entidades;
using Class1.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.LogicaNegocio
{
    /*internal class VehiculoLN
    {
       public bool Agregar(CategoriasVehiculos pCategoria)
        {
            if (pCategoria == null)
                throw new Exception("La categoría es nula.");

            if (pCategoria.IdCategoria <= 0)
                throw new Exception("El Id de la categoría debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(pCategoria.NombreCategoria))
                throw new Exception("El nombre de la categoría es obligatorio.");

            if (string.IsNullOrWhiteSpace(pCategoria.Descripcion))
                throw new Exception("La descripción de la categoría es obligatoria.");

            // Id de categoría único
            foreach (var cat in DataAccessVehiculo.ArregloCategoriasVehiculos)
            {
                if (cat != null && cat.IdCategoria == pCategoria.IdCategoria)
                    throw new Exception("Ya existe una categoría con ese Id.");
            }

            return DataAccessVehiculo.AgregarCategoriaVehiculo(pCategoria);
        }

        public Vehiculos[] Listar()
        {
            return DataAccessVehiculo.ListarVehiculo();
        }
    }*/
    public class VehiculoLN
    {
        public bool Agregar(Vehiculos pVehiculo)
        {
            if (pVehiculo == null)
                throw new Exception("El vehículo es nulo.");

            if (pVehiculo.IdVehiculos <= 0)
                throw new Exception("El Id del vehículo debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(pVehiculo.Marca))
                throw new Exception("La marca es obligatoria.");

            if (string.IsNullOrWhiteSpace(pVehiculo.Modelo))
                throw new Exception("El modelo es obligatorio.");

            // año razonable
            if (pVehiculo.Año < 1980 || pVehiculo.Año > DateTime.Today.Year + 1)
                throw new Exception("El año del vehículo no es válido.");

            if (pVehiculo.Precio <= 0)
                throw new Exception("El precio debe ser mayor que 0.");

            // estado solo 'N' o 'U'
            if (pVehiculo.Estado != 'N' && pVehiculo.Estado != 'U')
                throw new Exception("El estado del vehículo debe ser 'N' (nuevo) o 'U' (usado).");

            // placa única
            foreach (var v in DataAccessVehiculo.ArregloVehiculos)
            {
                if (v != null && v.IdVehiculos == pVehiculo.IdVehiculos)
                    throw new Exception("Ya existe un vehículo con esa placa.");
            }

            return DataAccessVehiculo.AgregarVehiculo(pVehiculo);
        }

        public Vehiculos[] Listar()
        {
            return DataAccessVehiculo.ListarVehiculo();
        }
    }
}
