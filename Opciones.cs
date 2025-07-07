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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btVerEquipos_Click(object sender, EventArgs e)
        {
            Equipos equiposForm = new Equipos();
            equiposForm.ShowDialog();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            CrearEquipos crearEquipoForm = new CrearEquipos();  
            crearEquipoForm.ShowDialog();
        }

        private void btPokedex_Click(object sender, EventArgs e)
        {
            Pokedexx pokedexForm = new Pokedexx();
            pokedexForm.ShowDialog();
        }
    }
}
