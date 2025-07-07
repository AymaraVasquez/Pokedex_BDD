using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex.Properties;

namespace Pokedex
{
    public partial class CrearEquipos : Form
    {
        public CrearEquipos()
        {
            InitializeComponent();
        }
        public static bool anadirPokemon;
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

            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            btElim1_1.Visible = true;
            btElim1_2.Visible = true;
            btElim1_3.Visible = true;
            btElim1_4.Visible = true;
            btElim1_5.Visible = true;
            btElim1_6.Visible = true;
        }

        private void btAnadir2_Click(object sender, EventArgs e)
        {
            btElim2_1.Visible = false;
            btElim2_2.Visible = false;
            btElim2_3.Visible = false;
            btElim2_4.Visible = false;
            btElim2_5.Visible = false;
            btElim2_6.Visible = false;

            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;
        }

        private void btEditar2_Click(object sender, EventArgs e)
        {
            btElim2_1.Visible = true;
            btElim2_2.Visible = true;
            btElim2_3.Visible = true;
            btElim2_4.Visible = true;
            btElim2_5.Visible = true;
            btElim2_6.Visible = true;
        }

        private void btAnadir3_Click(object sender, EventArgs e)
        {
            btElim3_1.Visible = false;
            btElim3_2.Visible = false;
            btElim3_3.Visible = false;
            btElim3_4.Visible = false;
            btElim3_5.Visible = false;
            btElim3_6.Visible = false;

            anadirPokemon = true;
            Pokedexx pokedex = new Pokedexx();
            pokedex.ShowDialog();
            anadirPokemon = false;
        }

        private void btEditar3_Click(object sender, EventArgs e)
        {
            btElim3_1.Visible = true;
            btElim3_2.Visible = true;
            btElim3_3.Visible = true;
            btElim3_4.Visible = true;
            btElim3_5.Visible = true;
            btElim3_6.Visible = true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar2_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar3_Click(object sender, EventArgs e)
        {

        }

        private void btFav1_Click(object sender, EventArgs e)
        {
            if (equipoFavorito == false)
            {
                equipoFavorito = true;
                equipoFav = 1;
                btFav1.Image = Resources.FavCheck;
            }
            else if (equipoFav == 1)
            {
                equipoFavorito = false;
                btFav1.Image = Resources.FavNoCheck;
            }
        }

        private void btFav2_Click(object sender, EventArgs e)
        {
            if (equipoFavorito == false)
            {
                equipoFavorito = true;
                equipoFav = 2;
                btFav2.Image = Resources.FavCheck;
                btFav2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (equipoFav == 2)
            {
                equipoFavorito = false;
                btFav2.Image = Resources.FavNoCheck;
                btFav2.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void btFav3_Click(object sender, EventArgs e)
        {
            if (equipoFavorito == false)
            {
                equipoFavorito = true;
                equipoFav = 3;
                btFav3.Image = Resources.FavCheck;
                btFav3.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (equipoFav == 3)
            {
                equipoFavorito = false;
                btFav3.Image = Resources.FavNoCheck;
                btFav3.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
    }
}
