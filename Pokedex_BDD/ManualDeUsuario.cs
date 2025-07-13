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
    public partial class ManualDeUsuario : Form
    {
        public ManualDeUsuario()
        {
            InitializeComponent();
        }

        private void btVolverAtras_Click(object sender, EventArgs e)
        {
            Form InicioForm = Application.OpenForms["Pokedexx"];
            if (InicioForm != null)
            {
                InicioForm.Show();
                this.Hide();
            }
        }
    }
}
