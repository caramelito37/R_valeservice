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

namespace Login
{
    public partial class frmRepuestos : Form
    {
        DRepuesto dRepuesto = new DRepuesto();
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            MostrarRepuestos();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cbxBuscarRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        
        private List<string> VerificarCamposFaltantes(params (string valor, string nombreCampo)[] campos)
        {
            List<string> camposFaltantes = new List<string>();

            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.valor))
                {
                    camposFaltantes.Add(campo.nombreCampo);
                }
            }

            return camposFaltantes;
        }
        private void LimpiarDatosRepuesto()
        {
            // Limpia los campos de entrada de datos para repuestos
            txtDescripcionRepuesto.Clear();
            txtRepuestoId.Clear();
        }
        private void LimpiarDatosHojaRepuesto()
        {
            // Limpia los campos de entrada de datos para repuestos

        }
        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRepuestos.Rows.Count)
            {
                // Supongamos que las columnas de tu DataGridView tienen nombres "Repuesto_Id" y "Repuesto_Descripcion"
                txtRepuestoId.Text = dgvRepuestos.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                txtDescripcionRepuesto.Text = dgvRepuestos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            }
        }        
        private void MostrarRepuestos()
        {
            DRepuesto dRepuesto = new DRepuesto();
            DataTable repuestos = dRepuesto.MostrarRepuestos();
            dgvRepuestos.DataSource = repuestos;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txtRepuestoId.Text.Trim();
            string descripcion = txtDescripcionRepuesto.Text.Trim();

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (descripcion, "Descripción del Repuesto")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de agregar el repuesto
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea agregar un repuesto con la siguiente descripción?\n\n" +
                    $"Descripción: {descripcion}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    dRepuesto.AgregarRepuesto(descripcion);
                    MostrarRepuestos();  // Asegúrate de tener un método similar para actualizar la vista
                    LimpiarDatosRepuesto();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de agregar un repuesto:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosRepuesto();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del repuesto directamente de la base de datos
            string id = txtRepuestoId.Text.Trim();
            string descripcion = txtDescripcionRepuesto.Text.Trim();

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (descripcion, "Descripción del Repuesto")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de editar el repuesto
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea editar el repuesto con el siguiente ID y descripción?\n\n" +
                    $"ID: {id}\n" +
                    $"Descripción: {descripcion}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    DRepuesto dRepuesto = new DRepuesto();

                    // Convertir el ID a un entero
                    if (int.TryParse(id, out int repuestoId))
                    {
                        dRepuesto.EditarRepuesto(repuestoId, descripcion);
                        MostrarRepuestos();  // Asegúrate de tener un método similar para actualizar la vista
                        LimpiarDatosRepuesto();
                    }
                    else
                    {
                        MessageBox.Show("El ID del repuesto no es válido. Por favor, seleccione un repuesto existente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarDatosRepuesto();
                    }
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de editar un repuesto:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosRepuesto();
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del repuesto desde el TextBox
            string id = txtRepuestoId.Text.Trim();

            // Verificar si el ID es válido (no está vacío)
            if (!string.IsNullOrWhiteSpace(id))
            {
                // Mostrar confirmación antes de eliminar el repuesto
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el repuesto con el siguiente ID?\n\n" +
                    $"ID: {id}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    DRepuesto dRepuesto = new DRepuesto();

                    // Convertir el ID a un entero
                    if (int.TryParse(id, out int repuestoId))
                    {
                        dRepuesto.EliminarRepuesto(repuestoId);
                        MostrarRepuestos();  // Actualizar la vista después de eliminar
                        LimpiarDatosRepuesto();
                    }
                    else
                    {
                        MessageBox.Show("El ID del repuesto no es válido. Por favor, seleccione un repuesto existente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarDatosRepuesto();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un repuesto existente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosRepuesto();
            }
        }
        private void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            string opcionSeleccionadaRepuesto = cbxBuscarRepuesto.SelectedItem?.ToString();
            string valorBusquedaRepuesto = txtBuscarRepuesto.Text;

            // Verificar que se haya seleccionado una opción y se haya ingresado un valor
            if (!string.IsNullOrWhiteSpace(opcionSeleccionadaRepuesto) && !string.IsNullOrWhiteSpace(valorBusquedaRepuesto))
            {
                // Llamar al método BuscarRepuesto en la capa de dominio
                DataTable resultadosRepuesto = dRepuesto.BuscarRepuesto(opcionSeleccionadaRepuesto, valorBusquedaRepuesto);

                // Verificar si hay registros en la DataTable
                if (resultadosRepuesto.Rows.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView dgvRepuestos
                    dgvRepuestos.DataSource = resultadosRepuesto;
                    LimpiarDatosRepuesto();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatosRepuesto();
                }
            }
            else
            {
                // Mensajes específicos para indicar qué falta
                if (string.IsNullOrWhiteSpace(opcionSeleccionadaRepuesto))
                {
                    MessageBox.Show("Por favor, seleccione una opción antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(valorBusquedaRepuesto))
                {
                    MessageBox.Show("Por favor, escriba un valor antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Limpiar datos si la búsqueda no es exitosa
                LimpiarDatosRepuesto();
            }

        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarRepuestos();
        }

        private void btnHojaAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
