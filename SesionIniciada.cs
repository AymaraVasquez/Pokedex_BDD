using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public static class SesionIniciada
    {
        public static bool Iniciada { get; set; } = false;
        public static string nombre{ get; set; } = string.Empty;
        public static string NombreUsuario { get; set; } = string.Empty;
        public static int IdUsuario { get; set; } = 0;
        public static int FotoPerfil { get; set; } = 0;
    }
}
