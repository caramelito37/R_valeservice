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
    public partial class FHojaRepuestos : Form
    {
        public TextBox TxtHojaRespuesto => txtHojaRespuesto;
        public TextBox TxtNumRepuesto => txtNumRepuesto;
        public TextBox TxtHojaCantidad => txtHojaCantidad;
        public TextBox TxtHojaMarca => txtHojaMarca;
        public TextBox TxtHojaPrecio => txtHojaPrecio;

        public FHojaRepuestos()
        {
            InitializeComponent();
        }
        private void FHojaRepuestos_Load(object sender, EventArgs e)
        {

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

    }
}
