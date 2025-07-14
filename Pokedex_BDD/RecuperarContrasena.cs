using CargarBDDPokemon;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pokedex
{
    public partial class RecuperarContrasena : Form
    {
        Conex Conexion = new Conex();
        public RecuperarContrasena()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.btAtras, "Volver al Inicio");
        }

        private void tbFraseRecup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Form InicioForm = Application.OpenForms["InicioDeSesion"];
            if (InicioForm != null)
            {
                InicioForm.Show();
                this.Hide();
            }
        }

        private void btCambiarCont_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string consultaActContrasena = "update usuarios set contrasena = '" + tbPass.Text + "' WHERE usuario = '" + tbNombreUsuario.Text + "' AND recuperacion = '" + tbFraseRecup.Text + "'";
            MySqlCommand comando = new MySqlCommand(consultaActContrasena, Conex.Coneccion);
            int filasAfectadas = comando.ExecuteNonQuery();
            Conexion.desconectar();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Contraseña actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la contraseña. Verifique el nombre de usuario y la frase de recuperación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
