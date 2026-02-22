using Class1.LogicaNegocio;
using Class1.Entidades;

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
            var datos = nClientes.ListarClientes();
            FormMostrarData formMostrarData = new FormMostrarData(datos);
            formMostrarData.Show();
        }
    }
}
// Quede en el minuto 1:52:20

//2:07:50