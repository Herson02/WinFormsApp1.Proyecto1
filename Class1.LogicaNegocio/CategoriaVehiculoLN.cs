using Class1.Entidades;
using Class1.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.LogicaNegocio
{
    public class CategoriaVehiculoLN
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

        public CategoriasVehiculos[] Listar()
        {
            return DataAccessVehiculo.ListarCategoriaVehiculo();
        }
    }
}
