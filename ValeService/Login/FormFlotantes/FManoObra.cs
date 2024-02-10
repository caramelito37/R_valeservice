using Domain;
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
using System.Windows.Forms;

namespace Login.FormFlotantes
{
    public partial class FManoObra : Form
    {
        public FManoObra()
        {
            InitializeComponent();
            //validaciones de solo se pueda ingresar los tipos de datos requeridos 
            DatoTextBox.ConfigurarTextBoxEntero(txtFFManoObraHoja);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFManoObraId);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFManoObraNumServicio);
            DatoTextBox.ConfigurarTextBoxString(txtFFManoObraServicioDesc, 100);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFManoObraCantidad);
            DatoTextBox.ConfigurarTextBoxEntero(txtFFManoObraTiempo);
            DatoTextBox.ConfigurarTextBoxDecimal(txtFFManoObraPrecio);
            //bloquear text box
            EstilosTextBox.BloquearTextBox(txtFFManoObraId, txtFFManoObraHoja, txtFFManoObraNumServicio, txtFFManoObraServicioDesc);
            // hacer publicos, para acceder a su contenido desde el frmHoja 
            EstilosTextBox.HacerPublico(txtFFManoObraHoja, txtFFManoObraId, txtFFManoObraNumServicio, txtFFManoObraServicioDesc, txtFFManoObraCantidad, txtFFManoObraTiempo, txtFFManoObraPrecio);
        }


        private void FManoObra_Load(object sender, EventArgs e)
        {
            MostrarDatosServiciosMecanicos();
            EstilosDGV.AplicarEstilosNoBotones(dgvFFManoObra);
        }

        private void MostrarDatosServiciosMecanicos()
        {
            DServiciosMecanicos dServiciosMecanicos = new DServiciosMecanicos();
            // Llamar al método para obtener los datos de los repuestos
            DataTable datosServiciosMecanicos = dServiciosMecanicos.MostrarDatosServiciosMecanicos();
            // Mostrar los datos en el DataGridView
            dgvFFManoObra.DataSource = datosServiciosMecanicos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvFFManoObra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si la celda seleccionada está dentro de los límites de las filas
            {
                // Obtener el valor de la celda seleccionada en la columna
                string idServicio = dgvFFManoObra.Rows[e.RowIndex].Cells["ID de Servicio Mecánico"].Value.ToString();
                string descripcionServicio = dgvFFManoObra.Rows[e.RowIndex].Cells["Descripción del Servicio"].Value.ToString();

                // Asignar los valores obtenidos a los TextBox respectivos
                txtFFManoObraNumServicio.Text = idServicio;
                txtFFManoObraServicioDesc.Text = descripcionServicio;
            }
        }
    }
}
