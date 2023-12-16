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
using Domain;

namespace Login
{
    public partial class frmVehiculos : Form
    {   
        DVehiculo DVehiculo = new DVehiculo();
        public frmVehiculos()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
        }
        private void MostrarVehiculos()
        {
            DataTable vehiculoTable = DVehiculo.MostrarVehiculos();
            dgvVehiculos.DataSource = vehiculoTable;
        }
        private void frmAutos_Load(object sender, EventArgs e)
        {
            cbxBuscarVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            MostrarVehiculos();

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarDatos()
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
            txtKilome.Clear();
            txtBuscarCliente.Clear();
            cbxBuscarVehiculo.SelectedIndex = -1;

        }//FUNCION PARA LIMPIAR LOS TEXT BOX Y COMBO BOX
        private void dgvVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvVehiculos.Rows.Count)
            {
                txtPlaca.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Vehiculo_Placa"].Value.ToString();
                txtMarca.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Vehiculo_Marca"].Value.ToString();
                txtModelo.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Vehiculo_Modelo"].Value.ToString();
                txtAño.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Vehiculo_Año"].Value.ToString();
                txtKilome.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Vehiculo_Kilometraje"].Value.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string año = txtAño.Text;
            string km = txtKilome.Text;

            if (!string.IsNullOrWhiteSpace(placa) && !string.IsNullOrWhiteSpace(marca) && !string.IsNullOrWhiteSpace(modelo) && !string.IsNullOrWhiteSpace(año) && !string.IsNullOrWhiteSpace(km))
            {
                // Intenta analizar la cadena del año en un DateTime con el formato esperado (yyyy)
                DateTime añoDateTime;

                if (DateTime.TryParseExact(año, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out añoDateTime))
                {
                    // Verificar si el vehículo ya existe en la base de datos usando el método de la capa de dominio
                    if (!DVehiculo.VehiculoExiste(placa))
                    {
                        // Mostrar un mensaje de confirmación antes de agregar el vehículo
                        DialogResult result = MessageBox.Show($"¿Seguro que deseas agregar el vehículo con placa '{placa}'?\n\nDetalles del nuevo vehículo:\nPlaca: {placa}\nMarca: {marca}\nModelo: {modelo}\nAño: {año}\nKilometraje: {km}", "Confirmar agregación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Llamar al método AgregarVehiculo en la capa de dominio
                            DVehiculo.AgregarVehiculo(placa, marca, modelo, añoDateTime, Convert.ToInt32(km));
                            MostrarVehiculos();  // Puedes implementar este método para reflejar los cambios en tu formulario
                            LimpiarDatos();
                        }
                        // Si el usuario hace clic en "No", no se realiza la adición
                    }
                    else
                    {
                        MessageBox.Show("El vehículo ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("El formato del año no es válido. Por favor, ingrese un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un vehículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string año = txtAño.Text;
            string km = txtKilome.Text;

            if (!string.IsNullOrWhiteSpace(placa) && !string.IsNullOrWhiteSpace(marca) && !string.IsNullOrWhiteSpace(modelo) && !string.IsNullOrWhiteSpace(año) && !string.IsNullOrWhiteSpace(km))
            {
                // Intenta analizar la cadena del año en un DateTime con el formato esperado (yyyy)
                DateTime añoDateTime;

                if (DateTime.TryParseExact(año, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out añoDateTime))
                {
                    // Verificar si el vehículo ya existe en la base de datos usando el método de la capa de dominio
                    if (DVehiculo.VehiculoExiste(placa))
                    {
                        // Mostrar un mensaje de confirmación antes de editar el vehículo
                        DialogResult result = MessageBox.Show($"¿Seguro que deseas editar el vehículo con placa '{placa}'?\n\nDetalles del vehículo a editar:\nPlaca: {placa}\nMarca: {marca}\nModelo: {modelo}\nAño: {año}\nKilometraje: {km}", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Llamar al método EditarVehiculo en la capa de dominio
                            DVehiculo.EditarVehiculo(placa, marca, modelo, añoDateTime, Convert.ToInt32(km));
                            MostrarVehiculos();  // Puedes implementar este método para reflejar los cambios en tu formulario
                            LimpiarDatos();
                        }
                        // Si el usuario hace clic en "No", no se realiza la edición
                    }
                    else
                    {
                        MessageBox.Show("El vehículo no existe en la base de datos. No se puede editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("El formato del año no es válido. Por favor, ingrese un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de editar un vehículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;

            if (!string.IsNullOrWhiteSpace(placa))
            {
                // Verificar si el vehículo ya existe en la base de datos usando el método de la capa de dominio
                if (DVehiculo.VehiculoExiste(placa))
                {
                    // Mostrar un mensaje de confirmación antes de eliminar el vehículo
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas eliminar el vehículo con placa '{placa}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método EliminarVehiculo en la capa de dominio
                        DVehiculo.EliminarVehiculo(placa);
                        MostrarVehiculos();  // Puedes implementar este método para reflejar los cambios en tu formulario
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la eliminación
                }
                else
                {
                    MessageBox.Show("El vehículo no existe en la base de datos. No se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete el campo de la placa antes de eliminar un vehículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }

        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = cbxBuscarVehiculo.SelectedItem?.ToString();
            string valorBusqueda = txtBuscarCliente.Text;

            // Verificar que se haya seleccionado una opción y se haya ingresado un valor
            if (!string.IsNullOrWhiteSpace(opcionSeleccionada) && !string.IsNullOrWhiteSpace(valorBusqueda))
            {
                // Llamar al método BuscarVehiculo en la capa de dominio
                DataTable resultados = DVehiculo.BuscarVehiculo(opcionSeleccionada, valorBusqueda);

                // Verificar si hay registros en la DataTable
                if (resultados.Rows.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView dgvVehiculos
                    dgvVehiculos.DataSource = resultados;
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para la búsqueda especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción y escriba un valor antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Limpiar datos si la búsqueda no es exitosa
                LimpiarDatos();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }
    }
}
