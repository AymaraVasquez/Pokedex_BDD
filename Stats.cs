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

    public partial class Stats : Form
    {

        public Stats()

        {
            InitializeComponent();
        }

        int size = 0;
        public void progressBarChafa(int largo, int valor)
        {
            size = (largo * valor) / 200;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            //Lo que vas a reemplazar con el valor de la base de datos es el 2do parametro
            // de la funcion lo demas de lo dejas igual

            //vida
            progressBarChafa(173, 150);
            pbVida.Size = new Size(size, 14);
            pbVida.BackColor = Color.GreenYellow;
            size = 0;
            //Ataque
            progressBarChafa(161, 50);
            pbAtaque.Size = new Size(size, 14);
            pbAtaque.BackColor = Color.Red;
            //Defensa
            progressBarChafa(155, 50);
            pbDefensa.Size = new Size(size, 14);
            pbDefensa.BackColor = Color.Blue;
            //AtqEsp
            progressBarChafa(122, 150);
            pbAtqEspecial.Size = new Size(size, 14);
            pbAtqEspecial.BackColor = Color.Orange;
            //DefEsp
            progressBarChafa(122, 150);
            pbDefEspecial.Size = new Size(size, 14);
            pbDefEspecial.BackColor = Color.Green;
            //Velocidad
            progressBarChafa(140, 150);
            pbVelocidad.Size = new Size(size, 14);
            pbVelocidad.BackColor = Color.Yellow;
        }
    }
}
