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
            cmbClientes = new ComboBox();
            cmbProductos = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            lblTotal = new Label();
            btnAgregarProducto = new Button();
            btnConfirmarVenta = new Button();
            dgvDetalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(151, 12);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(182, 33);
            cmbClientes.TabIndex = 0;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(151, 70);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(182, 33);
            cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Location = new Point(42, 78);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleTurquoise;
            label3.Location = new Point(42, 20);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 4;
            label3.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Location = new Point(42, 142);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 5;
            label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(151, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(182, 31);
            txtCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.PaleTurquoise;
            lblTotal.Location = new Point(202, 202);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 25);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total: ";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = SystemColors.InactiveCaption;
            btnAgregarProducto.Location = new Point(42, 259);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(170, 34);
            btnAgregarProducto.TabIndex = 9;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.BackColor = SystemColors.InactiveCaption;
            btnConfirmarVenta.Location = new Point(249, 259);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(163, 34);
            btnConfirmarVenta.TabIndex = 10;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(42, 325);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(583, 225);
            dgvDetalle.TabIndex = 11;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 585);
            Controls.Add(dgvDetalle);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblTotal);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbProductos);
            Controls.Add(cmbClientes);
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
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
        private Button btnAgregarProducto;
        private Button btnConfirmarVenta;
        private DataGridView dgvDetalle;
    }
}