namespace GestionClientes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGestionCientes_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();
        }
    }
}