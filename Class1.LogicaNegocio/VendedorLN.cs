using Class1.AccesoDatos;
using Class1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.LogicaNegocio
{
    public class VendedorLN
    {
        public bool Agregar(Vendedor pVendedor)
        {
            if (pVendedor == null)
                throw new Exception("El vendedor es nulo.");

            if (pVendedor.Id <= 0)
                throw new Exception("El Id del vendedor debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(pVendedor.Identificacion))
                throw new Exception("La identificación del vendedor es obligatoria.");

            if (string.IsNullOrWhiteSpace(pVendedor.NombreCompleto))
                throw new Exception("El nombre del vendedor es obligatorio.");

            // ejemplo: validar que fecha de nacimiento < fecha de ingreso
            if (pVendedor.FechaNacimiento >= pVendedor.FechaInclusionSistema)
                throw new Exception("La fecha de nacimiento debe ser menor que la fecha de ingreso.");

            // identificación única
            foreach (var v in DataAccessVendedor.ArregloVendedores)
            {
                if (v != null && v.Identificacion == pVendedor.Identificacion)
                    throw new Exception("Ya existe un vendedor con esa identificación.");
            }

            return DataAccessVendedor.AgregarEmpleado(pVendedor);
        }

        public Vendedor[] Listar()
        {
            return DataAccessVendedor.ListarVendedor();
        }
    }
}
