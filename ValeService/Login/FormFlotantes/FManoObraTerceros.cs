﻿using Login.Estilos;
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
    public partial class FManoObraTerceros : Form
    {
        public FManoObraTerceros()
        {
            InitializeComponent();
        }

        private void FManoObraTerceros_Load(object sender, EventArgs e)
        {
            EstilosTextBox.HacerPublico(txtFFMOTHoja, txtFFMOTDescripcion, txtFFMOTid);
            EstilosTextBox.BloquearTextBox(txtFFMOTHoja, txtFFMOTid);

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
