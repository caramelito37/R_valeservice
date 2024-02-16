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
        public static void ConfigurarTextBoxEntero(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MostrarError("entero");
                }
                else if (textBox.Text.Length >= 9) // Limitar a 9 caracteres para enteros (por ejemplo)
                {
                    e.Handled = true;
                }
            };
        }

        public static void ConfigurarTextBoxDecimal(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                    MostrarError("decimal");
                }
                else if (textBox.Text.Length >= 11) // Limitar a 11 caracteres para decimales (por ejemplo)
                {
                    e.Handled = true;
                }
            };
        }

        public static void ConfigurarTextBoxString(TextBox textBox, int maxLength)
        {
            textBox.MaxLength = maxLength; // Establecer el número máximo de caracteres permitidos
            textBox.KeyPress += (sender, e) =>
            {
                if (textBox.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Evitar que se ingresen más caracteres cuando se alcanza el límite
                }
            };
        }

        public static void ConfigurarTextBoxFechaDDMMYY(TextBox textBox)
        {
            // No permitir entrada de texto directamente en TextBox de fecha
            textBox.ReadOnly = true;
            textBox.MouseClick += (sender, e) =>
            {
                // Abre un control DateTimePicker cuando el usuario hace clic en el TextBox de fecha
                DateTimePicker dateTimePicker = new DateTimePicker();
                dateTimePicker.Format = DateTimePickerFormat.Short;
                dateTimePicker.Visible = true;
                dateTimePicker.Location = textBox.Location;
                dateTimePicker.Size = textBox.Size;
                dateTimePicker.ValueChanged += (s, args) =>
                {
                    textBox.Text = dateTimePicker.Value.ToString("dd/MM/yy");
                    dateTimePicker.Dispose();
                };

                ((Form)textBox.TopLevelControl).Controls.Add(dateTimePicker);
                dateTimePicker.BringToFront();
                dateTimePicker.Focus();
            };
        }
        public static void ConfigurarTextBoxFechaYY(TextBox textBox)
        {
            // No permitir entrada de texto directamente en TextBox de fecha
            textBox.ReadOnly = true;
            textBox.MouseClick += (sender, e) =>
            {
                // Abre un control DateTimePicker modificado para mostrar solo el año
                DateTimePicker dateTimePicker = new DateTimePicker();
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = "yyyy";
                dateTimePicker.Visible = true;
                dateTimePicker.Location = textBox.Location;
                dateTimePicker.Size = textBox.Size;
                dateTimePicker.ShowUpDown = true; // Mostrar solo el control de flechas arriba/abajo para cambiar el año
                dateTimePicker.ValueChanged += (s, args) =>
                {
                    textBox.Text = dateTimePicker.Value.Year.ToString();
                    dateTimePicker.Dispose();
                };

                ((Form)textBox.TopLevelControl).Controls.Add(dateTimePicker);
                dateTimePicker.BringToFront();
                dateTimePicker.Focus();
            };
        }




        private static void MostrarError(string tipoDato)
        {
            MessageBox.Show($"Error: Solo se permiten caracteres de tipo {tipoDato}.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



