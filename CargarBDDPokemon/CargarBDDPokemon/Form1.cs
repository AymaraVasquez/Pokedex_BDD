using MySql.Data.MySqlClient;
using System.Data;

namespace CargarBDDPokemon
{
    public partial class Form1 : Form
    {
        public Conex Conexion = new Conex();
        public List<Pokemon> pokemons = Pokemon.LeerProductos();
        public List<string> tipos = new List<string>();
        public List<string> habilidades = new List<string>();
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
        public bool existeTipo(string tipo1)
        {
            foreach (string poke in tipos)
            {
                if (poke == tipo1 && !(String.IsNullOrEmpty(poke)))
                {
                    return true;
                }
            }
            return false;
        }
        public bool existeHabilidad(string habilidad1)
        {
            foreach (string poke in habilidades)
            {
                if (poke == habilidad1 && !(String.IsNullOrEmpty(poke)))
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
            //Aca cargo los fokin tipos de pokes
            //foreach (string tipos in tipos)
            //{
            //    if (String.IsNullOrEmpty(tipos))
            //    {
            //        continue; // Skip empty types
            //    }
            //    string consulta = "INSERT INTO tipos (id_tipo,tipo) VALUES (null,'" + tipos + "');";

            //    using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id", null);
            //        cmd.Parameters.AddWithValue("tipo", tipos);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            //Aca cargo las habilidades de los pokes
            //foreach (string hab in habilidades)
            //{
            //    string consulta = "INSERT INTO habilidades (id_habilidad,habilidad) VALUES (null,'" + hab + "');";
            //    using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id", null);
            //        cmd.Parameters.AddWithValue("habilidad", hab);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            ////Aca cargo los datos generales de los pokes
            foreach (datosGeneralesPokes pokes in datosGenerales)
            {
                string consulta = "INSERT INTO datos_generales_pokes (id_datos_generales,generacion,altura,peso,color,legendario,mega) VALUES (" + pokes.id + "," + pokes.generacion + "," + pokes.altura.ToString("N2", new System.Globalization.CultureInfo("en-US")) + "," + pokes.peso.ToString("N2", new System.Globalization.CultureInfo("en-US")) + ",'" + pokes.color + "'," + pokes.legendario + "," + pokes.megaEvolucion + ");";
                using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
                {
                    cmd.Parameters.AddWithValue("id", pokes.id);
                    cmd.Parameters.AddWithValue("generacion", pokes.generacion);
                    cmd.Parameters.AddWithValue("altura", pokes.altura.ToString("N2", new System.Globalization.CultureInfo("en-US")));
                    cmd.Parameters.AddWithValue("peso", pokes.peso.ToString("N2", new System.Globalization.CultureInfo("en-US")));
                    cmd.Parameters.AddWithValue("color", pokes.color);
                    cmd.Parameters.AddWithValue("legendario", pokes.legendario);
                    cmd.Parameters.AddWithValue("mega_evolucion", pokes.megaEvolucion);
                    cmd.ExecuteNonQuery();
                }
            }
            ////Aca cargo las estadisticas de los pokes
            //foreach (estadisticas_pokes pokes in estadisticas)
            //{
            //    string consulta = "INSERT INTO estadisticas_pokes (id_att,vida,ataque,defensa,ataque_especial,defensa_especial,velocidad,att_totales) VALUES (" + pokes.id + "," + pokes.hp + "," + pokes.ataque + "," + pokes.defensa + "," + pokes.ataqueEspecial + "," + pokes.defensaEspecial + "," + pokes.velocidad + "," + pokes.total + ");";
            //    using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id_att", pokes.id);
            //        cmd.Parameters.AddWithValue("vida", pokes.hp);
            //        cmd.Parameters.AddWithValue("ataque", pokes.ataque);
            //        cmd.Parameters.AddWithValue("defensa", pokes.defensa);
            //        cmd.Parameters.AddWithValue("ataque_especial", pokes.ataqueEspecial);
            //        cmd.Parameters.AddWithValue("defensa_especial", pokes.defensaEspecial);
            //        cmd.Parameters.AddWithValue("velocidad", pokes.velocidad);
            //        cmd.Parameters.AddWithValue("att_totales", pokes.total);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
        }

        public void rellenarListas()
        {
            foreach (Pokemon pokes in pokemons)
            {
                if (!existeTipo(pokes.tipo2) && !String.IsNullOrEmpty(pokes.tipo2))
                {
                    tipos.Add(pokes.tipo2);
                }
                if (!existeTipo(pokes.tipo1))
                {
                    tipos.Add(pokes.tipo1);
                }
                if (!existeHabilidad(pokes.habilidad1))
                {
                    habilidades.Add(pokes.habilidad1);
                }
                if (!existeHabilidad(pokes.habilidad2) && !String.IsNullOrEmpty(pokes.habilidad2))
                {
                    habilidades.Add(pokes.habilidad2);
                }
                if (!existeHabilidad(pokes.habilidadOculta) && !String.IsNullOrEmpty(pokes.habilidadOculta))
                {
                    habilidades.Add(pokes.habilidadOculta);
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
        public int idEst;
        public int idDatosGenerales;

        private void button4_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            foreach (Pokemon poke in pokemons)
            {
                string consulta = "select id_datos_generales,generacion,altura,peso,color,legendario,mega from datos_generales_pokes";
                MySqlCommand comando = new MySqlCommand(consulta, Conex.Coneccion);
                Conex.Lector = comando.ExecuteReader();
                while (Conex.Lector.Read())
                {
                    // comparacion
                    if (Convert.ToInt32(Conex.Lector[1]) == poke.generacion &&
                        Convert.ToDouble(Conex.Lector[2]).ToString("N2", new System.Globalization.CultureInfo("en-US")) == poke.altura.ToString("N2", new System.Globalization.CultureInfo("en-US")) &&
                        Convert.ToDouble(Conex.Lector[3]).ToString("N2", new System.Globalization.CultureInfo("en-US")) == poke.peso.ToString("N2", new System.Globalization.CultureInfo("en-US")) &&
                        Conex.Lector[4].ToString() == poke.color &&
                        Convert.ToInt32(Conex.Lector[5]) == poke.legendario &&
                        Convert.ToInt32(Conex.Lector[6]) == poke.megaEvolucion)
                    {
                        idDatosGenerales = Convert.ToInt32(Conex.Lector[0]);
                        break;
                    }
                }
                Conexion.desconectar();
                Conexion.conectar();
                string consulta1 = "select id_att,vida,ataque,defensa,ataque_especial,defensa_especial,velocidad,att_totales from estadisticas_pokes";
                MySqlCommand comando1 = new MySqlCommand(consulta1, Conex.Coneccion);
                Conex.Lector = comando1.ExecuteReader();
                while (Conex.Lector.Read())
                {
                    if (Convert.ToInt32(Conex.Lector[1]) == poke.vida &&
                        Convert.ToInt32(Conex.Lector[2]) == poke.ataque &&
                        Convert.ToInt32(Conex.Lector[3]) == poke.defensa &&
                        Convert.ToInt32(Conex.Lector[4]) == poke.ataqueEspecial &&
                        Convert.ToInt32(Conex.Lector[5]) == poke.defensaEspecial &&
                        Convert.ToInt32(Conex.Lector[6]) == poke.velocidad)
                    {
                        idEst = Convert.ToInt32(Conex.Lector[0]);
                        break;
                    }
                }
                Conexion.desconectar();
                Conexion.conectar();
                string consulta2 = "INSERT INTO pokedex_normal (id_poke,id_forma,nombre_poke,id_datos_generales,id_att) VALUES (" + poke.code_poke + "," + poke.codigo + ",'" + poke.nombre + "'," + idDatosGenerales.ToString() + "," + idEst.ToString() + ");";
                using (MySqlCommand cmd = new MySqlCommand(consulta2, Conex.Coneccion))
                {
                    cmd.Parameters.AddWithValue("id_poke", poke.code_poke.ToString().Trim());
                    cmd.Parameters.AddWithValue("id_forma", poke.codigo);
                    cmd.Parameters.AddWithValue("nombre_poke", poke.nombre);
                    cmd.Parameters.AddWithValue("id_datos_generales", idDatosGenerales.ToString());
                    cmd.Parameters.AddWithValue("id_att", idEst.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
            Conexion.desconectar();
        }

        private void VerPokimon_Click(object sender, EventArgs e)
        {
            MessageBox.Show((decimal.Parse("5,2")).ToString("N2", new System.Globalization.CultureInfo("en-US")));
            foreach (Pokemon poke in pokemons)
            {
                MessageBox.Show("ID: " + poke.id + "\nCodigo: " + poke.codigo + "\nNombre: " + poke.nombre + "\nTipo1: " + poke.tipo1 + "\nTipo2: " + poke.tipo2 + "\nHabilidad1: " + poke.habilidad1 + "\nHabilidad2: " + poke.habilidad2 + "\nHabilidad Oculta: " + poke.habilidadOculta + "\nGeneracion: " + poke.generacion + "\nLegendario: " + poke.legendario + "\nMega Evolucion: " + poke.megaEvolucion + "\nAltura: " + poke.altura + "\nPeso: " + poke.peso + "\nVida: " + poke.vida + "\nAtaque: " + poke.ataque + "\nDefensa: " + poke.defensa + "\nAtaque Especial: " + poke.ataqueEspecial + "\nDefensa Especial: " + poke.defensaEspecial + "\nVelocidad: " + poke.velocidad, "Pokemon Info");
            }
        }
        public int idTipo;
        public int idHabilidad;
        private void CargarRela_Click(object sender, EventArgs e)
        {
            //Conexion.conectar();
            //foreach (Pokemon pokemon in pokemons)
            //{
            //    // Primer Tipo
            //    string consulta = "select * from tipos WHERE tipo = '" + pokemon.tipo1+"'";
            //    MySqlCommand comando = new MySqlCommand(consulta, Conex.Coneccion);
            //    Conex.Lector = comando.ExecuteReader();
            //    while (Conex.Lector.Read())
            //    {
            //       idTipo = Convert.ToInt32(Conex.Lector[0]);
            //    }
            //    Conexion.desconectar();
            //    Conexion.conectar();
            //    string consulta2 = "INSERT INTO rela_pokes_tipo (id_rela,id_poke,id_tipo) VALUES (null," + pokemon.code_poke + "," + idTipo +");";
            //    using (MySqlCommand cmd = new MySqlCommand(consulta2, Conex.Coneccion))
            //    {
            //        cmd.Parameters.AddWithValue("id_poke", pokemon.code_poke);
            //        cmd.Parameters.AddWithValue("id_tipo", idTipo);
            //        cmd.ExecuteNonQuery();
            //    }
            //    // Segundo Tipo
            //    if (!String.IsNullOrEmpty(pokemon.tipo2))
            //    {
            //        string consulta3 = "select * from tipos WHERE tipo = '" + pokemon.tipo2 + "'";
            //        MySqlCommand comando2 = new MySqlCommand(consulta3, Conex.Coneccion);
            //        Conex.Lector = comando2.ExecuteReader();
            //        while (Conex.Lector.Read())
            //        {
            //            idTipo = Convert.ToInt32(Conex.Lector[0]);
            //        }
            //        Conexion.desconectar();
            //        Conexion.conectar();
            //        string consulta4 = "INSERT INTO rela_pokes_tipo (id_rela,id_poke,id_tipo) VALUES (null," + pokemon.code_poke + "," + idTipo + ");";
            //        using (MySqlCommand cmd = new MySqlCommand(consulta4, Conex.Coneccion))
            //        {
            //            cmd.Parameters.AddWithValue("id_poke", pokemon.code_poke);
            //            cmd.Parameters.AddWithValue("id_tipo", idTipo);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //}
            Conexion.conectar();
            foreach (Pokemon pokemon in pokemons)
            {
                // Primer Habilidad
                string consulta = "select * from habilidades WHERE habilidad = '" + pokemon.habilidad1 + "'";
                MySqlCommand comando = new MySqlCommand(consulta, Conex.Coneccion);
                Conex.Lector = comando.ExecuteReader();
                while (Conex.Lector.Read())
                {
                    idHabilidad = Convert.ToInt32(Conex.Lector[0]);
                }
                Conexion.desconectar();
                Conexion.conectar();
                string consulta2 = "INSERT INTO rela_poke_habilidad (id_poke_hab,id_poke,id_habilidad,es_oculta) VALUES (null," + pokemon.code_poke + "," + idHabilidad + ", 0);";
                using (MySqlCommand cmd = new MySqlCommand(consulta2, Conex.Coneccion))
                {
                    cmd.Parameters.AddWithValue("id_poke", pokemon.code_poke);
                    cmd.Parameters.AddWithValue("id_habilidad", idHabilidad);
                    cmd.Parameters.AddWithValue("es_oculta", "0");
                    cmd.ExecuteNonQuery();
                }
                // Segunda Habilidad
                if (!String.IsNullOrEmpty(pokemon.habilidad2))
                {
                    string consulta3 = "select * from habilidades WHERE habilidad = '" + pokemon.habilidad2 + "'";
                    MySqlCommand comando2 = new MySqlCommand(consulta3, Conex.Coneccion);
                    Conex.Lector = comando2.ExecuteReader();
                    while (Conex.Lector.Read())
                    {
                        idHabilidad = Convert.ToInt32(Conex.Lector[0]);
                    }
                    Conexion.desconectar();
                    Conexion.conectar();
                    string consulta4 = "INSERT INTO rela_poke_habilidad (id_poke_hab,id_poke,id_habilidad,es_oculta) VALUES (null," + pokemon.code_poke + "," + idHabilidad + ", 0);";
                    using (MySqlCommand cmd = new MySqlCommand(consulta4, Conex.Coneccion))
                    {
                        cmd.Parameters.AddWithValue("id_poke", pokemon.code_poke);
                        cmd.Parameters.AddWithValue("id_habilidad", idHabilidad);
                        cmd.Parameters.AddWithValue("es_oculta", "0");
                        cmd.ExecuteNonQuery();
                    }
                }

                // Habilidad Oculta
                if (!String.IsNullOrEmpty(pokemon.habilidadOculta))
                {
                    string consulta5 = "select * from habilidades WHERE habilidad = '" + pokemon.habilidadOculta + "'";
                    MySqlCommand comando3 = new MySqlCommand(consulta5, Conex.Coneccion);
                    Conex.Lector = comando3.ExecuteReader();
                    while (Conex.Lector.Read())
                    {
                        idHabilidad = Convert.ToInt32(Conex.Lector[0]);
                    }
                    Conexion.desconectar();
                    Conexion.conectar();
                    string consulta6 = "INSERT INTO rela_poke_habilidad (id_poke_hab,id_poke,id_habilidad,es_oculta) VALUES (null," + pokemon.code_poke + "," + idHabilidad + ", 1);";
                    using (MySqlCommand cmd = new MySqlCommand(consulta6, Conex.Coneccion))
                    {
                        cmd.Parameters.AddWithValue("id_poke", pokemon.code_poke);
                        cmd.Parameters.AddWithValue("id_habilidad", idHabilidad);
                        cmd.Parameters.AddWithValue("es_oculta", "1");
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        private void BtMovi_Click(object sender, EventArgs e)
        {
            string RutaEspero = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "movimientos.txt"); ;

            try
            {
                if (File.Exists(RutaEspero))
                {
                    using (StreamReader leyendo = new StreamReader(RutaEspero))
                    {
                        string? linea;
                        while ((linea = leyendo.ReadLine()) != null)
                        {
                            string[] columnas = linea.Split(',');
                            if (columnas.Length == 15)
                            {
                                Conexion.conectar();

                                string consulta = "insert into movimientos (id_movimiento, nombre_movimiento, potencia, poke_precision, id_tipo) Values (null, '" + columnas[2] + "'," + columnas[4] + " ," + columnas[7] + ", @id_tipo)";

                                using (MySqlCommand cmd = new MySqlCommand(consulta, Conex.Coneccion))
                                {
                                    cmd.Parameters.AddWithValue("nombre_movimiento", columnas[2]);
                                    cmd.Parameters.AddWithValue("potencia", columnas[4]);
                                    cmd.Parameters.AddWithValue("poke_precision", columnas[7]);

                                    switch (columnas[5].ToString().Trim().ToLower())
                                    {
                                        case "poison":
                                            cmd.Parameters.AddWithValue("id_tipo", 1);
                                            break;
                                        case "grass":
                                            cmd.Parameters.AddWithValue("id_tipo", 2);
                                            break;
                                        case "fire":
                                            cmd.Parameters.AddWithValue("id_tipo", 3);
                                            break;
                                        case "flying":
                                            cmd.Parameters.AddWithValue("id_tipo", 4);
                                            break;
                                        case "dragon":
                                            cmd.Parameters.AddWithValue("id_tipo", 5);
                                            break;
                                        case "water":
                                            cmd.Parameters.AddWithValue("id_tipo", 6);
                                            break;
                                        case "bug":
                                            cmd.Parameters.AddWithValue("id_tipo", 7);
                                            break;
                                        case "normal":
                                            cmd.Parameters.AddWithValue("id_tipo", 8);
                                            break;
                                        case "dark":
                                            cmd.Parameters.AddWithValue("id_tipo", 9);
                                            break;
                                        case "electric":
                                            cmd.Parameters.AddWithValue("id_tipo", 10);
                                            break;
                                        case "psychic":
                                            cmd.Parameters.AddWithValue("id_tipo", 11);
                                            break;
                                        case "ground":
                                            cmd.Parameters.AddWithValue("id_tipo", 12);
                                            break;
                                        case "steel":
                                            cmd.Parameters.AddWithValue("id_tipo", 13);
                                            break;
                                        case "ice":
                                            cmd.Parameters.AddWithValue("id_tipo", 14);
                                            break;
                                        case "fairy":
                                            cmd.Parameters.AddWithValue("id_tipo", 15);
                                            break;
                                        case "fighting":
                                            cmd.Parameters.AddWithValue("id_tipo", 16);
                                            break;
                                        case "rock":
                                            cmd.Parameters.AddWithValue("id_tipo", 17);
                                            break;
                                        case "ghost":
                                            cmd.Parameters.AddWithValue("id_tipo", 18);
                                            break;
                                    }

                                    cmd.ExecuteNonQuery();
                                }

                                Conexion.desconectar();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private void BtCargarRelaMov_Click(object sender, EventArgs e)
        {
            foreach (Pokemon poke in pokemons)
            {
                for (int i = 0; i<4; i++)
                {
                    if (poke.tipo1 == "Fairy")
                    {
                        Conexion.conectar();
                        string consulta2 = "insert into rela_poke_movimiento (id_poke_movimiento, id_poke, id_movimiento) values (null, "+poke.code_poke.ToString()+", (select id_movimiento from movimientos order by rand() limit 1))";
                        MySqlCommand comando2 = new MySqlCommand(consulta2, Conex.Coneccion);
                        comando2.ExecuteNonQuery();
                        Conexion.desconectar();
                        continue;
                    }
                    Conexion.conectar();
                    string consulta = "insert into rela_poke_movimiento (id_poke_movimiento, id_poke, id_movimiento) values (null, "+poke.code_poke.ToString()+", (select id_movimiento from movimientos where id_tipo = (select id_tipo from tipos where tipo like '"+poke.tipo1+"') order by rand() limit 1))";
                    MySqlCommand comando = new MySqlCommand(consulta, Conex.Coneccion);
                    comando.ExecuteNonQuery();
                    Conexion.desconectar();
                }   
            }
        }
    }
    public class Movimiento()
    {

    }
}
