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
            string fechaEntrada = txtFechaEntrada.Text;
            string fechaSalida = txtFechaSalida.Text;
            string recepcionAdelanto = txtRecepcionAdelanto.Text;
            string clienteDni = cbxClienteDni.SelectedValue?.ToString();
            string vehiculoPlaca = cbxVehiculoPlaca.SelectedValue?.ToString();


        }
    }
}
