using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarBDDPokemon
{
    public class tipos_pokes
    {
        public int id { get; set; }
        public string tipo1 { get; set; }
        public string tipo2 { get; set; }
        public tipos_pokes(int id, string tipo1, string tipo2)
        {
            this.id = id;
            this.tipo1 = tipo1;
            this.tipo2 = tipo2;
        }
    }
    public class habilidad_pokes
    {
        public int id { get; set; }
        public string habilidad1 { get; set; }
        public string habilidad2 { get; set; }
        public string habilidadOculta { get; set; }

        public habilidad_pokes(int id, string habilidad1, string habilidad2, string habilidadOculta)
        {
            this.id = id;
            this.habilidad1 = habilidad1;
            this.habilidad2 = habilidad2;
            this.habilidadOculta = habilidadOculta;
        }
    }
    public class datosGeneralesPokes
    {
        public int id { get; set; }
        public int generacion { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }
        public string color { get; set; }
        public int legendario { get; set; }
        public int megaEvolucion { get; set; }
        public datosGeneralesPokes(int id, int generacion, double altura, double peso, string color, int legendario, int megaEvolucion)
        {
            this.id = id;
            this.generacion = generacion;
            this.altura = altura;
            this.peso = peso;
            this.color = color;
            this.legendario = legendario;
            this.megaEvolucion = megaEvolucion;
        }
    }
    public class estadisticas_pokes
    {
        public int id { get; set; }
        public int hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataqueEspecial { get; set; }
        public int defensaEspecial { get; set; }
        public int velocidad { get; set; }
        public int total;
        public estadisticas_pokes(int id, int hp, int ataque, int defensa, int ataqueEspecial, int defensaEspecial, int velocidad, int total)
        {
            this.id = id;
            this.hp = hp;
            this.ataque = ataque;
            this.defensa = defensa;
            this.ataqueEspecial = ataqueEspecial;
            this.defensaEspecial = defensaEspecial;
            this.velocidad = velocidad;
            this.total = total;
        }
    }
    public class tablaNormal
    {
        public int id_poke;
        public string nombre_poke;
        public int codigo;
        public int id_tipo;
        public int id_habilidades;
        public int id_datos_generales;
        public int id_att;
        public tablaNormal (int id_poke, string nombre_poke, int codigo, int id_tipo, int id_habilidades, int id_datos_generales, int id_att)
        {
            this.id_poke = id_poke;
            this.nombre_poke = nombre_poke;
            this.codigo = codigo;
            this.id_tipo = id_tipo;
            this.id_habilidades = id_habilidades;
            this.id_datos_generales = id_datos_generales;
            this.id_att = id_att;
        }
    }
}