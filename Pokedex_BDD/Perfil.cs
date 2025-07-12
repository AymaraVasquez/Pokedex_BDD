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

namespace Pokedex
{
    public partial class Perfil : Form
    {
        public Conex Conexion = new Conex();
        public PokemonVer[] EquipoFav = new PokemonVer[6];
        public int hayEquipo = 0; // Variable para saber si hay equipo favorito
        public Perfil()
        {
            InitializeComponent();
            EquipoFav[0] = new PokemonVer();
            EquipoFav[1] = new PokemonVer();
            EquipoFav[2] = new PokemonVer();
            EquipoFav[3] = new PokemonVer();
            EquipoFav[4] = new PokemonVer();
            EquipoFav[5] = new PokemonVer();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            // Cargar el perfil del usuario
            Conexion.conectar();
            string query = "SELECT nombre, foto_perfil FROM Usuarios WHERE id_usuario = " + SesionIniciada.IdUsuario;
            MySqlCommand mySqlCommand = new MySqlCommand(query, Conex.Coneccion);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                string nombre = reader.GetString("nombre");
                int fotoPerfil = reader.GetInt32("foto_perfil");
                // Asignar los valores a los controles del formulario
                lbNombre.Text = nombre;
                switch (fotoPerfil)
                {
                    case 1:
                        //pbFotoPerfil.Image = Properties.Resources.foto1;
                        break;
                    case 2:
                        //pbFotoPerfil.Image = Properties.Resources.foto2;
                        break;
                    case 3:
                        //pbFotoPerfil.Image = Properties.Resources.foto3;
                        break;
                    case 4:
                        //pbFotoPerfil.Image = Properties.Resources.foto4;
                        break;
                    default:
                        //pbFotoPerfil.Image = Properties.Resources.default_foto; 
                        break;
                }
            }
            Conexion.desconectar();

            Conexion.conectar();
            string consultaEquipo = "SELECT id_poke, nombre_poke FROM pokedex_normal WHERE id_poke IN (SELECT id_poke FROM rela_equipos_pokes WHERE id_equipo in (SELECT id_equipo from equipos where id_usuario = " + SesionIniciada.IdUsuario + " and es_favorito = 1) );";
            MySqlCommand comandoEquipo = new MySqlCommand(consultaEquipo, Conex.Coneccion);
            Conex.Lector = comandoEquipo.ExecuteReader();

            int i = 0;
            while (Conex.Lector.Read())
            {
                EquipoFav[i].id = Convert.ToInt32(Conex.Lector[0].ToString());
                EquipoFav[i].nombre = Conex.Lector[1].ToString();
                EquipoFav[i].imagen = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
                i++;
                hayEquipo = 1; // Si se ha encontrado al menos un Pokémon, hay equipo favorito
            }
            Conexion.desconectar();

            if (hayEquipo == 1)
            {
                CargarEquipo();
            }
            else
            {
                // Si no hay equipo favorito, mostrar un mensaje o dejar los controles vacíos
                MessageBox.Show("No tienes un equipo favorito configurado. Puedes Seleccionar uno en el Apartado de Crear Equipos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí podrías limpiar las imágenes y etiquetas si lo deseas
                CargarEquipo();
            }
        }
        public void CargarEquipo()
        {
            if (EquipoFav[0].imagen != null)
            {
                Foto1.Image = EquipoFav[0].imagen;
                lbCodigo1.Text = "#" + EquipoFav[0].id.ToString();
                lbNombre1.Text = EquipoFav[0].nombre;
            }
            else
            {
                Foto1.Image = Properties.Resources.pokeball;
                lbCodigo1.Text = "#####";
                lbNombre1.Text = "No posee";
                btInfo1.Visible = false;
            }
            if (EquipoFav[1].imagen != null)
            {
                Foto2.Image = EquipoFav[1].imagen;
                lbCodigo2.Text = "#" + EquipoFav[1].id.ToString();
                lbNombre2.Text = EquipoFav[1].nombre;
            }
            else
            {
                Foto2.Image = Properties.Resources.pokeball;
                lbCodigo2.Text = "#####";
                lbNombre2.Text = "No posee";
                btInfo2.Visible = false;
            }
            if (EquipoFav[2].imagen != null)
            {
                Foto3.Image = EquipoFav[2].imagen;
                lbCodigo3.Text = "#" + EquipoFav[2].id.ToString();
                lbNombre3.Text = EquipoFav[2].nombre;
            }
            else
            {
                Foto3.Image = Properties.Resources.pokeball;
                lbCodigo3.Text = "#####";
                lbNombre3.Text = "No posee";
                btInfo3.Visible = false;
            }
            if (EquipoFav[3].imagen != null)
            {
                Foto4.Image = EquipoFav[3].imagen;
                lbNombre4.Text = EquipoFav[3].nombre;
                lbCodigo4.Text = "#" + EquipoFav[3].id.ToString();
            }
            else
            {
                Foto4.Image = Properties.Resources.pokeball;
                lbCodigo4.Text = "#####";
                lbNombre4.Text = "No posee";
                btInfo4.Visible = false;
            }
            if (EquipoFav[4].imagen != null)
            {
                Foto5.Image = EquipoFav[4].imagen;
                lbCodigo5.Text = "#" + EquipoFav[4].id.ToString();
                lbNombre5.Text = EquipoFav[4].nombre;
            }
            else
            {
                Foto5.Image = Properties.Resources.pokeball;
                lbCodigo5.Text = "#####";
                lbNombre5.Text = "No posee";
                btInfo5.Visible = false;
            }
            if (EquipoFav[5].imagen != null)
            {
                Foto6.Image = EquipoFav[5].imagen;
                lbCodigo6.Text = "#" + EquipoFav[5].id.ToString();
                lbNombre6.Text = EquipoFav[5].nombre;
            }
            else
            {
                Foto6.Image = Properties.Resources.pokeball;
                lbCodigo6.Text = "#####";
                lbNombre6.Text = "No posee";
                btInfo6.Visible = false;
            }
        }

        private void btInfo1_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = EquipoFav[0].id;
            statsForm.ShowDialog();
        }

        private void btInfo2_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = EquipoFav[1].id;
            statsForm.ShowDialog();
        }

        private void btInfo3_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = EquipoFav[2].id;
            statsForm.ShowDialog();
        }

        private void btInfo4_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = EquipoFav[3].id;
            statsForm.ShowDialog();
        }

        private void btInfo5_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = EquipoFav[4].id;
            statsForm.ShowDialog();
        }

        private void btInfo6_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = EquipoFav[5].id;
            statsForm.ShowDialog();
        }
    }
}
