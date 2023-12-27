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
    public partial class frmHoja : Form
    {
        public frmHoja()
        {
            InitializeComponent();
        }

        private void frmHoja_Load(object sender, EventArgs e)
        {
            MostrarManoDeObraHoja();
        }
        private void MostrarManoDeObraHoja()
        {
            DManoDeObra dManoDeObra = new DManoDeObra();
            DataTable manoDeObra = dManoDeObra.MostrarManoDeObraHoja(int.Parse(txtNHoja.Text));
            dgvManoDeObra.DataSource = manoDeObra;
        }
    }
}
