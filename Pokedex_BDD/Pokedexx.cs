using CargarBDDPokemon;
using MySql.Data.MySqlClient;
using Pokedex.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Pokedexx : Form
    {
        Conex Conexion = new Conex();
        PokemonVer[] PokemonsAVer = new PokemonVer[8];
        public int pokemax;
        public int pokemin;
        public Pokedexx()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.btAcero, "Tipo Acero");
            toolTip2.SetToolTip(this.btAgua, "Tipo Agua");
            toolTip3.SetToolTip(this.btBicho, "Tipo Bicho");
            toolTip4.SetToolTip(this.btDragon, "Tipo Dragon");
            toolTip5.SetToolTip(this.btElectrico, "Tipo Electrico");
            toolTip6.SetToolTip(this.btFantasma, "Tipo Fantasma");
            toolTip7.SetToolTip(this.btFuego, "Tipo Fuego");
            toolTip8.SetToolTip(this.btHada, "Tipo Hada");
            toolTip9.SetToolTip(this.btHielo, "Tipo Hielo");
            toolTip10.SetToolTip(this.btLucha, "Tipo Lucha");
            toolTip11.SetToolTip(this.btNormal, "Tipo Normal");
            toolTip12.SetToolTip(this.btPlanta, "Tipo Planta");
            toolTip13.SetToolTip(this.btPsiquico, "Tipo Psiquico");
            toolTip14.SetToolTip(this.btRoca, "Tipo Roca");
            toolTip15.SetToolTip(this.btOscuro, "Tipo Siniestro");
            toolTip16.SetToolTip(this.btTierra, "Tipo Tierra");
            toolTip17.SetToolTip(this.btVenenoso, "Tipo Venenoso");
            toolTip18.SetToolTip(this.btVolador, "Tipo Volador");
            PokemonsAVer[0] = new PokemonVer();
            PokemonsAVer[1] = new PokemonVer();
            PokemonsAVer[2] = new PokemonVer();
            PokemonsAVer[3] = new PokemonVer();
            PokemonsAVer[4] = new PokemonVer();
            PokemonsAVer[5] = new PokemonVer();
            PokemonsAVer[6] = new PokemonVer();
            PokemonsAVer[7] = new PokemonVer();
        }

        private void btAcero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si funciona el boton");
        }

        private void btInfo1_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[0].id;
            statsForm.ShowDialog();
        }

        private void btInfo2_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[1].id;
            statsForm.ShowDialog();
        }

        private void btInfo3_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[2].id;
            statsForm.ShowDialog();
        }

        private void btInfo4_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[3].id;
            statsForm.ShowDialog();
        }

        private void btInfo5_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[4].id;
            statsForm.ShowDialog();
        }

        private void btInfo6_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[5].id;
            statsForm.ShowDialog();
        }

        private void btInfo7_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[6].id;
            statsForm.ShowDialog();
        }

        private void btInfo8_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[7].id;
            statsForm.ShowDialog();
        }

        private void Pokedexx_Load(object sender, EventArgs e)
        {
            if (CrearEquipos.anadirPokemon == true)
            {
                //labInstruccion.Visible = true;
            }
            else
            {
                //labInstruccion.Visible = false;
            }
            Conexion.conectar();
            string consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` limit 8";
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 0;
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[2].ToString()));
                contador++;
            }
            Conexion.desconectar();
            for (int i = 0; i < 8; i++)
            {
                Conexion.conectar();
                string consulta2 = "SELECT ti.tipo FROM rela_pokes_tipo rela join tipos ti on rela.id_tipo = ti.id_tipo WHERE rela.id_poke = " + PokemonsAVer[i].id;
                MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
                Conex.Lector = comando2.ExecuteReader();
                int contador2 = 0;
                while (Conex.Lector.Read())
                {
                    if (PokemonsAVer[i].Tipo1 == null)
                    {
                        PokemonsAVer[i].Tipo1 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                    else
                    {
                        PokemonsAVer[i].Tipo2 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                }
                Conexion.desconectar();
            }
            CargarPokemons();
        }

        public void BusquedaSinPokemon(int num)
        {
            Foto3.Image = Properties.Resources.pokebola;
            lbCodigo3.Text = "###";
            lbNombre3.Text = "Pokemon Oculto";
            pbTipo3_1.Image = Properties.Resources.question;
            pbTipo3_2.Image = Properties.Resources.question;
        }
        public void CargarPokemons()
        {
            //Panel1
            if (PokemonsAVer[0].imagen == null)
            {
                Foto1.Image = Properties.Resources.pokeball;
                lbCodigo1.Text = "#####";
                lbNombre1.Text = "Pokemon Oculto";
                pbTipo1_1.Image = Properties.Resources.questi;
                pbTipo1_2.Image = Properties.Resources.questi;
                btInfo1.Visible = false;

            }
            else
            {
                Foto1.Image = PokemonsAVer[0].imagen;
                lbCodigo1.Text = "#" + PokemonsAVer[0].id;
                lbNombre1.Text = PokemonsAVer[0].nombre;
                pbTipo1_1.Image = PokemonsAVer[0].Tipo1;
                pbTipo1_2.Image = PokemonsAVer[0].Tipo2;
                if (PokemonsAVer[0].Tipo1 == null)
                {
                    pbTipo1_2.Visible = false;
                }
                else
                {
                    pbTipo1_2.Visible = true;
                }
            }


            //Panel2
            if (PokemonsAVer[1].imagen == null)
            {
                Foto2.Image = Properties.Resources.pokeball;
                lbCodigo2.Text = "#####";
                lbNombre2.Text = "Pokemon Oculto";
                pbTipo2_1.Image = Properties.Resources.questi;
                pbTipo2_2.Image = Properties.Resources.questi;
                btInfo2.Visible = false;

            }
            else
            {
                Foto2.Image = PokemonsAVer[1].imagen;
                lbCodigo2.Text = "#" + PokemonsAVer[1].id;
                lbNombre2.Text = PokemonsAVer[1].nombre;
                pbTipo2_1.Image = PokemonsAVer[1].Tipo1;
                pbTipo2_2.Image = PokemonsAVer[1].Tipo2;
                if (PokemonsAVer[1].Tipo1 == null)
                {
                    pbTipo2_2.Visible = false;
                }
                else
                {
                    pbTipo2_2.Visible = true;
                }
            }

            //Panel3
            if (PokemonsAVer[2].imagen == null)
            {
                Foto3.Image = Properties.Resources.pokeball;
                lbCodigo3.Text = "#####";
                lbNombre3.Text = "Pokemon Oculto";
                pbTipo3_1.Image = Properties.Resources.questi;
                pbTipo3_2.Image = Properties.Resources.questi;
                btInfo3.Visible = false;

            }
            else
            {
                Foto3.Image = PokemonsAVer[2].imagen;
                lbCodigo3.Text = "#" + PokemonsAVer[2].id;
                lbNombre3.Text = PokemonsAVer[2].nombre;
                pbTipo3_1.Image = PokemonsAVer[2].Tipo1;
                pbTipo3_2.Image = PokemonsAVer[2].Tipo2;
                if (PokemonsAVer[2].Tipo1 == null)
                {
                    pbTipo3_2.Visible = false;
                }
                else
                {
                    pbTipo3_2.Visible = true;
                }
            }

            //Panel4
            if (PokemonsAVer[3].imagen == null)
            {
                Foto4.Image = Properties.Resources.pokeball;
                lbCodigo4.Text = "#####";
                lbNombre4.Text = "Pokemon Oculto";
                pbTipo4_1.Image = Properties.Resources.questi;
                pbTipo4_2.Image = Properties.Resources.questi;
                btInfo4.Visible = false;

            }
            else
            {
                Foto4.Image = PokemonsAVer[3].imagen;
                lbCodigo4.Text = "#" + PokemonsAVer[3].id;
                lbNombre4.Text = PokemonsAVer[3].nombre;
                pbTipo4_1.Image = PokemonsAVer[3].Tipo1;
                pbTipo4_2.Image = PokemonsAVer[3].Tipo2;
                if (PokemonsAVer[3].Tipo1 == null)
                {
                    pbTipo4_2.Visible = false;
                }
                else
                {
                    pbTipo4_2.Visible = true;
                }
            }

            //Panel5
            if (PokemonsAVer[4].imagen == null)
            {
                Foto5.Image = Properties.Resources.pokeball;
                lbCodigo5.Text = "#####";
                lbNombre5.Text = "Pokemon Oculto";
                pbTipo5_1.Image = Properties.Resources.questi;
                pbTipo5_2.Image = Properties.Resources.questi;
                btInfo5.Visible = false;

            }
            else
            {
                Foto5.Image = PokemonsAVer[4].imagen;
                lbCodigo5.Text = "#" + PokemonsAVer[4].id;
                lbNombre5.Text = PokemonsAVer[4].nombre;
                pbTipo5_1.Image = PokemonsAVer[4].Tipo1;
                pbTipo5_2.Image = PokemonsAVer[4].Tipo2;
                if (PokemonsAVer[4].Tipo1 == null)
                {
                    pbTipo5_2.Visible = false;
                }
                else
                {
                    pbTipo5_2.Visible = true;
                }
            }

            //Panel6
            if (PokemonsAVer[5].imagen == null)
            {
                Foto6.Image = Properties.Resources.pokeball;
                lbCodigo6.Text = "#####";
                lbNombre6.Text = "Pokemon Oculto";
                pbTipo6_1.Image = Properties.Resources.questi;
                pbTipo6_2.Image = Properties.Resources.questi;
                btInfo6.Visible = false;

            }
            else
            {
                Foto6.Image = PokemonsAVer[5].imagen;
                lbCodigo6.Text = "#" + PokemonsAVer[5].id;
                lbNombre6.Text = PokemonsAVer[5].nombre;
                pbTipo6_1.Image = PokemonsAVer[5].Tipo1;
                pbTipo6_2.Image = PokemonsAVer[5].Tipo2;
                if (PokemonsAVer[5].Tipo1 == null)
                {
                    pbTipo6_2.Visible = false;
                }
                else
                {
                    pbTipo6_2.Visible = true;
                }
            }


            //Panel7
            if (PokemonsAVer[6].imagen == null)
            {
                Foto7.Image = Properties.Resources.pokeball;
                lbCodigo7.Text = "#####";
                lbNombre7.Text = "Pokemon Oculto";
                pbTipo7_1.Image = Properties.Resources.questi;
                pbTipo7_2.Image = Properties.Resources.questi;
                btInfo7.Visible = false;

            }
            else
            {
                Foto7.Image = PokemonsAVer[6].imagen;
                lbCodigo7.Text = "#" + PokemonsAVer[6].id;
                lbNombre7.Text = PokemonsAVer[6].nombre;
                pbTipo7_1.Image = PokemonsAVer[6].Tipo1;
                pbTipo7_2.Image = PokemonsAVer[6].Tipo2;
                if (PokemonsAVer[6].Tipo1 == null)
                {
                    pbTipo7_2.Visible = false;
                }
                else
                {
                    pbTipo7_2.Visible = true;
                }
            }

            //Panel8
            if (PokemonsAVer[7].imagen == null)
            {
                Foto8.Image = Properties.Resources.pokeball;
                lbCodigo8.Text = "#####";
                lbNombre8.Text = "Pokemon Oculto";
                pbTipo8_1.Image = Properties.Resources.questi;
                pbTipo8_2.Image = Properties.Resources.questi;
                btInfo8.Visible = false;

            }
            else
            {
                Foto8.Image = PokemonsAVer[7].imagen;
                lbCodigo8.Text = "#" + PokemonsAVer[7].id;
                lbNombre8.Text = PokemonsAVer[7].nombre;
                pbTipo8_1.Image = PokemonsAVer[7].Tipo1;
                pbTipo8_2.Image = PokemonsAVer[7].Tipo2;
                if (PokemonsAVer[7].Tipo1 == null)
                {
                    pbTipo8_2.Visible = false;
                }
                else
                {
                    pbTipo8_2.Visible = true;
                }
            }
        }
        public Image ImagenTipo(string Tipo)
        {
            switch (Tipo.ToLower())
            {
                case "poison":
                    return Resources.TipoVenenoso;
                case "grass":
                    return Resources.TipoPlanta;
                case "fire":
                    return Resources.TipoFuego;
                case "flying":
                    return Resources.TipoVolador;
                case "dragon":
                    return Resources.TipoDragon;
                case "water":
                    return Resources.TipoAgua;
                case "bug":
                    return Resources.TipoBicho;
                case "normal":
                    return Resources.TipoNormal;
                case "dark":
                    return Resources.TipoSiniestro;
                case "electric":
                    return Resources.TipoElectrico;
                case "psychic":
                    return Resources.TipoPsiquico;
                case "ground":
                    return Resources.TipoTierra;
                case "steel":
                    return Resources.TipoAcero;
                case "ice":
                    return Resources.TipoHielo;
                case "fairy":
                    return Resources.TipoHada;
                case "fighting":
                    return Resources.TipoLucha;
                case "rock":
                    return Resources.TipoRoca;
                case "ghost":
                    return Resources.TipoFantasma;
                default:
                    return null; // O una imagen por defecto
            }
        }
        public void LimpiarPokemons()
        {
            PokemonsAVer[0] = new PokemonVer();
            PokemonsAVer[1] = new PokemonVer();
            PokemonsAVer[2] = new PokemonVer();
            PokemonsAVer[3] = new PokemonVer();
            PokemonsAVer[4] = new PokemonVer();
            PokemonsAVer[5] = new PokemonVer();
            PokemonsAVer[6] = new PokemonVer();
            PokemonsAVer[7] = new PokemonVer();
        }
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            Conexion.conectar();
            string consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where id_poke > " + pokemax + " limit 8";
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 0;
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[2].ToString()));
                contador++;
            }
            Conexion.desconectar();
            for (int i = 0; i < 8; i++)
            {
                Conexion.conectar();
                string consulta2 = "SELECT ti.tipo FROM rela_pokes_tipo rela join tipos ti on rela.id_tipo = ti.id_tipo WHERE rela.id_poke = " + PokemonsAVer[i].id;
                MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
                Conex.Lector = comando2.ExecuteReader();
                int contador2 = 0;
                while (Conex.Lector.Read())
                {
                    if (PokemonsAVer[i].Tipo1 == null)
                    {
                        PokemonsAVer[i].Tipo1 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                    else
                    {
                        PokemonsAVer[i].Tipo2 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                }
                Conexion.desconectar();
            }
            CargarPokemons();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            Conexion.conectar();
            string consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where nombre_poke like '%" + tbBarraBusqueda.Text + "%' limit 8";
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 0;
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = -1;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[2].ToString()));
                contador++;
            }
            Conexion.desconectar();
            for (int i = 0; i < 8; i++)
            {
                Conexion.conectar();
                string consulta2 = "SELECT ti.tipo FROM rela_pokes_tipo rela join tipos ti on rela.id_tipo = ti.id_tipo WHERE rela.id_poke = " + PokemonsAVer[i].id;
                MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
                Conex.Lector = comando2.ExecuteReader();
                int contador2 = 0;
                while (Conex.Lector.Read())
                {
                    if (PokemonsAVer[i].Tipo1 == null)
                    {
                        PokemonsAVer[i].Tipo1 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                    else
                    {
                        PokemonsAVer[i].Tipo2 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                }
                Conexion.desconectar();
            }
            CargarPokemons();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            pokemin = PokemonsAVer[0].id - 1;
            LimpiarPokemons();
            Conexion.conectar();
            string consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where id_poke < " + pokemin + " order by id_poke desc limit 8 ";
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 7;
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[2].ToString()));
                contador--;
            }
            Conexion.desconectar();
            for (int i = 0; i < 8; i++)
            {
                Conexion.conectar();
                string consulta2 = "SELECT ti.tipo FROM rela_pokes_tipo rela join tipos ti on rela.id_tipo = ti.id_tipo WHERE rela.id_poke = " + PokemonsAVer[i].id;
                MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
                Conex.Lector = comando2.ExecuteReader();
                int contador2 = 0;
                while (Conex.Lector.Read())
                {
                    if (PokemonsAVer[i].Tipo1 == null)
                    {
                        PokemonsAVer[i].Tipo1 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                    else
                    {
                        PokemonsAVer[i].Tipo2 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                }
                Conexion.desconectar();
            }
            CargarPokemons();
        }

        private void pcbPokedex_Click(object sender, EventArgs e)
        {
            tbBarraBusqueda.Text = "";
            if (CrearEquipos.anadirPokemon == true)
            {
                //labInstruccion.Visible = true;
            }
            else
            {
                //labInstruccion.Visible = false;
            }
            Conexion.conectar();
            string consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` limit 8";
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 0;
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[2].ToString()));
                contador++;
            }
            Conexion.desconectar();
            for (int i = 0; i < 8; i++)
            {
                Conexion.conectar();
                string consulta2 = "SELECT ti.tipo FROM rela_pokes_tipo rela join tipos ti on rela.id_tipo = ti.id_tipo WHERE rela.id_poke = " + PokemonsAVer[i].id;
                MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
                Conex.Lector = comando2.ExecuteReader();
                int contador2 = 0;
                while (Conex.Lector.Read())
                {
                    if (PokemonsAVer[i].Tipo1 == null)
                    {
                        PokemonsAVer[i].Tipo1 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                    else
                    {
                        PokemonsAVer[i].Tipo2 = ImagenTipo(Conex.Lector[0].ToString());
                    }
                }
                Conexion.desconectar();
            }
            CargarPokemons();
        }

        private void btManual_Click(object sender, EventArgs e)
        {
            ManualDeUsuario manualForm = new ManualDeUsuario();
            manualForm.ShowDialog();
        }
    }

    public class PokemonVer
    {
        public string nombre;
        public int id;
        public Image imagen;
        public Image Tipo1;
        public Image Tipo2;
        // Contructor con todo null
        public PokemonVer()
        {
            this.nombre = null;
            this.id = 0;
            this.imagen = null;
            this.Tipo1 = null;
            this.Tipo2 = null;
        }
    }

    public class ImageLoader
    {
        public void LoadImageFromDriveUrl(PictureBox pictureBox, string sharedUrl)
        {
            try
            {
                // 1. Obtener la URL de la base de datos
                if (!string.IsNullOrEmpty(sharedUrl))
                {
                    // 2. Convertir el enlace compartido a enlace de descarga directa
                    string downloadUrl = ConvertSharedLinkToDownloadLink(sharedUrl);

                    // 3. Descargar la imagen desde la URL
                    Image image = DownloadImageFromUrl(downloadUrl);

                    // 4. Asignar la imagen al PictureBox
                    pictureBox.Image = image;
                }
                else
                {
                    pictureBox.Image = null;
                    MessageBox.Show("No se encontró la URL de la imagen en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                pictureBox.Image = null;
            }
        }


        public string ConvertSharedLinkToDownloadLink(string sharedUrl)
        {
            // Extraer el ID del archivo de la URL compartida
            int startIndex = sharedUrl.IndexOf("/d/") + 3;
            int endIndex = sharedUrl.IndexOf("/", startIndex);

            if (endIndex == -1)
                endIndex = sharedUrl.IndexOf("?", startIndex);

            if (endIndex == -1)
                endIndex = sharedUrl.Length;

            string fileId = sharedUrl.Substring(startIndex, endIndex - startIndex);

            // Crear URL de descarga directa
            return $"https://drive.google.com/uc?export=download&id={fileId}";
        }

        public Image DownloadImageFromUrl(string imageUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                // Configurar credenciales si es necesario (para archivos con restricciones)
                webClient.UseDefaultCredentials = true;

                // Descargar los bytes de la imagen
                byte[] imageBytes = webClient.DownloadData(imageUrl);

                // Convertir los bytes a Image
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }
    }
}
