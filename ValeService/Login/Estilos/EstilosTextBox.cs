using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Estilos
{
    public class EstilosTextBox
    {
        // Método para cambiar la propiedad Modifiers de un TextBox a public
        public static void HacerPublico(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.GetType().GetProperty("Modifiers")?.SetValue(textBox, System.Reflection.BindingFlags.Public, null);
            }
        }

        public static void BloquearTextBox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Enabled = false;
            }
        }

        public static void HabilitarTextBox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Enabled = true;
            }
        }

    }
}
