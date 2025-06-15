using MySql.Data.MySqlClient;
using System.Data;

namespace CargarBDDPokemon
{
    public partial class Form1 : Form
    {
        public Conex Conexion = new Conex();
        public List<Pokemon> pokemons = Pokemon.LeerProductos();
        public List<tipos_pokes> tipos = new List<tipos_pokes>();
        public List<habilidad_pokes> habilidades = new List<habilidad_pokes>();
        public List<datosGeneralesPokes> datosGenerales = new List<datosGeneralesPokes>();
        public List<estadisticas_pokes> estadisticas = new List<estadisticas_pokes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pokemons = Pokemon.LeerProductos();
            rellenarListas();
        }
        public bool existeTipo(string tipo1, string tipo2)
        {
            foreach (tipos_pokes poke in tipos)
            {
                if (poke.tipo1 == tipo1 && poke.tipo2 == tipo2)
                {
                    return true;
                }
            }
            return false;
        }
        public bool existeHabilidad(string habilidad1, string habilidad2, string habilidadOculta)
        {
            foreach (habilidad_pokes poke in habilidades)
            {
                if (poke.habilidad1 == habilidad1 && poke.habilidad2 == habilidad2 && poke.habilidadOculta == habilidadOculta)
                {
                    return true;
                }
            }
            return false;
        }
        public bool existeDatosGenerales(int generacion, int legendario, int megaEvolucion, double altura, double peso)
        {
            foreach (datosGeneralesPokes poke in datosGenerales)
            {
                if (poke.generacion == generacion && poke.legendario == legendario && poke.megaEvolucion == megaEvolucion && poke.altura == altura && poke.peso == peso)
                {
                    return true;
                }
            }
            return false;
        }
        public bool existeEstadisticas(int vida, int ataque, int defensa, int ataqueEspecial, int defensaEspecial, int velocidad)
        {
            foreach (estadisticas_pokes poke in estadisticas)
            {
                if (poke.hp == vida && poke.ataque == ataque && poke.defensa == defensa && poke.ataqueEspecial == ataqueEspecial && poke.defensaEspecial == defensaEspecial && poke.velocidad == velocidad)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            if (Conex.Coneccion.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion abierta", "Mira Monstruo");
            }
            foreach (Pokemon pokes in pokemons)
            {
                string consulta = "INSERT INTO pokedex (id,codigo,nombre,tipo1,tipo2,habilidad1,habilidad2,habilidad_oculta,generacion,legendario,mega_evolucion,altura,peso,vida,ataque,defensa,ataque_especial,defensa_especial,velocidad,att_totales) VALUES (" + pokes.id + "," + pokes.codigo + ",'" + pokes.nombre + "','" + pokes.tipo1 + "','" + pokes.tipo2 + "','" + pokes.habilidad1 + "','" + pokes.habilidad2 + "','" + pokes.habilidadOculta + "'," + pokes.generacion + "," + pokes.legendario + "," + pokes.megaEvolucion + "," + pokes.altura + "," + pokes.peso + "," + pokes.vida + "," + pokes.ataque + "," + pokes.defensa + "," + pokes.ataqueEspecial + "," + pokes.defensaEspecial + "," + pokes.velocidad + "," + pokes.total + ");";

                using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
                {
                    cmd.Parameters.AddWithValue("id", pokes.id);
                    cmd.Parameters.AddWithValue("codigo", pokes.codigo);
                    cmd.Parameters.AddWithValue("nombre", pokes.nombre);
                    cmd.Parameters.AddWithValue("tipo1", pokes.tipo1);
                    cmd.Parameters.AddWithValue("tipo2", (object)pokes.tipo2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("habilidad1", pokes.habilidad1);
                    cmd.Parameters.AddWithValue("habilidad2", (object)pokes.habilidad2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("habilidad_oculta", pokes.habilidadOculta);
                    cmd.Parameters.AddWithValue("generacion", pokes.generacion);
                    cmd.Parameters.AddWithValue("legendario", pokes.legendario);
                    cmd.Parameters.AddWithValue("mega_evolucion", pokes.megaEvolucion);
                    cmd.Parameters.AddWithValue("altura", pokes.altura);
                    cmd.Parameters.AddWithValue("peso", pokes.peso);
                    cmd.Parameters.AddWithValue("vida", pokes.vida);
                    cmd.Parameters.AddWithValue("ataque", pokes.ataque);
                    cmd.Parameters.AddWithValue("defensa", pokes.defensa);
                    cmd.Parameters.AddWithValue("ataque_especial", pokes.ataqueEspecial);
                    cmd.Parameters.AddWithValue("defensa_especial", pokes.defensaEspecial);
                    cmd.Parameters.AddWithValue("velocidad", pokes.velocidad);
                    cmd.Parameters.AddWithValue("att_totales", pokes.total);

                    cmd.ExecuteNonQuery();
                }

                //MySqlCommand comando = new MySqlCommand(consulta, Conex.Coneccion);
                //Conex.Lector = comando.ExecuteReader();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            if (Conex.Coneccion.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion abierta", "Mira Monstruo");
            }
            // Aca cargo los fokin tipos de pokes
            //foreach (tipos_pokes pokes in tipos)
            //{
            //    if (pokes.id <= 0)
            //    { 
            //        continue;
            //    }
            //    string consulta = "INSERT INTO tipos_pokes (id_tipo,tipo1,tipo2) VALUES (" + pokes.id + ",'" + pokes.tipo1 + "','" + pokes.tipo2 + "');";

            //    using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id", pokes.id);
            //        cmd.Parameters.AddWithValue("tipo1", pokes.tipo1);
            //        cmd.Parameters.AddWithValue("tipo2", (object)pokes.tipo2 ?? DBNull.Value);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            // Aca cargo las habilidades de los pokes
            //foreach (habilidad_pokes pokes in habilidades)
            //{
            //    string consulta = "INSERT INTO habilidades_pokes (id_habilidades,habilidad1,habilidad2,habilidad_oculta) VALUES (" + pokes.id + ",'" + pokes.habilidad1 + "','" + pokes.habilidad2 + "','" + pokes.habilidadOculta + "');";
            //    using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id", pokes.id);
            //        cmd.Parameters.AddWithValue("habilidad1", pokes.habilidad1);
            //        cmd.Parameters.AddWithValue("habilidad2", (object)pokes.habilidad2 ?? DBNull.Value);
            //        cmd.Parameters.AddWithValue("habilidad_oculta", pokes.habilidadOculta);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            // Aca cargo los datos generales de los pokes
            //foreach (datosGeneralesPokes pokes in datosGenerales)
            //{
            //    string consulta = "INSERT INTO datos_generales_pokes (id_datos_generales,generacion,altura,peso,color,legendario,mega) VALUES (" + pokes.id + "," + pokes.generacion + "," + pokes.altura + "," + pokes.peso + ",'" + pokes.color + "'," + pokes.legendario + "," + pokes.megaEvolucion + ");";
            //    using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id", pokes.id);
            //        cmd.Parameters.AddWithValue("generacion", pokes.generacion);
            //        cmd.Parameters.AddWithValue("altura", pokes.altura);
            //        cmd.Parameters.AddWithValue("peso", pokes.peso);
            //        cmd.Parameters.AddWithValue("color", pokes.color);
            //        cmd.Parameters.AddWithValue("legendario", pokes.legendario);
            //        cmd.Parameters.AddWithValue("mega_evolucion", pokes.megaEvolucion);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            // Aca cargo las estadisticas de los pokes
            foreach (estadisticas_pokes pokes in estadisticas)
            {
                string consulta = "INSERT INTO estadisticas_pokes (id_att,vida,ataque,defensa,ataque_especial,defensa_especial,velocidad,att_totales) VALUES (" + pokes.id + "," + pokes.hp + "," + pokes.ataque + "," + pokes.defensa + "," + pokes.ataqueEspecial + "," + pokes.defensaEspecial + "," + pokes.velocidad + "," + pokes.total + ");";
                using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
                {
                    cmd.Parameters.AddWithValue("id_att", pokes.id);
                    cmd.Parameters.AddWithValue("vida", pokes.hp);
                    cmd.Parameters.AddWithValue("ataque", pokes.ataque);
                    cmd.Parameters.AddWithValue("defensa", pokes.defensa);
                    cmd.Parameters.AddWithValue("ataque_especial", pokes.ataqueEspecial);
                    cmd.Parameters.AddWithValue("defensa_especial", pokes.defensaEspecial);
                    cmd.Parameters.AddWithValue("velocidad", pokes.velocidad);
                    cmd.Parameters.AddWithValue("att_totales", pokes.total);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void rellenarListas()
        {
            foreach (Pokemon pokes in pokemons)
            {
                if (!existeTipo(pokes.tipo1, pokes.tipo2))
                {
                    tipos_pokes tipo = new tipos_pokes(tipos.Count + 1, pokes.tipo1, pokes.tipo2);
                    tipos.Add(tipo);
                }
                if (!existeHabilidad(pokes.habilidad1, pokes.habilidad2, pokes.habilidadOculta))
                {
                    habilidad_pokes habilidad = new habilidad_pokes(habilidades.Count + 1, pokes.habilidad1, pokes.habilidad2, pokes.habilidadOculta);
                    habilidades.Add(habilidad);
                }
                if (!existeDatosGenerales(pokes.generacion, pokes.legendario, pokes.megaEvolucion, pokes.altura, pokes.peso))
                {
                    datosGeneralesPokes datos = new datosGeneralesPokes(datosGenerales.Count + 1, pokes.generacion, pokes.altura, pokes.peso, pokes.color, pokes.legendario, pokes.megaEvolucion);
                    datosGenerales.Add(datos);
                }
                if (!existeEstadisticas(pokes.vida, pokes.ataque, pokes.defensa, pokes.ataqueEspecial, pokes.defensaEspecial, pokes.velocidad))
                {
                    estadisticas_pokes estadistica = new estadisticas_pokes(estadisticas.Count + 1, pokes.vida, pokes.ataque, pokes.defensa, pokes.ataqueEspecial, pokes.defensaEspecial, pokes.velocidad, pokes.total);
                    estadisticas.Add(estadistica);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tipos: " + tipos.Count + "\nHabilidades: " + habilidades.Count + "\nDatos Generales: " + datosGenerales.Count + "\nEstadisticas: " + estadisticas.Count, "Resumen de Datos");
        }
    }
}