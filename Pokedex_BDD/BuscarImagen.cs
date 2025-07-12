using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public static class BuscarImagen
    {
        public static Image DeStringAImage(string id)
        { 
            string nombreRecurso = "_" + id.ToString();

            Type tipoRecursos = typeof(Properties.Resources);

            PropertyInfo propiedad = tipoRecursos.GetProperty(nombreRecurso, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            if (propiedad != null)
            {
                return propiedad.GetValue(null) as Image;
            }
            else
            {
                return null;
            }

        }
    }
}
