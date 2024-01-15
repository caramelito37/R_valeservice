using Common.Eventos;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Login
{
    public partial class frmRecepcionVehicular : Form
    {
        DRecepcionVehiculo dRecepcionVehiculo = new DRecepcionVehiculo();
        public frmRecepcionVehicular()
        {
            InitializeComponent();
            EventosGlobales.NumeroHojaCambiado += ActualizarTextBox;
        }
        private void ActualizarTextBox(string nuevoNumeroHoja)
        {
            // Actualizar el TextBox del formulario secundario con el nuevo valor
            txtNHojaRecepcion.Text = nuevoNumeroHoja;
        }
        private void frmRecepcionVehicular_Load(object sender, EventArgs e)
        {
            MostrarRecepciones();
            MostrarVehiculosCBX();
            MostrarClientesCBX();
        }
        private void MostrarClientesCBX()
        {
            // Llenar el ComboBox con los DNI de los clientes
            List<int> dniList = dRecepcionVehiculo.MostrarDNIClientesCBX();
            cbxClienteDni.Items.Clear();

            // Convertir cada elemento a cadena antes de agregarlo al ComboBox
            cbxClienteDni.Items.AddRange(dniList.Select(dni => dni.ToString()).ToArray());
        }
        private void MostrarVehiculosCBX()
        {
            List<string> vehiculosList = dRecepcionVehiculo.MostrarVehiculosCBX();

            // Limpiar el ComboBox antes de agregar nuevos elementos
            cbxVehiculoPlaca.Items.Clear();
            // Agregar los elementos al ComboBox
            cbxVehiculoPlaca.Items.AddRange(vehiculosList.ToArray());
        }

        private void MostrarRecepciones()
        {
            DataTable DTrecepciones = dRecepcionVehiculo.MostrarRecepciones();
            dgvRecepcionVehicular.DataSource = DTrecepciones;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }       


        private void txtFechaSalida_TextChanged(object sender, EventArgs e)
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
        private void LimpiarDatosRecepcion()
        {
            mtxtFechaEntrada.Clear();
            mtxtFechaSalida.Clear();
            txtRecepcionAdelanto.Clear();
            cbxClienteDni.SelectedIndex = -1;
            cbxVehiculoPlaca.SelectedIndex = -1;
        }

        #region FORMULARIOS DE BUSCAR CLIENTE Y VEHICULO ---REDUNDANTE
        //private void LimpiarDatosBVehiculo()
        //{
        //    cbxBuscarVehiculo.SelectedIndex = -1;
        //    txtBuscarVehiculo.Clear();
        //}
        //private void LimpiarDatosBCliente()
        //{
        //    cbxBuscarCliente.SelectedIndex = -1;
        //    txtBuscarCliente.Clear();
        //}

        //private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        //{
        //    string opcionSeleccionada = cbxBuscarVehiculo.SelectedItem?.ToString();
        //    string valorBusqueda = txtBuscarVehiculo.Text;

        //    // Verificar que se haya seleccionado una opción y se haya ingresado un valor
        //    if (!string.IsNullOrWhiteSpace(opcionSeleccionada) && !string.IsNullOrWhiteSpace(valorBusqueda))
        //    {
        //        // Llamar al método BuscarVehiculo en la capa de dominio
        //        DataTable resultados = dRecepcionVehiculo.BuscarVehiculo(opcionSeleccionada, valorBusqueda);

        //        // Verificar si hay registros en la DataTable
        //        if (resultados.Rows.Count > 0)
        //        {
        //            // Mostrar los resultados en el DataGridView dgvVehiculos
        //            dgvBuscarVehiculo.DataSource = resultados;
        //            LimpiarDatosBVehiculo();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LimpiarDatosBVehiculo();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, seleccione una opción y escriba un valor antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        // Limpiar datos si la búsqueda no es exitosa
        //        LimpiarDatosBVehiculo();
        //    }
        //}

        //private void btnBuscarCliente_Click(object sender, EventArgs e)
        //{
        //    string opcionSeleccionadaCliente = cbxBuscarCliente.SelectedItem?.ToString();
        //    string valorBusquedaCliente = txtBuscarCliente.Text;

        //    // Verificar que se haya seleccionado una opción y se haya ingresado un valor
        //    if (!string.IsNullOrWhiteSpace(opcionSeleccionadaCliente) && !string.IsNullOrWhiteSpace(valorBusquedaCliente))
        //    {
        //        // Llamar al método BuscarCliente en la capa de dominio
        //        DataTable resultadosCliente = dRecepcionVehiculo.BuscarCliente(opcionSeleccionadaCliente, valorBusquedaCliente);

        //        // Verificar si hay registros en la DataTable
        //        if (resultadosCliente.Rows.Count > 0)
        //        {
        //            // Mostrar los resultados en el DataGridView dgvClientes
        //            dgvBuscarCliente.DataSource = resultadosCliente;
        //            LimpiarDatosBCliente();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LimpiarDatosBCliente();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, seleccione una opción y escriba un valor antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        // Limpiar datos si la búsqueda no es exitosa
        //        LimpiarDatosBCliente();
        //    }
        //}

        #endregion
        private void txtRecepcionId_TextChanged(object sender, EventArgs e)
        {

        }
        private void mtxtFechaEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void dgvRecepcionVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRecepcionVehicular.Rows.Count)
            {
                txtRecepcionId.Text = dgvRecepcionVehicular.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string fechaEntradaValue = dgvRecepcionVehicular.Rows[e.RowIndex].Cells["Entrada"].Value.ToString();
                string fechaSalidaValue = dgvRecepcionVehicular.Rows[e.RowIndex].Cells["Salida"].Value?.ToString();
                txtRecepcionAdelanto.Text = dgvRecepcionVehicular.Rows[e.RowIndex].Cells["Cuenta"].Value.ToString();

                // Si los datos provienen de ComboBox, también puedes seleccionar los elementos correspondientes
                string clienteDni = dgvRecepcionVehicular.Rows[e.RowIndex].Cells["Cliente_DNI"].Value.ToString();
                string vehiculoPlaca = dgvRecepcionVehicular.Rows[e.RowIndex].Cells["Vehiculo_Placa"].Value.ToString();

                // Parsear y formatear la fecha de entrada
                if (DateTime.TryParseExact(fechaEntradaValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaEntrada))
                {
                    mtxtFechaEntrada.Text = fechaEntrada.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Intentar analizar la fecha sin el formato específico
                    if (DateTime.TryParse(fechaEntradaValue, out DateTime fechaEntradaSinFormato))
                    {
                        mtxtFechaEntrada.Text = fechaEntradaSinFormato.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        mtxtFechaEntrada.Text = string.Empty;
                        Console.WriteLine("Error al convertir la fecha de entrada.");
                    }
                }

                // Parsear y formatear la fecha de salida si existe
                if (!string.IsNullOrEmpty(fechaSalidaValue) && DateTime.TryParseExact(fechaSalidaValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaSalida))
                {
                    mtxtFechaSalida.Text = fechaSalida.ToString("dd/MM/yyyy");
                }
                else if (!string.IsNullOrEmpty(fechaSalidaValue))
                {
                    // Intentar analizar la fecha de salida sin el formato específico
                    if (DateTime.TryParse(fechaSalidaValue, out DateTime fechaSalidaSinFormato))
                    {
                        mtxtFechaSalida.Text = fechaSalidaSinFormato.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        mtxtFechaSalida.Text = string.Empty;
                        Console.WriteLine("Error al convertir la fecha de salida.");
                    }
                }
                else
                {
                    mtxtFechaSalida.Text = string.Empty;
                }

                // Asignar valores al resto de los controles
                cbxClienteDni.SelectedItem = clienteDni;
                cbxVehiculoPlaca.SelectedItem = vehiculoPlaca;
            }
        }

        #region BOTONES DE AGREGAR, EDITAR, ELIMINAR, BUSCAR Y REFRESCAR TABLA
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ID = txtRecepcionId.Text;
            string fechaEntrada = mtxtFechaEntrada.Text.Trim();
            string fechaSalida = mtxtFechaSalida.Text;
            string cuenta = txtRecepcionAdelanto.Text;
            string clienteDni = cbxClienteDni.SelectedItem?.ToString();
            string vehiculoPlaca = cbxVehiculoPlaca.SelectedItem?.ToString();

            List<string> camposFaltantes = VerificarCamposFaltantes(
                (fechaEntrada, "Fecha de Entrada"),
                (cuenta, "Cuenta"),
                (clienteDni, "Cliente DNI"),
                (vehiculoPlaca, "Vehículo Placa")
            );

            if (camposFaltantes.Count == 0)
            {
                if (DateTime.TryParseExact(fechaEntrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaEntradaDateTime))
                {
                    DateTime? fechaSalidaDateTime = !string.IsNullOrWhiteSpace(fechaSalida) ?
                        DateTime.TryParseExact(fechaSalida, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime salidaValue) ?
                            salidaValue :
                            (DateTime?)null :
                        null;

                    // Mostrar confirmación antes de agregar la recepción
                    DialogResult confirmacion = MessageBox.Show(
                        $"¿Está seguro de que desea crear una recepción con los siguientes datos?\n\n" +
                        $"Fecha de Entrada: {fechaEntrada}\n" +
                        $"Fecha de Salida: {fechaSalida}\n" +
                        $"Cuenta: {cuenta}\n" +
                        $"Cliente DNI: {clienteDni}\n" +
                        $"Vehículo Placa: {vehiculoPlaca}",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        dRecepcionVehiculo.AgregarRecepcion(fechaEntradaDateTime, fechaSalidaDateTime, Convert.ToDecimal(cuenta), vehiculoPlaca, Convert.ToInt32(clienteDni));
                        MostrarRecepciones();
                        LimpiarDatosRecepcion();
                    }
                }
                else
                {
                    MessageBox.Show("El formato de la fecha de entrada no es válido. Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatosRecepcion();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de agregar una recepción:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosRecepcion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtén el ID de la recepción que deseas eliminar
            int recepcionId = Convert.ToInt32(txtRecepcionId.Text);

            // Pregunta al usuario para confirmar la eliminación
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta recepción?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Llama al método de la capa de dominio para eliminar
                dRecepcionVehiculo.EliminarRecepcion(recepcionId);

                // Actualiza la interfaz de usuario (puedes volver a cargar los datos desde la base de datos, o simplemente eliminar la fila del DataGridView)
                MostrarRecepciones();
                LimpiarDatosRecepcion();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID = txtRecepcionId.Text;
            string fechaEntrada = mtxtFechaEntrada.Text.Trim();
            string fechaSalida = mtxtFechaSalida.Text;
            string cuenta = txtRecepcionAdelanto.Text;
            string clienteDni = cbxClienteDni.SelectedItem?.ToString();
            string vehiculoPlaca = cbxVehiculoPlaca.SelectedItem?.ToString();

            List<string> camposFaltantes = VerificarCamposFaltantes(
                (fechaEntrada, "Fecha de Entrada"),
                (cuenta, "Cuenta"),
                (clienteDni, "Cliente DNI"),
                (vehiculoPlaca, "Vehículo Placa")
            );

            if (camposFaltantes.Count == 0)
            {
                if (DateTime.TryParseExact(fechaEntrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaEntradaDateTime))
                {
                    DateTime? fechaSalidaDateTime = !string.IsNullOrWhiteSpace(fechaSalida) ?
                        DateTime.TryParseExact(fechaSalida, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime salidaValue) ?
                            salidaValue :
                            (DateTime?)null :
                        null;

                    // Mostrar confirmación antes de editar la recepción
                    DialogResult confirmacion = MessageBox.Show(
                        $"¿Está seguro de que desea editar la recepción Nº {ID} con los siguientes datos?\n\n" +
                        $"Fecha de Entrada: {fechaEntrada}\n" +
                        $"Fecha de Salida: {fechaSalida}\n" +
                        $"Cuenta: S/. {cuenta}\n" +
                        $"Cliente DNI: {clienteDni}\n" +
                        $"Vehículo Placa: {vehiculoPlaca}",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Llama al método EditarRecepcion en la capa de dominio
                        dRecepcionVehiculo.EditarRecepcion(Convert.ToInt32(ID), fechaEntradaDateTime, fechaSalidaDateTime, Convert.ToDecimal(cuenta), vehiculoPlaca, Convert.ToInt32(clienteDni));
                        MostrarRecepciones();
                        LimpiarDatosRecepcion();
                    }
                }
                else
                {
                    MessageBox.Show("El formato de la fecha de entrada no es válido. Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatosRecepcion();
                }
            }
            else
            {
                string mensaje = $"Por favor, complete los siguientes campos antes de editar una recepción:\n{string.Join("\n", camposFaltantes)}";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatosRecepcion();
            }

        }

        private void btnBuscarRecepcion_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = cbxBuscarRecepcion.SelectedItem?.ToString();
            string valorBusqueda = txtBuscarRecepcion.Text;

            // Verificar que se haya seleccionado una opción y se haya ingresado un valor
            if (!string.IsNullOrWhiteSpace(opcionSeleccionada) && !string.IsNullOrWhiteSpace(valorBusqueda))
            {
                // Llamar al método BuscarRecepcion en la capa de dominio
                DataTable resultados = dRecepcionVehiculo.BuscarRecepcion(opcionSeleccionada, valorBusqueda);

                // Verificar si hay registros en la DataTable
                if (resultados.Rows.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView dgvRecepciones
                    dgvRecepcionVehicular.DataSource = resultados;
                    LimpiarDatosRecepcion();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatosRecepcion();
                }
            }
            else
            {
                // Mensajes específicos para indicar qué falta
                if (string.IsNullOrWhiteSpace(opcionSeleccionada))
                {
                    MessageBox.Show("Por favor, seleccione una opción antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(valorBusqueda))
                {
                    MessageBox.Show("Por favor, escriba un valor antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Limpiar datos si la búsqueda no es exitosa
                LimpiarDatosRecepcion();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarRecepciones();
        }
        #endregion


    }
}
