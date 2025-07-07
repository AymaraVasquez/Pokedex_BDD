namespace Pokedex
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroDeUsuarios registroForm = new RegistroDeUsuarios();
            registroForm.ShowDialog();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            Opciones opForm = new Opciones();
            opForm.ShowDialog();
        }

        
    }
}
