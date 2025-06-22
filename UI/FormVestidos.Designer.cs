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
            label2 = new Label();
            label4 = new Label();
            label9 = new Label();
            cmbEstado = new ComboBox();
            label12 = new Label();
            dgvVestidos = new DataGridView();
            dtpUltimoAjuste = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            txtHorasAjuste = new TextBox();
            txtDisenador = new TextBox();
            label6 = new Label();
            cmbTalle = new ComboBox();
            cmbNombreVestido = new ComboBox();
            ckbSi = new CheckBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVestidos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(22, 38);
            label2.Name = "label2";
            label2.Size = new Size(219, 26);
            label2.TabIndex = 1;
            label2.Text = "Nombre Vestido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(735, 301);
            label4.Name = "label4";
            label4.Size = new Size(256, 26);
            label4.TabIndex = 3;
            label4.Text = "Modelo Exclusivo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Light", 12F);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(22, 187);
            label9.Name = "label9";
            label9.Size = new Size(90, 26);
            label9.TabIndex = 8;
            label9.Text = "Talle:";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.SeaShell;
            cmbEstado.Font = new Font("Copperplate Gothic Light", 12F);
            cmbEstado.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(247, 108);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(217, 34);
            cmbEstado.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Copperplate Gothic Light", 12F);
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(22, 111);
            label12.Name = "label12";
            label12.Size = new Size(113, 26);
            label12.TabIndex = 23;
            label12.Text = "Estado:";
            // 
            // dgvVestidos
            // 
            dgvVestidos.BackgroundColor = Color.SeaShell;
            dgvVestidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVestidos.Location = new Point(11, 444);
            dgvVestidos.Name = "dgvVestidos";
            dgvVestidos.RowHeadersWidth = 62;
            dgvVestidos.Size = new Size(1507, 477);
            dgvVestidos.TabIndex = 24;
            dgvVestidos.Click += dgvVestidos_SelectionChanged;
            // 
            // dtpUltimoAjuste
            // 
            dtpUltimoAjuste.Location = new Point(881, 111);
            dtpUltimoAjuste.Name = "dtpUltimoAjuste";
            dtpUltimoAjuste.Size = new Size(300, 31);
            dtpUltimoAjuste.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(735, 117);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 34;
            label3.Text = "Ultimo Ajuste";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(735, 229);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 35;
            label5.Text = "Horas Ajuste";
            // 
            // txtHorasAjuste
            // 
            txtHorasAjuste.Location = new Point(881, 207);
            txtHorasAjuste.Name = "txtHorasAjuste";
            txtHorasAjuste.Size = new Size(300, 31);
            txtHorasAjuste.TabIndex = 36;
            // 
            // txtDisenador
            // 
            txtDisenador.BackColor = Color.SeaShell;
            txtDisenador.Location = new Point(881, 30);
            txtDisenador.Name = "txtDisenador";
            txtDisenador.Size = new Size(300, 31);
            txtDisenador.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(735, 36);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 38;
            label6.Text = "Diseñador";
            // 
            // cmbTalle
            // 
            cmbTalle.BackColor = Color.SeaShell;
            cmbTalle.Font = new Font("Copperplate Gothic Light", 12F);
            cmbTalle.ForeColor = Color.FromArgb(64, 0, 0);
            cmbTalle.FormattingEnabled = true;
            cmbTalle.Location = new Point(247, 184);
            cmbTalle.Name = "cmbTalle";
            cmbTalle.Size = new Size(217, 34);
            cmbTalle.TabIndex = 40;
            // 
            // cmbNombreVestido
            // 
            cmbNombreVestido.BackColor = Color.SeaShell;
            cmbNombreVestido.Font = new Font("Copperplate Gothic Light", 12F);
            cmbNombreVestido.ForeColor = Color.FromArgb(64, 0, 0);
            cmbNombreVestido.FormattingEnabled = true;
            cmbNombreVestido.Location = new Point(247, 30);
            cmbNombreVestido.Name = "cmbNombreVestido";
            cmbNombreVestido.Size = new Size(217, 34);
            cmbNombreVestido.TabIndex = 41;
            // 
            // ckbSi
            // 
            ckbSi.AutoSize = true;
            ckbSi.Location = new Point(1019, 301);
            ckbSi.Name = "ckbSi";
            ckbSi.Size = new Size(22, 21);
            ckbSi.TabIndex = 43;
            ckbSi.UseVisualStyleBackColor = true;
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
            btnEliminar.Location = new Point(957, 377);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 43);
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
            btnModificar.Location = new Point(581, 377);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(180, 43);
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
            btnAgregar.Location = new Point(178, 377);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 43);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormVestidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1530, 1050);
            Controls.Add(ckbSi);
            Controls.Add(cmbNombreVestido);
            Controls.Add(cmbTalle);
            Controls.Add(label6);
            Controls.Add(txtDisenador);
            Controls.Add(txtHorasAjuste);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dtpUltimoAjuste);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVestidos);
            Controls.Add(label12);
            Controls.Add(cmbEstado);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormVestidos";
            Text = "VESTIDOS - ATELIER SARKANY";
            Load += FormVestidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVestidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label9;
        private ComboBox cmbEstado;
        private Label label12;
        private DataGridView dgvVestidos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DateTimePicker dtpUltimoAjuste;
        private Label label3;
        private Label label5;
        private TextBox txtHorasAjuste;
        private TextBox txtDisenador;
        private Label label6;
        private ComboBox cmbTalle;
        private ComboBox cmbNombreVestido;
        private CheckBox ckbSi;
    }
}