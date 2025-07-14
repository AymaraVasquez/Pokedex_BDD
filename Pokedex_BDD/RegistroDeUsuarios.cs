using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargarBDDPokemon;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pokedex
{
    public partial class RegistroDeUsuarios : Form
    {
        int verPass = 0;
        int fotoUsuario = 0;
        Conex Conexion = new Conex();
        public RegistroDeUsuarios()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.btAtras, "Volver al Inicio");
        }

        private void btCrearUsu_Click(object sender, EventArgs e)
        {
            // Validar que el nombre no tenga numeros 
            if (tbNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbPass.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbUsu.Text != "" && tbPass.Text != "" && tbNombre.Text != "" && tbRecuperacion.Text != "")
            {
                fotoUsuario = (int)numericUpDown1.Value;
                Conexion.conectar();
                // Chequear si el usuario ya existe
                string queryCheck = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                MySqlCommand comandoCheck = new MySqlCommand(queryCheck, Conex.Coneccion);
                comandoCheck.Parameters.AddWithValue("@usuario", tbUsu.Text);
                int count = Convert.ToInt32(comandoCheck.ExecuteScalar());
                Conexion.desconectar();
                if (count > 0)
                {
                    MessageBox.Show("El usuario ya existe. Por favor, elija otro nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Conexion.conectar();
                string query = "INSERT INTO usuarios (id_usuario, nombre, usuario, contrasena, foto_perfil, recuperacion) VALUES (null, @nombre,@usuario, @contrasena, @foto_perfil, @recuperacion)";
                MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
                comando.Parameters.AddWithValue("@nombre", tbNombre.Text);
                comando.Parameters.AddWithValue("@usuario", tbUsu.Text);
                comando.Parameters.AddWithValue("@contrasena", tbPass.Text);
                comando.Parameters.AddWithValue("@foto_perfil", fotoUsuario);
                comando.Parameters.AddWithValue("@recuperacion", tbRecuperacion.Text);
                try
                {
                    comando.ExecuteNonQuery();
                    RegistroExitoso registrExiForm = new RegistroExitoso();
                    registrExiForm.ShowDialog();
                    this.Close();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conexion.desconectar();

                Conexion.conectar();
                string query2 = "SELECT id_usuario from usuarios where usuario = '" + tbUsu.Text + "'"; // Obtener el último ID insertado
                MySqlCommand comando3 = new MySqlCommand(query2, Conex.Coneccion);
                Conex.Lector = comando3.ExecuteReader();
                int contador = 0;
                while (Conex.Lector.Read())
                {
                    contador = Convert.ToInt32(Conex.Lector[0]);
                }
                Conexion.desconectar();

                Conexion.conectar();
                MySqlCommand comando2 = new MySqlCommand(query2, Conex.Coneccion);
                int lastId = Convert.ToInt32(comando2.ExecuteScalar()); // Ejecutar el comando y obtener el ID
                for (int i = 1; i < 4; i++)
                {
                    Conexion.conectar();
                    string query1 = "INSERT INTO `equipos`(`id_equipo`, `id_usuario`, `es_favorito`) VALUES (" + contador.ToString() + i.ToString() + "," + contador.ToString() + " ,0)";
                    MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                    comando1.ExecuteNonQuery();
                    Conexion.desconectar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 4)
            {
                numericUpDown1.Value = 0;
            }
            if (numericUpDown1.Value < 0)
            {
                numericUpDown1.Value = 4;
            }
            switch (numericUpDown1.Value)
            {
                case 0:
                    pbFotoUsu.Image = Properties.Resources.ashicon_removebg_preview;
                    break;
                case 1:
                    pbFotoUsu.Image = Properties.Resources.IconIsa;
                    break;
                case 2:
                    pbFotoUsu.Image = Properties.Resources.IconGabo;
                    break;
                case 3:
                    pbFotoUsu.Image = Properties.Resources.IconSergio;
                    break;
                case 4:
                    pbFotoUsu.Image = Properties.Resources.IconAyma;
                    break;
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
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' '))
            {
                e.Handled = true;
            }

        }

        private void tbUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (Char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void tbRecuperacion_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
