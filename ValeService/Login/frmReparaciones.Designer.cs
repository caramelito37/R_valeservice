﻿namespace Login
{
    partial class frmReparaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServicioId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cbxBuscarServicio = new System.Windows.Forms.ComboBox();
            this.txtBuscarServicio = new System.Windows.Forms.TextBox();
            this.btnBuscarRepuesto = new System.Windows.Forms.Button();
            this.txtServicioDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvReparaciones = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtManoNServicio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtManoObraNHoja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtManoObraCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtManoObraTiempo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtManoObraCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLIstarObra = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbuscarObra = new System.Windows.Forms.Button();
            this.btnObraEliminar = new System.Windows.Forms.Button();
            this.btnObraEditar = new System.Windows.Forms.Button();
            this.btnObraAgregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvManoDeObra = new System.Windows.Forms.DataGridView();
            this.Hoja_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiciosMecanicos_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManoDeObra_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManoDeObra_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManoDeObra_Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNHojaReparacion = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoDeObra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtNHojaReparacion);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1748, 98);
            this.panel2.TabIndex = 24;
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
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mano de Obra";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(881, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 880);
            this.panel3.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtServicioId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.cbxBuscarServicio);
            this.groupBox1.Controls.Add(this.txtBuscarServicio);
            this.groupBox1.Controls.Add(this.btnBuscarRepuesto);
            this.groupBox1.Controls.Add(this.txtServicioDescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(816, 364);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios Mecanicos";
            // 
            // txtServicioId
            // 
            this.txtServicioId.Enabled = false;
            this.txtServicioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicioId.Location = new System.Drawing.Point(168, 39);
            this.txtServicioId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtServicioId.Name = "txtServicioId";
            this.txtServicioId.Size = new System.Drawing.Size(149, 38);
            this.txtServicioId.TabIndex = 58;
            this.txtServicioId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "N° de Servicio";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Location = new System.Drawing.Point(347, 289);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(185, 39);
            this.btnRefrescar.TabIndex = 56;
            this.btnRefrescar.Text = "Refrescar Tabla";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cbxBuscarServicio
            // 
            this.cbxBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscarServicio.FormattingEnabled = true;
            this.cbxBuscarServicio.Items.AddRange(new object[] {
            "Servicio_Nº",
            "Descripcion"});
            this.cbxBuscarServicio.Location = new System.Drawing.Point(347, 218);
            this.cbxBuscarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBuscarServicio.Name = "cbxBuscarServicio";
            this.cbxBuscarServicio.Size = new System.Drawing.Size(184, 28);
            this.cbxBuscarServicio.TabIndex = 55;
            // 
            // txtBuscarServicio
            // 
            this.txtBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarServicio.Location = new System.Drawing.Point(541, 218);
            this.txtBuscarServicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscarServicio.Multiline = true;
            this.txtBuscarServicio.Name = "txtBuscarServicio";
            this.txtBuscarServicio.Size = new System.Drawing.Size(240, 63);
            this.txtBuscarServicio.TabIndex = 54;
            // 
            // btnBuscarRepuesto
            // 
            this.btnBuscarRepuesto.BackColor = System.Drawing.Color.Peru;
            this.btnBuscarRepuesto.FlatAppearance.BorderSize = 0;
            this.btnBuscarRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRepuesto.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarRepuesto.Location = new System.Drawing.Point(541, 289);
            this.btnBuscarRepuesto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarRepuesto.Name = "btnBuscarRepuesto";
            this.btnBuscarRepuesto.Size = new System.Drawing.Size(241, 39);
            this.btnBuscarRepuesto.TabIndex = 53;
            this.btnBuscarRepuesto.Text = "Buscar";
            this.btnBuscarRepuesto.UseVisualStyleBackColor = false;
            this.btnBuscarRepuesto.Click += new System.EventHandler(this.btnBuscarRepuesto_Click);
            // 
            // txtServicioDescripcion
            // 
            this.txtServicioDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicioDescripcion.Location = new System.Drawing.Point(21, 114);
            this.txtServicioDescripcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtServicioDescripcion.Multiline = true;
            this.txtServicioDescripcion.Name = "txtServicioDescripcion";
            this.txtServicioDescripcion.Size = new System.Drawing.Size(295, 96);
            this.txtServicioDescripcion.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Descripcion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(173, 277);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 50);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(23, 277);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 50);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(21, 218);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(295, 50);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.dgvReparaciones);
            this.panel5.Location = new System.Drawing.Point(15, 404);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 459);
            this.panel5.TabIndex = 3;
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.AllowUserToAddRows = false;
            this.dgvReparaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.dgvReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReparaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.NullValue = "-";
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvReparaciones.ColumnHeadersHeight = 30;
            this.dgvReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Descripcion});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReparaciones.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReparaciones.EnableHeadersVisualStyles = false;
            this.dgvReparaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvReparaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReparaciones.Name = "dgvReparaciones";
            this.dgvReparaciones.ReadOnly = true;
            this.dgvReparaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvReparaciones.RowHeadersVisible = false;
            this.dgvReparaciones.RowHeadersWidth = 51;
            this.dgvReparaciones.RowTemplate.Height = 25;
            this.dgvReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparaciones.Size = new System.Drawing.Size(816, 459);
            this.dgvReparaciones.TabIndex = 1;
            this.dgvReparaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReparaciones_CellClick);
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numero.DataPropertyName = "ServiciosMecanicos_Id";
            this.Numero.FillWeight = 53.2995F;
            this.Numero.Frozen = true;
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Numero.Width = 95;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descripcion.DataPropertyName = "ServiciosMecanicos_Descripcion";
            this.Descripcion.FillWeight = 117.761F;
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 600;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 880);
            this.panel1.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtManoNServicio);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtManoObraNHoja);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtManoObraCosto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtManoObraTiempo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtManoObraCantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnLIstarObra);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnbuscarObra);
            this.groupBox2.Controls.Add(this.btnObraEliminar);
            this.groupBox2.Controls.Add(this.btnObraEditar);
            this.groupBox2.Controls.Add(this.btnObraAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(816, 470);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mano de Obra";
            // 
            // txtManoNServicio
            // 
            this.txtManoNServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoNServicio.Location = new System.Drawing.Point(189, 111);
            this.txtManoNServicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManoNServicio.Name = "txtManoNServicio";
            this.txtManoNServicio.Size = new System.Drawing.Size(189, 30);
            this.txtManoNServicio.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Login.Properties.Resources.hoja_pequeño;
            this.button1.Location = new System.Drawing.Point(391, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 32);
            this.button1.TabIndex = 69;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtManoObraNHoja
            // 
            this.txtManoObraNHoja.Enabled = false;
            this.txtManoObraNHoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoObraNHoja.Location = new System.Drawing.Point(189, 53);
            this.txtManoObraNHoja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManoObraNHoja.Name = "txtManoObraNHoja";
            this.txtManoObraNHoja.Size = new System.Drawing.Size(189, 30);
            this.txtManoObraNHoja.TabIndex = 68;
            this.txtManoObraNHoja.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Costo";
            // 
            // txtManoObraCosto
            // 
            this.txtManoObraCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoObraCosto.Location = new System.Drawing.Point(189, 209);
            this.txtManoObraCosto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManoObraCosto.Name = "txtManoObraCosto";
            this.txtManoObraCosto.Size = new System.Drawing.Size(231, 30);
            this.txtManoObraCosto.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tiempo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = "N° Servicio";
            // 
            // txtManoObraTiempo
            // 
            this.txtManoObraTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoObraTiempo.Location = new System.Drawing.Point(189, 252);
            this.txtManoObraTiempo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManoObraTiempo.Name = "txtManoObraTiempo";
            this.txtManoObraTiempo.Size = new System.Drawing.Size(231, 30);
            this.txtManoObraTiempo.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Cantidad";
            // 
            // txtManoObraCantidad
            // 
            this.txtManoObraCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoObraCantidad.Location = new System.Drawing.Point(189, 159);
            this.txtManoObraCantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManoObraCantidad.Name = "txtManoObraCantidad";
            this.txtManoObraCantidad.Size = new System.Drawing.Size(189, 30);
            this.txtManoObraCantidad.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "N° Hoja";
            // 
            // btnLIstarObra
            // 
            this.btnLIstarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnLIstarObra.FlatAppearance.BorderSize = 0;
            this.btnLIstarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIstarObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIstarObra.ForeColor = System.Drawing.Color.Transparent;
            this.btnLIstarObra.Location = new System.Drawing.Point(23, 415);
            this.btnLIstarObra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLIstarObra.Name = "btnLIstarObra";
            this.btnLIstarObra.Size = new System.Drawing.Size(236, 39);
            this.btnLIstarObra.TabIndex = 56;
            this.btnLIstarObra.Text = "Ver todos los registros ";
            this.btnLIstarObra.UseVisualStyleBackColor = false;
            this.btnLIstarObra.Click += new System.EventHandler(this.btnLIstarObra_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Recepcion_ID",
            "Fecha_Entrada",
            "Fecha_Salida",
            "Cuenta",
            "Placa_Vehiculo",
            "Cliente_DNI"});
            this.comboBox1.Location = new System.Drawing.Point(23, 363);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 28);
            this.comboBox1.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(219, 363);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 54;
            // 
            // btnbuscarObra
            // 
            this.btnbuscarObra.BackColor = System.Drawing.Color.Peru;
            this.btnbuscarObra.FlatAppearance.BorderSize = 0;
            this.btnbuscarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarObra.ForeColor = System.Drawing.Color.Transparent;
            this.btnbuscarObra.Location = new System.Drawing.Point(269, 415);
            this.btnbuscarObra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnbuscarObra.Name = "btnbuscarObra";
            this.btnbuscarObra.Size = new System.Drawing.Size(241, 39);
            this.btnbuscarObra.TabIndex = 53;
            this.btnbuscarObra.Text = "Buscar";
            this.btnbuscarObra.UseVisualStyleBackColor = false;
            // 
            // btnObraEliminar
            // 
            this.btnObraEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnObraEliminar.FlatAppearance.BorderSize = 0;
            this.btnObraEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObraEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnObraEliminar.Location = new System.Drawing.Point(576, 218);
            this.btnObraEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnObraEliminar.Name = "btnObraEliminar";
            this.btnObraEliminar.Size = new System.Drawing.Size(221, 50);
            this.btnObraEliminar.TabIndex = 50;
            this.btnObraEliminar.Text = "Eliminar";
            this.btnObraEliminar.UseVisualStyleBackColor = false;
            this.btnObraEliminar.Click += new System.EventHandler(this.btnObraEliminar_Click);
            // 
            // btnObraEditar
            // 
            this.btnObraEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btnObraEditar.FlatAppearance.BorderSize = 0;
            this.btnObraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObraEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnObraEditar.Location = new System.Drawing.Point(576, 150);
            this.btnObraEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnObraEditar.Name = "btnObraEditar";
            this.btnObraEditar.Size = new System.Drawing.Size(221, 50);
            this.btnObraEditar.TabIndex = 49;
            this.btnObraEditar.Text = "Editar";
            this.btnObraEditar.UseVisualStyleBackColor = false;
            this.btnObraEditar.Click += new System.EventHandler(this.btnObraEditar_Click);
            // 
            // btnObraAgregar
            // 
            this.btnObraAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObraAgregar.FlatAppearance.BorderSize = 0;
            this.btnObraAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObraAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnObraAgregar.Location = new System.Drawing.Point(576, 85);
            this.btnObraAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnObraAgregar.Name = "btnObraAgregar";
            this.btnObraAgregar.Size = new System.Drawing.Size(221, 50);
            this.btnObraAgregar.TabIndex = 48;
            this.btnObraAgregar.Text = "Agregar";
            this.btnObraAgregar.UseVisualStyleBackColor = false;
            this.btnObraAgregar.Click += new System.EventHandler(this.btnObraAgregar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.dgvManoDeObra);
            this.panel4.Location = new System.Drawing.Point(13, 510);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(816, 353);
            this.panel4.TabIndex = 2;
            // 
            // dgvManoDeObra
            // 
            this.dgvManoDeObra.AllowUserToAddRows = false;
            this.dgvManoDeObra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.dgvManoDeObra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvManoDeObra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManoDeObra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvManoDeObra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.NullValue = "-";
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManoDeObra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvManoDeObra.ColumnHeadersHeight = 60;
            this.dgvManoDeObra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hoja_Numero,
            this.ServiciosMecanicos_Id,
            this.ManoDeObra_Cantidad,
            this.ManoDeObra_Costo,
            this.ManoDeObra_Tiempo});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManoDeObra.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvManoDeObra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManoDeObra.EnableHeadersVisualStyles = false;
            this.dgvManoDeObra.Location = new System.Drawing.Point(0, 0);
            this.dgvManoDeObra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvManoDeObra.Name = "dgvManoDeObra";
            this.dgvManoDeObra.ReadOnly = true;
            this.dgvManoDeObra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManoDeObra.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvManoDeObra.RowHeadersVisible = false;
            this.dgvManoDeObra.RowHeadersWidth = 51;
            this.dgvManoDeObra.RowTemplate.Height = 25;
            this.dgvManoDeObra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManoDeObra.Size = new System.Drawing.Size(816, 353);
            this.dgvManoDeObra.TabIndex = 2;
            this.dgvManoDeObra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManoDeObra_CellClick);
            // 
            // Hoja_Numero
            // 
            this.Hoja_Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Hoja_Numero.DataPropertyName = "Hoja_Numero";
            this.Hoja_Numero.FillWeight = 53.2995F;
            this.Hoja_Numero.Frozen = true;
            this.Hoja_Numero.HeaderText = "Nº HOJA";
            this.Hoja_Numero.MinimumWidth = 6;
            this.Hoja_Numero.Name = "Hoja_Numero";
            this.Hoja_Numero.ReadOnly = true;
            this.Hoja_Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hoja_Numero.Width = 95;
            // 
            // ServiciosMecanicos_Id
            // 
            this.ServiciosMecanicos_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiciosMecanicos_Id.DataPropertyName = "ServiciosMecanicos_Id";
            this.ServiciosMecanicos_Id.FillWeight = 117.761F;
            this.ServiciosMecanicos_Id.Frozen = true;
            this.ServiciosMecanicos_Id.HeaderText = "SERVICO MECANICO ID";
            this.ServiciosMecanicos_Id.MinimumWidth = 6;
            this.ServiciosMecanicos_Id.Name = "ServiciosMecanicos_Id";
            this.ServiciosMecanicos_Id.ReadOnly = true;
            this.ServiciosMecanicos_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiciosMecanicos_Id.Width = 125;
            // 
            // ManoDeObra_Cantidad
            // 
            this.ManoDeObra_Cantidad.DataPropertyName = "ManoDeObra_Cantidad";
            this.ManoDeObra_Cantidad.HeaderText = "CANTIDAD";
            this.ManoDeObra_Cantidad.MinimumWidth = 6;
            this.ManoDeObra_Cantidad.Name = "ManoDeObra_Cantidad";
            this.ManoDeObra_Cantidad.ReadOnly = true;
            this.ManoDeObra_Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ManoDeObra_Costo
            // 
            this.ManoDeObra_Costo.DataPropertyName = "ManoDeObra_Costo";
            this.ManoDeObra_Costo.HeaderText = "COSTO";
            this.ManoDeObra_Costo.MinimumWidth = 6;
            this.ManoDeObra_Costo.Name = "ManoDeObra_Costo";
            this.ManoDeObra_Costo.ReadOnly = true;
            this.ManoDeObra_Costo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ManoDeObra_Tiempo
            // 
            this.ManoDeObra_Tiempo.DataPropertyName = "ManoDeObra_Tiempo";
            this.ManoDeObra_Tiempo.HeaderText = "TIEMPO";
            this.ManoDeObra_Tiempo.MinimumWidth = 6;
            this.ManoDeObra_Tiempo.Name = "ManoDeObra_Tiempo";
            this.ManoDeObra_Tiempo.ReadOnly = true;
            this.ManoDeObra_Tiempo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtNHojaReparacion
            // 
            this.txtNHojaReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNHojaReparacion.Location = new System.Drawing.Point(325, 16);
            this.txtNHojaReparacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNHojaReparacion.Name = "txtNHojaReparacion";
            this.txtNHojaReparacion.Size = new System.Drawing.Size(159, 56);
            this.txtNHojaReparacion.TabIndex = 8;
            // 
            // frmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 1031);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReparaciones";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmReparaciones_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoDeObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServicioId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cbxBuscarServicio;
        private System.Windows.Forms.TextBox txtBuscarServicio;
        private System.Windows.Forms.Button btnBuscarRepuesto;
        private System.Windows.Forms.TextBox txtServicioDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvReparaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtManoObraCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtManoObraTiempo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtManoObraCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLIstarObra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbuscarObra;
        private System.Windows.Forms.Button btnObraEliminar;
        private System.Windows.Forms.Button btnObraEditar;
        private System.Windows.Forms.Button btnObraAgregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvManoDeObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtManoObraNHoja;
        private System.Windows.Forms.TextBox txtManoNServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoja_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiciosMecanicos_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManoDeObra_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManoDeObra_Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManoDeObra_Tiempo;
        private System.Windows.Forms.TextBox txtNHojaReparacion;
    }
}