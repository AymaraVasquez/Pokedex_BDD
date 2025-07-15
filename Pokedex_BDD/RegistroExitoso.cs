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
    public partial class RegistroExitoso : Form
    {
        public RegistroExitoso()
        {
            InitializeComponent();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
           
            Form InicioForm = Application.OpenForms["InicioDeSesion"];
            if (InicioForm != null)
            {
                InicioForm.Show();
                this.Hide();
            }
        }

        private void RegistroExitoso_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
