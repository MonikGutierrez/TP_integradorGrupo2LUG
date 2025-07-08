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
        private void InitializeComponent()
        {
            Button btnConfirmarVenta;
            Button btnAgregarProducto;
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Button btnLimpiarVestidos;
            Button btnEliminar;
            Button btnAgregarStock;
            Button button1;
            cmbClientes = new ComboBox();
            cmbProductos = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            lblMostrarTotal = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnConfirmarVenta = new Button();
            btnAgregarProducto = new Button();
            btnLimpiarVestidos = new Button();
            btnEliminar = new Button();
            btnAgregarStock = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            groupBox1.SuspendLayout();
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
            btnConfirmarVenta.Location = new Point(16, 303);
            btnConfirmarVenta.Margin = new Padding(2);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(175, 30);
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
            btnAgregarProducto.Location = new Point(14, 266);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(181, 30);
            btnAgregarProducto.TabIndex = 29;
            btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.Font = new Font("Copperplate Gothic Light", 12F);
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(128, 22);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(678, 25);
            cmbClientes.TabIndex = 0;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.SeaShell;
            cmbProductos.Font = new Font("Copperplate Gothic Light", 12F);
            cmbProductos.ForeColor = Color.FromArgb(64, 0, 0);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(122, 27);
            cmbProductos.Margin = new Padding(2);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(577, 25);
            cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(9, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 2;
            label1.Text = "Calzado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(18, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 4;
            label3.Text = "Cliente(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(474, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(570, 64);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(129, 25);
            txtCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Copperplate Gothic Light", 12F);
            lblTotal.ForeColor = Color.FromArgb(64, 0, 0);
            lblTotal.Location = new Point(112, 239);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 17);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "$.-";
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalle.BackgroundColor = Color.SeaShell;
            dgvDetalle.BorderStyle = BorderStyle.Fixed3D;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(11, 370);
            dgvDetalle.Margin = new Padding(2);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(841, 249);
            dgvDetalle.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(18, 238);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 12;
            label4.Text = "Total(*): ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Font = new Font("Copperplate Gothic Light", 12F);
            textBox1.ForeColor = Color.FromArgb(64, 0, 0);
            textBox1.Location = new Point(570, 134);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 25);
            textBox1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(474, 137);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 32;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(12, 105);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 18);
            label6.TabIndex = 31;
            label6.Text = "Vestido:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.SeaShell;
            comboBox1.Font = new Font("Copperplate Gothic Light", 12F);
            comboBox1.ForeColor = Color.FromArgb(64, 0, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(122, 102);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(577, 25);
            comboBox1.TabIndex = 30;
            // 
            // lblMostrarTotal
            // 
            lblMostrarTotal.AutoSize = true;
            lblMostrarTotal.Font = new Font("Copperplate Gothic Light", 12F);
            lblMostrarTotal.ForeColor = Color.FromArgb(64, 0, 0);
            lblMostrarTotal.Location = new Point(143, 241);
            lblMostrarTotal.Margin = new Padding(2, 0, 2, 0);
            lblMostrarTotal.Name = "lblMostrarTotal";
            lblMostrarTotal.Size = new Size(38, 17);
            lblMostrarTotal.TabIndex = 34;
            lblMostrarTotal.Text = "----------";
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
            groupBox1.Location = new Point(16, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 168);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el producto a comprar";
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
            btnLimpiarVestidos.Location = new Point(708, 252);
            btnLimpiarVestidos.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarVestidos.Name = "btnLimpiarVestidos";
            btnLimpiarVestidos.Size = new Size(133, 40);
            btnLimpiarVestidos.TabIndex = 67;
            btnLimpiarVestidos.Text = "LIMPIAR";
            btnLimpiarVestidos.UseVisualStyleBackColor = false;
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
            btnEliminar.Location = new Point(708, 303);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 40);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarStock.BackColor = Color.RosyBrown;
            btnAgregarStock.FlatAppearance.BorderColor = Color.White;
            btnAgregarStock.FlatAppearance.BorderSize = 3;
            btnAgregarStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnAgregarStock.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnAgregarStock.FlatStyle = FlatStyle.Popup;
            btnAgregarStock.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarStock.ForeColor = SystemColors.ControlLightLight;
            btnAgregarStock.Location = new Point(570, 252);
            btnAgregarStock.Margin = new Padding(2);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(133, 40);
            btnAgregarStock.TabIndex = 68;
            btnAgregarStock.Text = "AGREGAR";
            btnAgregarStock.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Bisque;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(570, 303);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 69;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(12, 356);
            label7.Name = "label7";
            label7.Size = new Size(118, 12);
            label7.TabIndex = 70;
            label7.Text = "Listado de ventas";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(873, 630);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnLimpiarVestidos);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox1);
            Controls.Add(lblMostrarTotal);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(label4);
            Controls.Add(dgvDetalle);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(cmbClientes);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VENTAS - ATELIER SARKANY";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dgvDetalle;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label lblMostrarTotal;
        private GroupBox groupBox1;
        private Label label7;
    }
}