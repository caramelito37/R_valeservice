using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Login
{
    public partial class frmClientes : Form
    {
        DCliente dClientes = new DCliente();  
        public frmClientes()
        {
            InitializeComponent();
        }
        private void MostrarClientes()
        {
            DataTable usuariosTable = dClientes.MostrarClientes();
            dgvClientes.DataSource = usuariosTable;
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvClientes.Rows.Count)
            {
                txtClienteDni.Text = dgvClientes.Rows[e.RowIndex].Cells["Cliente_DNI"].Value.ToString();
                txtClienteNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Cliente_Nombre_Apellido"].Value.ToString();
                txtClienteContacto.Text = dgvClientes.Rows[e.RowIndex].Cells["Cliente_Contacto"].Value.ToString();
            }
        }
        private void LimpiarDatos()
        {
            txtClienteNombre.Clear();
            txtClienteDni.Clear();
            txtClienteContacto.Clear();
            txtBuscarCliente.Clear();
            cbxBuscarCliente.SelectedIndex = -1;
        }//FUNCION PARA LIMPIAR LOS TEXT BOX Y COMBO BOX

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cbxBuscarCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            MostrarClientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ClienteDni = txtClienteDni.Text;
            string ClienteNombre = txtClienteNombre.Text;
            string ClienteContacto = txtClienteContacto.Text;

            if (!string.IsNullOrWhiteSpace(ClienteDni) && !string.IsNullOrWhiteSpace(ClienteNombre) && !string.IsNullOrWhiteSpace(ClienteContacto))
            {
                // Verificar si el cliente ya existe en la base de datos usando el método de la capa de dominio
                if (!dClientes.ClienteExiste(Convert.ToInt32(ClienteDni)))
                {
                    // Mostrar un mensaje de confirmación antes de agregar el cliente
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas agregar al cliente con DNI '{ClienteDni}'?\n\nDetalles del nuevo cliente:\nDNI: {ClienteDni}\nNombre: {ClienteNombre}\nContacto: {ClienteContacto}", "Confirmar agregación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método AgregarCliente en la capa de dominio
                        dClientes.AgregarCliente(Convert.ToInt32(ClienteDni), ClienteNombre, Convert.ToInt32(ClienteContacto));
                        MostrarClientes();
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la adición
                }
                else
                {
                    MessageBox.Show("El cliente ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ClienteDni = txtClienteDni.Text;
            string ClienteNombre = txtClienteNombre.Text;
            string ClienteContacto = txtClienteContacto.Text;

            if (!string.IsNullOrWhiteSpace(ClienteDni) && !string.IsNullOrWhiteSpace(ClienteNombre) && !string.IsNullOrWhiteSpace(ClienteContacto))
            {
                // Verificar si el cliente ya existe en la base de datos usando el método de la capa de dominio
                if (dClientes.ClienteExiste(Convert.ToInt32(ClienteDni)))
                {
                    // Mostrar un mensaje de confirmación antes de editar el cliente
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas editar los datos del cliente con DNI '{ClienteDni}'?\n\nDetalles del cliente editado:\nDNI: {ClienteDni}\nNuevo Nombre: {ClienteNombre}\nNuevo Contacto: {ClienteContacto}", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método EditarCliente en la capa de dominio
                        dClientes.EditarCliente(Convert.ToInt32(ClienteDni), ClienteNombre, Convert.ToInt32(ClienteContacto));
                        MostrarClientes();
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la edición
                }
                else
                {
                    MessageBox.Show("El cliente no existe en la base de datos. No se puede realizar la edición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de editar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ClienteDni = txtClienteDni.Text;

            if (!string.IsNullOrWhiteSpace(ClienteDni))
            {
                // Verificar si el cliente ya existe en la base de datos usando el método de la capa de dominio
                if (dClientes.ClienteExiste(Convert.ToInt32(ClienteDni)))
                {
                    // Mostrar un mensaje de confirmación antes de eliminar el cliente
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas eliminar al cliente con DNI '{ClienteDni}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método EliminarCliente en la capa de dominio
                        dClientes.EliminarCliente(Convert.ToInt32(ClienteDni));
                        MostrarClientes();
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la eliminación
                }
                else
                {
                    MessageBox.Show("El cliente no existe en la base de datos. No se puede realizar la eliminación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el DNI del cliente antes de intentar eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string opcionSeleccionadaCliente = cbxBuscarCliente.SelectedItem?.ToString();
            string valorBusquedaCliente = txtBuscarCliente.Text;

            // Verificar que se haya seleccionado una opción y se haya ingresado un valor
            if (!string.IsNullOrWhiteSpace(opcionSeleccionadaCliente) && !string.IsNullOrWhiteSpace(valorBusquedaCliente))
            {
                // Llamar al método BuscarCliente en la capa de dominio
                DataTable resultadosCliente = dClientes.BuscarCliente(opcionSeleccionadaCliente, valorBusquedaCliente);

                // Verificar si hay registros en la DataTable
                if (resultadosCliente.Rows.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView dgvClientes
                    dgvClientes.DataSource = resultadosCliente;
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
            MostrarClientes();
        }
    }
}
