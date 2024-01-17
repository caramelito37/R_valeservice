using Common.Eventos;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.FormFlotantes
{
    
    public partial class FHojaRepuestos : Form
    {
        DRepuesto dRepuesto = new DRepuesto();

        public TextBox TxtHojaRespuestoFF => txtHojaRespuestoFF;
        public TextBox TxtNumRepuesto => txtNumRepuesto;
        public TextBox TxtHojaCantidad => txtHojaCantidad;
        public TextBox TxtHojaMarca => txtHojaMarca;
        public TextBox TxtHojaPrecio => txtHojaPrecio;

        public FHojaRepuestos()
        {
            InitializeComponent();
            EventosGlobales.NumeroHojaCambiado += ActualizarTextBox;

        }
        private void ActualizarTextBox(string nuevoNumeroHoja)
        {
            // Actualizar el TextBox del formulario secundario con el nuevo valor
            txtHojaRespuestoFF.Text = nuevoNumeroHoja;
        }
        private void FHojaRepuestos_Load(object sender, EventArgs e)
        {
            MostrarRepuestos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void MostrarRepuestos()
        {
            DRepuesto dRepuesto = new DRepuesto();
            DataTable repuestos = dRepuesto.MostrarRepuestos();
            dgvRepuestos.DataSource = repuestos;
        }

        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRepuestos.Rows.Count)
            {
                txtNumRepuesto.Text = dgvRepuestos.Rows[e.RowIndex].Cells["NumeroFF"].Value.ToString();
                txtRepuestoNombre.Text = dgvRepuestos.Rows[e.RowIndex].Cells["DescripcionFF"].Value.ToString();
            }
        }
        private void txtBuscarRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el texto actual del TextBox
            string textoActual = txtBuscarRepuestoFF.Text;

            switch (e.KeyChar)
            {
                case (char)Keys.Back:
                    // Tecla de retroceso, eliminar el último carácter
                    textoActual = textoActual.Length > 0 ? textoActual.Substring(0, textoActual.Length - 1) : "";
                    break;

                case (char)Keys.Delete:
                    // Tecla Eliminar, verificar si hay al menos una letra antes de procesar
                    if (textoActual.Any(char.IsLetter))
                    {
                        // Llamar a la función de búsqueda con el texto actual
                        BuscarRepuestoDescripcion(textoActual);
                    }
                    else
                    {
                        // Evitar que se realice la acción de eliminar si no hay letras
                        e.Handled = true;
                    }
                    break;

                default:
                    // Otras teclas (letras), concatenar al texto actual
                    if (char.IsLetter(e.KeyChar))
                    {
                        textoActual += e.KeyChar;
                    }
                    break;
            }

            // Llamar a la función de búsqueda con el texto actual
            BuscarRepuestoDescripcion(textoActual);
        }
        private void BuscarRepuestoDescripcion(string valorBusquedaRepuesto)
        {
            string opcionSeleccionadaRepuesto = "Descripcion";  // Siempre establecer la opción como "Descripcion"

            // Llamar al método BuscarRepuesto en la capa de dominio
            DataTable resultadosRepuesto = dRepuesto.BuscarRepuesto(opcionSeleccionadaRepuesto, valorBusquedaRepuesto);

            // Verificar si hay registros en la DataTable
            if (resultadosRepuesto.Rows.Count > 0)
            {
                // Mostrar los resultados en el DataGridView dgvRepuestos
                dgvRepuestos.DataSource = resultadosRepuesto;
            }
        }
    }
}
