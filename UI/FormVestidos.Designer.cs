namespace UI
{
    partial class FormVestidos
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
            Button btnEliminar;
            Button btnModificar;
            Button btnAgregar;
            Button btnLimpiarVestidos;
            label2 = new Label();
            label4 = new Label();
            label9 = new Label();
            label12 = new Label();
            dgvVestidos = new DataGridView();
            dtpUltimoAjuste = new DateTimePicker();
            txtDisenador = new TextBox();
            cmbTemporada = new ComboBox();
            ckbSi = new CheckBox();
            label1 = new Label();
            txtDescripcionVestido = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            cmbTalle = new ComboBox();
            label11 = new Label();
            cmbEstado = new ComboBox();
            label13 = new Label();
            label17 = new Label();
            label5 = new Label();
            txtHorasAjuste = new TextBox();
            label18 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lblId = new Label();
            cmbModelo = new ComboBox();
            label8 = new Label();
            label15 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtPrecio = new TextBox();
            txtColor = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnLimpiarVestidos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVestidos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(624, 361);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 40);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.BackColor = Color.Bisque;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnModificar.FlatAppearance.BorderSize = 3;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.FromArgb(64, 0, 0);
            btnModificar.Location = new Point(475, 361);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 40);
            btnModificar.TabIndex = 31;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.BackColor = Color.RosyBrown;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(327, 361);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 40);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiarVestidos
            // 
            btnLimpiarVestidos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarVestidos.BackColor = Color.SeaShell;
            btnLimpiarVestidos.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiarVestidos.FlatAppearance.BorderSize = 3;
            btnLimpiarVestidos.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiarVestidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarVestidos.FlatStyle = FlatStyle.Popup;
            btnLimpiarVestidos.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarVestidos.ForeColor = Color.FromArgb(64, 0, 0);
            btnLimpiarVestidos.Location = new Point(774, 360);
            btnLimpiarVestidos.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarVestidos.Name = "btnLimpiarVestidos";
            btnLimpiarVestidos.Size = new Size(133, 40);
            btnLimpiarVestidos.TabIndex = 65;
            btnLimpiarVestidos.Text = "LIMPIAR";
            btnLimpiarVestidos.UseVisualStyleBackColor = false;
            btnLimpiarVestidos.Click += btnLimpiarVestidos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(22, 156);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 1;
            label2.Text = "Modelo(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(584, 160);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 18);
            label4.TabIndex = 3;
            label4.Text = "Modelo Exclusivo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Bold", 12F);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(22, 261);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 18);
            label9.TabIndex = 8;
            label9.Text = "Temporada(*):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Copperplate Gothic Bold", 12F);
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(22, 213);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 18);
            label12.TabIndex = 23;
            label12.Text = "Color:";
            // 
            // dgvVestidos
            // 
            dgvVestidos.BackgroundColor = Color.SeaShell;
            dgvVestidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVestidos.Location = new Point(5, 457);
            dgvVestidos.Margin = new Padding(2);
            dgvVestidos.Name = "dgvVestidos";
            dgvVestidos.RowHeadersWidth = 62;
            dgvVestidos.Size = new Size(1055, 250);
            dgvVestidos.TabIndex = 24;
            dgvVestidos.SelectionChanged += dgvVestidos_SelectionChanged;
            // 
            // dtpUltimoAjuste
            // 
            dtpUltimoAjuste.CalendarForeColor = Color.FromArgb(64, 0, 0);
            dtpUltimoAjuste.CalendarTitleForeColor = Color.FromArgb(64, 0, 0);
            dtpUltimoAjuste.Font = new Font("Bookman Old Style", 9F);
            dtpUltimoAjuste.Location = new Point(741, 260);
            dtpUltimoAjuste.Margin = new Padding(2);
            dtpUltimoAjuste.Name = "dtpUltimoAjuste";
            dtpUltimoAjuste.Size = new Size(295, 22);
            dtpUltimoAjuste.TabIndex = 33;
            // 
            // txtDisenador
            // 
            txtDisenador.BackColor = Color.SeaShell;
            txtDisenador.Font = new Font("Bookman Old Style", 9F);
            txtDisenador.ForeColor = Color.FromArgb(64, 0, 0);
            txtDisenador.Location = new Point(741, 52);
            txtDisenador.Margin = new Padding(2);
            txtDisenador.Name = "txtDisenador";
            txtDisenador.Size = new Size(295, 22);
            txtDisenador.TabIndex = 37;
            // 
            // cmbTemporada
            // 
            cmbTemporada.BackColor = Color.SeaShell;
            cmbTemporada.Font = new Font("Bookman Old Style", 9F);
            cmbTemporada.ForeColor = Color.FromArgb(64, 0, 0);
            cmbTemporada.FormattingEnabled = true;
            cmbTemporada.Location = new Point(180, 258);
            cmbTemporada.Margin = new Padding(2);
            cmbTemporada.Name = "cmbTemporada";
            cmbTemporada.Size = new Size(295, 24);
            cmbTemporada.TabIndex = 40;
            // 
            // ckbSi
            // 
            ckbSi.AutoSize = true;
            ckbSi.Location = new Point(783, 162);
            ckbSi.Margin = new Padding(2);
            ckbSi.Name = "ckbSi";
            ckbSi.Size = new Size(15, 14);
            ckbSi.TabIndex = 43;
            ckbSi.UseVisualStyleBackColor = true;
            ckbSi.CheckedChanged += ckbSi_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(22, 105);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 44;
            label1.Text = "Descripción:";
            // 
            // txtDescripcionVestido
            // 
            txtDescripcionVestido.Font = new Font("Bookman Old Style", 9F);
            txtDescripcionVestido.ForeColor = Color.FromArgb(64, 0, 0);
            txtDescripcionVestido.Location = new Point(180, 104);
            txtDescripcionVestido.Margin = new Padding(2);
            txtDescripcionVestido.Name = "txtDescripcionVestido";
            txtDescripcionVestido.Size = new Size(295, 22);
            txtDescripcionVestido.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(22, 56);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 18);
            label7.TabIndex = 46;
            label7.Text = "Nombre(*):";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bookman Old Style", 9F);
            txtNombre.ForeColor = Color.FromArgb(64, 0, 0);
            txtNombre.Location = new Point(180, 52);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 22);
            txtNombre.TabIndex = 48;
            // 
            // cmbTalle
            // 
            cmbTalle.BackColor = Color.SeaShell;
            cmbTalle.Font = new Font("Bookman Old Style", 9F);
            cmbTalle.ForeColor = Color.FromArgb(64, 0, 0);
            cmbTalle.FormattingEnabled = true;
            cmbTalle.Location = new Point(180, 315);
            cmbTalle.Margin = new Padding(2);
            cmbTalle.Name = "cmbTalle";
            cmbTalle.Size = new Size(295, 24);
            cmbTalle.TabIndex = 54;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Bold", 12F);
            label11.ForeColor = Color.FromArgb(64, 0, 0);
            label11.Location = new Point(586, 106);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 18);
            label11.TabIndex = 53;
            label11.Text = "Estado(*):";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.SeaShell;
            cmbEstado.Font = new Font("Bookman Old Style", 9F);
            cmbEstado.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(741, 102);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(295, 24);
            cmbEstado.TabIndex = 52;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Copperplate Gothic Bold", 12F);
            label13.ForeColor = Color.FromArgb(64, 0, 0);
            label13.Location = new Point(22, 319);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(81, 18);
            label13.TabIndex = 51;
            label13.Text = "Talle(*):";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Copperplate Gothic Bold", 12F);
            label17.ForeColor = Color.FromArgb(64, 0, 0);
            label17.Location = new Point(586, 53);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(125, 18);
            label17.TabIndex = 59;
            label17.Text = "Diseñador(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(586, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 18);
            label5.TabIndex = 62;
            label5.Text = "Horas Ajuste:";
            // 
            // txtHorasAjuste
            // 
            txtHorasAjuste.Font = new Font("Bookman Old Style", 9F);
            txtHorasAjuste.ForeColor = Color.FromArgb(64, 0, 0);
            txtHorasAjuste.Location = new Point(741, 207);
            txtHorasAjuste.Margin = new Padding(2);
            txtHorasAjuste.Name = "txtHorasAjuste";
            txtHorasAjuste.Size = new Size(295, 22);
            txtHorasAjuste.TabIndex = 61;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Copperplate Gothic Bold", 12F);
            label18.ForeColor = Color.FromArgb(64, 0, 0);
            label18.Location = new Point(586, 262);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(138, 18);
            label18.TabIndex = 64;
            label18.Text = "Ultimo Ajuste:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(5, 443);
            label3.Name = "label3";
            label3.Size = new Size(130, 12);
            label3.TabIndex = 65;
            label3.Text = "Listado de vestidos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(cmbModelo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(btnLimpiarVestidos);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHorasAjuste);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(cmbTalle);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDescripcionVestido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ckbSi);
            groupBox1.Controls.Add(cmbTemporada);
            groupBox1.Controls.Add(txtDisenador);
            groupBox1.Controls.Add(dtpUltimoAjuste);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1054, 416);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "GESTION DE VESTIDOS";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.ScrollBar;
            lblId.Font = new Font("Copperplate Gothic Bold", 12F);
            lblId.ForeColor = Color.FromArgb(64, 0, 0);
            lblId.Location = new Point(52, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 73;
            // 
            // cmbModelo
            // 
            cmbModelo.BackColor = Color.SeaShell;
            cmbModelo.Font = new Font("Bookman Old Style", 9F);
            cmbModelo.ForeColor = Color.FromArgb(64, 0, 0);
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(180, 154);
            cmbModelo.Margin = new Padding(2);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(295, 24);
            cmbModelo.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ScrollBar;
            label8.Font = new Font("Copperplate Gothic Bold", 12F);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(23, 24);
            label8.Name = "label8";
            label8.Size = new Size(33, 18);
            label8.TabIndex = 72;
            label8.Text = "Id: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Copperplate Gothic Bold", 12F);
            label15.ForeColor = Color.FromArgb(64, 0, 0);
            label15.Location = new Point(853, 314);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(85, 18);
            label15.TabIndex = 69;
            label15.Text = "Stock(*):";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.SeaShell;
            txtStock.Font = new Font("Bookman Old Style", 9F);
            txtStock.ForeColor = Color.FromArgb(64, 0, 0);
            txtStock.Location = new Point(942, 312);
            txtStock.Margin = new Padding(2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(94, 22);
            txtStock.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(586, 317);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 18);
            label6.TabIndex = 67;
            label6.Text = "Precio(*):";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.SeaShell;
            txtPrecio.Font = new Font("Bookman Old Style", 9F);
            txtPrecio.ForeColor = Color.FromArgb(64, 0, 0);
            txtPrecio.Location = new Point(681, 315);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(94, 22);
            txtPrecio.TabIndex = 66;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.SeaShell;
            txtColor.Font = new Font("Bookman Old Style", 9F);
            txtColor.ForeColor = Color.FromArgb(64, 0, 0);
            txtColor.Location = new Point(180, 207);
            txtColor.Margin = new Padding(2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(295, 22);
            txtColor.TabIndex = 55;
            // 
            // FormVestidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1071, 722);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dgvVestidos);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "FormVestidos";
            Text = "VESTIDOS - ATELIER SARKANY";
            Load += FormVestidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVestidos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label9;
        private Label label12;
        private DataGridView dgvVestidos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DateTimePicker dtpUltimoAjuste;
        private TextBox txtDisenador;
        private ComboBox cmbTemporada;
        private ComboBox cmbModelo;
        private CheckBox ckbSi;
        private Label label1;
        private TextBox txtDescripcionVestido;
        private Label label7;
        private TextBox txtNombre;
        private ComboBox cmbTalle;
        private Label label11;
        private ComboBox cmbEstado;
        private Label label13;
        private Label label17;
        private Label label5;
        private TextBox txtHorasAjuste;
        private Label label18;
        private Label label3;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtPrecio;
        private Label label15;
        private TextBox txtStock;
        private TextBox txtColor;
        private Label label8;
        private Label lblId;
    }
}