namespace Login.FormFlotantes
{
    partial class FHojaRepuestos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNumRepuesto = new System.Windows.Forms.TextBox();
            this.txtHojaRespuestoFF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHojaMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHojaPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHojaCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.txtBuscarRepuestoFF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepuestoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(17, 256);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(181, 33);
            this.btnAceptar.TabIndex = 81;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(240, 256);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 33);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNumRepuesto
            // 
            this.txtNumRepuesto.Enabled = false;
            this.txtNumRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRepuesto.Location = new System.Drawing.Point(160, 46);
            this.txtNumRepuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumRepuesto.Name = "txtNumRepuesto";
            this.txtNumRepuesto.Size = new System.Drawing.Size(119, 30);
            this.txtNumRepuesto.TabIndex = 92;
            // 
            // txtHojaRespuestoFF
            // 
            this.txtHojaRespuestoFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaRespuestoFF.Location = new System.Drawing.Point(160, 7);
            this.txtHojaRespuestoFF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHojaRespuestoFF.Name = "txtHojaRespuestoFF";
            this.txtHojaRespuestoFF.Size = new System.Drawing.Size(119, 30);
            this.txtHojaRespuestoFF.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 87;
            this.label7.Text = "Marca";
            // 
            // txtHojaMarca
            // 
            this.txtHojaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaMarca.Location = new System.Drawing.Point(160, 164);
            this.txtHojaMarca.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHojaMarca.Name = "txtHojaMarca";
            this.txtHojaMarca.Size = new System.Drawing.Size(191, 30);
            this.txtHojaMarca.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 88;
            this.label6.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 90;
            this.label8.Text = "N° Repuesto";
            // 
            // txtHojaPrecio
            // 
            this.txtHojaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaPrecio.Location = new System.Drawing.Point(160, 203);
            this.txtHojaPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHojaPrecio.Name = "txtHojaPrecio";
            this.txtHojaPrecio.Size = new System.Drawing.Size(155, 30);
            this.txtHojaPrecio.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 89;
            this.label9.Text = "Cantidad";
            // 
            // txtHojaCantidad
            // 
            this.txtHojaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaCantidad.Location = new System.Drawing.Point(160, 124);
            this.txtHojaCantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHojaCantidad.Name = "txtHojaCantidad";
            this.txtHojaCantidad.Size = new System.Drawing.Size(169, 30);
            this.txtHojaCantidad.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "N° Hoja";
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRepuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepuestos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRepuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepuestos.ColumnHeadersHeight = 30;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroFF,
            this.DescripcionFF});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRepuestos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRepuestos.EnableHeadersVisualStyles = false;
            this.dgvRepuestos.Location = new System.Drawing.Point(455, 47);
            this.dgvRepuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.ReadOnly = true;
            this.dgvRepuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRepuestos.RowHeadersVisible = false;
            this.dgvRepuestos.RowHeadersWidth = 51;
            this.dgvRepuestos.RowTemplate.Height = 25;
            this.dgvRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRepuestos.Size = new System.Drawing.Size(595, 265);
            this.dgvRepuestos.TabIndex = 93;
            this.dgvRepuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepuestos_CellClick);
            // 
            // txtBuscarRepuestoFF
            // 
            this.txtBuscarRepuestoFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRepuestoFF.Location = new System.Drawing.Point(536, 12);
            this.txtBuscarRepuestoFF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscarRepuestoFF.Name = "txtBuscarRepuestoFF";
            this.txtBuscarRepuestoFF.Size = new System.Drawing.Size(465, 26);
            this.txtBuscarRepuestoFF.TabIndex = 94;
            this.txtBuscarRepuestoFF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarRepuesto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Buscar";
            // 
            // txtRepuestoNombre
            // 
            this.txtRepuestoNombre.Enabled = false;
            this.txtRepuestoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepuestoNombre.Location = new System.Drawing.Point(160, 85);
            this.txtRepuestoNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepuestoNombre.Name = "txtRepuestoNombre";
            this.txtRepuestoNombre.Size = new System.Drawing.Size(268, 30);
            this.txtRepuestoNombre.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Nombre";
            // 
            // NumeroFF
            // 
            this.NumeroFF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumeroFF.DataPropertyName = "Repuesto_Id";
            this.NumeroFF.FillWeight = 53.2995F;
            this.NumeroFF.Frozen = true;
            this.NumeroFF.HeaderText = "Numero";
            this.NumeroFF.MinimumWidth = 6;
            this.NumeroFF.Name = "NumeroFF";
            this.NumeroFF.ReadOnly = true;
            this.NumeroFF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroFF.Width = 95;
            // 
            // DescripcionFF
            // 
            this.DescripcionFF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DescripcionFF.DataPropertyName = "Repuesto_Descripcion";
            this.DescripcionFF.FillWeight = 117.761F;
            this.DescripcionFF.Frozen = true;
            this.DescripcionFF.HeaderText = "Descripcion";
            this.DescripcionFF.MinimumWidth = 6;
            this.DescripcionFF.Name = "DescripcionFF";
            this.DescripcionFF.ReadOnly = true;
            this.DescripcionFF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionFF.Width = 495;
            // 
            // FHojaRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1068, 320);
            this.ControlBox = false;
            this.Controls.Add(this.txtRepuestoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarRepuestoFF);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.txtNumRepuesto);
            this.Controls.Add(this.txtHojaRespuestoFF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHojaMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHojaPrecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHojaCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FHojaRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FHojaRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNumRepuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHojaMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHojaPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHojaCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.TextBox txtBuscarRepuestoFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepuestoNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtHojaRespuestoFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionFF;
    }
}