using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Login
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();

            //MANEJO DE PERMISOS
            //if (UserCache.Rol == Positions.Administrador)
            //{

            //}
            if (UserCache.Rol == Positions.Usuario)
            {
                btnAutos.Enabled = false;
            }
        }
        private void LoadUserData()
        {
            lblRol.Text = UserCache.Rol;
        }
        #region Funcionalidades del Formulario


        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar la aplicacion ?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }
        //Capturar posicion y tamaño actual de la pantalla  antes de maximizar
        int lx, ly;
        int sw, sh;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuarios>();
            btnUsuarios.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVehiculos>();
            btnAutos.BackColor = Color.FromArgb(12,61,92);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmReparaciones>();
            btnReparaciones.BackColor = Color.FromArgb(12, 61, 92);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientes>();
            btnClientes.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmRepuestos>();
            btnRepuestos.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnRecepcionVehicular_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmRecepcionVehicular>();
            btnRecepcionVehicular.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnHoja_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHoja>();
            btnHoja.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;//quitar borde al formulario 
                formulario.Dock = DockStyle.Fill; // acoplar al panel  y que este en todo el fondo 
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms["frmUsuarios"] ==null)
                btnUsuarios.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmReparaciones"] == null)
                btnReparaciones.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmAutos"] == null)
                btnAutos.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmClientes"] == null)
                btnClientes.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmRepuestos"] == null)
                btnRepuestos.BackColor = Color.FromArgb(4, 41, 68);
        }

    }
}
