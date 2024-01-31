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
using Common.Eventos;
using Login.Estilos;
using Login.FormFlotantes;

namespace Login
{

    public partial class frmHoja : Form
    {
        DHojaRepuesto dHojaRepuesto = new DHojaRepuesto();
        DRecepcionVehiculo dRecepcionVehiculo = new DRecepcionVehiculo();
        DManoDeObra dManoDeObra = new DManoDeObra();
        DManoObraTerceros dManoObraTerceros = new DManoObraTerceros();
        public frmHoja()
        {
            InitializeComponent();
        }


        private void frmHoja_Load(object sender, EventArgs e)
        {


        }
        private void LimpiarDatosRecepciones()
        {
            lblSumaCostoManoObra.Text = "00.00";
            lblSumaCostoRepuestos.Text = "00.00";
            txtIDRecepcion.Clear();
            txtRecepcionNHoja.Clear();
            txtDNICliente.Clear();
            txtNombreCliente.Clear();
            txtContactoCliente.Clear();
            txtPlacaVehiculo.Clear();
            txtMarcaVehiculo.Clear();
            txtModeloVehiculo.Clear();
            txtAnioVehiculo.Clear();
            txtKilometrajeVehiculo.Clear();
            txtFechaEntrada.Clear();
            txtFechaSalida.Clear();
            txtCuentaRecepcion.Clear();
        }
        private void LimpiarDataGridViews()
        {
            dgvRepuestoHoja.Columns.Clear();
            dgvManoObraHoja.Columns.Clear();
            dgvManoObraTercerosHoja.Columns.Clear();
            dgvRepuestoHoja.DataSource = null;
            dgvManoObraHoja.DataSource = null;
            dgvManoObraTercerosHoja.DataSource = null;
        }

        private void MostrarDatosRepuestos()
        {
            // Obtener el número de hoja del TextBox
            if (int.TryParse(txtNumeroHoja.Text, out int numeroHoja))
            {
                // Llamar al método para obtener los datos de los repuestos
                DataTable datosRepuestos = dHojaRepuesto.MostrarHojaRepuestos(numeroHoja);

                // Mostrar los datos en el DataGridView
                dgvRepuestoHoja.DataSource = datosRepuestos;

                // Calcular y mostrar la suma de la columna "Costo"
                decimal sumaCosto = 0;
                foreach (DataRow row in datosRepuestos.Rows)
                {
                    sumaCosto += Convert.ToDecimal(row["Costo"]);
                }
                // Mostrar la suma en el Label
                lblSumaCostoRepuestos.Text = sumaCosto.ToString();
            }
        }
        private void MostrarDatosRecepciones()
        {

            if (int.TryParse(txtNumeroHoja.Text, out int numeroHoja))
            {
                // Llamar al método para obtener los datos de las reparaciones
                DataTable datosRecepciones = dRecepcionVehiculo.MostrarDatosRecepciones(numeroHoja);

                // Verificar si hay al menos una fila de datos
                if (datosRecepciones.Rows.Count > 0)
                {
                    // Mostrar los datos en los TextBox
                    DataRow row = datosRecepciones.Rows[0];

                    txtIDRecepcion.Text = row["ID de Recepción Vehicular"].ToString();
                    txtRecepcionNHoja.Text = row["Número de Hoja"].ToString();
                    txtDNICliente.Text = row["DNI del Cliente"].ToString();
                    txtNombreCliente.Text = row["Nombre y Apellido del Cliente"].ToString();
                    txtContactoCliente.Text = row["Contacto del Cliente"].ToString();
                    txtPlacaVehiculo.Text = row["Placa del Vehículo"].ToString();
                    txtMarcaVehiculo.Text = row["Marca del Vehículo"].ToString();
                    txtModeloVehiculo.Text = row["Modelo del Vehículo"].ToString();
                    txtAnioVehiculo.Text = row["Año del Vehículo"].ToString();
                    txtKilometrajeVehiculo.Text = row["Kilometraje del Vehículo"].ToString();
                    txtFechaEntrada.Text = row["Fecha de Entrada"].ToString();
                    txtFechaSalida.Text = row["Fecha de Salida"].ToString();
                    txtCuentaRecepcion.Text = row["Adelanto de Recepción"].ToString();
                }
                else
                {
                    // Manejar el caso en el que no hay datos para la hoja especificada
                    LimpiarDatosRecepciones();
                }
            }
        }
        private void MostrarDatosManoObra()
        {
            // Obtener el número de hoja del TextBox
            if (int.TryParse(txtNumeroHoja.Text, out int numeroHoja))
            {
                // Llamar al método para obtener los datos de los servicios
                DataTable datosServicios = dManoDeObra.MostrarDatosManoObra(numeroHoja);

                // Mostrar los datos en el DataGridView
                dgvManoObraHoja.DataSource = datosServicios;

                // Calcular y mostrar la suma de la columna "Costo de Mano de Obra"
                decimal sumaCostoManoObra = 0;
                foreach (DataRow row in datosServicios.Rows)
                {
                    sumaCostoManoObra += Convert.ToDecimal(row["Costo de Mano de Obra"]);
                }

                // Mostrar la suma en el Label
                lblSumaCostoManoObra.Text = sumaCostoManoObra.ToString();
            }
        }
        private void MostrarDatosManoObraTerceros()
        {
            // Obtener el número de hoja del TextBox
            if (int.TryParse(txtNumeroHoja.Text, out int numeroHoja))
            {
                // Llamar al método para obtener los datos de los servicios
                DataTable datosServicios = dManoObraTerceros.MostrarDatosManoObraTerceros(numeroHoja);

                // Mostrar los datos en el DataGridView
                dgvManoObraTercerosHoja.DataSource = datosServicios;
            }
        }


        private void txtNumeroHoja_TextChanged_1(object sender, EventArgs e)
        {
            // Verificar si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(txtNumeroHoja.Text))
            {
                LimpiarDataGridViews();// Limpiar el contenido de los DataGridView
                LimpiarDatosRecepciones();// Limpiar los datos de Recepciones
            }
            else
            {
                MostrarDatosRepuestos();
                MostrarDatosManoObra();
                MostrarDatosManoObraTerceros();
                MostrarDatosRecepciones();
                EstilosDGV.AplicarEstilos(dgvRepuestoHoja);
                EstilosDGV.AplicarEstilos(dgvManoObraHoja);
                EstilosDGV.AplicarEstilos(dgvManoObraTercerosHoja);
            }
        }

        private void btnAddRepuestos_Click(object sender, EventArgs e)
        {

        }

        private void btnAddManoObra_Click(object sender, EventArgs e)
        {

        }

        private void btnAddManoObraTerceros_Click(object sender, EventArgs e)
        {
            FManoObraTerceros fManoObraTerceros = new FManoObraTerceros();

            // Aplicar estilos utilizando la clase EstilosFormFlotantes
            EstilosFromFlotantes.AplicarEstilosForm(fManoObraTerceros);

            // Mostrar el formulario
            fManoObraTerceros.ShowDialog();
        }
    }
}
