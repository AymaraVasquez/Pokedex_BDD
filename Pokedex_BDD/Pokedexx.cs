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
        public int pokemax = 0;
        public int pokemin = 0;
        public string whereconsulta;
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
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 13)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 13)";
            }
            cargar_Arrays();
            CargarPokemons();
        }
        public void ChequearAniadido()
        {
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }
        private void btInfo1_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[0].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo2_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[1].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo3_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[2].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo4_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[3].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo5_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[4].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo6_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[5].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo7_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[6].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }

        private void btInfo8_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            SesionIniciada.idPokeVer = PokemonsAVer[7].id;
            statsForm.ShowDialog();
            if (SesionIniciada.idPokeAniadir != 0)
            {
                this.Close();
            }
        }
        public void cargar_Arrays()
        {
            Conexion.conectar();
            string consulta;
            if (!String.IsNullOrEmpty(whereconsulta))
            {
                consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal`where " + whereconsulta + " limit 8 ";
            }
            else
            {
                consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` limit 8 ";
            }
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 0;
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
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
            cargar_Arrays();
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
            if (PokemonsAVer[7].imagen == null)
            {
                return;
            }
            LimpiarPokemons();
            Conexion.conectar();
            string consulta;
            if (String.IsNullOrEmpty(whereconsulta))
            {
                consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where id_poke > " + pokemax + " limit 8 ";
            }
            else
            {
                consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where id_poke > " + pokemax + " and " + whereconsulta + " limit 8 ";
            }
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 0;
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
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
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = -1;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
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
            string consulta;
            if (String.IsNullOrEmpty(whereconsulta))
            {
                consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where id_poke < " + pokemin + " order by id_poke desc limit 8 ";
            }
            else
            {
                consulta = "SELECT id_poke, nombre_poke, url_img FROM `pokedex_normal` where id_poke < " + pokemin + " and " + whereconsulta + " order by id_poke desc limit 8 ";
            }
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            int contador = 7;
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
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
            btInfo1.Visible = true;
            btInfo2.Visible = true;
            btInfo3.Visible = true;
            btInfo4.Visible = true;
            btInfo5.Visible = true;
            btInfo6.Visible = true;
            btInfo7.Visible = true;
            btInfo8.Visible = true;

            whereconsulta = "";
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
            while (Conex.Lector.Read())
            {
                PokemonsAVer[contador].id = Convert.ToInt32(Conex.Lector[0].ToString());
                pokemax = PokemonsAVer[contador].id;
                PokemonsAVer[contador].nombre = Conex.Lector[1].ToString();
                PokemonsAVer[contador].imagen = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
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

        private void btAgua_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 6)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 6)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btBicho_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 7)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 7)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btDragon_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 5)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 5)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btElectrico_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 10)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 10)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btFantasma_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 18)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 18)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btFuego_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 3)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 3)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btHada_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 15)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 15)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btHielo_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 14)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 14)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btLucha_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 16)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 16)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 8)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 8)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btPlanta_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 2)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 2)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btPsiquico_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 11)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 11)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btRoca_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 17)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 17)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btOscuro_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 9)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 9)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btTierra_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 12)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 12)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btVenenoso_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 1)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 1)";
            }
            cargar_Arrays();
            CargarPokemons();
        }

        private void btVolador_Click(object sender, EventArgs e)
        {
            LimpiarPokemons();
            if (String.IsNullOrEmpty(whereconsulta))
            {
                whereconsulta = "id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 4)";
            }
            else
            {
                whereconsulta += " and id_poke in (Select id_poke from rela_pokes_tipo where id_tipo = 4)";
            }
            cargar_Arrays();
            CargarPokemons();
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
}
