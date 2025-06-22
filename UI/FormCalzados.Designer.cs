namespace UI
{
    partial class FormCalzados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Button btnLimpiarCalzado;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalzados));
            txtIdCalzado = new TextBox();
            txtStockMinimo = new TextBox();
            txtCategoria = new TextBox();
            txtNumero = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtTemporada = new TextBox();
            txtColor = new TextBox();
            txtModelo = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
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
            dgvCalzados = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnLimpiarCalzado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCalzados).BeginInit();
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
            btnEliminar.Location = new Point(479, 516);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(201, 29);
            btnEliminar.TabIndex = 26;
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
            btnModificar.Location = new Point(248, 516);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(201, 29);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.BackColor = Color.RosyBrown;
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(13, 515);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(201, 29);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIdCalzado
            // 
            txtIdCalzado.BackColor = Color.SeaShell;
            txtIdCalzado.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCalzado.ForeColor = Color.FromArgb(64, 0, 0);
            txtIdCalzado.Location = new Point(146, 11);
            txtIdCalzado.Margin = new Padding(2);
            txtIdCalzado.Name = "txtIdCalzado";
            txtIdCalzado.Size = new Size(121, 23);
            txtIdCalzado.TabIndex = 0;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.BackColor = Color.SeaShell;
            txtStockMinimo.Font = new Font("Bookman Old Style", 9.75F);
            txtStockMinimo.ForeColor = Color.FromArgb(64, 0, 0);
            txtStockMinimo.Location = new Point(147, 196);
            txtStockMinimo.Margin = new Padding(2);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(121, 23);
            txtStockMinimo.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.SeaShell;
            txtCategoria.Font = new Font("Bookman Old Style", 9.75F);
            txtCategoria.ForeColor = Color.FromArgb(64, 0, 0);
            txtCategoria.Location = new Point(544, 123);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(402, 23);
            txtCategoria.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.SeaShell;
            txtNumero.Font = new Font("Bookman Old Style", 9.75F);
            txtNumero.ForeColor = Color.FromArgb(64, 0, 0);
            txtNumero.Location = new Point(147, 46);
            txtNumero.Margin = new Padding(2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.SeaShell;
            txtStock.Font = new Font("Bookman Old Style", 9.75F);
            txtStock.ForeColor = Color.FromArgb(64, 0, 0);
            txtStock.Location = new Point(146, 161);
            txtStock.Margin = new Padding(2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.SeaShell;
            txtPrecio.Font = new Font("Bookman Old Style", 9.75F);
            txtPrecio.ForeColor = Color.FromArgb(64, 0, 0);
            txtPrecio.Location = new Point(147, 123);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtTemporada
            // 
            txtTemporada.BackColor = Color.SeaShell;
            txtTemporada.Font = new Font("Bookman Old Style", 9.75F);
            txtTemporada.ForeColor = Color.FromArgb(64, 0, 0);
            txtTemporada.Location = new Point(544, 161);
            txtTemporada.Margin = new Padding(2);
            txtTemporada.Name = "txtTemporada";
            txtTemporada.Size = new Size(402, 23);
            txtTemporada.TabIndex = 6;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.SeaShell;
            txtColor.Font = new Font("Bookman Old Style", 9.75F);
            txtColor.ForeColor = Color.FromArgb(64, 0, 0);
            txtColor.Location = new Point(147, 83);
            txtColor.Margin = new Padding(2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(121, 23);
            txtColor.TabIndex = 7;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.SeaShell;
            txtModelo.Font = new Font("Bookman Old Style", 9.75F);
            txtModelo.ForeColor = Color.FromArgb(64, 0, 0);
            txtModelo.Location = new Point(544, 86);
            txtModelo.Margin = new Padding(2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(402, 23);
            txtModelo.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.SeaShell;
            txtDescripcion.Font = new Font("Bookman Old Style", 9.75F);
            txtDescripcion.ForeColor = Color.FromArgb(64, 0, 0);
            txtDescripcion.Location = new Point(544, 48);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(402, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.SeaShell;
            txtNombre.Font = new Font("Bookman Old Style", 9.75F);
            txtNombre.ForeColor = Color.FromArgb(64, 0, 0);
            txtNombre.Location = new Point(544, 11);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(402, 23);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 11;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(461, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(422, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 13;
            label3.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(459, 88);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 14;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(432, 163);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 17);
            label5.TabIndex = 15;
            label5.Text = "Temporada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 124);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 16;
            label6.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 162);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 17;
            label7.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(64, 47);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 18;
            label8.Text = "Numero:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(438, 125);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(102, 17);
            label9.TabIndex = 19;
            label9.Text = "Categoria:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(77, 86);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 17);
            label10.TabIndex = 20;
            label10.Text = "Color:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 200);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(127, 17);
            label11.TabIndex = 21;
            label11.Text = "Stock Minino:";
            // 
            // dgvCalzados
            // 
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvCalzados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCalzados.BackgroundColor = Color.SeaShell;
            dgvCalzados.BorderStyle = BorderStyle.Fixed3D;
            dgvCalzados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalzados.Location = new Point(13, 249);
            dgvCalzados.Margin = new Padding(2);
            dgvCalzados.Name = "dgvCalzados";
            dgvCalzados.RowHeadersWidth = 62;
            dgvCalzados.Size = new Size(935, 262);
            dgvCalzados.TabIndex = 22;
            dgvCalzados.Click += dgvCalzados_SelectionChanged;
            // 
            // btnLimpiarCalzado
            // 
            btnLimpiarCalzado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarCalzado.BackColor = Color.SeaShell;
            btnLimpiarCalzado.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiarCalzado.FlatAppearance.BorderSize = 3;
            btnLimpiarCalzado.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiarCalzado.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCalzado.FlatStyle = FlatStyle.Popup;
            btnLimpiarCalzado.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCalzado.ForeColor = Color.FromArgb(64, 0, 0);
            btnLimpiarCalzado.Location = new Point(724, 516);
            btnLimpiarCalzado.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCalzado.Name = "btnLimpiarCalzado";
            btnLimpiarCalzado.Size = new Size(152, 32);
            btnLimpiarCalzado.TabIndex = 31;
            btnLimpiarCalzado.Text = "LIMPIAR";
            btnLimpiarCalzado.UseVisualStyleBackColor = false;
            btnLimpiarCalzado.Click += btnLimpiarCalzado_Click;
            // 
            // FormCalzados
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(975, 569);
            Controls.Add(btnLimpiarCalzado);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCalzados);
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
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtModelo);
            Controls.Add(txtColor);
            Controls.Add(txtTemporada);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtNumero);
            Controls.Add(txtCategoria);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtIdCalzado);
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 0, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormCalzados";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CALZADOS - ATELIER SARKANY";
            Load += FormCalzados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalzados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCalzado;
        private TextBox txtStockMinimo;
        private TextBox txtCategoria;
        private TextBox txtNumero;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtTemporada;
        private TextBox txtColor;
        private TextBox txtModelo;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
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
        private DataGridView dgvCalzados;
    }
}