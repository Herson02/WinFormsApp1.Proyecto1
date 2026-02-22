using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class1.Entidades;

namespace WinFormsApp1.Proyecto1
{
    public partial class FormMostrarData : Form
    {
        private readonly Cliente[] clientes;
        public FormMostrarData(Cliente[] pDatos)
        {
            InitializeComponent();
            clientes = pDatos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Por ahora lo dejamos vacío
        }

        private void FormMostrarData_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            foreach (Cliente cliente in clientes)
            {
                if (cliente != null)
                {
                    dataGridView1.Rows.Add(cliente.Identificacion, cliente.NombreCompleto);
                    
                    //, cliente.Edad);
                }
            
            }
        }
    }
}
