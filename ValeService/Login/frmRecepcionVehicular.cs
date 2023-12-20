using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmRecepcionVehicular : Form
    {
        DRecepcionVehiculo dRecepcionVehiculo = new DRecepcionVehiculo();
        public frmRecepcionVehicular()
        {
            InitializeComponent();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtFechaSalida_TextChanged(object sender, EventArgs e)
        {

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaEntrada = mtxtFechaEntrada.Text.Trim();  // Trim para eliminar espacios en blanco al inicio y al final
            string fechaSalida = mtxtFechaSalida.Text;
            string cuenta = txtRecepcionAdelanto.Text;
            string clienteDni = cbxClienteDni.SelectedItem?.ToString();
            string vehiculoPlaca = cbxVehiculoPlaca.SelectedItem?.ToString();

            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrEmpty(fechaEntrada))
            {
                camposFaltantes.Add("Fecha de Entrada");
            }

            if (string.IsNullOrWhiteSpace(cuenta))
            {
                camposFaltantes.Add("Cuenta");
            }

            if (string.IsNullOrWhiteSpace(clienteDni))
            {
                camposFaltantes.Add("Cliente DNI");
            }

            if (string.IsNullOrWhiteSpace(vehiculoPlaca))
            {
                camposFaltantes.Add("Vehículo Placa");
            }

            if (camposFaltantes.Count == 0)
            {
                // Intenta analizar la cadena de fechaEntrada en un DateTime con el formato esperado
                if (DateTime.TryParseExact(fechaEntrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaEntradaDateTime))
                {
                    // Parsear la cadena de fechaSalida o asignar null si está vacío
                    DateTime? fechaSalidaDateTime = !string.IsNullOrWhiteSpace(fechaSalida) ?
                        DateTime.TryParseExact(fechaSalida, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime salidaValue) ?
                            salidaValue :
                            (DateTime?)null :
                        null;

                    // Llamar al método AgregarRecepcion en la capa de dominio sin verificar existencia
                    dRecepcionVehiculo.AgregarRecepcion(fechaEntradaDateTime, fechaSalidaDateTime, Convert.ToDecimal(cuenta), vehiculoPlaca, Convert.ToInt32(clienteDni));
                    MostrarRecepciones();

                    // Puedes implementar la actualización de tu interfaz de usuario o cualquier otro proceso necesario aquí
                    LimpiarDatosRecepcion();
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

        private void txtRecepcionId_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtFechaEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
