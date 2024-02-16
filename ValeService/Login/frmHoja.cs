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
        public static string Accion { get; set; }

        DHoja dHoja = new DHoja();
        DManoDeObra dManoDeObra = new DManoDeObra();
        DHojaRepuesto dHojaRepuesto = new DHojaRepuesto();
        DManoObraTerceros dManoObraTerceros = new DManoObraTerceros();
        DRecepcionVehiculo dRecepcionVehiculo = new DRecepcionVehiculo();

        public frmHoja()
        {
            InitializeComponent();
            DatoTextBox.ConfigurarTextBoxEntero(txtNumeroHoja);
        }


        private void frmHoja_Load(object sender, EventArgs e)
        {
            EstilosBoton.OcultarBoton
                (btnAddRecepcionVehicular, btnAsignarFechaSalidaRecepcion, 
                btnDeleteRecepcionVehicular, btnAddRepuestos, btnAddManoObra, btnAddManoObraTerceros);
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
                    EstilosBoton.OcultarBoton(btnAddRecepcionVehicular);
                    EstilosBoton.MostrarBoton(btnAsignarFechaSalidaRecepcion, btnDeleteRecepcionVehicular);

                }
                else
                {
                    LimpiarDatosRecepciones();
                    EstilosBoton.MostrarBoton(btnAddRecepcionVehicular);
                    EstilosBoton.OcultarBoton(btnAsignarFechaSalidaRecepcion, btnDeleteRecepcionVehicular);

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
        private bool ValidarNumeroHoja(string numeroHoja)
        {
            // Verificar si el número de hoja está en la lista de números de hoja
            DataTable datosHoja = dHoja.MostrarDatosHoja();
            bool numeroValido = datosHoja.AsEnumerable().Any(row => numeroHoja.Equals(row.Field<int>("Hoja_Numero").ToString()));

            // Si el número de hoja no es válido, mostrar un mensaje de error y eliminar el último carácter del TextBox
            if (!numeroValido)
            {
                MessageBox.Show("El número de hoja: " + numeroHoja + " no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Eliminar el último carácter del TextBox
                txtNumeroHoja.Text = txtNumeroHoja.Text.Substring(0, txtNumeroHoja.Text.Length - 1);
            }
            return numeroValido;
        }


        private void txtNumeroHoja_TextChanged_1(object sender, EventArgs e)
        {
            // Verificar si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(txtNumeroHoja.Text))
            {
                LimpiarDataGridViews(); // Limpiar el contenido de los DataGridView
                LimpiarDatosRecepciones(); // Limpiar los datos de Recepciones
                EstilosBoton.OcultarBoton(btnAddRecepcionVehicular, btnAsignarFechaSalidaRecepcion, btnDeleteRecepcionVehicular, btnAddRepuestos, btnAddManoObra, btnAddManoObraTerceros);
            }
            else
            {
                // Llamar a la función de validación del número de hoja
                if (!ValidarNumeroHoja(txtNumeroHoja.Text))
                {
                    // El número de hoja no es válido, limpiar el contenido y salir de la función
                    LimpiarDataGridViews();
                    LimpiarDatosRecepciones();
                    EstilosBoton.OcultarBoton(btnAddRecepcionVehicular, btnAsignarFechaSalidaRecepcion, btnDeleteRecepcionVehicular, btnAddRepuestos, btnAddManoObra, btnAddManoObraTerceros);
                    return;
                }

                MostrarDatosRepuestos();
                MostrarDatosManoObra();
                MostrarDatosManoObraTerceros();
                MostrarDatosRecepciones();
                EstilosBoton.MostrarBoton(btnAddRepuestos, btnAddManoObra, btnAddManoObraTerceros);

                EstilosDGV.AplicarEstilosSiBotones(dgvRepuestoHoja);
                EstilosDGV.AplicarEstilosSiBotones(dgvManoObraHoja);
                EstilosDGV.AplicarEstilosSiBotones(dgvManoObraTercerosHoja);
            }
        }

        // ************************************************************
        // ******************* RECEPCION VEHICULAR ********************
        // ************************************************************
        #region Eventos del los textbox RECEPCION VEHICULAR 


        private void btnAddRecepcionVehicular_Click(object sender, EventArgs e)
        {
            Accion = "agregar";
            FRecepcionVehicular fRecepcionVehicular = new FRecepcionVehicular();

            // Asignar el valor de txtNumeroHoja al TextBox en el nuevo formulario
            fRecepcionVehicular.txtFFRVnhoja.Text = txtNumeroHoja.Text;
            fRecepcionVehicular.dtpFFRVFechaEntrada.Value = DateTime.Now;

            EstilosFromFlotantes.AplicarEstilosForm(fRecepcionVehicular);

            // Mostrar el formulario
            if (fRecepcionVehicular.ShowDialog(this) == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int hojaNumero, clienteDNI;
                decimal cuenta;
                string placaVehiculo;
                DateTime fechaEntrada;

                if (int.TryParse(fRecepcionVehicular.txtFFRVnhoja.Text, out hojaNumero) &&
                    int.TryParse(fRecepcionVehicular.txtFFRVDNICliente.Text, out clienteDNI) &&
                    decimal.TryParse(fRecepcionVehicular.txtFFRVCuentaRecepcion.Text, out cuenta) &&
                    DateTime.TryParse(fRecepcionVehicular.dtpFFRVFechaEntrada.Value.ToString(), out fechaEntrada) &&
                    !string.IsNullOrEmpty(fRecepcionVehicular.txtFFRVPlacaVehiculo.Text))
                {
                    placaVehiculo = fRecepcionVehicular.txtFFRVPlacaVehiculo.Text;

                    // Insertar el nuevo registro directamente aquí sin llamar a otro método
                    dRecepcionVehiculo.AddDatosRecepcion(hojaNumero, fechaEntrada, cuenta, placaVehiculo, clienteDNI);

                    // Actualizar la visualización de los datos
                    MostrarDatosRecepciones();
                }
            }
        }

        private void btnAsignarFechaSalidaRecepcionVehicular_Click(object sender, EventArgs e)
        {
            Accion = "salida";
            // Crear una instancia del formulario FRecepcionVehicular
            FRecepcionVehicular fRecepcionVehicular = new FRecepcionVehicular();
            // Asignar los valores de los campos de hoja al nuevo formulario
            fRecepcionVehicular.txtFFRVid.Text = txtIDRecepcion.Text;
            fRecepcionVehicular.txtFFRVnhoja.Text = txtNumeroHoja.Text;
            fRecepcionVehicular.txtFFRVDNICliente.Text = txtDNICliente.Text;
            fRecepcionVehicular.txtFFRVNombreCliente.Text = txtNombreCliente.Text;
            fRecepcionVehicular.txtFFRVContactoCliente.Text= txtContactoCliente.Text;
            fRecepcionVehicular.txtFFRVPlacaVehiculo.Text = txtPlacaVehiculo.Text;
            fRecepcionVehicular.txtFFRVMarcaVehiculo.Text = txtMarcaVehiculo.Text;
            fRecepcionVehicular.txtFFRVModeloVehiculo.Text = txtModeloVehiculo.Text;
            fRecepcionVehicular.txtFFRVAnioVehiculo.Text = txtAnioVehiculo.Text;
            fRecepcionVehicular.txtFFRVKilometrajeVehiculo.Text = txtKilometrajeVehiculo.Text;
            fRecepcionVehicular.txtFFRVCuentaRecepcion.Text = txtCuentaRecepcion.Text;
            fRecepcionVehicular.dtpFFRVFechaEntrada.Value = DateTime.Parse(txtFechaEntrada.Text);
            fRecepcionVehicular.dtpFFRVFechaEntrada.Enabled = false;
            EstilosTextBox.BloquearTextBox(fRecepcionVehicular.txtFFRVCuentaRecepcion);

            EstilosTextBox.HabilitarTextBox(fRecepcionVehicular.txtFFRVFechaSalida);

            // Aplicar estilos al formulario
            EstilosFromFlotantes.AplicarEstilosForm(fRecepcionVehicular);

            // Mostrar el formulario como un diálogo
            if (fRecepcionVehicular.ShowDialog() == DialogResult.OK)
            {
                // Obtener la fecha de salida del TextBox
                int idRecepcion = int.Parse(fRecepcionVehicular.txtFFRVid.Text);

                DateTime? fechaSalida = null;
                if (DateTime.TryParse(fRecepcionVehicular.txtFFRVFechaSalida.Text, out DateTime salida))
                {
                    fechaSalida = salida;
                    
                }

                // Llamar al método AsignarFechaSalida con el ID de recepción y la fecha de salida
                dRecepcionVehiculo.AsignarFechaSalida(idRecepcion, fechaSalida);
                MostrarDatosRecepciones();

            }
        }

        private void btnDeleteRecepcionVehicular_Click(object sender, EventArgs e)
        {
            int recepcionId;
            if (int.TryParse(txtIDRecepcion.Text, out recepcionId))
            {
                // Llamada al método para eliminar los datos de la recepción
                dRecepcionVehiculo.DeleteDatosRecepcion(recepcionId);

                // Actualizar la visualización de los datos
                MostrarDatosRecepciones();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido para la recepción.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion
        // ************************************************************
        // ******************* RECEPCION VEHICULAR ********************
        // ************************************************************



        // ************************************************************
        // ******************* HOJA REPUESTOS *************************
        // ************************************************************
        #region Eventos del  MANO DE OBRA

        private void dgvManoObraHoja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvManoObraHoja.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "Eliminar":
                        // Obtener el ID de la mano de obra seleccionada
                        int manoDeObraId = Convert.ToInt32(dgvManoObraHoja.Rows[e.RowIndex].Cells["ID de Mano de Obra"].Value);

                        // Llamar al método para eliminar
                        DeleteDatosManoObra(manoDeObraId);
                        break;

                    case "Editar":
                        // Obtener los datos de la fila seleccionada
                        int hojaManoObraId = Convert.ToInt32(dgvManoObraHoja.Rows[e.RowIndex].Cells["ID de Mano de Obra"].Value);
                        int cantidad = Convert.ToInt32(dgvManoObraHoja.Rows[e.RowIndex].Cells["Cantidad"].Value);
                        decimal precio = Convert.ToDecimal(dgvManoObraHoja.Rows[e.RowIndex].Cells["Costo de Mano de Obra"].Value);
                        int tiempo = Convert.ToInt32(dgvManoObraHoja.Rows[e.RowIndex].Cells["Tiempo de Mano de Obra"].Value);
                        int hojaNumero = Convert.ToInt32(dgvManoObraHoja.Rows[e.RowIndex].Cells["Número de Hoja"].Value);

                        int NumServicio = Convert.ToInt32(dgvManoObraHoja.Rows[e.RowIndex].Cells["Tiempo de Mano de Obra"].Value);
                        string ServicioDesc = Convert.ToString(dgvManoObraHoja.Rows[e.RowIndex].Cells["Número de Hoja"].Value);

                        // Mostrar el formulario de edición
                        EditDatosManoObra(hojaManoObraId, cantidad, precio, tiempo, hojaNumero, NumServicio, ServicioDesc);
                        break;

                    // Agrega más casos según tus necesidades

                    default:
                        // Acción por defecto o mensaje de error
                        break;
                }
            }
        }
        private void btnAddManoObra_Click(object sender, EventArgs e)
        {
            FManoObra fManoObra = new FManoObra();

            // Asignar el valor de txtNumeroHoja al TextBox en el nuevo formulario
            fManoObra.txtFFManoObraHoja.Text = txtNumeroHoja.Text;

            EstilosFromFlotantes.AplicarEstilosForm(fManoObra);

            // Mostrar el formulario
            if (fManoObra.ShowDialog(this) == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int hojaNumero, numServicio, cantidad, tiempo;
                decimal precio;

                if (int.TryParse(fManoObra.txtFFManoObraHoja.Text, out hojaNumero) &&
                    int.TryParse(fManoObra.txtFFManoObraNumServicio.Text, out numServicio) &&
                    int.TryParse(fManoObra.txtFFManoObraCantidad.Text, out cantidad) &&
                    int.TryParse(fManoObra.txtFFManoObraTiempo.Text, out tiempo) &&
                    decimal.TryParse(fManoObra.txtFFManoObraPrecio.Text, out precio))
                {
                    // Insertar el nuevo registro directamente aquí sin llamar a otro método
                    dManoDeObra.AddDatosManoObra(hojaNumero, cantidad, precio, tiempo, numServicio);

                    // Actualizar la visualización de los datos
                    MostrarDatosManoObra();
                    EstilosDGV.AplicarEstilosSiBotones(dgvManoObraHoja);

                }
            }
        }
        private void EditDatosManoObra(int manoDeObraId, int cantidad, decimal precio, int tiempo, int hojaNumero, int NumServicio, string ServicioDesc)
        {
            // Crear una instancia del formulario para editar los datos de mano de obra
            FManoObra formularioManoObra = new FManoObra();

            // Asignar los valores actuales a los controles del formulario
            formularioManoObra.txtFFManoObraHoja.Text = hojaNumero.ToString();
            formularioManoObra.txtFFManoObraCantidad.Text = cantidad.ToString();
            formularioManoObra.txtFFManoObraTiempo.Text = tiempo.ToString();
            formularioManoObra.txtFFManoObraPrecio.Text = precio.ToString();
            formularioManoObra.txtFFManoObraId.Text = manoDeObraId.ToString();

            formularioManoObra.txtFFManoObraNumServicio.Text = NumServicio.ToString();
            formularioManoObra.txtFFManoObraServicioDesc.Text = ServicioDesc.ToString();


            // Aplicar estilos utilizando la clase EstilosFromFlotantes
            EstilosFromFlotantes.AplicarEstilosForm(formularioManoObra);

            // Mostrar el formulario y manejar el resultado
            DialogResult resultado = formularioManoObra.ShowDialog();

            // Procesar el resultado del formulario
            if (resultado == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int nuevaCantidad = int.Parse(formularioManoObra.txtFFManoObraCantidad.Text);
                decimal nuevoPrecio = decimal.Parse(formularioManoObra.txtFFManoObraPrecio.Text);
                int nuevoTiempo = int.Parse(formularioManoObra.txtFFManoObraTiempo.Text);

                // Realizar acciones según sea necesario para editar los datos
                dManoDeObra.EditDatosManoObra(manoDeObraId, nuevaCantidad, nuevoPrecio, nuevoTiempo);

                // Actualizar la vista y aplicar estilos después de guardar
                MostrarDatosManoObra();
                EstilosDGV.AplicarEstilosSiBotones(dgvManoObraHoja);
            }
        }
        private void DeleteDatosManoObra(int manoDeObraId)
        {
            // Puedes mostrar un mensaje de confirmación antes de proceder con la eliminación
            DialogResult confirmacion = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Llamar al método para eliminar en la capa de datos
                dManoDeObra.DeleteDatosManoObra(manoDeObraId);

                // Actualizar la vista después de la eliminación
                MostrarDatosManoObra();
                EstilosDGV.AplicarEstilosSiBotones(dgvManoObraHoja);
            }
        }

        #endregion
        // ************************************************************
        // ******************* HOJA REPUESTOS *************************
        // ************************************************************



        // ************************************************************
        // ******************* HOJA REPUESTOS *************************
        // ************************************************************
        #region Eventos del  HOJA REPUESTOS
        private void dgvRepuestoHoja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvRepuestoHoja.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "Eliminar":
                        // Obtener los datos de la fila seleccionada
                        int hojaNumero = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["Número de Hoja"].Value);
                        int repuestoId = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["ID de Repuesto"].Value);
                        int cantidad = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["Cantidad"].Value);
                        decimal costo = Convert.ToDecimal(dgvRepuestoHoja.Rows[e.RowIndex].Cells["Costo"].Value);
                        string marca = dgvRepuestoHoja.Rows[e.RowIndex].Cells["Marca"].Value.ToString();

                        // Llamar al método para eliminar
                        DeleteDatosHojaRepuestos(hojaNumero, repuestoId, cantidad, costo, marca);
                        break;

                    case "Editar":
                        // Obtener los datos de la fila seleccionada
                        int hojaRepuestosId = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["ID"].Value);
                        hojaNumero = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["Número de Hoja"].Value);
                        repuestoId = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["ID de Repuesto"].Value);
                        cantidad = Convert.ToInt32(dgvRepuestoHoja.Rows[e.RowIndex].Cells["Cantidad"].Value);
                        costo = Convert.ToDecimal(dgvRepuestoHoja.Rows[e.RowIndex].Cells["Costo"].Value);
                        marca = dgvRepuestoHoja.Rows[e.RowIndex].Cells["Marca"].Value.ToString();

                        // Mostrar el formulario de edición
                        EditDatosHojaRepuestos(hojaRepuestosId, cantidad, costo, marca, repuestoId, hojaNumero);
                        break;

                    // Agrega más casos según tus necesidades

                    default:
                        // Acción por defecto o mensaje de error
                        break;
                }
            }
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

                if (int.TryParse(fHojaRepuestos.txtFFHRHoja.Text, out hojaNumero) &&
                    int.TryParse(fHojaRepuestos.txtFFHRCantidad.Text, out cantidad) &&
                    int.TryParse(fHojaRepuestos.txtFFHRNumRepuesto.Text, out repuestoId) &&
                    decimal.TryParse(fHojaRepuestos.txtFFHRPrecio.Text, out costo))
                {
                    marca = fHojaRepuestos.txtFFHRMarca.Text;

                    // Insertar el nuevo registro utilizando el método AddDatosHojaRepuestos
                    dHojaRepuesto.AddDatosHojaRepuestos(cantidad, costo, marca, repuestoId, hojaNumero);

                    // Actualizar la visualización de los datos
                    MostrarDatosRepuestos();

                    // Aplicar estilos al DataGridView (si es necesario)
                    EstilosDGV.AplicarEstilosSiBotones(dgvRepuestoHoja); // Asegúrate de tener un DataGridView llamado dgvRepuestoHoja
                }
            }
        }

        private void EditDatosHojaRepuestos(int hojaRepuestosId, int cantidad, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            // Crear una instancia del formulario para editar los datos de hoja de repuestos
            FHojaRepuestos formularioHojaRepuestos = new FHojaRepuestos();

            // Asignar los valores actuales a los controles del formulario
            formularioHojaRepuestos.txtFFHRHoja.Text = hojaNumero.ToString();
            formularioHojaRepuestos.txtFFHRCantidad.Text = cantidad.ToString();
            formularioHojaRepuestos.txtFFHRNumRepuesto.Text = repuestoId.ToString();
            formularioHojaRepuestos.txtFFHRPrecio.Text = costo.ToString();
            formularioHojaRepuestos.txtFFHRMarca.Text = marca;

            // Aplicar estilos utilizando la clase EstilosFromFlotantes
            EstilosFromFlotantes.AplicarEstilosForm(formularioHojaRepuestos);

            // Mostrar el formulario y manejar el resultado
            DialogResult resultado = formularioHojaRepuestos.ShowDialog();

            // Procesar el resultado del formulario
            if (resultado == DialogResult.OK)
            {
                // Obtener datos del formulario después de aceptar
                int nuevoHojaNumero = int.Parse(formularioHojaRepuestos.txtFFHRHoja.Text);
                int nuevaCantidad = int.Parse(formularioHojaRepuestos.txtFFHRCantidad.Text);
                int nuevoRepuestoId = int.Parse(formularioHojaRepuestos.txtFFHRNumRepuesto.Text);
                decimal nuevoCosto = decimal.Parse(formularioHojaRepuestos.txtFFHRPrecio.Text);
                string nuevaMarca = formularioHojaRepuestos.txtFFHRMarca.Text;

                // Realizar acciones según sea necesario para editar los datos
                dHojaRepuesto.EditDatosHojaRepuestos(hojaRepuestosId, nuevaCantidad, nuevoCosto, nuevaMarca, nuevoRepuestoId, nuevoHojaNumero);

                // Actualizar la vista y aplicar estilos después de guardar
                MostrarDatosRepuestos();
                EstilosDGV.AplicarEstilosSiBotones(dgvRepuestoHoja);
            }
        }

        private void DeleteDatosHojaRepuestos(int hojaNumero, int repuestoId, int cantidad, decimal costo, string marca)
        {
            // Puedes mostrar un mensaje de confirmación antes de proceder con la eliminación
            DialogResult confirmacion = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Llamar al método para eliminar en la capa de datos
                dHojaRepuesto.DeleteDatosHojaRepuestos(hojaNumero, repuestoId, cantidad, costo, marca);

                // Actualizar la vista después de la eliminación
                MostrarDatosRepuestos();
                EstilosDGV.AplicarEstilosSiBotones(dgvRepuestoHoja);
            }
        }

        #endregion 
        // ************************************************************
        // ******************* HOJA REPUESTOS *************************
        // ************************************************************



        // ************************************************************
        // ************ MANO DE OBRA TERCEROS *************************
        // ************************************************************
        #region Eventos del  MANO DE OBRA TERCEROS

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
                    EstilosDGV.AplicarEstilosSiBotones(dgvManoObraTercerosHoja);
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
                        EstilosDGV.AplicarEstilosSiBotones(dgvManoObraTercerosHoja);
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
                EstilosDGV.AplicarEstilosSiBotones(dgvManoObraTercerosHoja);
            }
        }


        #endregion
        // ************************************************************
        // ************ FIN MANO DE OBRA TERCEROS *********************
        // ************************************************************

        private void btnNuevaHoja_Click(object sender, EventArgs e)
        {
            // Obtener el número de la nueva hoja
            int nuevoNumeroHoja = dHoja.GenerarNumeroHoja();

            // Asignar el valor al TextBox txtNumeroHoja
            txtNumeroHoja.Text = nuevoNumeroHoja.ToString();
        }
    }
}
