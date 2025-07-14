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
            Button btnLimpiar;
            Button btnEliminar;
            Button btnAgregar;
            Button btnCobrar;
            Button btnAgregarCliente;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmbClientes = new ComboBox();
            label3 = new Label();
            dgvVentas = new DataGridView();
            lblMostrarTotal = new Label();
            groupBox1 = new GroupBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbProducto = new ComboBox();
            label4 = new Label();
            lblTotal = new Label();
            label7 = new Label();
            dgvCarrito = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            lblId = new Label();
            groupBox2 = new GroupBox();
            btnConfirmarVenta = new Button();
            btnAgregarProducto = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnCobrar = new Button();
            btnAgregarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            groupBox2.SuspendLayout();
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
            btnConfirmarVenta.Location = new Point(16, 286);
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
            btnAgregarProducto.Location = new Point(14, 241);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(177, 30);
            btnAgregarProducto.TabIndex = 29;
            btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.SeaShell;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(64, 0, 0);
            btnLimpiar.Location = new Point(316, 19);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 40);
            btnLimpiar.TabIndex = 67;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            btnEliminar.Location = new Point(163, 19);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 40);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnAgregar.Location = new Point(12, 19);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 40);
            btnAgregar.TabIndex = 68;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCobrar.BackColor = Color.Bisque;
            btnCobrar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnCobrar.FlatAppearance.BorderSize = 3;
            btnCobrar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCobrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = Color.FromArgb(64, 0, 0);
            btnCobrar.Location = new Point(617, 19);
            btnCobrar.Margin = new Padding(3, 2, 3, 2);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(206, 40);
            btnCobrar.TabIndex = 73;
            btnCobrar.Text = "COBRAR PRODUCTO";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarCliente.BackColor = Color.SeaShell;
            btnAgregarCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnAgregarCliente.FlatAppearance.BorderSize = 3;
            btnAgregarCliente.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAgregarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarCliente.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCliente.ForeColor = Color.FromArgb(64, 0, 0);
            btnAgregarCliente.Location = new Point(14, 197);
            btnAgregarCliente.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(177, 30);
            btnAgregarCliente.TabIndex = 76;
            btnAgregarCliente.Text = "AGREGAR CLIENTE";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.Font = new Font("Copperplate Gothic Light", 12F);
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(146, 29);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(691, 25);
            cmbClientes.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(23, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 4;
            label3.Text = "Cliente:";
            // 
            // dgvVentas
            // 
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.BackgroundColor = Color.SeaShell;
            dgvVentas.BorderStyle = BorderStyle.Fixed3D;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(11, 356);
            dgvVentas.Margin = new Padding(2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.Size = new Size(841, 249);
            dgvVentas.TabIndex = 11;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            // 
            // lblMostrarTotal
            // 
            lblMostrarTotal.AutoSize = true;
            lblMostrarTotal.Font = new Font("Copperplate Gothic Light", 12F);
            lblMostrarTotal.ForeColor = Color.FromArgb(64, 0, 0);
            lblMostrarTotal.Location = new Point(666, 75);
            lblMostrarTotal.Margin = new Padding(2, 0, 2, 0);
            lblMostrarTotal.Name = "lblMostrarTotal";
            lblMostrarTotal.Size = new Size(20, 17);
            lblMostrarTotal.TabIndex = 34;
            lblMostrarTotal.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblMostrarTotal);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(14, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(838, 114);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el producto a comprar";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(131, 71);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(129, 25);
            txtCantidad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(30, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(9, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 2;
            label1.Text = "Producto(*):";
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.SeaShell;
            cmbProducto.Font = new Font("Copperplate Gothic Light", 12F);
            cmbProducto.ForeColor = Color.FromArgb(64, 0, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(132, 27);
            cmbProducto.Margin = new Padding(2);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(688, 25);
            cmbProducto.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(548, 74);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 12;
            label4.Text = "Total(*): ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Copperplate Gothic Light", 12F);
            lblTotal.ForeColor = Color.FromArgb(64, 0, 0);
            lblTotal.Location = new Point(637, 75);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 17);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "$.-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(118, 12);
            label7.TabIndex = 70;
            label7.Text = "Listado de ventas";
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.BackgroundColor = Color.SeaShell;
            dgvCarrito.BorderStyle = BorderStyle.Fixed3D;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(213, 212);
            dgvCarrito.Margin = new Padding(2);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(639, 115);
            dgvCarrito.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(213, 197);
            label5.Name = "label5";
            label5.Size = new Size(76, 12);
            label5.TabIndex = 72;
            label5.Text = "A comprar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(23, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 18);
            label6.TabIndex = 74;
            label6.Text = "Id:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(64, 0, 0);
            lblId.Location = new Point(56, 9);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 75;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnCobrar);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(12, 615);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(838, 69);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Venta unitaria";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(863, 698);
            Controls.Add(btnAgregarCliente);
            Controls.Add(groupBox2);
            Controls.Add(lblId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvCarrito);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(dgvVentas);
            Controls.Add(label3);
            Controls.Add(cmbClientes);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VENTAS - ATELIER SARKANY";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Label label3;
        private DataGridView dgvVentas;
        private Label lblMostrarTotal;
        private GroupBox groupBox1;
        private Label label7;
        private DataGridView dgvCarrito;
        private Label label5;
        private Label label6;
        private Label lblId;
        private TextBox txtCantidad;
        private Label label2;
        private Label label1;
        private ComboBox cmbProducto;
        private Label label4;
        private Label lblTotal;
        private GroupBox groupBox2;
    }
}