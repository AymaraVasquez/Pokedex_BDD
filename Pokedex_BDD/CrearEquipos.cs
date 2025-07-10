using CargarBDDPokemon;
using MySql.Data.MySqlClient;
using Pokedex.Properties;
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
    public partial class CrearEquipos : Form
    {
        public PokemonVer[] Equipo1 = new PokemonVer[6];
        public PokemonVer[] Equipo2 = new PokemonVer[6];
        public PokemonVer[] Equipo3 = new PokemonVer[6];
        Conex Conexion = new Conex();
        public void ReestablecerEquipos()
        {
            for (int i = 0; i < Equipo1.Length; i++) 
            {
                Equipo1[i] = new PokemonVer();
                Equipo2[i] = new PokemonVer();
                Equipo3[i] = new PokemonVer();
            }
        }
        public CrearEquipos()
        {
            InitializeComponent();
        }
        public static bool anadirPokemon;
        public static bool equipoFavorito;
        public static int equipoFav;
        private void btAnadir_Click(object sender, EventArgs e)
        {
            btElim1_1.Visible = false;
            btElim1_2.Visible = false;
            btElim1_3.Visible = false;
            btElim1_4.Visible = false;
            btElim1_5.Visible = false;
            btElim1_6.Visible = false;

            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;

            if (SesionIniciada.idPokeAniadir != 0)
            {
                for (int i = 0;i < Equipo1.Length; i++)
                {
                    if (Equipo1[i].imagen == null)
                    {
                        Conexion.conectar();
                        string query1 = "INSERT INTO `rela_equipos_pokes`(`id_rela_equipos`, `id_equipo`, `id_poke`) VALUES (null,"+SesionIniciada.IdUsuario.ToString()+"1,"+SesionIniciada.idPokeAniadir.ToString()+")";
                        MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                        comando1.ExecuteNonQuery();
                        Conexion.desconectar();
                        SesionIniciada.idPokeAniadir = 0;
                        return;
                    }
                }
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
            }
            CargarImagenes();
        }
        

        private void btEditar_Click(object sender, EventArgs e)
        {
            btElim1_1.Visible = true;
            btElim1_2.Visible = true;
            btElim1_3.Visible = true;
            btElim1_4.Visible = true;
            btElim1_5.Visible = true;
            btElim1_6.Visible = true;
        }

        private void btAnadir2_Click(object sender, EventArgs e)
        {
            btElim2_1.Visible = false;
            btElim2_2.Visible = false;
            btElim2_3.Visible = false;
            btElim2_4.Visible = false;
            btElim2_5.Visible = false;
            btElim2_6.Visible = false;

            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;

            if (SesionIniciada.idPokeAniadir != 0)
            {
                for (int i = 0; i < Equipo1.Length; i++)
                {
                    if (Equipo2[i].imagen == null)
                    {
                        Conexion.conectar();
                        string query1 = "INSERT INTO `rela_equipos_pokes`(`id_rela_equipos`, `id_equipo`, `id_poke`) VALUES (null,"+SesionIniciada.IdUsuario.ToString()+"2," + SesionIniciada.idPokeAniadir.ToString() + ")";
                        MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                        comando1.ExecuteNonQuery();
                        Conexion.desconectar();
                        SesionIniciada.idPokeAniadir = 0;
                        return;
                    }
                }
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
            }
            CargarImagenes();
        }

        private void btEditar2_Click(object sender, EventArgs e)
        {
            btElim2_1.Visible = true;
            btElim2_2.Visible = true;
            btElim2_3.Visible = true;
            btElim2_4.Visible = true;
            btElim2_5.Visible = true;
            btElim2_6.Visible = true;
        }

        private void btAnadir3_Click(object sender, EventArgs e)
        {
            btElim3_1.Visible = false;
            btElim3_2.Visible = false;
            btElim3_3.Visible = false;
            btElim3_4.Visible = false;
            btElim3_5.Visible = false;
            btElim3_6.Visible = false;

            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;

            if (SesionIniciada.idPokeAniadir != 0)
            {
                for (int i = 0; i < Equipo3.Length; i++)
                {
                    if (Equipo3[i].imagen == null)
                    {
                        Conexion.conectar();
                        string query1 = "INSERT INTO `rela_equipos_pokes`(`id_rela_equipos`, `id_equipo`, `id_poke`) VALUES (null,"+SesionIniciada.IdUsuario+"3," + SesionIniciada.idPokeAniadir.ToString() + ")";
                        MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                        comando1.ExecuteNonQuery();
                        Conexion.desconectar();
                        SesionIniciada.idPokeAniadir = 0;
                        return;
                    }
                }
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
            }
            CargarImagenes();
        }

        private void btEditar3_Click(object sender, EventArgs e)
        {
            btElim3_1.Visible = true;
            btElim3_2.Visible = true;
            btElim3_3.Visible = true;
            btElim3_4.Visible = true;
            btElim3_5.Visible = true;
            btElim3_6.Visible = true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar2_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar3_Click(object sender, EventArgs e)
        {

        }

        private void btFav1_Click(object sender, EventArgs e)
        {
            if (equipoFavorito == false)
            {
                equipoFavorito = true;
                equipoFav = 1;
                btFav1.Image = Resources.FavCheck;
            }
            else if (equipoFav == 1)
            {
                equipoFavorito = false;
                btFav1.Image = Resources.FavNoCheck;
            }
        }

        private void btFav2_Click(object sender, EventArgs e)
        {
            if (equipoFavorito == false)
            {
                equipoFavorito = true;
                equipoFav = 2;
                btFav2.Image = Resources.FavCheck;
                btFav2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (equipoFav == 2)
            {
                equipoFavorito = false;
                btFav2.Image = Resources.FavNoCheck;
                btFav2.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void btFav3_Click(object sender, EventArgs e)
        {
            if (equipoFavorito == false)
            {
                equipoFavorito = true;
                equipoFav = 3;
                btFav3.Image = Resources.FavCheck;
                btFav3.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (equipoFav == 3)
            {
                equipoFavorito = false;
                btFav3.Image = Resources.FavNoCheck;
                btFav3.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void CrearEquipos_Load(object sender, EventArgs e)
        {
            ReestablecerEquipos();
            Conexion.conectar();
            string consulta = "SELECT po.url_img, po.id_poke, equi.id_equipo from rela_equipos_pokes rela join pokedex_normal po on rela.id_poke = po.id_poke join equipos equi on rela.id_equipo = equi.id_equipo where equi.id_usuario = " + SesionIniciada.IdUsuario;
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contadore1 = 0;
            int contadore2 = 0;
            int contadore3 = 0;
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                char[] strings = Conex.Lector[2].ToString().ToCharArray();
                int equipo = Convert.ToInt32(strings[1].ToString());
                switch (equipo)
                {
                    case 1:
                        Equipo1[contadore1].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[0].ToString()));
                        Equipo1[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                        contadore1++;
                    break;
                    case 2: 
                        Equipo2[contadore2].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[0].ToString()));
                        Equipo2[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                        contadore2++;
                    break;
                    case 3:
                        Equipo3[contadore2].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[0].ToString()));
                        Equipo3[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                        contadore3++;
                    break;
                }
            }
            Conexion.desconectar();

            // Cargar en los imageBox
            CargarImagenes();
            
        }
        public void CargarImagenes()
        {
            if (Equipo1[0].imagen != null)
            {
                Foto1_1.Image = Equipo1[0].imagen;
            }
            if (Equipo1[1].imagen != null)
            {
                Foto1_2.Image = Equipo1[1].imagen;
            }
            if (Equipo1[2].imagen != null)
            {
                Foto1_3.Image = Equipo1[2].imagen;
            }
            if (Equipo1[3].imagen != null)
            {
                Foto1_4.Image = Equipo1[3].imagen;
            }
            if (Equipo1[4].imagen != null)
            {
                Foto1_5.Image = Equipo1[4].imagen;
            }
            if (Equipo1[5].imagen != null)
            {
                Foto1_6.Image = Equipo1[5].imagen;
            }

            if (Equipo2[0].imagen != null)
            {
                Foto2_1.Image = Equipo2[0].imagen;
            }
            if (Equipo2[1].imagen != null)
            {
                Foto2_2.Image = Equipo2[1].imagen;
            }
            if (Equipo2[2].imagen != null)
            {
                Foto2_3.Image = Equipo2[2].imagen;
            }
            if (Equipo2[3].imagen != null)
            {
                Foto2_4.Image = Equipo2[3].imagen;
            }
            if (Equipo2[4].imagen != null)
            {
                Foto2_5.Image = Equipo2[4].imagen;
            }
            if (Equipo2[5].imagen != null)
            {
                Foto2_6.Image = Equipo2[5].imagen;
            }

            if (Equipo3[0].imagen != null)
            {
                Foto3_1.Image = Equipo3[0].imagen;
            }
            if (Equipo3[1].imagen != null)
            {
                Foto3_2.Image = Equipo3[1].imagen;
            }
            if (Equipo3[2].imagen != null)
            {
                Foto3_3.Image = Equipo3[2].imagen;
            }
            if (Equipo3[3].imagen != null)
            {
                Foto3_4.Image = Equipo3[3].imagen;
            }
            if (Equipo3[4].imagen != null)
            {
                Foto3_5.Image = Equipo3[4].imagen;
            }
            if (Equipo3[5].imagen != null)
            {
                Foto3_6.Image = Equipo3[5].imagen;
            }
        }
    }
}
