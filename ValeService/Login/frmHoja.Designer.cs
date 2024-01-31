namespace Login
{
    partial class frmHoja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoja));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumeroHoja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblSumaCostoRepuestos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCuentaRecepcion = new System.Windows.Forms.TextBox();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.txtFechaEntrada = new System.Windows.Forms.TextBox();
            this.txtKilometrajeVehiculo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAnioVehiculo = new System.Windows.Forms.TextBox();
            this.txtModeloVehiculo = new System.Windows.Forms.TextBox();
            this.txtMarcaVehiculo = new System.Windows.Forms.TextBox();
            this.txtContactoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.txtRecepcionNHoja = new System.Windows.Forms.TextBox();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.txtIDRecepcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRepuestos = new System.Windows.Forms.Button();
            this.dgvRepuestoHoja = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddManoObraTerceros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvManoObraTercerosHoja = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddManoObra = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvManoObraHoja = new System.Windows.Forms.DataGridView();
            this.lblSumaCostoManoObra = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestoHoja)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObraTercerosHoja)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObraHoja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtNumeroHoja);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1748, 81);
            this.panel2.TabIndex = 25;
            // 
            // txtNumeroHoja
            // 
            this.txtNumeroHoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHoja.Location = new System.Drawing.Point(208, 21);
            this.txtNumeroHoja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroHoja.Name = "txtNumeroHoja";
            this.txtNumeroHoja.Size = new System.Drawing.Size(300, 38);
            this.txtNumeroHoja.TabIndex = 5;
            this.txtNumeroHoja.TextChanged += new System.EventHandler(this.txtNumeroHoja_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de Hoja ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(1597, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(149, 41);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblSumaCostoRepuestos
            // 
            this.lblSumaCostoRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumaCostoRepuestos.AutoSize = true;
            this.lblSumaCostoRepuestos.BackColor = System.Drawing.Color.White;
            this.lblSumaCostoRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaCostoRepuestos.ForeColor = System.Drawing.Color.Black;
            this.lblSumaCostoRepuestos.Location = new System.Drawing.Point(1043, 240);
            this.lblSumaCostoRepuestos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSumaCostoRepuestos.Name = "lblSumaCostoRepuestos";
            this.lblSumaCostoRepuestos.Size = new System.Drawing.Size(66, 25);
            this.lblSumaCostoRepuestos.TabIndex = 9;
            this.lblSumaCostoRepuestos.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(731, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOTAL EN REPUESTO   S/.";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.txtCuentaRecepcion);
            this.groupBox4.Controls.Add(this.txtFechaSalida);
            this.groupBox4.Controls.Add(this.txtFechaEntrada);
            this.groupBox4.Controls.Add(this.txtKilometrajeVehiculo);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtAnioVehiculo);
            this.groupBox4.Controls.Add(this.txtModeloVehiculo);
            this.groupBox4.Controls.Add(this.txtMarcaVehiculo);
            this.groupBox4.Controls.Add(this.txtContactoCliente);
            this.groupBox4.Controls.Add(this.txtNombreCliente);
            this.groupBox4.Controls.Add(this.txtDNICliente);
            this.groupBox4.Controls.Add(this.txtRecepcionNHoja);
            this.groupBox4.Controls.Add(this.txtPlacaVehiculo);
            this.groupBox4.Controls.Add(this.txtIDRecepcion);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(10, 85);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(406, 935);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INFORME DE RECEPCION";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(275, 862);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 57);
            this.button6.TabIndex = 77;
            this.button6.Text = "Borrar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(144, 862);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 57);
            this.button5.TabIndex = 76;
            this.button5.Text = "Editar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(13, 862);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 57);
            this.button4.TabIndex = 75;
            this.button4.Text = "Agregar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtCuentaRecepcion
            // 
            this.txtCuentaRecepcion.Enabled = false;
            this.txtCuentaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaRecepcion.Location = new System.Drawing.Point(18, 824);
            this.txtCuentaRecepcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCuentaRecepcion.Name = "txtCuentaRecepcion";
            this.txtCuentaRecepcion.Size = new System.Drawing.Size(364, 30);
            this.txtCuentaRecepcion.TabIndex = 74;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Enabled = false;
            this.txtFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaSalida.Location = new System.Drawing.Point(18, 760);
            this.txtFechaSalida.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(364, 30);
            this.txtFechaSalida.TabIndex = 73;
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Enabled = false;
            this.txtFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrada.Location = new System.Drawing.Point(18, 693);
            this.txtFechaEntrada.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(364, 30);
            this.txtFechaEntrada.TabIndex = 72;
            // 
            // txtKilometrajeVehiculo
            // 
            this.txtKilometrajeVehiculo.Enabled = false;
            this.txtKilometrajeVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometrajeVehiculo.Location = new System.Drawing.Point(18, 630);
            this.txtKilometrajeVehiculo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKilometrajeVehiculo.Name = "txtKilometrajeVehiculo";
            this.txtKilometrajeVehiculo.Size = new System.Drawing.Size(364, 30);
            this.txtKilometrajeVehiculo.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(15, 794);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 25);
            this.label17.TabIndex = 70;
            this.label17.Text = "Adelanto de Recepción       ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(15, 731);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 25);
            this.label18.TabIndex = 69;
            this.label18.Text = "Fecha de Salida     ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(15, 664);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 25);
            this.label19.TabIndex = 68;
            this.label19.Text = "Fecha de Entrada";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(15, 601);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(221, 25);
            this.label20.TabIndex = 67;
            this.label20.Text = "Kilometraje del Vehículo";
            // 
            // txtAnioVehiculo
            // 
            this.txtAnioVehiculo.Enabled = false;
            this.txtAnioVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioVehiculo.Location = new System.Drawing.Point(18, 567);
            this.txtAnioVehiculo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAnioVehiculo.Name = "txtAnioVehiculo";
            this.txtAnioVehiculo.Size = new System.Drawing.Size(364, 30);
            this.txtAnioVehiculo.TabIndex = 66;
            // 
            // txtModeloVehiculo
            // 
            this.txtModeloVehiculo.Enabled = false;
            this.txtModeloVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloVehiculo.Location = new System.Drawing.Point(18, 504);
            this.txtModeloVehiculo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtModeloVehiculo.Name = "txtModeloVehiculo";
            this.txtModeloVehiculo.Size = new System.Drawing.Size(364, 30);
            this.txtModeloVehiculo.TabIndex = 65;
            // 
            // txtMarcaVehiculo
            // 
            this.txtMarcaVehiculo.Enabled = false;
            this.txtMarcaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaVehiculo.Location = new System.Drawing.Point(16, 441);
            this.txtMarcaVehiculo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            this.txtMarcaVehiculo.Size = new System.Drawing.Size(364, 30);
            this.txtMarcaVehiculo.TabIndex = 64;
            // 
            // txtContactoCliente
            // 
            this.txtContactoCliente.Enabled = false;
            this.txtContactoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoCliente.Location = new System.Drawing.Point(15, 314);
            this.txtContactoCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtContactoCliente.Name = "txtContactoCliente";
            this.txtContactoCliente.Size = new System.Drawing.Size(367, 30);
            this.txtContactoCliente.TabIndex = 63;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(15, 251);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(367, 30);
            this.txtNombreCliente.TabIndex = 62;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Enabled = false;
            this.txtDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNICliente.Location = new System.Drawing.Point(15, 188);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(367, 30);
            this.txtDNICliente.TabIndex = 61;
            // 
            // txtRecepcionNHoja
            // 
            this.txtRecepcionNHoja.Enabled = false;
            this.txtRecepcionNHoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcionNHoja.Location = new System.Drawing.Point(15, 125);
            this.txtRecepcionNHoja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRecepcionNHoja.Name = "txtRecepcionNHoja";
            this.txtRecepcionNHoja.Size = new System.Drawing.Size(367, 30);
            this.txtRecepcionNHoja.TabIndex = 60;
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.Enabled = false;
            this.txtPlacaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(18, 378);
            this.txtPlacaVehiculo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(364, 30);
            this.txtPlacaVehiculo.TabIndex = 59;
            // 
            // txtIDRecepcion
            // 
            this.txtIDRecepcion.Enabled = false;
            this.txtIDRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRecepcion.Location = new System.Drawing.Point(15, 62);
            this.txtIDRecepcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIDRecepcion.Name = "txtIDRecepcion";
            this.txtIDRecepcion.Size = new System.Drawing.Size(367, 30);
            this.txtIDRecepcion.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 538);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Año del Vehículo ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Modelo del Vehículo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Marca del Vehículo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Placa del Vehículo ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Contacto del Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre y Apellido del Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "DNI del Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Número de Hoja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID de Recepción Vehicular ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnAddRepuestos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvRepuestoHoja);
            this.groupBox1.Controls.Add(this.lblSumaCostoRepuestos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(437, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1184, 290);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPUESTOS";
            // 
            // btnAddRepuestos
            // 
            this.btnAddRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRepuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddRepuestos.FlatAppearance.BorderSize = 0;
            this.btnAddRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRepuestos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRepuestos.Image")));
            this.btnAddRepuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRepuestos.Location = new System.Drawing.Point(10, 237);
            this.btnAddRepuestos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddRepuestos.Name = "btnAddRepuestos";
            this.btnAddRepuestos.Size = new System.Drawing.Size(140, 47);
            this.btnAddRepuestos.TabIndex = 50;
            this.btnAddRepuestos.Text = "Agregar";
            this.btnAddRepuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRepuestos.UseVisualStyleBackColor = false;
            this.btnAddRepuestos.Click += new System.EventHandler(this.btnAddRepuestos_Click);
            // 
            // dgvRepuestoHoja
            // 
            this.dgvRepuestoHoja.AllowUserToAddRows = false;
            this.dgvRepuestoHoja.AllowUserToDeleteRows = false;
            this.dgvRepuestoHoja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRepuestoHoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestoHoja.Location = new System.Drawing.Point(10, 36);
            this.dgvRepuestoHoja.Name = "dgvRepuestoHoja";
            this.dgvRepuestoHoja.ReadOnly = true;
            this.dgvRepuestoHoja.RowHeadersWidth = 51;
            this.dgvRepuestoHoja.RowTemplate.Height = 24;
            this.dgvRepuestoHoja.Size = new System.Drawing.Size(1157, 194);
            this.dgvRepuestoHoja.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnAddManoObraTerceros);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvManoObraTercerosHoja);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(437, 715);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1184, 290);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MANO DE OBRA TERCEROS";
            // 
            // btnAddManoObraTerceros
            // 
            this.btnAddManoObraTerceros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddManoObraTerceros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddManoObraTerceros.FlatAppearance.BorderSize = 0;
            this.btnAddManoObraTerceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManoObraTerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManoObraTerceros.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddManoObraTerceros.Image = ((System.Drawing.Image)(resources.GetObject("btnAddManoObraTerceros.Image")));
            this.btnAddManoObraTerceros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManoObraTerceros.Location = new System.Drawing.Point(10, 237);
            this.btnAddManoObraTerceros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddManoObraTerceros.Name = "btnAddManoObraTerceros";
            this.btnAddManoObraTerceros.Size = new System.Drawing.Size(140, 47);
            this.btnAddManoObraTerceros.TabIndex = 50;
            this.btnAddManoObraTerceros.Text = "Agregar";
            this.btnAddManoObraTerceros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddManoObraTerceros.UseVisualStyleBackColor = false;
            this.btnAddManoObraTerceros.Click += new System.EventHandler(this.btnAddManoObraTerceros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(777, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOTAL EN REPUESTO";
            // 
            // dgvManoObraTercerosHoja
            // 
            this.dgvManoObraTercerosHoja.AllowUserToAddRows = false;
            this.dgvManoObraTercerosHoja.AllowUserToDeleteRows = false;
            this.dgvManoObraTercerosHoja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManoObraTercerosHoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManoObraTercerosHoja.Location = new System.Drawing.Point(10, 36);
            this.dgvManoObraTercerosHoja.Name = "dgvManoObraTercerosHoja";
            this.dgvManoObraTercerosHoja.ReadOnly = true;
            this.dgvManoObraTercerosHoja.RowHeadersWidth = 51;
            this.dgvManoObraTercerosHoja.RowTemplate.Height = 24;
            this.dgvManoObraTercerosHoja.Size = new System.Drawing.Size(1157, 194);
            this.dgvManoObraTercerosHoja.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1043, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "00.00";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btnAddManoObra);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dgvManoObraHoja);
            this.groupBox3.Controls.Add(this.lblSumaCostoManoObra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(437, 399);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1184, 290);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MANO DE OBRA";
            // 
            // btnAddManoObra
            // 
            this.btnAddManoObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddManoObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddManoObra.FlatAppearance.BorderSize = 0;
            this.btnAddManoObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManoObra.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddManoObra.Image = ((System.Drawing.Image)(resources.GetObject("btnAddManoObra.Image")));
            this.btnAddManoObra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManoObra.Location = new System.Drawing.Point(10, 237);
            this.btnAddManoObra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddManoObra.Name = "btnAddManoObra";
            this.btnAddManoObra.Size = new System.Drawing.Size(140, 47);
            this.btnAddManoObra.TabIndex = 50;
            this.btnAddManoObra.Text = "Agregar";
            this.btnAddManoObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddManoObra.UseVisualStyleBackColor = false;
            this.btnAddManoObra.Click += new System.EventHandler(this.btnAddManoObra_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Desktop;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(717, 237);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(302, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "TOTAL MANO DE OBRA   S/.";
            // 
            // dgvManoObraHoja
            // 
            this.dgvManoObraHoja.AllowUserToAddRows = false;
            this.dgvManoObraHoja.AllowUserToDeleteRows = false;
            this.dgvManoObraHoja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManoObraHoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManoObraHoja.Location = new System.Drawing.Point(10, 36);
            this.dgvManoObraHoja.Name = "dgvManoObraHoja";
            this.dgvManoObraHoja.ReadOnly = true;
            this.dgvManoObraHoja.RowHeadersWidth = 51;
            this.dgvManoObraHoja.RowTemplate.Height = 24;
            this.dgvManoObraHoja.Size = new System.Drawing.Size(1157, 194);
            this.dgvManoObraHoja.TabIndex = 29;
            // 
            // lblSumaCostoManoObra
            // 
            this.lblSumaCostoManoObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumaCostoManoObra.AutoSize = true;
            this.lblSumaCostoManoObra.BackColor = System.Drawing.Color.White;
            this.lblSumaCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaCostoManoObra.ForeColor = System.Drawing.Color.Black;
            this.lblSumaCostoManoObra.Location = new System.Drawing.Point(1043, 237);
            this.lblSumaCostoManoObra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSumaCostoManoObra.Name = "lblSumaCostoManoObra";
            this.lblSumaCostoManoObra.Size = new System.Drawing.Size(66, 25);
            this.lblSumaCostoManoObra.TabIndex = 9;
            this.lblSumaCostoManoObra.Text = "00.00";
            // 
            // frmHoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1748, 1031);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(18, 1018);
            this.Name = "frmHoja";
            this.Text = "frmHoja";
            this.Load += new System.EventHandler(this.frmHoja_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestoHoja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObraTercerosHoja)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObraHoja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumeroHoja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaCostoRepuestos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModeloVehiculo;
        private System.Windows.Forms.TextBox txtMarcaVehiculo;
        private System.Windows.Forms.TextBox txtContactoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TextBox txtRecepcionNHoja;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.TextBox txtIDRecepcion;
        private System.Windows.Forms.TextBox txtAnioVehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddRepuestos;
        private System.Windows.Forms.DataGridView dgvRepuestoHoja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddManoObraTerceros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvManoObraTercerosHoja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddManoObra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvManoObraHoja;
        private System.Windows.Forms.Label lblSumaCostoManoObra;
        private System.Windows.Forms.TextBox txtCuentaRecepcion;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.TextBox txtFechaEntrada;
        private System.Windows.Forms.TextBox txtKilometrajeVehiculo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}