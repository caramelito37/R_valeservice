using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Estilos
{
    public class EstilosDGV
    {
        public static void AplicarEstilosSiBotones(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false; // Desactivar los estilos visuales predeterminados de los encabezados
            dgv.BackgroundColor = Color.FromArgb(255, 255, 255);  // color de fondo del dgv blanco 
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(42, 54, 75); // Color de fondo
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Color de las letras
            dgv.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra para las celdas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra y hacerla negrita para los encabezados de columna
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra para los encabezados de fila (si aplicable)
            dgv.DefaultCellStyle.ForeColor = Color.Black; // color de las letras de las filas a negro

            // Ocultar la primera columna (row headers)
            dgv.RowHeadersVisible = false;

            // Desactivar la capacidad de cambiar la altura de las filas
            dgv.AllowUserToResizeRows = false;

            // Verificar si el DataGridView tiene contenido
            if (dgv.Rows.Count > 0)
            {
                // Verificar si ya existen columnas con los nombres "Editar" y "Eliminar"
                bool existeColumnaEditar = dgv.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == "Editar");
                bool existeColumnaEliminar = dgv.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == "Eliminar");

                // Crear columna "Editar" si no existe
                if (!existeColumnaEditar)
                {
                    DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
                    columnaEditar.HeaderText = "Editar";
                    columnaEditar.Name = "Editar"; // Nombre de la columna
                    columnaEditar.Image = Properties.Resources.editar;
                    columnaEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgv.Columns.Add(columnaEditar);
                }

                // Crear columna "Eliminar" si no existe
                if (!existeColumnaEliminar)
                {
                    DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
                    columnaEliminar.HeaderText = "Eliminar";
                    columnaEliminar.Name = "Eliminar"; // Nombre de la columna
                    columnaEliminar.Image = Properties.Resources.eliminar;
                    columnaEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgv.Columns.Add(columnaEliminar);
                }

            }
        }
        public static void AplicarEstilosNoBotones(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false; // Desactivar los estilos visuales predeterminados de los encabezados
            dgv.BackgroundColor = Color.FromArgb(255, 255, 255);  // color de fondo del dgv blanco 
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(42, 54, 75); // Color de fondo
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Color de las letras
            dgv.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra para las celdas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra y hacerla negrita para los encabezados de columna
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular); // Cambiar el tamaño de la letra para los encabezados de fila (si aplicable)
            dgv.DefaultCellStyle.ForeColor = Color.Black; // color de las letras de las filas a negro


            // Ocultar la primera columna (row headers)
            dgv.RowHeadersVisible = false;

            // Desactivar la capacidad de cambiar la altura de las filas
            dgv.AllowUserToResizeRows = false;
        }
    }
}
