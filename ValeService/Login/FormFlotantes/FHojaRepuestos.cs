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
        public TextBox TxtHojaRespuesto => txtHojaRespuesto;
        public TextBox TxtNumRepuesto => txtNumRepuesto;
        public TextBox TxtHojaCantidad => txtHojaCantidad;
        public TextBox TxtHojaMarca => txtHojaMarca;
        public TextBox TxtHojaPrecio => txtHojaPrecio;

        public FHojaRepuestos()
        {
            InitializeComponent();
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
            // Verificar si la tecla presionada es una letra o una tecla de eliminación (Delete o Backspace)
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                // Obtener el texto actual del TextBox
                string textoActual = txtBuscarRepuestoFF.Text;

                // Si la tecla presionada no es una tecla de eliminación, concatenar la letra al texto actual
                if (e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
                {
                    textoActual += e.KeyChar;
                }

                // Llamar a la función de búsqueda
                BuscarRepuestoDescripcion(textoActual);
            }
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
            else
            {
                // No mostrar mensajes si no hay resultados
                dgvRepuestos.DataSource = null; // Limpiar el DataGridView en caso de que no haya resultados
            }
        }
    }
}
