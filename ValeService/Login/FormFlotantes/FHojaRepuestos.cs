using Common.Eventos;
using Domain;
using Login.Estilos;
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

        public FHojaRepuestos()
        {
            InitializeComponent();

        }

        private void FHojaRepuestos_Load(object sender, EventArgs e)
        {
            MostrarRepuestos();
            EstilosDGV.AplicarEstilosNoBotones(dgvFFRepuestos);
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
            DataTable repuestos = dRepuesto.MostrarDatosRepuesto();
            dgvFFRepuestos.DataSource = repuestos;
        }
        private void BuscarRepuestoDescripcion(string descripcionBusqueda)
        {
            // Llamar al método BuscarRepuesto en la capa de dominio
            DataTable resultadosRepuesto = dRepuesto.BuscarRepuestoDescripcion(descripcionBusqueda);

            // Verificar si hay registros en la DataTable
            if (resultadosRepuesto.Rows.Count > 0)
            {
                // Mostrar los resultados en el DataGridView dgvRepuestos
                dgvFFRepuestos.DataSource = resultadosRepuesto;
            }
            else
            {
                // No hay resultados, limpiar el DataGridView
                dgvFFRepuestos.DataSource = null;
            }
        }

        private void dgvFFRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFFRepuestos.Rows.Count)
            {
                txtFFHRNumRepuesto.Text = dgvFFRepuestos.Rows[e.RowIndex].Cells["ID de Repuesto"].Value.ToString();
                txtFFHRRepuestoNombre.Text = dgvFFRepuestos.Rows[e.RowIndex].Cells["Descripción de Repuesto"].Value.ToString();
            }
        }

        private void txtBuscarRepuestoFF_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto actual del TextBox
            string textoActual = txtBuscarRepuestoFF.Text;

            BuscarRepuestoDescripcion(textoActual);
        }
    }
}
