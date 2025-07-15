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
        public static bool anadirPokemonn;
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
            btEditar.Text = "Editar";

            int hayEspacio = 0;
            for (int i = 0; i<6; i++)
            {
                if (Equipo1[i].imagen == null)
                {
                    hayEspacio = 1;
                }
            }

            if (hayEspacio == 0)
            {
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
                return;
            }
            
            anadirPokemon = true;
            anadirPokemonn = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;
            anadirPokemonn = false;
            if (SesionIniciada.idPokeAniadir != 0)
            {
                for (int i = 0; i < Equipo1.Length; i++)
                {
                    if (Equipo1[i].imagen == null)
                    {
                        Conexion.conectar();
                        string query1 = "INSERT INTO `rela_equipos_pokes`(`id_rela_equipos`, `id_equipo`, `id_poke`) VALUES (null," + SesionIniciada.IdUsuario.ToString() + "1," + SesionIniciada.idPokeAniadir.ToString() + ")";
                        MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                        comando1.ExecuteNonQuery();
                        Conexion.desconectar();
                        SesionIniciada.idPokeAniadir = 0;

                        ReestablecerEquipos();
                        Conexion.conectar();
                        string consulta = "SELECT po.url_img, po.id_poke, equi.id_equipo from rela_equipos_pokes rela join pokedex_normal po on rela.id_poke = po.id_poke join equipos equi on rela.id_equipo = equi.id_equipo where equi.id_usuario = " + SesionIniciada.IdUsuario;
                        MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
                        Conex.Lector = comando3.ExecuteReader();
                        int contadore1 = 0;
                        int contadore2 = 0;
                        int contadore3 = 0;
                        while (Conex.Lector.Read())
                        {
                            // strings.Count()-1
                            char[] strings = Conex.Lector[2].ToString().ToCharArray();
                            int equipo = Convert.ToInt32(strings[strings.Count()-1].ToString());
                            switch (equipo)
                            {
                                case 1:
                                    Equipo1[contadore1].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo1[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore1++;
                                    break;
                                case 2:
                                    Equipo2[contadore2].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo2[contadore2].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore2++;
                                    break;
                                case 3:
                                    Equipo3[contadore3].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo3[contadore3].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore3++;
                                    break;
                            }
                        }
                        Conexion.desconectar();
                        CargarImagenes();


                        return;
                    }
                }
            }
        }


        private void btEditar_Click(object sender, EventArgs e)
        {
            if (btEditar.Text == "Editar")
            {
                btElim1_1.Visible = true;
                btElim1_2.Visible = true;
                btElim1_3.Visible = true;
                btElim1_4.Visible = true;
                btElim1_5.Visible = true;
                btElim1_6.Visible = true;
                btEditar.Text = "Guardar";
            }
            else
            {
                btElim1_1.Visible = false;
                btElim1_2.Visible = false;
                btElim1_3.Visible = false;
                btElim1_4.Visible = false;
                btElim1_5.Visible = false;
                btElim1_6.Visible = false;
                btEditar.Text = "Editar";
            }
        }

        private void btAnadir2_Click(object sender, EventArgs e)
        {
            btElim2_1.Visible = false;
            btElim2_2.Visible = false;
            btElim2_3.Visible = false;
            btElim2_4.Visible = false;
            btElim2_5.Visible = false;
            btElim2_6.Visible = false;
            btEditar2.Text = "Editar";

            int hayEspacio = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Equipo2[i].imagen == null)
                {
                    hayEspacio = 1;
                }
            }

            if (hayEspacio == 0)
            {
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
                return;
            }
            anadirPokemonn = true;
            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemonn = false;
            anadirPokemon = false;

            if (SesionIniciada.idPokeAniadir != 0)
            {
                for (int i = 0; i < Equipo1.Length; i++)
                {
                    if (Equipo2[i].imagen == null)
                    {
                        Conexion.conectar();
                        string query1 = "INSERT INTO `rela_equipos_pokes`(`id_rela_equipos`, `id_equipo`, `id_poke`) VALUES (null," + SesionIniciada.IdUsuario.ToString() + "2," + SesionIniciada.idPokeAniadir.ToString() + ")";
                        MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                        comando1.ExecuteNonQuery();
                        Conexion.desconectar();
                        SesionIniciada.idPokeAniadir = 0;

                        ReestablecerEquipos();
                        Conexion.conectar();
                        string consulta = "SELECT po.url_img, po.id_poke, equi.id_equipo from rela_equipos_pokes rela join pokedex_normal po on rela.id_poke = po.id_poke join equipos equi on rela.id_equipo = equi.id_equipo where equi.id_usuario = " + SesionIniciada.IdUsuario;
                        MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
                        Conex.Lector = comando3.ExecuteReader();
                        int contadore1 = 0;
                        int contadore2 = 0;
                        int contadore3 = 0;
                        while (Conex.Lector.Read())
                        {
                            char[] strings = Conex.Lector[2].ToString().ToCharArray();
                            int equipo = Convert.ToInt32(strings[strings.Count()-1].ToString());
                            switch (equipo)
                            {
                                case 1:
                                    Equipo1[contadore1].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo1[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore1++;
                                    break;
                                case 2:
                                    Equipo2[contadore2].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo2[contadore2].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore2++;
                                    break;
                                case 3:
                                    Equipo3[contadore3].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo3[contadore3].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore3++;
                                    break;
                            }
                        }
                        Conexion.desconectar();
                        CargarImagenes();

                        return;
                    }
                }
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
            }
            
        }

        private void btEditar2_Click(object sender, EventArgs e)
        {
            if (btEditar2.Text == "Editar")
            {
                btElim2_1.Visible = true;
                btElim2_2.Visible = true;
                btElim2_3.Visible = true;
                btElim2_4.Visible = true;
                btElim2_5.Visible = true;
                btElim2_6.Visible = true;
                btEditar2.Text = "Guardar";
            }
            else
            {
                btElim2_1.Visible = false;
                btElim2_2.Visible = false;
                btElim2_3.Visible = false;
                btElim2_4.Visible = false;
                btElim2_5.Visible = false;
                btElim2_6.Visible = false;
                btEditar2.Text = "Editar";
            }
        }

        private void btAnadir3_Click(object sender, EventArgs e)
        {
            btElim3_1.Visible = false;
            btElim3_2.Visible = false;
            btElim3_3.Visible = false;
            btElim3_4.Visible = false;
            btElim3_5.Visible = false;
            btElim3_6.Visible = false;
            btEditar3.Text = "Editar";

            int hayEspacio = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Equipo3[i].imagen == null)
                {
                    hayEspacio = 1;
                }
            }

            if (hayEspacio == 0)
            {
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
                return;
            }
            anadirPokemonn = true;
            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;
            anadirPokemonn = false;

            if (SesionIniciada.idPokeAniadir != 0)
            {
                for (int i = 0; i < Equipo3.Length; i++)
                {
                    if (Equipo3[i].imagen == null)
                    {
                        Conexion.conectar();
                        string query1 = "INSERT INTO `rela_equipos_pokes`(`id_rela_equipos`, `id_equipo`, `id_poke`) VALUES (null," + SesionIniciada.IdUsuario + "3," + SesionIniciada.idPokeAniadir.ToString() + ")";
                        MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                        comando1.ExecuteNonQuery();
                        Conexion.desconectar();
                        SesionIniciada.idPokeAniadir = 0;
                        ReestablecerEquipos();
                        Conexion.conectar();
                        string consulta = "SELECT po.url_img, po.id_poke, equi.id_equipo from rela_equipos_pokes rela join pokedex_normal po on rela.id_poke = po.id_poke join equipos equi on rela.id_equipo = equi.id_equipo where equi.id_usuario = " + SesionIniciada.IdUsuario;
                        MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
                        Conex.Lector = comando3.ExecuteReader();
                        int contadore1 = 0;
                        int contadore2 = 0;
                        int contadore3 = 0;
                        while (Conex.Lector.Read())
                        {
                            char[] strings = Conex.Lector[2].ToString().ToCharArray();
                            int equipo = Convert.ToInt32(strings[strings.Count()-1].ToString());
                            switch (equipo)
                            {
                                case 1:
                                    Equipo1[contadore1].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo1[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore1++;
                                    break;
                                case 2:
                                    Equipo2[contadore2].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo2[contadore2].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore2++;
                                    break;
                                case 3:
                                    Equipo3[contadore3].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                                    Equipo3[contadore3].id = Convert.ToInt32(Conex.Lector[1].ToString());
                                    contadore3++;
                                    break;
                            }
                        }
                        Conexion.desconectar();
                        CargarImagenes();
                        return;
                    }
                }
                MessageBox.Show("No se pueden añadir mas de 6 pokemons a un equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada.idPokeAniadir = 0;
            }
        }

        private void btEditar3_Click(object sender, EventArgs e)
        {
            if (btEditar3.Text == "Editar")
            {
                btElim3_1.Visible = true;
                btElim3_2.Visible = true;
                btElim3_3.Visible = true;
                btElim3_4.Visible = true;
                btElim3_5.Visible = true;
                btElim3_6.Visible = true;
                btEditar3.Text = "Guardar";
            }
            else
            {
                btElim3_1.Visible = false;
                btElim3_2.Visible = false;
                btElim3_3.Visible = false;
                btElim3_4.Visible = false;
                btElim3_5.Visible = false;
                btElim3_6.Visible = false;
                btEditar3.Text = "Editar";
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Conexion.conectar();
                string query = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1";
                MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
                comando.ExecuteNonQuery();
                Conexion.desconectar();
                Equipo1 = new PokemonVer[6];
                Equipo1[0] = new PokemonVer();
                Equipo1[1] = new PokemonVer();
                Equipo1[2] = new PokemonVer();
                Equipo1[3] = new PokemonVer();
                Equipo1[4] = new PokemonVer();
                Equipo1[5] = new PokemonVer();
                CargarImagenes();
            }
            else
            {
                return;
            }
        }

        private void btEliminar2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Conexion.conectar();
                string query = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2";
                MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
                comando.ExecuteNonQuery();
                Conexion.desconectar();
                Equipo2 = new PokemonVer[6];
                Equipo2[0] = new PokemonVer();
                Equipo2[1] = new PokemonVer();
                Equipo2[2] = new PokemonVer();
                Equipo2[3] = new PokemonVer();
                Equipo2[4] = new PokemonVer();
                Equipo2[5] = new PokemonVer();
                CargarImagenes();
            }
            else
            {
                return;
            }
        }

        private void btEliminar3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Conexion.conectar();
                string query = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3";
                MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
                comando.ExecuteNonQuery();
                Conexion.desconectar();
                Equipo3 = new PokemonVer[6];
                Equipo3[0] = new PokemonVer();
                Equipo3[1] = new PokemonVer();
                Equipo3[2] = new PokemonVer();
                Equipo3[3] = new PokemonVer();
                Equipo3[4] = new PokemonVer();
                Equipo3[5] = new PokemonVer();
                CargarImagenes();
            }
            else
            {
                return;
            }
        }

        private void btFav1_Click(object sender, EventArgs e)
        {
            if (equipoFav == 1)
            {
                equipoFavorito = false;
                equipoFav = 0;
                btFav1.BackgroundImage = Resources.FavNoCheck;
                Conexion.conectar();
                string query1 = "UPDATE `equipos` SET es_favorito = 0 WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND id_equipo = " + SesionIniciada.IdUsuario + "1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                return;
            }
            else if (equipoFav == 2)
            {
                btFav2_Click(sender, e);
            }
            else if (equipoFav == 3)
            {
                btFav3_Click(sender, e);
            }
            equipoFavorito = true;
            equipoFav = 1;
            btFav1.BackgroundImage = Resources.FavCheck;
            Conexion.conectar();
            string query = "UPDATE `equipos` SET es_favorito = 1 WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND id_equipo = " + SesionIniciada.IdUsuario + "1";
            MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
            comando.ExecuteNonQuery();
            Conexion.desconectar();

        }

        private void btFav2_Click(object sender, EventArgs e)
        {
            if (equipoFav == 1)
            {
                btFav1_Click(sender, e);
            }
            else if (equipoFav == 3)
            {
                btFav3_Click(sender, e);
            }
            else if (equipoFav == 2)
            {
                equipoFavorito = false;
                equipoFav = 0;
                btFav2.BackgroundImage = Resources.FavNoCheck;
                btFav2.BackgroundImageLayout = ImageLayout.Zoom;
                Conexion.conectar();
                string query1 = "UPDATE `equipos` SET es_favorito = 0 WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND id_equipo = " + SesionIniciada.IdUsuario + "2";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                return;
            }
            equipoFavorito = true;
            equipoFav = 2;
            btFav2.BackgroundImage = Resources.FavCheck;
            btFav2.BackgroundImageLayout = ImageLayout.Stretch;
            Conexion.conectar();
            string query = "UPDATE `equipos` SET es_favorito = 1 WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND id_equipo = " + SesionIniciada.IdUsuario + "2";
            MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
            comando.ExecuteNonQuery();
            Conexion.desconectar();
        }

        private void btFav3_Click(object sender, EventArgs e)
        {
            if (equipoFav == 1)
            {
                btFav1_Click(sender, e);
            }
            else if (equipoFav == 2)
            {
                btFav2_Click(sender, e);
            }
            else if (equipoFav == 3)
            {
                equipoFav = 0;
                equipoFavorito = false;
                btFav3.BackgroundImage = Resources.FavNoCheck;
                btFav3.BackgroundImageLayout = ImageLayout.Zoom;
                Conexion.conectar();
                string query1 = "UPDATE `equipos` SET es_favorito = 0 WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND id_equipo = " + SesionIniciada.IdUsuario + "3";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                return;
            }
            equipoFavorito = true;
            equipoFav = 3;
            btFav3.BackgroundImage = Resources.FavCheck;
            btFav3.BackgroundImageLayout = ImageLayout.Zoom;
            Conexion.conectar();
            string query = "UPDATE `equipos` SET es_favorito = 1 WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND id_equipo = " + SesionIniciada.IdUsuario + "3";
            MySqlCommand comando = new MySqlCommand(query, Conex.Coneccion);
            comando.ExecuteNonQuery();
            Conexion.desconectar();

        }

        private void CrearEquipos_Load(object sender, EventArgs e)
        {
            Opciones.vista = 2;

            ReestablecerEquipos();
            //Revisar cual es el favorito
            Conexion.conectar();
            string consulta1 = "SELECT id_equipo FROM equipos WHERE id_usuario = " + SesionIniciada.IdUsuario + " AND es_favorito = 1";
            MySqlCommand comando1 = new MySqlCommand(consulta1, Conex.Coneccion);
            Conex.Lector = comando1.ExecuteReader();
            int numEquipo = 0;
            while (Conex.Lector.Read())
            {
                // Extraer el número del equipo (1, 2 o 3)
                char[] strings = Conex.Lector[0].ToString().ToCharArray();
                numEquipo = Convert.ToInt32(strings[1].ToString());
            }
            Conexion.desconectar();

            switch (numEquipo)
            {
                case 1:
                    equipoFav = 1;
                    btFav1.BackgroundImage = Resources.FavCheck;
                    break;
                case 2:
                    equipoFav = 2;
                    btFav2.BackgroundImage = Resources.FavCheck;
                    break;
                case 3:
                    equipoFav = 3;
                    btFav3.BackgroundImage = Resources.FavCheck;
                    break;
                default:
                    equipoFavorito = false;
                    break;
            }


            CargarArrays();
            // Cargar en los imageBox
            CargarImagenes();

        }
        public void CargarArrays()
        {
            Conexion.conectar();
            string consulta = "SELECT po.url_img, po.id_poke, equi.id_equipo from rela_equipos_pokes rela join pokedex_normal po on rela.id_poke = po.id_poke join equipos equi on rela.id_equipo = equi.id_equipo where equi.id_usuario = " + SesionIniciada.IdUsuario;
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contadore1 = 0;
            int contadore2 = 0;
            int contadore3 = 0;
            while (Conex.Lector.Read())
            {
                char[] strings = Conex.Lector[2].ToString().ToCharArray();
                int equipo = Convert.ToInt32(strings[strings.Count() - 1].ToString());
                switch (equipo)
                {
                    case 1:
                        Equipo1[contadore1].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                        Equipo1[contadore1].id = Convert.ToInt32(Conex.Lector[1].ToString());
                        contadore1++;
                        break;
                    case 2:
                        Equipo2[contadore2].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                        Equipo2[contadore2].id = Convert.ToInt32(Conex.Lector[1].ToString());
                        contadore2++;
                        break;
                    case 3:
                        Equipo3[contadore3].imagen = BuscarImagen.DeStringAImage(Conex.Lector[1].ToString());
                        Equipo3[contadore3].id = Convert.ToInt32(Conex.Lector[1].ToString());
                        contadore3++;
                        break;
                }
            }
            Conexion.desconectar();
        }
        public void CargarImagenes()
        {
            if (Equipo1[0].imagen != null)
            {
                Foto1_1.Image = Equipo1[0].imagen;
            }
            else
            {
                Foto1_1.Image = Resources.pokebola;
            }
            if (Equipo1[1].imagen != null)
            {
                Foto1_2.Image = Equipo1[1].imagen;
            }
            else
            {
                Foto1_2.Image = Resources.pokebola;
            }
            if (Equipo1[2].imagen != null)
            {
                Foto1_3.Image = Equipo1[2].imagen;
            }
            else
            {
                Foto1_3.Image = Resources.pokebola;
            }
            if (Equipo1[3].imagen != null)
            {
                Foto1_4.Image = Equipo1[3].imagen;
            }
            else
            {
                Foto1_4.Image = Resources.pokebola;
            }
            if (Equipo1[4].imagen != null)
            {
                Foto1_5.Image = Equipo1[4].imagen;
            }
            else
            {
                Foto1_5.Image = Resources.pokebola;
            }
            if (Equipo1[5].imagen != null)
            {
                Foto1_6.Image = Equipo1[5].imagen;
            }
            else
            {
                Foto1_6.Image = Resources.pokebola;
            }

            if (Equipo2[0].imagen != null)
            {
                Foto2_1.Image = Equipo2[0].imagen;
            }
            else
            {
                Foto2_1.Image = Resources.pokebola;
            }
            if (Equipo2[1].imagen != null)
            {
                Foto2_2.Image = Equipo2[1].imagen;
            }
            else
            {
                Foto2_2.Image = Resources.pokebola;
            }
            if (Equipo2[2].imagen != null)
            {
                Foto2_3.Image = Equipo2[2].imagen;
            }
            else
            {
                Foto2_3.Image = Resources.pokebola;
            }
            if (Equipo2[3].imagen != null)
            {
                Foto2_4.Image = Equipo2[3].imagen;
            }
            else
            {
                Foto2_4.Image = Resources.pokebola;
            }
            if (Equipo2[4].imagen != null)
            {
                Foto2_5.Image = Equipo2[4].imagen;
            }
            else
            {
                Foto2_5.Image = Resources.pokebola;
            }
            if (Equipo2[5].imagen != null)
            {
                Foto2_6.Image = Equipo2[5].imagen;
            }
            else
            {
                Foto2_6.Image = Resources.pokebola;
            }

            if (Equipo3[0].imagen != null)
            {
                Foto3_1.Image = Equipo3[0].imagen;
            }
            else
            {
                Foto3_1.Image = Resources.pokebola;
            }
            if (Equipo3[1].imagen != null)
            {
                Foto3_2.Image = Equipo3[1].imagen;
            }
            else
            {
                Foto3_2.Image = Resources.pokebola;
            }
            if (Equipo3[2].imagen != null)
            {
                Foto3_3.Image = Equipo3[2].imagen;
            }
            else
            {
                Foto3_3.Image = Resources.pokebola;
            }
            if (Equipo3[3].imagen != null)
            {
                Foto3_4.Image = Equipo3[3].imagen;
            }
            else
            {
                Foto3_4.Image = Resources.pokebola;
            }
            if (Equipo3[4].imagen != null)
            {
                Foto3_5.Image = Equipo3[4].imagen;
            }
            else
            {
                Foto3_5.Image = Resources.pokebola;
            }
            if (Equipo3[5].imagen != null)
            {
                Foto3_6.Image = Equipo3[5].imagen;
            }
            else
            {
                Foto3_6.Image = Resources.pokebola;
            }
        }

        private void btElim1_1_Click(object sender, EventArgs e)
        {
            if (Equipo1[0].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1 AND id_poke = " + Equipo1[0].id.ToString()+" limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim1_2_Click(object sender, EventArgs e)
        {
            if (Equipo1[1].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1 AND id_poke = " + Equipo1[1].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim1_3_Click(object sender, EventArgs e)
        {
            if (Equipo1[2].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1 AND id_poke = " + Equipo1[2].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim1_4_Click(object sender, EventArgs e)
        {
            if (Equipo1[3].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1 AND id_poke = " + Equipo1[3].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim1_5_Click(object sender, EventArgs e)
        {
            if (Equipo1[4].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1 AND id_poke = " + Equipo1[4].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim1_6_Click(object sender, EventArgs e)
        {
            if (Equipo1[5].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "1 AND id_poke = " + Equipo1[5].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim2_1_Click(object sender, EventArgs e)
        {
            if (Equipo2[0].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2 AND id_poke = " + Equipo2[0].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim2_2_Click(object sender, EventArgs e)
        {
            if (Equipo2[1].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2 AND id_poke = " + Equipo2[1].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim2_3_Click(object sender, EventArgs e)
        {
            if (Equipo2[2].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2 AND id_poke = " + Equipo2[2].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim2_4_Click(object sender, EventArgs e)
        {
            if (Equipo2[3].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2 AND id_poke = " + Equipo2[3].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim2_5_Click(object sender, EventArgs e)
        {
            if (Equipo2[4].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2 AND id_poke = " + Equipo2[4].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim2_6_Click(object sender, EventArgs e)
        {
            if (Equipo2[5].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "2 AND id_poke = " + Equipo2[5].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim3_1_Click(object sender, EventArgs e)
        {
            if (Equipo3[0].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3 AND id_poke = " + Equipo3[0].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim3_2_Click(object sender, EventArgs e)
        {
            if (Equipo3[1].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3 AND id_poke = " + Equipo3[1].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim3_3_Click(object sender, EventArgs e)
        {
            if (Equipo3[2].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3 AND id_poke = " + Equipo3[2].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim3_4_Click(object sender, EventArgs e)
        {
            if (Equipo3[3].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3 AND id_poke = " + Equipo3[3].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim3_5_Click(object sender, EventArgs e)
        {
            if (Equipo3[4].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3 AND id_poke = " + Equipo3[4].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btElim3_6_Click(object sender, EventArgs e)
        {
            if (Equipo3[5].imagen != null)
            {
                Conexion.conectar();
                string query1 = "DELETE FROM `rela_equipos_pokes` WHERE id_equipo = " + SesionIniciada.IdUsuario.ToString() + "3 AND id_poke = " + Equipo3[5].id.ToString() + " limit 1";
                MySqlCommand comando1 = new MySqlCommand(query1, Conex.Coneccion);
                comando1.ExecuteNonQuery();
                Conexion.desconectar();
                ReestablecerEquipos();
                CargarArrays();
                CargarImagenes();
            }
            else
            {
                MessageBox.Show("No hay pokemon para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        Dictionary<Button, Image> imagenesOg = new Dictionary<Button, Image>();
        Dictionary<Button, Image> imagenesCk = new Dictionary<Button, Image>();
        List<Button> botonesClick = new List<Button>();
        int contadorClicks = 0;



        private void btVolverAtras_Click(object sender, EventArgs e)
        {
            Form InicioForm = Application.OpenForms["Opciones"];
            if (InicioForm != null)
            {
                InicioForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btManual_Click(object sender, EventArgs e)
        {
            ManualDeUsuario manualForm = new ManualDeUsuario();
            manualForm.ShowDialog();
        }
    }
}
