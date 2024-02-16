using Login.Estilos;
using Login.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Windows.Forms;

namespace Login.FormFlotantes
{
    public partial class FRecepcionVehicular : Form
    {

        DCliente dCliente = new DCliente();
        DVehiculo dVehiculo = new DVehiculo();
        public FRecepcionVehicular()
        {
            InitializeComponent();
            //validaciones de solo se pueda ingresar los tipos de datos requeridos 
            DatoTextBox.ConfigurarTextBoxEntero(txtFFRVid);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFRVnhoja);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFRVDNICliente);
            DatoTextBox.ConfigurarTextBoxString(txtFFRVNombreCliente, 100);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFRVContactoCliente);
            DatoTextBox.ConfigurarTextBoxString(txtFFRVPlacaVehiculo, 7);
            DatoTextBox.ConfigurarTextBoxString(txtFFRVMarcaVehiculo, 50);
            DatoTextBox.ConfigurarTextBoxString(txtFFRVModeloVehiculo, 50);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFRVAnioVehiculo);
            DatoTextBox.ConfigurarTextBoxDecimal(txtFFRVKilometrajeVehiculo);
            DatoTextBox.ConfigurarTextBoxDecimal(txtFFRVCuentaRecepcion);
            DatoTextBox.ConfigurarTextBoxFechaDDMMYY(txtFFRVFechaSalida);
            //bloquear text box
            EstilosTextBox.BloquearTextBox(txtFFRVid, txtFFRVnhoja, txtFFRVDNICliente,
                txtFFRVNombreCliente, txtFFRVContactoCliente, txtFFRVPlacaVehiculo, txtFFRVMarcaVehiculo, 
                txtFFRVModeloVehiculo, txtFFRVAnioVehiculo, txtFFRVKilometrajeVehiculo, txtFFRVFechaSalida);
            // hacer publicos, para acceder a su contenido desde el frmHoja 

        }

        private void FRecepcionVehicular_Load(object sender, EventArgs e) 
        {

            MostrarDatosClientes();
            MostrarDatosdVehiculo();

        }

        public void MostrarDatosClientes()
        {
            DataTable datosClientes = new DataTable();
            datosClientes = dCliente.MostrarDatosClientes();
            dgvFFRVCliente.DataSource = datosClientes;
            EstilosDGV.AplicarEstilosNoBotones(dgvFFRVCliente);
        }
        public void MostrarDatosdVehiculo()
        {
            DataTable datosVehiculo = new DataTable();
            datosVehiculo = dVehiculo.MostrarDatosVehiculos();
            dgvFFRVvehiculo.DataSource = datosVehiculo;
            EstilosDGV.AplicarEstilosNoBotones(dgvFFRVvehiculo);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Crear un diccionario para almacenar los TextBox y sus mensajes de error
            Dictionary<TextBox, string> textBoxes = new Dictionary<TextBox, string>();

            // Verificar según la acción que se esté realizando
            switch (frmHoja.Accion)
            {
                case "agregar":
                    // Agregar los TextBox y sus mensajes de error al diccionario
                    textBoxes.Add(txtFFRVCuentaRecepcion, "adelanto");
                    textBoxes.Add(txtFFRVPlacaVehiculo, "placa del vehículo");
                    textBoxes.Add(txtFFRVDNICliente, "nombre del cliente");
                    break;

                case "salida":
                    // Agregar el TextBox y su mensaje de error al diccionario
                    textBoxes.Add(txtFFRVFechaSalida, "fecha de salida");
                    break;

                // Agrega más casos según sea necesario para otros botones

                default:
                    MessageBox.Show("Error ", "al pulsar btn aceptar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            // Llamar al método LLenarTextBoxObligatorio con el diccionario de TextBoxes
            if (ContenidoTextBox.LLenarTextBoxObligatorio(textBoxes))
            {
                return; // Salir del método si hay campos vacíos
            }

            DialogResult = DialogResult.OK;
            Close();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void dgvFFRVCliente_CellClick(object sender, DataGridViewCellEventArgs e) // asignar valores de CLIENTE AL TEXTBOX
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFFRVCliente.Rows.Count)
            {
                txtFFRVDNICliente.Text = dgvFFRVCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFFRVNombreCliente.Text = dgvFFRVCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtFFRVContactoCliente.Text = dgvFFRVCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void dgvFFRVvehiculo_CellClick(object sender, DataGridViewCellEventArgs e) // asignar valores de VEHICULO AL TEXTBOX
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFFRVvehiculo.Rows.Count)
            {
                txtFFRVPlacaVehiculo.Text = dgvFFRVvehiculo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFFRVMarcaVehiculo.Text = dgvFFRVvehiculo.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtFFRVModeloVehiculo.Text = dgvFFRVvehiculo.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtFFRVAnioVehiculo.Text = dgvFFRVvehiculo.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtFFRVKilometrajeVehiculo.Text = dgvFFRVvehiculo.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }


    }
}
