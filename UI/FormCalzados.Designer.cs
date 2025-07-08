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
            Button btnLimpiarCalzado;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalzados));
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
            dtpUltimoAjuste = new DateTimePicker();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnLimpiarCalzado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCalzados).BeginInit();
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
            btnEliminar.Location = new Point(530, 257);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 40);
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
            btnModificar.Location = new Point(382, 257);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 40);
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
            btnAgregar.Location = new Point(236, 257);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 40);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
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
            btnLimpiarCalzado.Location = new Point(680, 257);
            btnLimpiarCalzado.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCalzado.Name = "btnLimpiarCalzado";
            btnLimpiarCalzado.Size = new Size(133, 40);
            btnLimpiarCalzado.TabIndex = 31;
            btnLimpiarCalzado.Text = "LIMPIAR";
            btnLimpiarCalzado.UseVisualStyleBackColor = false;
            btnLimpiarCalzado.Click += btnLimpiarCalzado_Click;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.BackColor = Color.SeaShell;
            txtStockMinimo.Font = new Font("Bookman Old Style", 9.75F);
            txtStockMinimo.ForeColor = Color.FromArgb(64, 0, 0);
            txtStockMinimo.Location = new Point(837, 95);
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
            txtCategoria.Location = new Point(152, 134);
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
            txtNumero.Location = new Point(837, 22);
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
            txtStock.Location = new Point(837, 137);
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
            txtPrecio.Location = new Point(837, 61);
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
            txtTemporada.Location = new Point(152, 172);
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
            txtColor.Location = new Point(152, 216);
            txtColor.Margin = new Padding(2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(402, 23);
            txtColor.TabIndex = 7;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.SeaShell;
            txtModelo.Font = new Font("Bookman Old Style", 9.75F);
            txtModelo.ForeColor = Color.FromArgb(64, 0, 0);
            txtModelo.Location = new Point(152, 97);
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
            txtDescripcion.Location = new Point(152, 59);
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
            txtNombre.Location = new Point(152, 22);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(402, 23);
            txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(7, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(6, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 18);
            label3.TabIndex = 13;
            label3.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(5, 100);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 14;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(5, 175);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 15;
            label5.Text = "Temporada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F);
            label6.Location = new Point(727, 62);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 16;
            label6.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(734, 138);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 18);
            label7.TabIndex = 17;
            label7.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Bold", 12F);
            label8.Location = new Point(720, 23);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 18);
            label8.TabIndex = 18;
            label8.Text = "Numero:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Copperplate Gothic Bold", 12F);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(6, 137);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 18);
            label9.TabIndex = 19;
            label9.Text = "Categoria:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Copperplate Gothic Bold", 12F);
            label10.Location = new Point(7, 219);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 18);
            label10.TabIndex = 20;
            label10.Text = "Color:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Copperplate Gothic Bold", 12F);
            label11.Location = new Point(668, 97);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(132, 18);
            label11.TabIndex = 21;
            label11.Text = "Stock Minimo:";
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
            dgvCalzados.Location = new Point(8, 368);
            dgvCalzados.Margin = new Padding(2);
            dgvCalzados.Name = "dgvCalzados";
            dgvCalzados.RowHeadersWidth = 62;
            dgvCalzados.Size = new Size(968, 262);
            dgvCalzados.TabIndex = 22;
            dgvCalzados.Click += dgvCalzados_SelectionChanged;
            // 
            // dtpUltimoAjuste
            // 
            dtpUltimoAjuste.CalendarForeColor = Color.FromArgb(64, 0, 0);
            dtpUltimoAjuste.CalendarTitleForeColor = Color.FromArgb(64, 0, 0);
            dtpUltimoAjuste.Font = new Font("Bookman Old Style", 9F);
            dtpUltimoAjuste.Location = new Point(663, 175);
            dtpUltimoAjuste.Margin = new Padding(2);
            dtpUltimoAjuste.Name = "dtpUltimoAjuste";
            dtpUltimoAjuste.Size = new Size(295, 22);
            dtpUltimoAjuste.TabIndex = 65;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(dtpUltimoAjuste);
            groupBox1.Controls.Add(btnLimpiarCalzado);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtTemporada);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtStockMinimo);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(8, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 313);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "GESTION CALZADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(11, 354);
            label1.Name = "label1";
            label1.Size = new Size(127, 12);
            label1.TabIndex = 68;
            label1.Text = "Listado de calzado";
            // 
            // FormCalzados
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(996, 641);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvCalzados);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DateTimePicker dtpUltimoAjuste;
        private GroupBox groupBox1;
        private Label label1;
    }
}