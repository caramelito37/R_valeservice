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
            this.txtFechaEntrada = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtRecepcionId = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdelanto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRecepcionVehicular = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBuscarCliente = new System.Windows.Forms.DataGridView();
            this.btnRefrescar2 = new System.Windows.Forms.Button();
            this.cbxBuscarCliente = new System.Windows.Forms.ComboBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvBuscarVehiculo = new System.Windows.Forms.DataGridView();
            this.btnRefrescar1 = new System.Windows.Forms.Button();
            this.cbxBuscarVehiculo = new System.Windows.Forms.ComboBox();
            this.txtBuscarVehiculo = new System.Windows.Forms.TextBox();
            this.btnBuscarVehiculo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionVehicular)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1553, 80);
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
            this.btnCerrar.Location = new System.Drawing.Point(1466, 0);
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
            this.groupBox2.Location = new System.Drawing.Point(20, 481);
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
            this.groupBox1.Controls.Add(this.cbxClienteDni);
            this.groupBox1.Controls.Add(this.cbxVehiculoPlaca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFechaEntrada);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtRecepcionId);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdelanto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFechaSalida);
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
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrada.Location = new System.Drawing.Point(157, 71);
            this.txtFechaEntrada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(179, 26);
            this.txtFechaEntrada.TabIndex = 26;
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
            this.txtRecepcionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcionId.Location = new System.Drawing.Point(157, 36);
            this.txtRecepcionId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRecepcionId.Name = "txtRecepcionId";
            this.txtRecepcionId.Size = new System.Drawing.Size(179, 26);
            this.txtRecepcionId.TabIndex = 25;
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
            // txtAdelanto
            // 
            this.txtAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdelanto.Location = new System.Drawing.Point(157, 144);
            this.txtAdelanto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdelanto.Name = "txtAdelanto";
            this.txtAdelanto.Size = new System.Drawing.Size(179, 26);
            this.txtAdelanto.TabIndex = 35;
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
            // txtFechaSalida
            // 
            this.txtFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaSalida.Location = new System.Drawing.Point(157, 109);
            this.txtFechaSalida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(179, 26);
            this.txtFechaSalida.TabIndex = 34;
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
            this.panel1.Location = new System.Drawing.Point(838, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 845);
            this.panel1.TabIndex = 54;
            // 
            // dgvRecepcionVehicular
            // 
            this.dgvRecepcionVehicular.AllowUserToAddRows = false;
            this.dgvRecepcionVehicular.AllowUserToDeleteRows = false;
            this.dgvRecepcionVehicular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecepcionVehicular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepcionVehicular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecepcionVehicular.Location = new System.Drawing.Point(0, 0);
            this.dgvRecepcionVehicular.Name = "dgvRecepcionVehicular";
            this.dgvRecepcionVehicular.ReadOnly = true;
            this.dgvRecepcionVehicular.Size = new System.Drawing.Size(715, 845);
            this.dgvRecepcionVehicular.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dgvBuscarCliente);
            this.groupBox3.Controls.Add(this.btnRefrescar2);
            this.groupBox3.Controls.Add(this.cbxBuscarCliente);
            this.groupBox3.Controls.Add(this.txtBuscarCliente);
            this.groupBox3.Controls.Add(this.btnBuscarCliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(408, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 313);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Cliente";
            // 
            // dgvBuscarCliente
            // 
            this.dgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCliente.Location = new System.Drawing.Point(0, 132);
            this.dgvBuscarCliente.Name = "dgvBuscarCliente";
            this.dgvBuscarCliente.Size = new System.Drawing.Size(424, 181);
            this.dgvBuscarCliente.TabIndex = 48;
            // 
            // btnRefrescar2
            // 
            this.btnRefrescar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnRefrescar2.FlatAppearance.BorderSize = 0;
            this.btnRefrescar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar2.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar2.Location = new System.Drawing.Point(15, 78);
            this.btnRefrescar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefrescar2.Name = "btnRefrescar2";
            this.btnRefrescar2.Size = new System.Drawing.Size(176, 32);
            this.btnRefrescar2.TabIndex = 47;
            this.btnRefrescar2.Text = "Refrescar Tabla";
            this.btnRefrescar2.UseVisualStyleBackColor = false;
            // 
            // cbxBuscarCliente
            // 
            this.cbxBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscarCliente.FormattingEnabled = true;
            this.cbxBuscarCliente.Items.AddRange(new object[] {
            "DNI",
            "Nombre_Apellido",
            "Contacto"});
            this.cbxBuscarCliente.Location = new System.Drawing.Point(15, 36);
            this.cbxBuscarCliente.Name = "cbxBuscarCliente";
            this.cbxBuscarCliente.Size = new System.Drawing.Size(176, 24);
            this.cbxBuscarCliente.TabIndex = 34;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(198, 36);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(181, 22);
            this.txtBuscarCliente.TabIndex = 33;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Peru;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.Location = new System.Drawing.Point(198, 78);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(181, 32);
            this.btnBuscarCliente.TabIndex = 32;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.dgvBuscarVehiculo);
            this.groupBox4.Controls.Add(this.btnRefrescar1);
            this.groupBox4.Controls.Add(this.cbxBuscarVehiculo);
            this.groupBox4.Controls.Add(this.txtBuscarVehiculo);
            this.groupBox4.Controls.Add(this.btnBuscarVehiculo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(408, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 313);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar Vehiculo";
            // 
            // dgvBuscarVehiculo
            // 
            this.dgvBuscarVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarVehiculo.Location = new System.Drawing.Point(0, 132);
            this.dgvBuscarVehiculo.Name = "dgvBuscarVehiculo";
            this.dgvBuscarVehiculo.Size = new System.Drawing.Size(424, 181);
            this.dgvBuscarVehiculo.TabIndex = 49;
            // 
            // btnRefrescar1
            // 
            this.btnRefrescar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnRefrescar1.FlatAppearance.BorderSize = 0;
            this.btnRefrescar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar1.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar1.Location = new System.Drawing.Point(15, 78);
            this.btnRefrescar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefrescar1.Name = "btnRefrescar1";
            this.btnRefrescar1.Size = new System.Drawing.Size(176, 32);
            this.btnRefrescar1.TabIndex = 47;
            this.btnRefrescar1.Text = "Refrescar Tabla";
            this.btnRefrescar1.UseVisualStyleBackColor = false;
            // 
            // cbxBuscarVehiculo
            // 
            this.cbxBuscarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscarVehiculo.FormattingEnabled = true;
            this.cbxBuscarVehiculo.Items.AddRange(new object[] {
            "Placa",
            "Marca",
            "Modelo",
            "Año",
            "Kilometraje"});
            this.cbxBuscarVehiculo.Location = new System.Drawing.Point(15, 36);
            this.cbxBuscarVehiculo.Name = "cbxBuscarVehiculo";
            this.cbxBuscarVehiculo.Size = new System.Drawing.Size(176, 24);
            this.cbxBuscarVehiculo.TabIndex = 34;
            // 
            // txtBuscarVehiculo
            // 
            this.txtBuscarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVehiculo.Location = new System.Drawing.Point(198, 36);
            this.txtBuscarVehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarVehiculo.Name = "txtBuscarVehiculo";
            this.txtBuscarVehiculo.Size = new System.Drawing.Size(181, 22);
            this.txtBuscarVehiculo.TabIndex = 33;
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.BackColor = System.Drawing.Color.Peru;
            this.btnBuscarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnBuscarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVehiculo.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(198, 78);
            this.btnBuscarVehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(181, 32);
            this.btnBuscarVehiculo.TabIndex = 32;
            this.btnBuscarVehiculo.Text = "Buscar";
            this.btnBuscarVehiculo.UseVisualStyleBackColor = false;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBuscarVehiculo_Click);
            // 
            // frmRecepcionVehicular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1553, 925);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarVehiculo)).EndInit();
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
        private System.Windows.Forms.TextBox txtFechaEntrada;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtRecepcionId;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdelanto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRecepcionVehicular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxClienteDni;
        private System.Windows.Forms.ComboBox cbxVehiculoPlaca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefrescar2;
        private System.Windows.Forms.ComboBox cbxBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRefrescar1;
        private System.Windows.Forms.ComboBox cbxBuscarVehiculo;
        private System.Windows.Forms.TextBox txtBuscarVehiculo;
        private System.Windows.Forms.Button btnBuscarVehiculo;
        private System.Windows.Forms.DataGridView dgvBuscarCliente;
        private System.Windows.Forms.DataGridView dgvBuscarVehiculo;
    }
}