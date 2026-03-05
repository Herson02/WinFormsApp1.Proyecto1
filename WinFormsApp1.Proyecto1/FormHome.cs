using Class1.Entidades;
using Class1.LogicaNegocio;

namespace WinFormsApp1.Proyecto1
{
    public partial class FormHome : Form
    {
        public ClienteLN nClientes = new ClienteLN();
        public FormHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                Cliente cliente = new Cliente();
                //Si se tuviera un solo constructor vacio y
                //se crea una clase ya por defecto se sabe que hay un constructor vacio
                //***cliente.Identificacion = rand.Next(0,100);
                //cliente.Nombre = "Juan";
                cliente.NombreCompleto = textNombre.Text;
                //***cliente.Edad = int.Parse(textEdad.Text);
                //int.TryParse(textEdad.Text, out int edad); 
                //Cliente.Edad = edad;


                nClientes.Agregar(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el registro de datos. Verifique e intente de neuvo");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var datos = nClientes.Listar();
            FormMostrarData formMostrarData = new FormMostrarData(datos);
            formMostrarData.Show();
        }

        private void textIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResidencia_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Crear el objeto cliente
                Cliente cliente = new Cliente();

                // 2. Cargar datos desde los controles de la pestaña Clientes
                if (!int.TryParse(txtIdCliente.Text, out int id))
                {
                    throw new FormatException("El Id del cliente debe ser un número entero.");
                }

                cliente.Id = id;
                cliente.Identificacion = txtIdentificacionCliente.Text;
                cliente.NombreCompleto = txtNombreCliente.Text;
                cliente.FechaNacimiento = dtpFechaNacCliente.Value;
                cliente.ClienteActivo = chkClienteActivo.Checked;

                // 3. Llamar a la lógica de negocio (aquí se hacen las validaciones fuertes)
                nClientes.Agregar(cliente);

                // 4. Si todo salió bien, mostrar mensaje
                MessageBox.Show("Cliente agregado correctamente.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // 5. Limpiar controles
                textIdCliente.Clear();
                textIdentificacionCliente.Clear();
                textNombreCliente.Clear();
                chkClienteActivo.Checked = false;
                // opcional: dtpFechaNacCliente.Value = DateTime.Today;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message,
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Aquí llegan las excepciones que lanzas en ClienteLN (reglas de negocio)
                MessageBox.Show(ex.Message,
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
// Quede en el minuto 1:52:20

//2:07:50