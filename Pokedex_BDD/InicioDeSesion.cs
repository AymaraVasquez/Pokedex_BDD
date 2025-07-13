using CargarBDDPokemon;
using MySql.Data.MySqlClient;

namespace Pokedex
{
    public partial class InicioDeSesion : Form
    {
        int verPass = 0;
        Conex Conexion = new Conex();
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistroDeUsuarios registroForm = new RegistroDeUsuarios();
            registroForm.ShowDialog();
            this.Show();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            // Chequear Parametros llenos
            if (String.IsNullOrEmpty(tbNombre.Text) || String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Rellene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Chequear si el Usuario existe en las Base de datos   
            Conexion.conectar();
            string consulta = "select * from usuarios WHERE usuario = '" + tbNombre.Text + "' AND contrasena = '" + tbPass.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando.ExecuteReader();
            while (Conex.Lector.Read())
            {
                SesionIniciada.Iniciada = true;
                SesionIniciada.NombreUsuario = Conex.Lector.GetString(2); // Nombre de usuario
                SesionIniciada.nombre = Conex.Lector.GetString(1); // Nombre completo
                SesionIniciada.IdUsuario = Conex.Lector.GetInt32(0); // ID de usuario
                SesionIniciada.FotoPerfil = Conex.Lector.GetInt32(4); // Foto de perfil
            }
            Conexion.desconectar();
            if (SesionIniciada.Iniciada == true)
            {
                this.Hide();
                Opciones opForm = new Opciones();
                opForm.ShowDialog();
                this.Show();
                SesionIniciada.Iniciada = false;
                tbNombre.Text = "";
                tbPass.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void checkContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContrasena.Checked == true)
            {
                tbPass.UseSystemPasswordChar = false;
                checkContrasena.Text = "Ocultar Contraseña";
                tbPass.PasswordChar = '\0';
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
                checkContrasena.Text = "Ver Contraseña";
                tbPass.PasswordChar = '*';
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (Char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void linkContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RecuperarContrasena recupContrasenaForm = new RecuperarContrasena();
            recupContrasenaForm.ShowDialog();
            this.Show();
        }
    }
}
