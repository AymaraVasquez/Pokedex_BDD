using CargarBDDPokemon;
using MySql.Data.MySqlClient;
using Pokedex.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public movimiento[] movimientos = new movimiento[4];
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
            while (Conex.Lector.Read())
            {
                id = Convert.ToInt32(Conex.Lector[0].ToString());
                nombre = Conex.Lector[1].ToString();
                Pokimon = BuscarImagen.DeStringAImage(Conex.Lector[0].ToString());
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
                label24.ForeColor = Color.White;
                label33.ForeColor = Color.White;
                lbNombreMov1.ForeColor = Color.White;
                lbNombreMov2.ForeColor = Color.White;
                lBNombreMov3.ForeColor = Color.White;
                lbNombreMov4.ForeColor = Color.White;
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

            // Cargar movimientos
            Conexion.conectar();
            string consulta3 = "SELECT mo.nombre_movimiento, mo.potencia, mo.poke_precision, ti.tipo from movimientos mo join tipos ti on mo.id_tipo = ti.id_tipo where mo.id_movimiento in (SELECT id_movimiento FROM rela_poke_movimiento where id_poke = "+id.ToString()+") ORDER BY mo.id_movimiento asc";
            MySqlCommand comandomov = new MySqlCommand(consulta3, Conex.Coneccion);
            Conex.Lector = comandomov.ExecuteReader();
            int i = 0;
            while (Conex.Lector.Read())
            {
                movimientos[i] = new movimiento(Conex.Lector[0].ToString(), Convert.ToInt32(Conex.Lector[1].ToString()), Convert.ToInt32(Conex.Lector[2].ToString()), ImagenTipo(Conex.Lector[3].ToString()));
                i++;
            }
            Conexion.desconectar();

            // Cargar movimientos en el panel
            if (movimientos[0] != null)
            {
                lbNombreMov1.Text = movimientos[0].nombre;
                lbPotMov1.Text = movimientos[0].potencia.ToString();
                lbPrecisionMov1.Text = movimientos[0].precision.ToString();
                pbTipoMov1.Image = movimientos[0].tipo;
            }
            else
            {
                panelMov1.Visible = false;
                lbNombreMov1.Visible = false;
                lbPotMov1.Visible = false;
                lbPrecisionMov1.Visible = false;
                pbTipoMov1.Visible = false;
            }

            panel19.BackColor = ColorHex;
            panelMov1.BackColor = ColorHex;
            panelMov3.BackColor = ColorHex;
            panelMov4.BackColor = ColorHex;

            if (movimientos[1] != null)
            {
                panelMov2.BackColor = ColorHex;
                lbNombreMov2.Text = movimientos[1].nombre;
                lbPotMov2.Text = movimientos[1].potencia.ToString();
                lbPrecisionMov2.Text = movimientos[1].precision.ToString();
                pbTipoMov2.Image = movimientos[1].tipo;
            }
            else
            {
                panelMov2.Visible = false;
                lbNombreMov2.Visible = false;
                lbPotMov2.Visible = false;
                lbPrecisionMov2.Visible = false;
                pbTipoMov2.Visible = false;
            }

            if (movimientos[2] != null)
            {
                lBNombreMov3.Text = movimientos[2].nombre;
                lbPotMov3.Text = movimientos[2].potencia.ToString();
                lbPrecisionMov3.Text = movimientos[2].precision.ToString();
                pbTipoMov3.Image = movimientos[2].tipo;
            }
            else
            {
                panelMov3.Visible = false;
                lBNombreMov3.Visible = false;
                lbPotMov3.Visible = false;
                lbPrecisionMov3.Visible = false;
                pbTipoMov3.Visible = false;
            }

            if (movimientos[3] != null)
            {
                lbNombreMov4.Text = movimientos[3].nombre;
                lbPotMov4.Text = movimientos[3].potencia.ToString();
                lbPrecisionMov4.Text = movimientos[3].precision.ToString();
                pbTipoMov4.Image = movimientos[3].tipo;
            } else
            {
                panelMov4.Visible = false;
                lbNombreMov4.Visible = false;
                lbPotMov4.Visible = false;
                lbPrecisionMov4.Visible = false;
                pbTipoMov4.Visible = false;
                panel24.Visible = false;
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
    public class movimiento
    {
        public string nombre;
        public int potencia;
        public int precision;
        public Image tipo;
        public movimiento(string nombre, int potencia, int precision, Image tipo)
        {
            this.nombre = nombre;
            this.potencia = potencia;
            this.precision = precision;
            this.tipo = tipo;
        }
    }
}
