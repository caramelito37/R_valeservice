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
    public partial class frmUsuarios : Form
    {
        UserModel objUserModel = new UserModel();
        public frmUsuarios()
        {
            InitializeComponent();
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            DataTable usuariosTable = objUserModel.MostrarUsuarios();
            dgvUsuarios.DataSource = usuariosTable;
        }

        private void LimpiarDatos()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cbxRol.SelectedIndex = -1;
        }//FUNCION PARA LIMPIAR LOS TEXT BOX Y COMBO BOX
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUsuarios.Rows.Count)
            {
                txtNombreUsuario.Text =
                    dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
                txtContraseña.Text =
                    dgvUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                string rolValue = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();

                // Verifica el valor en la columna "Rol" y asigna el valor correspondiente al ComboBox
                if (rolValue == "Administrador")
                {
                    cbxRol.SelectedItem = "Administrador";
                }
                else if (rolValue == "Usuario")
                {
                    cbxRol.SelectedItem = "Usuario";
                }
            }

        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUsuarios.Rows.Count)
            {
                txtNombreUsuario.Text =
                    dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
                txtContraseña.Text =
                    dgvUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                string rolValue = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();

                // Verifica el valor en la columna "Rol" y asigna el valor correspondiente al ComboBox
                if (rolValue == "Administrador")
                {
                    cbxRol.SelectedItem = "Administrador";
                }
                else if (rolValue == "Usuario")
                {
                    cbxRol.SelectedItem = "Usuario";
                }
            }
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = cbxRol.SelectedItem?.ToString();  // Usa ?. para evitar una excepción si SelectedItem es nulo

            // Validar que los campos no estén vacíos
            if (!string.IsNullOrWhiteSpace(nombreUsuario) && !string.IsNullOrWhiteSpace(contraseña) && !string.IsNullOrWhiteSpace(rol))
            {
                // Verificar si el usuario ya existe en la base de datos usando el método de la capa de dominio
                if (!objUserModel.UsuarioExiste(nombreUsuario))
                {
                    // Mostrar un mensaje de confirmación antes de agregar el usuario
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas agregar al usuario '{nombreUsuario}'?\n\nDetalles del nuevo usuario:\nNombre: {nombreUsuario}\nContraseña: {contraseña}\nRol: {rol}", "Confirmar agregación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método AgregarUsuario en la capa de dominio
                        objUserModel.AgregarUsuario(nombreUsuario, contraseña, rol);
                        MostrarUsuarios();
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la adición
                }
                else
                {
                    MessageBox.Show("El usuario ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario seleccionado en el DataGridView (asumiendo que hay una fila seleccionada)
            string nombreUsuario = txtNombreUsuario.Text;

            // Verificar si el campo de nombre de usuario no está vacío
            if (!string.IsNullOrWhiteSpace(nombreUsuario))
            {
                // Verificar si el usuario existe en la base de datos
                if (objUserModel.UsuarioExiste(nombreUsuario))
                {
                    // Mostrar un mensaje de confirmación antes de eliminar el usuario
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas eliminar al usuario '{nombreUsuario}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método EliminarUsuario en la capa de dominio
                        objUserModel.EliminarUsuario(nombreUsuario);

                        // Volver a cargar la lista de usuarios en el DataGridView
                        MostrarUsuarios();
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la eliminación
                }
                else
                {
                    MessageBox.Show("El usuario no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario antes de intentar eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = cbxRol.SelectedItem?.ToString();

            // Validar que los campos no estén vacíos
            if (!string.IsNullOrWhiteSpace(nombreUsuario) && !string.IsNullOrWhiteSpace(contraseña) && !string.IsNullOrWhiteSpace(rol))
            {
                // Verificar si el usuario ya existe en la base de datos usando el método de la capa de dominio
                if (objUserModel.UsuarioExiste(nombreUsuario))
                {
                    // Mostrar un mensaje de confirmación antes de editar el usuario
                    DialogResult result = MessageBox.Show($"¿Seguro que deseas editar al usuario '{nombreUsuario}' con los siguientes datos?\n\nDetalles actualizados del usuario:\nNombre: {nombreUsuario}\nContraseña: {contraseña}\nRol: {rol}", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método EditarUsuario en la capa de dominio
                        objUserModel.EditarUsuario(nombreUsuario, contraseña, rol);
                        MostrarUsuarios();
                        LimpiarDatos();
                    }
                    // Si el usuario hace clic en "No", no se realiza la edición
                }
                else
                {
                    MessageBox.Show("El usuario no existe en la base de datos. Puede agregarlo en lugar de editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Nombre de usuario y complete todos los campos antes de editar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDatos();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
