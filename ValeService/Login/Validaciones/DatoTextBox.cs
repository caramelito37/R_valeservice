using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Windows.Forms;

namespace Login.Validaciones
{
    public class DatoTextBox
    {
        public static bool ObtenerEnteroValido(string entrada, out int resultado)
        {
            return int.TryParse(entrada, out resultado) || MostrarError("entero");
        }

        public static bool ObtenerDecimalValido(string entrada, out decimal resultado)
        {
            return decimal.TryParse(entrada, out resultado) || MostrarError("decimal");
        }

        public static bool ObtenerFechaValida(string entrada, out DateTime resultado)
        {
            return DateTime.TryParseExact(entrada, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out resultado) || MostrarError("fecha");
        }
        private static bool MostrarError(string tipoDato)
        {
            MessageBox.Show($"Error: El tipo de dato ingresado debe ser {tipoDato}.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}

