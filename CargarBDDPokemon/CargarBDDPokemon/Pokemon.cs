using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CargarBDDPokemon
{
    public class Pokemon
    {
        public static string RutaEspero = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pokemon.csv");
        public int id;
        public int codigo;
        public int code_poke;
        public string nombre;
        public string tipo1;
        public string tipo2;
        public string habilidad1;
        public string habilidad2;
        public string habilidadOculta;
        public int generacion;
        public int legendario;
        public int megaEvolucion;
        public double altura;
        public double peso;
        public string color;
        public int vida;
        public int ataque;
        public int defensa;
        public int ataqueEspecial;
        public int defensaEspecial;
        public int velocidad;
        public int total;
        public Pokemon(int id, int codigo, int codePoke, string nombre, string tipo1, string tipo2, string habilidad1, string habilidad2, string habilidadOculta, int generacion, int legendario, int megaEvolucion, double altura, double peso, int vida, int ataque, int defensa, int ataqueEspecial, int defensaEspecial, int velocidad, int totales)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.tipo1 = tipo1;
            this.tipo2 = tipo2;
            this.habilidad1 = habilidad1;
            this.habilidad2 = habilidad2;
            this.habilidadOculta = habilidadOculta;
            this.generacion = generacion;
            this.legendario = legendario;
            this.megaEvolucion = megaEvolucion;
            this.altura = altura;
            this.peso = peso;
            this.vida = vida;
            this.ataque = ataque;
            this.defensa = defensa;
            this.ataqueEspecial = ataqueEspecial;
            this.defensaEspecial = defensaEspecial;
            this.velocidad = velocidad;
            this.total = totales;
            this.code_poke = codePoke;
        }
        public Pokemon()
        {
            // Constructor por defecto
        }
        public static List<Pokemon> LeerProductos()
        {
            List<Pokemon> usuarios = new List<Pokemon>();

            try
            {
                if (File.Exists(RutaEspero))
                {
                    using (StreamReader leyendo = new StreamReader(RutaEspero))
                    {
                        string? linea;
                        while ((linea = leyendo.ReadLine()) != null)
                        {
                            string[] columnas = linea.Split('.');
                            if (columnas.Length == 22)
                            {
                                Pokemon user = new Pokemon
                                {
                                    id = int.Parse(columnas[0]),
                                    codigo = int.Parse(columnas[1]),
                                    code_poke = int.Parse(columnas[2]),
                                    nombre = columnas[3],
                                    tipo1 = columnas[4],
                                    tipo2 = columnas[5],
                                    color = columnas[6],
                                    habilidad1 = columnas[7],
                                    habilidad2 = columnas[8],
                                    habilidadOculta = columnas[9],
                                    generacion = int.Parse(columnas[10]),
                                    legendario = int.Parse(columnas[11]),
                                    megaEvolucion = int.Parse(columnas[12]),
                                    altura = double.Parse(columnas[13]),
                                    peso = double.Parse(columnas[14]),
                                    vida = int.Parse(columnas[15]),
                                    ataque = int.Parse(columnas[16]),
                                    defensa = int.Parse(columnas[17]),
                                    ataqueEspecial = int.Parse(columnas[18]),
                                    defensaEspecial = int.Parse(columnas[19]),
                                    velocidad = int.Parse(columnas[20]),
                                    total = int.Parse(columnas[21])
                                };
                                usuarios.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
            return usuarios;
        }
    }
}
