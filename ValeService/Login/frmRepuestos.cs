using Common.Eventos;
using Domain;
using Login.FormFlotantes;
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
        DHojaRepuesto dHojaRepuesto = new DHojaRepuesto();
        public frmRepuestos()
        {
            InitializeComponent();
            EventosGlobales.NumeroHojaCambiado += ActualizarTextBox;

        }
        private void ActualizarTextBox(string nuevoNumeroHoja)
        {
            // Actualizar el TextBox del formulario secundario con el nuevo valor
            txtNHojaRepuestos.Text = nuevoNumeroHoja;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            MostrarManoDeObraHoja();
            MostrarRepuestos();
        }


        //FUNCION PARA VERIFICAR SI FALTAN LLENAR ALGUNOS CAMPOS 
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

        private void MostrarManoDeObraHoja()
        {
            DataTable dtHojaRepuesto = dHojaRepuesto.MostrarHojaRepuestos(int.Parse(txtNHojaRepuestos.Text));
            dgvHojaRepuestos.DataSource = dtHojaRepuesto;
        }

        //MOSTRAR REPUESTOS DEN EL DGV 
        private void MostrarRepuestos()
        {
            DRepuesto dRepuesto = new DRepuesto();
            DataTable repuestos = dRepuesto.MostrarRepuestos();
            dgvRepuestos.DataSource = repuestos;
        }        

        #region ------ PROGRAMACION DE BOTONES AGREGAR,EDITAR,ELIMINAR Y ACTUALIZAR BUSCAR -- CLICK EN EL DGV   ---------------------/----------/
        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvRepuestos.Rows.Count)
                return;

            if (!(dgvRepuestos.Columns[e.ColumnIndex] is DataGridViewImageColumn))
                return;

            string columnName = dgvRepuestos.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "btnRowEliminar":
                    string idEliminar = dgvRepuestos.Rows[e.RowIndex].Cells["Numero"].Value?.ToString();
                    EliminarRepuesto(idEliminar);
                    break;

                case "btnRowEditar":
                    string idEditar = dgvRepuestos.Rows[e.RowIndex].Cells["Numero"].Value?.ToString();
                    string descripcionActual = dgvRepuestos.Rows[e.RowIndex].Cells["Descripcion"].Value?.ToString();
                    MostrarFormularioEdicion(idEditar, descripcionActual);
                    break;


            }
        }

        private void MostrarFormularioEdicion(string id, string descripcionActual)
        {
            // Crear una instancia del formulario FRepuestos
            FRepuestos formularioEdicion = new FRepuestos();

            // Asignar los valores actuales a los controles del formulario
            formularioEdicion.TxtFRId.Text = id;
            formularioEdicion.TxtFRDescripcion.Text = descripcionActual;

            // Mostrar el formulario de edición y manejar el resultado
            DialogResult resultado = formularioEdicion.ShowDialog();

            // Procesar el resultado del formulario
            if (resultado == DialogResult.OK)
            {
                // Obtener los nuevos valores del formulario
                string nuevoId = formularioEdicion.TxtFRId.Text.Trim();
                string nuevaDescripcion = formularioEdicion.TxtFRDescripcion.Text.Trim();

                // Validar campos antes de guardar
                List<string> camposFaltantes = VerificarCamposFaltantes(
                    (nuevaDescripcion, "Nueva Descripción")
                );

                if (camposFaltantes.Count == 0)
                {
                        // Llamada al método de la capa de datos para guardar la nueva descripción
                        DRepuesto dRepuesto = new DRepuesto();
                        dRepuesto.EditarRepuesto(int.Parse(nuevoId), nuevaDescripcion);

                        // Actualizar la vista después de guardar
                        MostrarRepuestos();
                        formularioEdicion.Dispose();
                }
                else
                {
                    string mensaje = $"Por favor, complete los siguientes campos antes de guardar:\n{string.Join("\n", camposFaltantes)}";
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void EliminarRepuesto(string id)
        {
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
                        // Llamada al método de la capa de datos para eliminar el repuesto
                        dRepuesto.EliminarRepuesto(repuestoId);

                        // Actualizar la vista después de eliminar
                        MostrarRepuestos();
                    }
                    else
                    {
                        MessageBox.Show("El ID del repuesto no es válido. Por favor, seleccione un repuesto existente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un repuesto existente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FRepuestos
            FRepuestos formularioAgregar = new FRepuestos();

            // Mostrar el formulario de agregar y manejar el resultado
            DialogResult resultado = formularioAgregar.ShowDialog();

            // Procesar el resultado del formulario
            if (resultado == DialogResult.OK)
            {
                // Obtener los valores ingresados en el formulario
                string Descripcion = formularioAgregar.TxtFRDescripcion.Text.Trim();

                // Validar campos antes de agregar
                List<string> camposFaltantes = VerificarCamposFaltantes(
                    (Descripcion, "Descripción")
                );

                if (camposFaltantes.Count == 0)
                {
                    // Mostrar confirmación antes de agregar el repuesto
                    DialogResult confirmacion = MessageBox.Show(
                        $"¿Está seguro de que desea agregar un repuesto con la siguiente descripción?\n\n" +
                        $"Descripción: {Descripcion}",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Llamada al método de la capa de datos para agregar el nuevo repuesto
                        DRepuesto dRepuesto = new DRepuesto();
                        dRepuesto.AgregarRepuesto(Descripcion);

                        // Actualizar la vista después de agregar
                        MostrarRepuestos();
                    }
                }
                else
                {
                    string mensaje = $"Por favor, complete los siguientes campos antes de agregar un repuesto:\n{string.Join("\n", camposFaltantes)}";
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }

        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarRepuestos();
        }



        #endregion

        private void dgvHojaRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHojaRepuestos.Rows.Count)
                return;

            if (!(dgvHojaRepuestos.Columns[e.ColumnIndex] is DataGridViewImageColumn))
                return;

            string columnName = dgvRepuestos.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "btnRowEliminar":
                    string idEliminar = dgvRepuestos.Rows[e.RowIndex].Cells["Numero"].Value?.ToString();
                    FHojaRepuestos fHojaRepuestos = new FHojaRepuestos();
                    DialogResult resultado = fHojaRepuestos.ShowDialog();
                    break;

                case "btnRowEditar":
                    string idEditar = dgvRepuestos.Rows[e.RowIndex].Cells["Numero"].Value?.ToString();
                    string descripcionActual = dgvRepuestos.Rows[e.RowIndex].Cells["Descripcion"].Value?.ToString();
                    MostrarFormularioEdicion(idEditar, descripcionActual);
                    break;
            }

        }

        private void btnHojaEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnHojaAgregar_Click(object sender, EventArgs e)
        {
            FHojaRepuestos fHojaRepuestos = new FHojaRepuestos();

            // Asegúrate de que txtHojaRespuestoFF esté inicializado antes de asignarle un valor.
            if (fHojaRepuestos.txtHojaRespuestoFF != null)
            {
                fHojaRepuestos.txtHojaRespuestoFF.Text = this.txtHojaRespuesto.Text;
                fHojaRepuestos.Show();
            }
        }
    }
}
