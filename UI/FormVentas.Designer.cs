namespace UI
{
    partial class FormVentas
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
        private void InitializeComponent() {
            Button btnConfirmarVenta;
            Button btnAgregarProducto;
            Button btnEliminar;
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            cmbClientes = new ComboBox();
            cmbProductos = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            lblTotal = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            dgvVentas = new DataGridView();
            label8 = new Label();
            dgvCarrito = new DataGridView();
            cmbMetodoDePago = new ComboBox();
            btnConfirmarVenta = new Button();
            btnAgregarProducto = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmarVenta.BackColor = Color.RosyBrown;
            btnConfirmarVenta.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnConfirmarVenta.FlatAppearance.BorderSize = 3;
            btnConfirmarVenta.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnConfirmarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmarVenta.FlatStyle = FlatStyle.Popup;
            btnConfirmarVenta.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarVenta.ForeColor = SystemColors.ControlLightLight;
            btnConfirmarVenta.Location = new Point(1340, 355);
            btnConfirmarVenta.Margin = new Padding(2, 3, 2, 3);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(200, 40);
            btnConfirmarVenta.TabIndex = 25;
            btnConfirmarVenta.Text = "CONFIRMAR VENTA";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.BackColor = Color.Bisque;
            btnAgregarProducto.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnAgregarProducto.FlatAppearance.BorderSize = 3;
            btnAgregarProducto.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarProducto.FlatStyle = FlatStyle.Popup;
            btnAgregarProducto.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = Color.FromArgb(64, 0, 0);
            btnAgregarProducto.Location = new Point(685, 311);
            btnAgregarProducto.Margin = new Padding(2, 3, 2, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(276, 40);
            btnAgregarProducto.TabIndex = 29;
            btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
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
            btnEliminar.Location = new Point(1549, 52);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 53);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.Font = new Font("Copperplate Gothic Light", 12F);
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(146, 29);
            cmbClientes.Margin = new Padding(2, 3, 2, 3);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(774, 29);
            cmbClientes.TabIndex = 0;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.SeaShell;
            cmbProductos.Font = new Font("Copperplate Gothic Light", 12F);
            cmbProductos.ForeColor = Color.FromArgb(64, 0, 0);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(139, 36);
            cmbProductos.Margin = new Padding(2, 3, 2, 3);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(659, 29);
            cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(10, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 2;
            label1.Text = "Calzado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(21, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 4;
            label3.Text = "Cliente(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(542, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(651, 85);
            txtCantidad.Margin = new Padding(2, 3, 2, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(147, 29);
            txtCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Copperplate Gothic Light", 12F);
            lblTotal.ForeColor = Color.FromArgb(64, 0, 0);
            lblTotal.Location = new Point(1103, 323);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "$.-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(996, 321);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 12;
            label4.Text = "Total(*): ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Font = new Font("Copperplate Gothic Light", 12F);
            textBox1.ForeColor = Color.FromArgb(64, 0, 0);
            textBox1.Location = new Point(651, 179);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 29);
            textBox1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(542, 183);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 32;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(14, 140);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 31;
            label6.Text = "Vestido:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.SeaShell;
            comboBox1.Font = new Font("Copperplate Gothic Light", 12F);
            comboBox1.ForeColor = Color.FromArgb(64, 0, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 136);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(659, 29);
            comboBox1.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbProductos);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(18, 79);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(943, 224);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el producto a comprar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(14, 409);
            label7.Name = "label7";
            label7.Size = new Size(150, 16);
            label7.TabIndex = 70;
            label7.Text = "Listado de ventas";
            // 
            // dgvVentas
            // 
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.BackgroundColor = Color.SeaShell;
            dgvVentas.BorderStyle = BorderStyle.Fixed3D;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(16, 428);
            dgvVentas.Margin = new Padding(2, 3, 2, 3);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.Size = new Size(1676, 327);
            dgvVentas.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(996, 29);
            label8.Name = "label8";
            label8.Size = new Size(170, 16);
            label8.TabIndex = 72;
            label8.Text = "Carrito de compras";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.SeaShell;
            dataGridViewCellStyle4.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarrito.BackgroundColor = Color.SeaShell;
            dgvCarrito.BorderStyle = BorderStyle.Fixed3D;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCarrito.Location = new Point(996, 52);
            dgvCarrito.Margin = new Padding(2, 3, 2, 3);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(544, 251);
            dgvCarrito.TabIndex = 74;
            // 
            // cmbMetodoDePago
            // 
            cmbMetodoDePago.BackColor = Color.SeaShell;
            cmbMetodoDePago.Font = new Font("Copperplate Gothic Light", 12F);
            cmbMetodoDePago.ForeColor = Color.FromArgb(64, 0, 0);
            cmbMetodoDePago.FormattingEnabled = true;
            cmbMetodoDePago.Location = new Point(1306, 317);
            cmbMetodoDePago.Margin = new Padding(2, 3, 2, 3);
            cmbMetodoDePago.Name = "cmbMetodoDePago";
            cmbMetodoDePago.Size = new Size(234, 29);
            cmbMetodoDePago.TabIndex = 34;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1707, 766);
            Controls.Add(cmbMetodoDePago);
            Controls.Add(dgvCarrito);
            Controls.Add(label8);
            Controls.Add(dgvVentas);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(cmbClientes);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VENTAS - ATELIER SARKANY";
            Load += FormVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private ComboBox cmbProductos;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtCantidad;
        private Label lblTotal;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label7;
        private DataGridView dgvVentas;
        private Label label8;
        private DataGridView dgvCarrito;
        private ComboBox cmbMetodoDePago;
    }
}