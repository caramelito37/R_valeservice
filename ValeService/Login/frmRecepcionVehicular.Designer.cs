namespace Login
{
    partial class frmRecepcionVehicular
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cbxBuscarRecepcion = new System.Windows.Forms.ComboBox();
            this.txtBuscarRecepcion = new System.Windows.Forms.TextBox();
            this.btnBuscarRecepcion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.cbxClienteDni = new System.Windows.Forms.ComboBox();
            this.cbxVehiculoPlaca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtRecepcionId = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecepcionAdelanto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRecepcionVehicular = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo_Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionVehicular)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 98);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recepcion Vehicular";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(1808, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 32);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnRefrescar);
            this.groupBox2.Controls.Add(this.cbxBuscarRecepcion);
            this.groupBox2.Controls.Add(this.txtBuscarRecepcion);
            this.groupBox2.Controls.Add(this.btnBuscarRecepcion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 574);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(489, 194);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Recepcion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Location = new System.Drawing.Point(20, 96);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(185, 39);
            this.btnRefrescar.TabIndex = 47;
            this.btnRefrescar.Text = "Refrescar Tabla";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cbxBuscarRecepcion
            // 
            this.cbxBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscarRecepcion.FormattingEnabled = true;
            this.cbxBuscarRecepcion.Items.AddRange(new object[] {
            "Recepcion_ID",
            "Fecha_Entrada",
            "Fecha_Salida",
            "Cuenta",
            "Placa_Vehiculo",
            "Cliente_DNI"});
            this.cbxBuscarRecepcion.Location = new System.Drawing.Point(20, 44);
            this.cbxBuscarRecepcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBuscarRecepcion.Name = "cbxBuscarRecepcion";
            this.cbxBuscarRecepcion.Size = new System.Drawing.Size(184, 28);
            this.cbxBuscarRecepcion.TabIndex = 34;
            // 
            // txtBuscarRecepcion
            // 
            this.txtBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRecepcion.Location = new System.Drawing.Point(215, 44);
            this.txtBuscarRecepcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscarRecepcion.Name = "txtBuscarRecepcion";
            this.txtBuscarRecepcion.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarRecepcion.TabIndex = 33;
            // 
            // btnBuscarRecepcion
            // 
            this.btnBuscarRecepcion.BackColor = System.Drawing.Color.Peru;
            this.btnBuscarRecepcion.FlatAppearance.BorderSize = 0;
            this.btnBuscarRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRecepcion.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarRecepcion.Location = new System.Drawing.Point(215, 96);
            this.btnBuscarRecepcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarRecepcion.Name = "btnBuscarRecepcion";
            this.btnBuscarRecepcion.Size = new System.Drawing.Size(241, 39);
            this.btnBuscarRecepcion.TabIndex = 32;
            this.btnBuscarRecepcion.Text = "Buscar";
            this.btnBuscarRecepcion.UseVisualStyleBackColor = false;
            this.btnBuscarRecepcion.Click += new System.EventHandler(this.btnBuscarRecepcion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.mtxtFechaSalida);
            this.groupBox1.Controls.Add(this.mtxtFechaEntrada);
            this.groupBox1.Controls.Add(this.cbxClienteDni);
            this.groupBox1.Controls.Add(this.cbxVehiculoPlaca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtRecepcionId);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecepcionAdelanto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(489, 443);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Recepcion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mtxtFechaSalida
            // 
            this.mtxtFechaSalida.Location = new System.Drawing.Point(209, 130);
            this.mtxtFechaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtFechaSalida.Mask = "00/00/0000";
            this.mtxtFechaSalida.Name = "mtxtFechaSalida";
            this.mtxtFechaSalida.Size = new System.Drawing.Size(133, 30);
            this.mtxtFechaSalida.TabIndex = 54;
            this.mtxtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaEntrada
            // 
            this.mtxtFechaEntrada.Location = new System.Drawing.Point(209, 87);
            this.mtxtFechaEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtFechaEntrada.Mask = "00/00/0000";
            this.mtxtFechaEntrada.Name = "mtxtFechaEntrada";
            this.mtxtFechaEntrada.Size = new System.Drawing.Size(133, 30);
            this.mtxtFechaEntrada.TabIndex = 53;
            this.mtxtFechaEntrada.ValidatingType = typeof(System.DateTime);
            this.mtxtFechaEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFechaEntrada_MaskInputRejected);
            // 
            // cbxClienteDni
            // 
            this.cbxClienteDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClienteDni.FormattingEnabled = true;
            this.cbxClienteDni.Location = new System.Drawing.Point(209, 226);
            this.cbxClienteDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxClienteDni.Name = "cbxClienteDni";
            this.cbxClienteDni.Size = new System.Drawing.Size(237, 28);
            this.cbxClienteDni.TabIndex = 52;
            // 
            // cbxVehiculoPlaca
            // 
            this.cbxVehiculoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiculoPlaca.FormattingEnabled = true;
            this.cbxVehiculoPlaca.Location = new System.Drawing.Point(209, 279);
            this.cbxVehiculoPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxVehiculoPlaca.Name = "cbxVehiculoPlaca";
            this.cbxVehiculoPlaca.Size = new System.Drawing.Size(237, 28);
            this.cbxVehiculoPlaca.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Vehiculo Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cliente Dni";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(248, 380);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 39);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtRecepcionId
            // 
            this.txtRecepcionId.Enabled = false;
            this.txtRecepcionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcionId.Location = new System.Drawing.Point(209, 44);
            this.txtRecepcionId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRecepcionId.Name = "txtRecepcionId";
            this.txtRecepcionId.Size = new System.Drawing.Size(133, 30);
            this.txtRecepcionId.TabIndex = 25;
            this.txtRecepcionId.TextChanged += new System.EventHandler(this.txtRecepcionId_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(40, 380);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 39);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(39, 334);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(409, 39);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha Entrada ";
            // 
            // txtRecepcionAdelanto
            // 
            this.txtRecepcionAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcionAdelanto.Location = new System.Drawing.Point(209, 177);
            this.txtRecepcionAdelanto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRecepcionAdelanto.Name = "txtRecepcionAdelanto";
            this.txtRecepcionAdelanto.Size = new System.Drawing.Size(133, 30);
            this.txtRecepcionAdelanto.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adelanto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha Salida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRecepcionVehicular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(728, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 957);
            this.panel1.TabIndex = 54;
            // 
            // dgvRecepcionVehicular
            // 
            this.dgvRecepcionVehicular.AllowUserToAddRows = false;
            this.dgvRecepcionVehicular.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvRecepcionVehicular.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecepcionVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecepcionVehicular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecepcionVehicular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.NullValue = "-";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecepcionVehicular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecepcionVehicular.ColumnHeadersHeight = 30;
            this.dgvRecepcionVehicular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Entrada,
            this.Salida,
            this.Cuenta,
            this.Vehiculo_Placa,
            this.Cliente_DNI,
            this.Cliente_Nombre});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecepcionVehicular.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecepcionVehicular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecepcionVehicular.EnableHeadersVisualStyles = false;
            this.dgvRecepcionVehicular.Location = new System.Drawing.Point(0, 0);
            this.dgvRecepcionVehicular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRecepcionVehicular.Name = "dgvRecepcionVehicular";
            this.dgvRecepcionVehicular.ReadOnly = true;
            this.dgvRecepcionVehicular.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecepcionVehicular.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecepcionVehicular.RowHeadersVisible = false;
            this.dgvRecepcionVehicular.RowHeadersWidth = 51;
            this.dgvRecepcionVehicular.RowTemplate.Height = 25;
            this.dgvRecepcionVehicular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepcionVehicular.Size = new System.Drawing.Size(1196, 957);
            this.dgvRecepcionVehicular.TabIndex = 0;
            this.dgvRecepcionVehicular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepcionVehicular_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "RecepcionVehiculo_Id";
            this.ID.FillWeight = 53.2995F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 64;
            // 
            // Entrada
            // 
            this.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Entrada.DataPropertyName = "RecepcionVehiculo_Fecha_Entrada";
            this.Entrada.FillWeight = 117.761F;
            this.Entrada.Frozen = true;
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.MinimumWidth = 6;
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            this.Entrada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Entrada.Width = 120;
            // 
            // Salida
            // 
            this.Salida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salida.DataPropertyName = "RecepcionVehiculo_Fecha_Salida";
            this.Salida.FillWeight = 117.761F;
            this.Salida.Frozen = true;
            this.Salida.HeaderText = "Salida";
            this.Salida.MinimumWidth = 6;
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            this.Salida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Salida.Width = 120;
            // 
            // Cuenta
            // 
            this.Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuenta.DataPropertyName = "RecepcionVehiculo_Cuenta";
            this.Cuenta.FillWeight = 66.35426F;
            this.Cuenta.Frozen = true;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.Width = 80;
            // 
            // Vehiculo_Placa
            // 
            this.Vehiculo_Placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Vehiculo_Placa.DataPropertyName = "Vehiculo_Placa";
            this.Vehiculo_Placa.FillWeight = 117.761F;
            this.Vehiculo_Placa.Frozen = true;
            this.Vehiculo_Placa.HeaderText = "Vehiculo_Placa";
            this.Vehiculo_Placa.MinimumWidth = 6;
            this.Vehiculo_Placa.Name = "Vehiculo_Placa";
            this.Vehiculo_Placa.ReadOnly = true;
            this.Vehiculo_Placa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Vehiculo_Placa.Width = 130;
            // 
            // Cliente_DNI
            // 
            this.Cliente_DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cliente_DNI.DataPropertyName = "Cliente_DNI";
            this.Cliente_DNI.FillWeight = 117.761F;
            this.Cliente_DNI.Frozen = true;
            this.Cliente_DNI.HeaderText = "Cliente_DNI";
            this.Cliente_DNI.MinimumWidth = 6;
            this.Cliente_DNI.Name = "Cliente_DNI";
            this.Cliente_DNI.ReadOnly = true;
            this.Cliente_DNI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cliente_DNI.Width = 130;
            // 
            // Cliente_Nombre
            // 
            this.Cliente_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cliente_Nombre.DataPropertyName = "Cliente_Nombre_Apellido";
            this.Cliente_Nombre.Frozen = true;
            this.Cliente_Nombre.HeaderText = "Cliente_Nombre";
            this.Cliente_Nombre.MinimumWidth = 6;
            this.Cliente_Nombre.Name = "Cliente_Nombre";
            this.Cliente_Nombre.ReadOnly = true;
            this.Cliente_Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cliente_Nombre.Width = 250;
            // 
            // frmRecepcionVehicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecepcionVehicular";
            this.Text = "frmRecepcionVehicular";
            this.Load += new System.EventHandler(this.frmRecepcionVehicular_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionVehicular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cbxBuscarRecepcion;
        private System.Windows.Forms.TextBox txtBuscarRecepcion;
        private System.Windows.Forms.Button btnBuscarRecepcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtRecepcionId;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecepcionAdelanto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRecepcionVehicular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxClienteDni;
        private System.Windows.Forms.ComboBox cbxVehiculoPlaca;
        private System.Windows.Forms.MaskedTextBox mtxtFechaSalida;
        private System.Windows.Forms.MaskedTextBox mtxtFechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo_Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nombre;
    }
}