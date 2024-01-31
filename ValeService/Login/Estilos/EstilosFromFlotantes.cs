using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Estilos
{
    public class EstilosFromFlotantes
    {
        public static void AplicarEstilosForm(Form formulario)
        {
            formulario.FormBorderStyle = FormBorderStyle.None;  // Eliminar el borde del formulario
            formulario.MaximizeBox = false;  // Deshabilitar el botón de maximizar
            formulario.MinimizeBox = false;  // Deshabilitar el botón de minimizar
            formulario.StartPosition = FormStartPosition.CenterScreen;  // Centrar el formulario en la pantalla
            formulario.ControlBox = false;  // Ocultar el botón de cerrar (X)
            formulario.Text = "";  // Eliminar el texto de la barra de título
        }

    }
}
