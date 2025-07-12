using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CargarBDDPokemon
{
    public class Conex
    {
        public static MySqlConnection Coneccion;
        public static MySqlDataReader Lector;
        public void conectar()
        {
            Coneccion = new MySqlConnection();
            if ((Coneccion.State == ConnectionState.Closed))
            {
                var conect = "Datasource=localhost;Port=3306;User=root;password=;Database=unsafe people";
                Coneccion.ConnectionString = conect;
                Coneccion.Open();
            }
        }
        public void desconectar()
        {
            if ((Coneccion.State == ConnectionState.Open))
            {
                Coneccion.Close();
            }
        }
    }

    public class Conex2
    {
        public MySqlConnection Coneccion;
        public MySqlDataReader Lector;
        public void conectar()
        {
            Coneccion = new MySqlConnection();
            if ((Coneccion.State == ConnectionState.Closed))
            {
                var conect = "Datasource=localhost;Port=3306;User=root;password=;Database=unsafe people";
                Coneccion.ConnectionString = conect;
                Coneccion.Open();
            }
        }
        public void desconectar()
        {
            if ((Coneccion.State == ConnectionState.Open))
            {
                Coneccion.Close();
            }
        }
    }
}