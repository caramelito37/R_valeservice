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
using System.Globalization;
using Login.Validaciones;

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
                DataTable datosRepuestos = dHojaRepuesto.MostrarDatosHojaRepuestos(numeroHoja);

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
        private void btnAddManoObra_Click(object sender, EventArgs e)
        {

        }
        private void btnAddRepuestos_Click(object sender, EventArgs e)
        {
            FHojaRepuestos fHojaRepuestos = new FHojaRepuestos();

            // Asignar el valor de txtNumeroHoja al TextBox en el nuevo formulario
            fHojaRepuestos.txtFFHRHoja.Text = txtNumeroHoja.Text;
            EstilosFromFlotantes.AplicarEstilosForm(fHojaRepuestos);

            // Mostrar el formulario
            if (fHojaRepuestos.ShowDialog() == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int hojaNumero, cantidad, repuestoId;
                decimal costo;
                string marca;


                if (DatoTextBox.ObtenerEnteroValido(fHojaRepuestos.txtFFHRHoja.Text, out hojaNumero) &&
                    DatoTextBox.ObtenerEnteroValido(fHojaRepuestos.txtFFHRCantidad.Text, out cantidad) &&
                    DatoTextBox.ObtenerEnteroValido(fHojaRepuestos.txtFFHRNumRepuesto.Text, out repuestoId) &&
                    DatoTextBox.ObtenerDecimalValido(fHojaRepuestos.txtFFHRPrecio.Text, out costo))
                {
                    marca = fHojaRepuestos.txtFFHRMarca.Text; 

                    // Insertar el nuevo registro utilizando el método AddDatosHojaRepuestos
                    dHojaRepuesto.AddDatosHojaRepuestos(cantidad, costo, marca, repuestoId, hojaNumero);

                    // Actualizar la visualización de los datos
                    MostrarDatosRepuestos();

                    // Aplicar estilos al DataGridView (si es necesario)
                    EstilosDGV.AplicarEstilos(dgvRepuestoHoja); // Asegúrate de tener un DataGridView llamado dgvRepuestoHoja
                }
            }
        }





        // ************************************************************
        // ************ MANO DE OBRA TERCEROS *************************
        // ************************************************************
        #region Eventos del DataGridView
        private void dgvManoObraTercerosHoja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvManoObraTercerosHoja.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "Eliminar":
                        // Obtener el ID de Mano de Obra Terceros de la fila seleccionada
                        int idManoObraTercerosEliminar = Convert.ToInt32(dgvManoObraTercerosHoja.Rows[e.RowIndex].Cells["ID de Mano de Obra Terceros"].Value);

                        // Llamar al método para eliminar
                        DeleteManoObraTerceros(idManoObraTercerosEliminar);
                        break;

                    case "Editar":
                        // Obtener los datos de la fila seleccionada
                        int idManoObraTerceros = Convert.ToInt32(dgvManoObraTercerosHoja.Rows[e.RowIndex].Cells["ID de Mano de Obra Terceros"].Value);
                        int numeroHoja = Convert.ToInt32(dgvManoObraTercerosHoja.Rows[e.RowIndex].Cells["Número de Hoja"].Value);
                        string descripcion = dgvManoObraTercerosHoja.Rows[e.RowIndex].Cells["Descripción de Mano de Obra Terceros"].Value.ToString();

                        // Mostrar el formulario de edición
                        EditManoObraTerceros(idManoObraTerceros, numeroHoja, descripcion);
                        break;

                    // Agrega más casos según tus necesidades

                    default:
                        // Acción por defecto o mensaje de error
                        break;
                }
            }
        }
        private void btnAddManoObraTerceros_Click(object sender, EventArgs e)
        {
            FManoObraTerceros fManoObraTerceros = new FManoObraTerceros();

            // Asignar el valor de txtNumeroHoja al TextBox en el nuevo formulario
            fManoObraTerceros.txtFFMOTHoja.Text = txtNumeroHoja.Text;

            // Aplicar estilos utilizando la clase EstilosFormFlotantes
            EstilosFromFlotantes.AplicarEstilosForm(fManoObraTerceros);

            // Mostrar el formulario
            if (fManoObraTerceros.ShowDialog() == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int numeroHoja;
                if (int.TryParse(fManoObraTerceros.txtFFMOTHoja.Text, out numeroHoja))
                {
                    string descripcion = fManoObraTerceros.txtFFMOTDescripcion.Text;

                    // Insertar el nuevo registro
                    dManoObraTerceros.AddManoObraTerceros(numeroHoja, descripcion);

                    MostrarDatosManoObraTerceros();
                    EstilosDGV.AplicarEstilos(dgvManoObraTercerosHoja);
                }
                else
                {
                    // Mostrar mensaje de error o tomar otra acción en caso de que el número de hoja no sea válido
                }
            }
        }
        private void EditManoObraTerceros(int idManoObraTerceros, int numeroHoja, string descripcionActual)
        {
            // Crear una instancia del formulario FManoObraTerceros
            FManoObraTerceros formularioManoObraTerceros = new FManoObraTerceros();

            // Asignar los valores actuales a los controles del formulario
            formularioManoObraTerceros.txtFFMOTid.Text = idManoObraTerceros.ToString();
            formularioManoObraTerceros.txtFFMOTHoja.Text = numeroHoja.ToString();
            formularioManoObraTerceros.txtFFMOTDescripcion.Text = descripcionActual;

            // Aplicar estilos utilizando la clase EstilosFromFlotantes
            EstilosFromFlotantes.AplicarEstilosForm(formularioManoObraTerceros);

            // Mostrar el formulario y manejar el resultado
            DialogResult resultado = formularioManoObraTerceros.ShowDialog();

            // Procesar el resultado del formulario
            if (resultado == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int nuevoNumeroHoja;
                if (int.TryParse(formularioManoObraTerceros.txtFFMOTHoja.Text, out nuevoNumeroHoja))
                {
                    string nuevaDescripcion = formularioManoObraTerceros.txtFFMOTDescripcion.Text;

                    // Verificar si la descripción no está vacía
                    if (!string.IsNullOrEmpty(nuevaDescripcion))
                    {
                        // Realizar acciones según sea necesario
                        dManoObraTerceros.EditManoObraTerceros(idManoObraTerceros, nuevoNumeroHoja, nuevaDescripcion);

                        // Actualizar la vista y aplicar estilos después de guardar
                        MostrarDatosManoObraTerceros();
                        EstilosDGV.AplicarEstilos(dgvManoObraTercerosHoja);
                    }
                    else
                    {
                        MessageBox.Show("La descripción no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Puedes tomar alguna acción adicional, como no realizar la actualización o mostrar un mensaje adicional.
                    }
                }
                else
                {
                    MessageBox.Show("Numero de hoja no valido. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void DeleteManoObraTerceros(int idManoObraTerceros)
        {
            // Puedes mostrar un mensaje de confirmación antes de proceder con la eliminación
            DialogResult confirmacion = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Llamar al método para eliminar en la capa de datos
                dManoObraTerceros.DeleteManoObraTerceros(idManoObraTerceros);

                // Actualizar la vista después de la eliminación
                MostrarDatosManoObraTerceros();
                EstilosDGV.AplicarEstilos(dgvManoObraTercerosHoja);
            }
        }

        #endregion
        // ************************************************************
        // ************ FIN MANO DE OBRA TERCEROS *********************
        // ************************************************************
    }
}
