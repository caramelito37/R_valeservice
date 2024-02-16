using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login.Validaciones
{
    internal class ContenidoTextBox
    {
        //public static bool LLenarTextBoxObligatorio(TextBox textBox, string errorMessage)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox.Text))
        //    {
        //        MessageBox.Show($"Por favor, complete el campo: {errorMessage}", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return true;
        //    }
        //    return false;
        //}

        public static bool LLenarTextBoxObligatorio(Dictionary<TextBox, string> textBoxes)
        {
            List<string> camposVacios = new List<string>();

            foreach (var pair in textBoxes)
            {
                TextBox textBox = pair.Key;
                string errorMessage = pair.Value;

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    camposVacios.Add(errorMessage);
                }
            }

            if (camposVacios.Count > 0)
            {
                string errorMessage = "Por favor, complete los siguientes campos obligatorios:\n\n";
                foreach (string campo in camposVacios)
                {
                    errorMessage += $"- {campo}\n";
                }

                MessageBox.Show(errorMessage, "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
    }
}


