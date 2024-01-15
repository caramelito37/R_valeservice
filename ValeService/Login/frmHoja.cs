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

namespace Login
{
    public partial class frmHoja : Form
    {
        public frmHoja()
        {
            InitializeComponent();
        }


        private void frmHoja_Load(object sender, EventArgs e)
        {

        }
        private void MostrarManoDeObraHoja()
        {
            DManoDeObra dManoDeObra = new DManoDeObra();

            // Verificar si el textbox no está vacío y se ha realizado alguna acción
            if (!string.IsNullOrWhiteSpace(txtNumeroHoja.Text))
            {
                DataTable manoDeObra = dManoDeObra.MostrarManoDeObraHoja(int.Parse(txtNumeroHoja.Text));
                dgvManoDeObra.DataSource = manoDeObra;
            }
        }

        private void txtNumeroHoja_TextChanged_1(object sender, EventArgs e)
        {
            // Cuando el valor cambia, invocar el evento global con el nuevo valor
            EventosGlobales.InvocarNumeroHojaCambiado(txtNumeroHoja.Text);
            MostrarManoDeObraHoja();
        }
    }
}
