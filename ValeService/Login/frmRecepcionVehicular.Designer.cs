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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cbxBuscarRecepcion = new System.Windows.Forms.ComboBox();
            this.txtBuscarRecepcion = new System.Windows.Forms.TextBox();
            this.btnBuscarRecepcion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaSalida = new System.Windows.Forms.MaskedTextBox();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 80);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
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
            this.btnCerrar.Location = new System.Drawing.Point(1356, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 26);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnRefrescar);
            this.groupBox2.Controls.Add(this.cbxBuscarRecepcion);
            this.groupBox2.Controls.Add(this.txtBuscarRecepcion);
            this.groupBox2.Controls.Add(this.btnBuscarRecepcion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 158);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Recepcion";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Location = new System.Drawing.Point(15, 78);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(139, 32);
            this.btnRefrescar.TabIndex = 47;
            this.btnRefrescar.Text = "Refrescar Tabla";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // cbxBuscarRecepcion
            // 
            this.cbxBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscarRecepcion.FormattingEnabled = true;
            this.cbxBuscarRecepcion.Items.AddRange(new object[] {
            "Placa",
            "Marca",
            "Modelo",
            "Año",
            "Kilometraje"});
            this.cbxBuscarRecepcion.Location = new System.Drawing.Point(15, 36);
            this.cbxBuscarRecepcion.Name = "cbxBuscarRecepcion";
            this.cbxBuscarRecepcion.Size = new System.Drawing.Size(139, 24);
            this.cbxBuscarRecepcion.TabIndex = 34;
            // 
            // txtBuscarRecepcion
            // 
            this.txtBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRecepcion.Location = new System.Drawing.Point(161, 36);
            this.txtBuscarRecepcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarRecepcion.Name = "txtBuscarRecepcion";
            this.txtBuscarRecepcion.Size = new System.Drawing.Size(181, 22);
            this.txtBuscarRecepcion.TabIndex = 33;
            // 
            // btnBuscarRecepcion
            // 
            this.btnBuscarRecepcion.BackColor = System.Drawing.Color.Peru;
            this.btnBuscarRecepcion.FlatAppearance.BorderSize = 0;
            this.btnBuscarRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRecepcion.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarRecepcion.Location = new System.Drawing.Point(161, 78);
            this.btnBuscarRecepcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarRecepcion.Name = "btnBuscarRecepcion";
            this.btnBuscarRecepcion.Size = new System.Drawing.Size(181, 32);
            this.btnBuscarRecepcion.TabIndex = 32;
            this.btnBuscarRecepcion.Text = "Buscar";
            this.btnBuscarRecepcion.UseVisualStyleBackColor = false;
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
            this.groupBox1.Location = new System.Drawing.Point(20, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 360);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Recepcion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxClienteDni
            // 
            this.cbxClienteDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClienteDni.FormattingEnabled = true;
            this.cbxClienteDni.Location = new System.Drawing.Point(157, 184);
            this.cbxClienteDni.Name = "cbxClienteDni";
            this.cbxClienteDni.Size = new System.Drawing.Size(179, 24);
            this.cbxClienteDni.TabIndex = 52;
            // 
            // cbxVehiculoPlaca
            // 
            this.cbxVehiculoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiculoPlaca.FormattingEnabled = true;
            this.cbxVehiculoPlaca.Location = new System.Drawing.Point(157, 221);
            this.cbxVehiculoPlaca.Name = "cbxVehiculoPlaca";
            this.cbxVehiculoPlaca.Size = new System.Drawing.Size(179, 24);
            this.cbxVehiculoPlaca.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Vehiculo Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
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
            this.btnEliminar.Location = new System.Drawing.Point(144, 310);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 32);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtRecepcionId
            // 
            this.txtRecepcionId.Enabled = false;
            this.txtRecepcionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcionId.Location = new System.Drawing.Point(157, 36);
            this.txtRecepcionId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRecepcionId.Name = "txtRecepcionId";
            this.txtRecepcionId.Size = new System.Drawing.Size(101, 26);
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
            this.btnEditar.Location = new System.Drawing.Point(29, 310);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 32);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
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
            this.btnAgregar.Location = new System.Drawing.Point(29, 271);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(229, 32);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha Entrada ";
            // 
            // txtRecepcionAdelanto
            // 
            this.txtRecepcionAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcionAdelanto.Location = new System.Drawing.Point(157, 144);
            this.txtRecepcionAdelanto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRecepcionAdelanto.Name = "txtRecepcionAdelanto";
            this.txtRecepcionAdelanto.Size = new System.Drawing.Size(101, 26);
            this.txtRecepcionAdelanto.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adelanto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha Salida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRecepcionVehicular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(546, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 777);
            this.panel1.TabIndex = 54;
            // 
            // dgvRecepcionVehicular
            // 
            this.dgvRecepcionVehicular.AllowUserToAddRows = false;
            this.dgvRecepcionVehicular.AllowUserToDeleteRows = false;
            this.dgvRecepcionVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecepcionVehicular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecepcionVehicular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepcionVehicular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRecepcionVehicular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecepcionVehicular.Location = new System.Drawing.Point(0, 0);
            this.dgvRecepcionVehicular.Name = "dgvRecepcionVehicular";
            this.dgvRecepcionVehicular.ReadOnly = true;
            this.dgvRecepcionVehicular.RowHeadersWidth = 51;
            this.dgvRecepcionVehicular.Size = new System.Drawing.Size(897, 777);
            this.dgvRecepcionVehicular.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RecepcionVehiculo_Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RecepcionVehiculo_Fecha_Entrada";
            this.Column2.HeaderText = "Entrada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RecepcionVehiculo_Fecha_Salida";
            this.Column7.HeaderText = "Salida";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RecepcionVehiculo_Cuenta";
            this.Column4.HeaderText = "Cuenta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Vehiculo_Placa";
            this.Column5.HeaderText = "Vehiculo_Placa";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cliente_DNI";
            this.Column6.HeaderText = "Cliente_DNI";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // mtxtFechaEntrada
            // 
            this.mtxtFechaEntrada.Location = new System.Drawing.Point(157, 71);
            this.mtxtFechaEntrada.Mask = "00/00/0000";
            this.mtxtFechaEntrada.Name = "mtxtFechaEntrada";
            this.mtxtFechaEntrada.Size = new System.Drawing.Size(101, 26);
            this.mtxtFechaEntrada.TabIndex = 53;
            this.mtxtFechaEntrada.ValidatingType = typeof(System.DateTime);
            this.mtxtFechaEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFechaEntrada_MaskInputRejected);
            // 
            // mtxtFechaSalida
            // 
            this.mtxtFechaSalida.Location = new System.Drawing.Point(157, 106);
            this.mtxtFechaSalida.Mask = "00/00/0000";
            this.mtxtFechaSalida.Name = "mtxtFechaSalida";
            this.mtxtFechaSalida.Size = new System.Drawing.Size(101, 26);
            this.mtxtFechaSalida.TabIndex = 54;
            this.mtxtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // frmRecepcionVehicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.MaskedTextBox mtxtFechaSalida;
        private System.Windows.Forms.MaskedTextBox mtxtFechaEntrada;
    }
}