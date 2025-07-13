using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pokedex
{
    public partial class RecuperarContrasena : Form
    {
        public RecuperarContrasena()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.btAtras, "Volver al Inicio");
        }

        private void tbFraseRecup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Form InicioForm = Application.OpenForms["InicioDeSesion"];
            if (InicioForm != null)
            {
                InicioForm.Show();
                this.Hide();
            }
        }
    }
}
