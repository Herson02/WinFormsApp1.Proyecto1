using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class1.Entidades
{
    public class Sucursal
    {
        public Sucursal()
        {
            _vendedor = new Vendedor();
        }

        public Sucursal(int pIdSucursal, string pNombreSucursal, string pDireccion, string pTelefonoSucursal, 
                        String pVendedorEncargado, bool pSucursalActiva)
        {
            IdSucursal = pIdSucursal;
            NombreSucursal = pNombreSucursal;
            Direccion = pDireccion;
            TelefonoSucursal = pTelefonoSucursal;
            VendedorEncargado.NombreCompleto = pVendedorEncargado;
            SucursalActiva = pSucursalActiva;
        }

        private int _idSucursal;
        public int IdSucursal
        {
            get { return _idSucursal; }
            set { _idSucursal = value; }
        }

        private string _nombre;
        public string NombreSucursal
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _telefono;
        public string TelefonoSucursal
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private bool _sucursalActiva;
        public bool SucursalActiva
        {
            get { return _sucursalActiva; }
            set { _sucursalActiva = value; }
        }

        private Vendedor _vendedor;
        public Vendedor VendedorEncargado
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }
    }
}
