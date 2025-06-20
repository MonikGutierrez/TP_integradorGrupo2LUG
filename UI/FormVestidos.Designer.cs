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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtId = new TextBox();
            txtTemporada = new TextBox();
            txtColor = new TextBox();
            txtPrecio = new TextBox();
            txtModelo = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtTalle = new TextBox();
            txtDiseñador = new TextBox();
            txtTiempoAjuste = new TextBox();
            cmbEstado = new ComboBox();
            label12 = new Label();
            dgvVestido = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVestido).BeginInit();
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
            btnEliminar.Location = new Point(571, 309);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 26);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnModificar.Location = new Point(256, 309);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 26);
            btnModificar.TabIndex = 31;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
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
            btnAgregar.Location = new Point(14, 309);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 26);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(8, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(290, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(288, 119);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(288, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 3;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Light", 12F);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(8, 119);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 4;
            label5.Text = "Color:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Light", 12F);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(288, 165);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 17);
            label6.TabIndex = 5;
            label6.Text = "Temporada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Light", 12F);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(8, 165);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 6;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Light", 12F);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(8, 212);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 7;
            label8.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Light", 12F);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(8, 260);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 8;
            label9.Text = "Talle:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Light", 12F);
            label10.ForeColor = Color.FromArgb(64, 0, 0);
            label10.Location = new Point(288, 217);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 17);
            label10.TabIndex = 9;
            label10.Text = "Diseñador:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Light", 12F);
            label11.ForeColor = Color.FromArgb(64, 0, 0);
            label11.Location = new Point(290, 264);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(223, 17);
            label11.TabIndex = 10;
            label11.Text = "Tiempo de Ajuste (en hs.):";
            // 
            // txtId
            // 
            txtId.BackColor = Color.SeaShell;
            txtId.Font = new Font("Copperplate Gothic Light", 12F);
            txtId.ForeColor = Color.FromArgb(64, 0, 0);
            txtId.Location = new Point(88, 19);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(156, 25);
            txtId.TabIndex = 11;
            // 
            // txtTemporada
            // 
            txtTemporada.BackColor = Color.SeaShell;
            txtTemporada.Location = new Point(410, 163);
            txtTemporada.Margin = new Padding(2);
            txtTemporada.Name = "txtTemporada";
            txtTemporada.Size = new Size(287, 23);
            txtTemporada.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.SeaShell;
            txtColor.Font = new Font("Copperplate Gothic Light", 12F);
            txtColor.ForeColor = Color.FromArgb(64, 0, 0);
            txtColor.Location = new Point(88, 114);
            txtColor.Margin = new Padding(2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(153, 25);
            txtColor.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.SeaShell;
            txtPrecio.Font = new Font("Copperplate Gothic Light", 12F);
            txtPrecio.ForeColor = Color.FromArgb(64, 0, 0);
            txtPrecio.Location = new Point(88, 162);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(153, 25);
            txtPrecio.TabIndex = 14;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.SeaShell;
            txtModelo.Font = new Font("Copperplate Gothic Light", 12F);
            txtModelo.ForeColor = Color.FromArgb(64, 0, 0);
            txtModelo.Location = new Point(372, 68);
            txtModelo.Margin = new Padding(2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(327, 25);
            txtModelo.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.SeaShell;
            txtDescripcion.Location = new Point(410, 116);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(287, 23);
            txtDescripcion.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.SeaShell;
            txtNombre.Font = new Font("Copperplate Gothic Light", 12F);
            txtNombre.ForeColor = Color.FromArgb(64, 0, 0);
            txtNombre.Location = new Point(373, 19);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(327, 25);
            txtNombre.TabIndex = 17;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.SeaShell;
            txtStock.Location = new Point(88, 211);
            txtStock.Margin = new Padding(2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(153, 23);
            txtStock.TabIndex = 18;
            // 
            // txtTalle
            // 
            txtTalle.BackColor = Color.SeaShell;
            txtTalle.Location = new Point(87, 258);
            txtTalle.Margin = new Padding(2);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new Size(153, 23);
            txtTalle.TabIndex = 19;
            // 
            // txtDiseñador
            // 
            txtDiseñador.BackColor = Color.SeaShell;
            txtDiseñador.Location = new Point(410, 212);
            txtDiseñador.Margin = new Padding(2);
            txtDiseñador.Name = "txtDiseñador";
            txtDiseñador.Size = new Size(287, 23);
            txtDiseñador.TabIndex = 20;
            // 
            // txtTiempoAjuste
            // 
            txtTiempoAjuste.BackColor = Color.SeaShell;
            txtTiempoAjuste.Location = new Point(517, 260);
            txtTiempoAjuste.Margin = new Padding(2);
            txtTiempoAjuste.Name = "txtTiempoAjuste";
            txtTiempoAjuste.Size = new Size(180, 23);
            txtTiempoAjuste.TabIndex = 21;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.SeaShell;
            cmbEstado.Font = new Font("Copperplate Gothic Light", 12F);
            cmbEstado.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(88, 67);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(153, 25);
            cmbEstado.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Copperplate Gothic Light", 12F);
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(8, 70);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 23;
            label12.Text = "Estado:";
            // 
            // dgvVestido
            // 
            dgvVestido.BackgroundColor = Color.SeaShell;
            dgvVestido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVestido.Location = new Point(8, 369);
            dgvVestido.Margin = new Padding(2);
            dgvVestido.Name = "dgvVestido";
            dgvVestido.RowHeadersWidth = 62;
            dgvVestido.Size = new Size(699, 286);
            dgvVestido.TabIndex = 24;
            // 
            // FormVestidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(718, 666);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVestido);
            Controls.Add(label12);
            Controls.Add(cmbEstado);
            Controls.Add(txtTiempoAjuste);
            Controls.Add(txtDiseñador);
            Controls.Add(txtTalle);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtModelo);
            Controls.Add(txtPrecio);
            Controls.Add(txtColor);
            Controls.Add(txtTemporada);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "FormVestidos";
            Text = "VESTIDOS - ATELIER SARKANY";
            ((System.ComponentModel.ISupportInitialize)dgvVestido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtId;
        private TextBox txtTemporada;
        private TextBox txtColor;
        private TextBox txtPrecio;
        private TextBox txtModelo;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtTalle;
        private TextBox txtDiseñador;
        private TextBox txtTiempoAjuste;
        private ComboBox cmbEstado;
        private Label label12;
        private DataGridView dgvVestido;
    }
}