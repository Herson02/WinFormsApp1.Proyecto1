using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class Vehiculos
    {
        public Vehiculos()
        { 
            _categoriaVehiculo = new CategoriasVehiculos();
        }

        public Vehiculos(int pIdVehiculos, string pMarca, string pModelo, int pAño, decimal pPrecio,
                         char pEstado, int pIdCategoria, string pNombreCategoria, string pDescripcion)
        {
            IdVehiculos = pIdVehiculos;
            Marca = pMarca;
            Modelo = pModelo;
            Año = pAño;
            Precio = pPrecio;
            Estado = pEstado;
            CategoriaVehiculo.IdCategoria = pIdCategoria;
            CategoriaVehiculo.NombreCategoria = pNombreCategoria;
            CategoriaVehiculo.Descripcion = pDescripcion;
        }



        private int _idVehiculos;
        public int IdVehiculos
        {
            get { return _idVehiculos; }
            set { _idVehiculos = value; }
        }

        private string _marca;
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private string _modelo;
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        private int _año;
        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }

        private decimal _precio;
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private char _estado;
        public char Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private CategoriasVehiculos _categoriaVehiculo;
        public CategoriasVehiculos CategoriaVehiculo
        {
            get { return _categoriaVehiculo; }
            set { _categoriaVehiculo= value; }
        }
    }
}
