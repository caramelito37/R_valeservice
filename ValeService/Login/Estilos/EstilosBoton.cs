using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Login.Estilos
{
    public class EstilosBoton
    {
        // Método para hacer visible un botón
        public static void MostrarBoton(params Button[] botones)
        {
            foreach (var boton in botones)
            {
                boton.Visible = true;
            }
        }

        // Método para ocultar un botón
        public static void OcultarBoton(params Button[] botones)
        {
            foreach (var boton in botones)
            {
                boton.Visible = false;
            }
        }
    }
}

