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

    public partial class Stats : Form
    {
        Conex Conexion = new Conex();
        public Image Pokimon;
        public int id = 0;
        public string nombre;
        public Image tipo1;
        public Image tipo2;
        public double altura;
        public double peso;
        public int generacion;
        public string Habilidad1;
        public string Habilidad2;
        public string HabilidadOculta;
        public int vida;
        public int ataque;
        public int defensa;
        public int atqEspecial;
        public int defEspecial;
        public int velocidad;
        public int statsTotales;
        public string color;
        public Color ColorHex;
        public Stats()
        {
            InitializeComponent();
        }

        int size = 0;
        public void progressBarChafa(int largo, int valor)
        {
            size = (largo * valor) / 200;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            if (CrearEquipos.anadirPokemon == true)
            {
                butAnadirEquipo.Visible = true;
            }
            else
            {
                butAnadirEquipo.Visible = false;
            }
            buttonAtras.Visible = false;
            btSiguiente.Visible = true;
            panel9.Visible = false;
            toolTip1.SetToolTip(this.butAnadirEquipo, "Agregar al Equipo");

            //Lo que vas a reemplazar con el valor de la base de datos es el 2do parametro
            // de la funcion lo demas de lo dejas igual

            Conexion.conectar();
            string consulta = "SELECT id_poke, nombre_poke, url_img, generacion, altura, peso, color, vida, ataque, defensa, ataque_especial, defensa_especial, velocidad, att_totales FROM pokedex_normal po join datos_generales_pokes da on po.id_datos_generales = da.id_datos_generales join estadisticas_pokes est on po.id_att = est.id_att where id_poke = " + SesionIniciada.idPokeVer.ToString();
            MySqlCommand comando3 = new MySqlCommand(consulta, Conex.Coneccion);
            Conex.Lector = comando3.ExecuteReader();
            ImageLoader Cargador = new ImageLoader();
            while (Conex.Lector.Read())
            {
                id = Convert.ToInt32(Conex.Lector[0].ToString());
                nombre = Conex.Lector[1].ToString();
                Pokimon = Cargador.DownloadImageFromUrl(Cargador.ConvertSharedLinkToDownloadLink(Conex.Lector[2].ToString()));
                generacion = Convert.ToInt32(Conex.Lector[3].ToString());
                altura = Convert.ToDouble(Conex.Lector[4].ToString());
                peso = Convert.ToDouble(Conex.Lector[5].ToString());
                color = Conex.Lector[6].ToString();
                vida = Convert.ToInt32(Conex.Lector[7].ToString());
                ataque = Convert.ToInt32(Conex.Lector[8].ToString());
                defensa = Convert.ToInt32(Conex.Lector[9].ToString());
                atqEspecial = Convert.ToInt32(Conex.Lector[10].ToString());
                defEspecial = Convert.ToInt32(Conex.Lector[11].ToString());
                velocidad = Convert.ToInt32(Conex.Lector[12].ToString());
                statsTotales = Convert.ToInt32(Conex.Lector[13].ToString());
            }
            Conexion.desconectar();

            //vida
            lbVida.Text = vida.ToString();
            progressBarChafa(173, vida);
            pbVida.Size = new Size(size, 14);
            pbVida.BackColor = Color.GreenYellow;
            size = 0;
            //Ataque
            lbAtaque.Text = ataque.ToString();
            progressBarChafa(161, ataque);
            pbAtaque.Size = new Size(size, 14);
            pbAtaque.BackColor = Color.Red;
            //Defensa
            lbDefensa.Text = defensa.ToString();
            progressBarChafa(155, defensa);
            pbDefensa.Size = new Size(size, 14);
            pbDefensa.BackColor = Color.Blue;
            //AtqEsp
            lbAtqEsp.Text = atqEspecial.ToString();
            progressBarChafa(122, atqEspecial);
            pbAtqEspecial.Size = new Size(size, 14);
            pbAtqEspecial.BackColor = Color.Orange;
            //DefEsp
            lbDefEsp.Text = defEspecial.ToString();
            progressBarChafa(122, defEspecial);
            pbDefEspecial.Size = new Size(size, 14);
            pbDefEspecial.BackColor = Color.Green;
            //Velocidad
            lbVelocidad.Text = velocidad.ToString();
            progressBarChafa(140, velocidad);
            pbVelocidad.Size = new Size(size, 14);
            pbVelocidad.BackColor = Color.Yellow;

            FoticoPokemon.Image = Pokimon;
            lbAltura.Text = altura.ToString() + " m";
            lbPeso.Text = peso.ToString() + " kg";
            lbAttTotal.Text = statsTotales.ToString();

            switch (color)
            {
                case "Black":
                    ColorHex = Color.FromArgb(35, 35, 35);
                    break;
                case "Blue":
                    ColorHex = Color.CornflowerBlue;
                    break;
                case "Brown":
                    ColorHex = Color.FromArgb(126, 96, 58);
                    break;
                case "Green":
                    ColorHex = Color.YellowGreen;
                    break;
                case "Grey":
                    ColorHex = Color.Gray;
                    break;
                case "Pink":
                    ColorHex = Color.Pink;
                    break;
                case "Purple":
                    ColorHex = Color.Orchid;
                    break;
                case "Red":
                    ColorHex = Color.Tomato;
                    break;
                case "White":
                    ColorHex = Color.GhostWhite;
                    break;
                case "Yellow":
                    ColorHex = Color.FromArgb(255, 222, 0);
                    break;
            }
            lbNombre.Text = nombre;
            lbGeneracion.Text = generacion.ToString();
            lbCodigo.Text = "#" + id.ToString();
            this.BackColor = ColorHex;
            panelHabi.BackColor = ColorHex;
            panelEstat.BackColor = ColorHex;
            panelMov.BackColor = ColorHex;
            buttonAtras.BackColor = ColorHex;
            btSiguiente.BackColor = ColorHex;

            if (ColorHex == Color.FromArgb(35, 35, 35) || ColorHex == Color.FromArgb(126, 96, 58)
            || ColorHex == Color.Orchid || ColorHex == Color.CornflowerBlue || ColorHex == Color.Tomato)
            {
                label1.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label39.ForeColor = Color.White;
                btSiguiente.ForeColor = Color.White;
                btSiguiente.BackColor = ColorHex;
                buttonAtras.ForeColor = Color.White;
                buttonAtras.BackColor = ColorHex;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label39.ForeColor = Color.Black;
                btSiguiente.ForeColor = Color.Black;
            }

            Conexion.conectar();
            string consulta2 = "SELECT hab.habilidad, rela.es_oculta FROM rela_poke_habilidad rela join habilidades hab on rela.id_habilidad = hab.id_habilidad where rela.id_poke = " + SesionIniciada.idPokeVer.ToString();
            MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
            Conex.Lector = comando2.ExecuteReader();
            int habilidadCount = 0;
            while (Conex.Lector.Read())
            {
                if (Conex.Lector[1].ToString() == "True")
                {
                    lbHabilidadOculta.Text = Conex.Lector[0].ToString();
                }
                else if (habilidadCount == 0)
                {
                    lbHabilidad1.Text = Conex.Lector[0].ToString();
                    habilidadCount++;

                }
                else
                {
                    lbHabilidad2.Text = Conex.Lector[0].ToString();
                    label11.Visible = false;
                }
            }
            Conexion.desconectar();

            Conexion.conectar();
            string consulta4 = "SELECT ti.tipo FROM rela_pokes_tipo rela join tipos ti on rela.id_tipo = ti.id_tipo where rela.id_poke = " + SesionIniciada.idPokeVer.ToString();
            MySqlCommand comando4 = new MySqlCommand(consulta4, Conex.Coneccion);
            Conex.Lector = comando4.ExecuteReader();
            int tipoCount = 0;
            while (Conex.Lector.Read())
            {
                if (tipoCount == 0)
                {
                    pbTipo1.Image = ImagenTipo(Conex.Lector[0].ToString());
                }
                else
                {
                    pbTipo2.Image = ImagenTipo(Conex.Lector[0].ToString());
                }
                tipoCount++;
            }
            if (tipoCount == 1)
            {
                pbTipo2.Visible = false;
            }
            Conexion.desconectar();
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
        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btSiguiente_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            buttonAtras.Visible = true;
            btSiguiente.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            buttonAtras.Visible = false;
            btSiguiente.Visible = true;

        }

        private void butAnadirEquipo_Click(object sender, EventArgs e)
        {
            SesionIniciada.idPokeAniadir = id;
            this.Close();
        }
    }
}
