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
    public partial class Pokedexx : Form
    {
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

        }

        private void btAcero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si funciona el boton");
        }

        private void btInfo1_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo2_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo3_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo4_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo5_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo6_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo7_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void btInfo8_Click(object sender, EventArgs e)
        {
            Stats statsForm = new Stats();
            statsForm.ShowDialog();
        }

        private void Pokedexx_Load(object sender, EventArgs e)
        {
            if (CrearEquipos.anadirPokemon == true)
            {
                labInstruccion.Visible = true;
            }
            else
            {
                labInstruccion.Visible = false;
            }
        }
    }
}
