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

namespace Login
{
    public partial class frmReparaciones : Form
    {
        DReparacion dReparacion = new DReparacion();
        public frmReparaciones()
        {
            InitializeComponent();
            EventosGlobales.NumeroHojaCambiado += ActualizarTextBox;
        }
        private void ActualizarTextBox(string nuevoNumeroHoja)
        {
            // Actualizar el TextBox del formulario secundario con el nuevo valor
            txtNHojaReparacion.Text = nuevoNumeroHoja;
        }
        private void MostrarReparaciones()
        {

        }
        private void MostrarManoDeObraHoja()
        {
            DManoDeObra dManoDeObra = new DManoDeObra();
            DataTable manoDeObra = dManoDeObra.MostrarManoDeObraHoja(int.Parse(txtManoObraNHoja.Text));
            dgvManoDeObra.DataSource = manoDeObra;
        }
        private void MostrarManoDeObra()
        {

        }




        private void frmReparaciones_Load(object sender, EventArgs e)
        {
            MostrarReparaciones();
            MostrarManoDeObraHoja();
        }        

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
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
        private void LimpiarDatosReparacion()
        {
            // Limpia los campos de entrada de datos para repuestos
            txtServicioDescripcion.Clear();
            txtServicioId.Clear();
        }
        private void LimpiarDatosManoDeObra()
        {
            txtManoObraNHoja.Text = "";
            txtManoNServicio.Text = "";
            txtManoObraCantidad.Text = "";
            txtManoObraCosto.Text = "";
            txtManoObraTiempo.Text = "";
        }
        private void dgvReparaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvReparaciones.Rows.Count)
            {
                // Supongamos que las columnas de tu DataGridView tienen nombres "Repuesto_Id" y "Repuesto_Descripcion"
                txtServicioId.Text = dgvReparaciones.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                txtServicioDescripcion.Text = dgvReparaciones.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtManoNServicio.Text = dgvReparaciones.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
            }
        }

        private void dgvManoDeObra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvManoDeObra.Rows.Count)
            {
                txtManoObraNHoja.Text = dgvManoDeObra.Rows[e.RowIndex].Cells["Hoja_Numero"].Value.ToString();
                txtManoNServicio.Text = dgvManoDeObra.Rows[e.RowIndex].Cells["ServiciosMecanicos_Id"].Value.ToString();
                txtManoObraCantidad.Text = dgvManoDeObra.Rows[e.RowIndex].Cells["ManoDeObra_Cantidad"].Value.ToString();
                txtManoObraCosto.Text = dgvManoDeObra.Rows[e.RowIndex].Cells["ManoDeObra_Costo"].Value.ToString();
                txtManoObraTiempo.Text = dgvManoDeObra.Rows[e.RowIndex].Cells["ManoDeObra_Tiempo"].Value.ToString();
            }
        }
        #region SERVICIOS MECANICOS -------------------------- BOTONES DE AGREGAR ELIMINAR EDITAR Y BUSCAR DE SERVICIOS MECANICOS 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string servicioId = txtServicioId.Text;
            string servicioDescripcion = txtServicioDescripcion.Text.Trim();

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (servicioDescripcion, "Descripción del Servicio")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de agregar la reparación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea agregar un servicio con la siguiente descripción?\n\n" +
                    $"Descripción: {servicioDescripcion}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar al método AgregarReparacion en la clase DReparacion
                    DReparacion dReparacion = new DReparacion();
                    dReparacion.AgregarReparacion(servicioDescripcion);
                    MostrarReparaciones();  // Asegúrate de tener un método similar para actualizar la vista
                    LimpiarDatosReparacion();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de agregar un servicio:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosReparacion();
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la reparación desde el TextBox
            string servicioId = txtServicioId.Text.Trim();

            // Verificar si el ID es válido (no está vacío)
            if (!string.IsNullOrWhiteSpace(servicioId))
            {
                // Mostrar confirmación antes de eliminar la reparación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el servicio con el siguiente ID?\n\n" +
                    $"ID: {servicioId}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    DReparacion dReparacion = new DReparacion();

                    // Convertir el ID a un entero
                    if (int.TryParse(servicioId, out int reparacionId))
                    {
                        dReparacion.EliminarReparacion(reparacionId);
                        MostrarReparaciones();  // Actualizar la vista después de eliminar
                        LimpiarDatosReparacion();
                    }
                    else
                    {
                        MessageBox.Show("El ID del servicio no es válido. Por favor, seleccione un servicio existente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarDatosReparacion();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio existente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosReparacion();
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string servicioId = txtServicioId.Text.Trim();
            string servicioDescripcion = txtServicioDescripcion.Text.Trim();

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (servicioDescripcion, "Descripción del Servicio")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de editar la reparación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea editar el servicio con el siguiente ID y descripción?\n\n" +
                    $"ID: {servicioId}\n" +
                    $"Descripción: {servicioDescripcion}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    DReparacion dReparacion = new DReparacion();

                    // Convertir el ID a un entero
                    if (int.TryParse(servicioId, out int reparacionId))
                    {
                        dReparacion.EditarReparacion(reparacionId, servicioDescripcion);
                        MostrarReparaciones();  // Asegúrate de tener un método similar para actualizar la vista
                        LimpiarDatosReparacion();
                    }
                    else
                    {
                        MessageBox.Show("El ID del servicio no es válido. Por favor, seleccione un servicio existente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarDatosReparacion();
                    }
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de editar un servicio:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosReparacion();
            }
        }
        private void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            string opcionSeleccionadaReparacion = cbxBuscarServicio.SelectedItem?.ToString();
            string valorBusquedaReparacion = txtBuscarServicio.Text;

            // Verificar que se haya seleccionado una opción y se haya ingresado un valor
            if (!string.IsNullOrWhiteSpace(opcionSeleccionadaReparacion) && !string.IsNullOrWhiteSpace(valorBusquedaReparacion))
            {
                // Llamar al método BuscarReparacion en la capa de dominio
                DataTable resultadosReparacion = dReparacion.BuscarReparacion(opcionSeleccionadaReparacion, valorBusquedaReparacion);

                // Verificar si hay registros en la DataTable
                if (resultadosReparacion.Rows.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView dgvReparaciones
                    dgvReparaciones.DataSource = resultadosReparacion;
                    LimpiarDatosReparacion();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatosReparacion();
                }
            }
            else
            {
                // Mensajes específicos para indicar qué falta
                if (string.IsNullOrWhiteSpace(opcionSeleccionadaReparacion))
                {
                    MessageBox.Show("Por favor, seleccione una opción antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(valorBusquedaReparacion))
                {
                    MessageBox.Show("Por favor, escriba un valor antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Limpiar datos si la búsqueda no es exitosa
                LimpiarDatosReparacion();
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarReparaciones();
        }

        #endregion



        private void btnLIstarObra_Click(object sender, EventArgs e)
        {
            MostrarManoDeObra();
        }

        private void btnObraAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string manoObraNHoja = txtManoObraNHoja.Text;
            string nServicio = txtManoNServicio.Text;
            string manoObraCantidad = txtManoObraCantidad.Text;
            string manoObraCosto = txtManoObraCosto.Text;
            string manoObraTiempo = txtManoObraTiempo.Text;

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (manoObraNHoja, "Número de Hoja"),
                (nServicio, "Número de Servicio"),
                (manoObraCantidad, "Cantidad de Mano de Obra"),
                (manoObraCosto, "Costo de Mano de Obra"),
                (manoObraTiempo, "Tiempo de Mano de Obra")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de agregar la mano de obra
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea agregar una mano de obra con los siguientes detalles?\n\n" +
                    $"Número de Hoja: {manoObraNHoja}\n" +
                    $"Número de Servicio: {nServicio}\n" +
                    $"Cantidad: {manoObraCantidad}\n" +
                    $"Costo: {manoObraCosto}\n" +
                    $"Tiempo: {manoObraTiempo}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar al método AgregarManoDeObra en la clase DManoDeObra
                    DManoDeObra dManoDeObra = new DManoDeObra();
                    int hojaNumero = int.Parse(manoObraNHoja);
                    int cantidad = int.Parse(manoObraCantidad);
                    decimal costo = decimal.Parse(manoObraCosto);
                    int tiempo = int.Parse(manoObraTiempo);
                    int servicioId = int.Parse(nServicio);

                    dManoDeObra.AgregarManoDeObra(hojaNumero, cantidad, costo, tiempo, servicioId);
                    MostrarManoDeObraHoja(); // Asegúrate de tener un método similar para actualizar la vista
                    LimpiarDatosManoDeObra();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de agregar una mano de obra:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosManoDeObra();
            }
        }
        private void btnObraEliminar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string manoObraNHoja = txtManoObraNHoja.Text;
            string nServicio = txtManoNServicio.Text;
            string manoObraCantidad = txtManoObraCantidad.Text;
            string manoObraCosto = txtManoObraCosto.Text;
            string manoObraTiempo = txtManoObraTiempo.Text;

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (manoObraNHoja, "Número de Hoja"),
                (nServicio, "Número de Servicio"),
                (manoObraCantidad, "Cantidad de Mano de Obra"),
                (manoObraCosto, "Costo de Mano de Obra"),
                (manoObraTiempo, "Tiempo de Mano de Obra")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de eliminar la mano de obra
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la mano de obra con los siguientes detalles?\n\n" +
                    $"Número de Hoja: {manoObraNHoja}\n" +
                    $"Número de Servicio: {nServicio}\n" +
                    $"Cantidad: {manoObraCantidad}\n" +
                    $"Costo: {manoObraCosto}\n" +
                    $"Tiempo: {manoObraTiempo}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar al método EliminarManoDeObra en la clase DManoDeObra
                    DManoDeObra dManoDeObra = new DManoDeObra();
                    int hojaNumero = int.Parse(manoObraNHoja);
                    int cantidad = int.Parse(manoObraCantidad);
                    decimal costo = decimal.Parse(manoObraCosto);
                    int tiempo = int.Parse(manoObraTiempo);
                    int servicioId = int.Parse(nServicio);

                    dManoDeObra.EliminarManoDeObra(hojaNumero, cantidad, costo, tiempo, servicioId);
                    MostrarManoDeObraHoja(); // Asegúrate de tener un método similar para actualizar la vista
                    LimpiarDatosManoDeObra();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de eliminar la mano de obra:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosManoDeObra();
            }


        }

        private void btnObraEditar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string manoObraNHoja = txtManoObraNHoja.Text;
            string nServicio = txtManoNServicio.Text;
            string manoObraCantidad = txtManoObraCantidad.Text;
            string manoObraCosto = txtManoObraCosto.Text;
            string manoObraTiempo = txtManoObraTiempo.Text;

            // Verificar si hay campos faltantes
            List<string> camposFaltantes = VerificarCamposFaltantes(
                (manoObraNHoja, "Número de Hoja"),
                (nServicio, "Número de Servicio"),
                (manoObraCantidad, "Cantidad de Mano de Obra"),
                (manoObraCosto, "Costo de Mano de Obra"),
                (manoObraTiempo, "Tiempo de Mano de Obra")
            );

            if (camposFaltantes.Count == 0)
            {
                // Mostrar confirmación antes de editar la mano de obra
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea editar la mano de obra con los siguientes detalles?\n\n" +
                    $"Número de Hoja: {manoObraNHoja}\n" +
                    $"Número de Servicio: {nServicio}\n" +
                    $"Cantidad: {manoObraCantidad}\n" +
                    $"Costo: {manoObraCosto}\n" +
                    $"Tiempo: {manoObraTiempo}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar al método EditarManoDeObra en la clase DManoDeObra
                    DManoDeObra dManoDeObra = new DManoDeObra();
                    int hojaNumero = int.Parse(manoObraNHoja);
                    int cantidad = int.Parse(manoObraCantidad);
                    decimal costo = decimal.Parse(manoObraCosto);
                    int tiempo = int.Parse(manoObraTiempo);
                    int servicioId = int.Parse(nServicio);

                    dManoDeObra.EditarManoDeObra(hojaNumero, cantidad, costo, tiempo, servicioId);
                    MostrarManoDeObraHoja(); // Asegúrate de tener un método similar para actualizar la vista
                    LimpiarDatosManoDeObra();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de editar la mano de obra:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosManoDeObra();
            }
        }


    }
}
