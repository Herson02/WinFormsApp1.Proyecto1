using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class CategoriasVehiculos
    {
        private int _idCategoria;
        public int IdCategoria
        {

            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        private string _nombreCategoria;
        public string NombreCategoria
        {

            get { return _nombreCategoria; }
            set { _nombreCategoria = value; }
        }

        private string _descripcion;
        public string Descripcion
        {

            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
