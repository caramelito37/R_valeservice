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
            Common.NHoja.Configuracion.NumeroHojaCambiado += ActualizarTextBox;

        }
        private void ActualizarTextBox(string nuevoNumeroHoja)
        {
            txtNHojaRepuestos.Text = nuevoNumeroHoja;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            MostrarHojaRepuestos();
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

        private void MostrarHojaRepuestos()
        {
            if (!string.IsNullOrEmpty(txtNHojaRepuestos.Text))
            {
                DataTable dtHojaRepuesto = dHojaRepuesto.MostrarHojaRepuestos(int.Parse(txtNHojaRepuestos.Text));

                // Verificar si el DataTable contiene al menos una fila antes de asignarlo al DataSource
                if (dtHojaRepuesto.Rows.Count > 0)
                {
                    dgvHojaRepuestos.DataSource = dtHojaRepuesto;
                }
            }
        }

        //MOSTRAR REPUESTOS DEN EL DGV 
        private void MostrarRepuestos()
        {
            DRepuesto dRepuesto = new DRepuesto();
            DataTable repuestos = dRepuesto.MostrarDatosRepuesto();
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
            fHojaRepuestos.txtFFHRHoja.Text = txtNHojaRepuestos.Text;
            fHojaRepuestos.Show();
        }

        private void txtNHojaRepuestos_TextChanged(object sender, EventArgs e)
        {
            MostrarHojaRepuestos();

        }
    }
}
