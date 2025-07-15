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
    public partial class ManualDeUsuario : Form
    {
        public ManualDeUsuario()
        {
            InitializeComponent();
        }

        public void rellenar()
        {
            if (Opciones.vista == 1)
            {
                btSiguiente.Visible = true;
                btAtras.Visible = false;
                pictureVista.Image = Resources.VistaOpciones;
                textDescrip.Text = "# Opciones:\r\n• <<: regresa a la pantalla anterior.\r\n• Ver Perfil: muestra el perfil del usuario con los datos de registro y su equipo.\r\n• Crear Equipo: muestra el modulo de creación de equipos.\r\n• Ver Pokedex: muestra el modulo de Pokedex donde se accede a toda la información de cada Pokémon.";
            }
            else if (Opciones.vista == 2)
            {
                btAtras.Visible = true;
                btSiguiente.Visible = true;
                pictureVista.Image = Resources.VistaEquipos;
                textDescrip.Text = "# Crear Equipo:\r\n• <<: regresa a la pantalla anterior.\r\n• Añadir: abre la Pokédex para seleccionar los pokemones a añadir al equipo.\r\n• Editar: habilita los botones para eliminar los pokemones individualmente del equipo.\r\n• Eliminar: elimina todos los pokemones del equipo.";
            }
            else if (Opciones.vista == 3)
            {
                btSiguiente.Visible = false;
                pictureVista.Image = Resources.VistaPokedex;
                textDescrip.Text = "# Pokedex:\r\n• <<: regresa a la pantalla anterior.\r\n• i: accede a la información del Pokémon.\r\n• Buscar: busca pokemones con el nombre en la barra de búsqueda.\r\n• Refrescar: reinicia la pantalla de la Pokedex.\r\n• >: muestra los pokemones siguientes.\r\n• <: muestra los pokemones anteriores.\r\n• Filtros: se filtran los pokemones con los tipos seleccionados al presionarlos.";
            }
        }

        private void btVolverAtras_Click(object sender, EventArgs e)
        {
            Form InicioForm = Application.OpenForms["Pokedexx"];
            if (InicioForm != null)
            {
                InicioForm.Show();
                this.Hide();
            }

            Form InicioFor = Application.OpenForms["Opciones"];
            if (InicioFor != null)
            {
                InicioFor.Show();
                this.Hide();
            }

            Form InicioFo = Application.OpenForms["CrearEquipos"];
            if (InicioFo != null)
            {
                InicioFo.Show();
                this.Hide();
            }
        }

        private void ManualDeUsuario_Load(object sender, EventArgs e)
        {
            rellenar();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            if (Opciones.vista == 2)
            {
                Opciones.vista = 1;
            }
            else if (Opciones.vista == 3)
            {
                Opciones.vista = 2;

            }
            rellenar();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if (Opciones.vista == 1)
            {
                Opciones.vista = 2;

            }
            else if (Opciones.vista == 2)
            {
                Opciones.vista = 3;

            }
            rellenar();
        }
    }
}
