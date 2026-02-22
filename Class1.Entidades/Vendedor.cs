using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class Vendedor : Persona
    {
         public string Telefono { get; set; }
  

         public Vendedor()
         {

         }

         public Vendedor(int pIdVendedor, string pIdentificacion, string pNombreCompletoVendedor, DateTime pFechaNacimiento,
                       DateTime pFechaIngreso, string pTelefono)
         {
                Id = pIdVendedor; //Creo deberia de ser Identificacion ya que el atributo _id es privado
                      //y solo se puede acceder a el dentro de la misma clase
                Identificacion = pIdentificacion;
                NombreCompleto = pNombreCompletoVendedor;
                FechaNacimiento = pFechaNacimiento;
                FechaInclusionSistema = pFechaIngreso;
                Telefono = pTelefono;
         }
    }
}