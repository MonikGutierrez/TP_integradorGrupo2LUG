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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cmbClientes = new ComboBox();
            cmbProductos = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            label4 = new Label();
            btnConfirmarVenta = new Button();
            btnAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
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
            btnConfirmarVenta.Location = new Point(573, 313);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(264, 50);
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
            btnAgregarProducto.Location = new Point(231, 313);
            btnAgregarProducto.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(284, 50);
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
            cmbClientes.Location = new Point(183, 37);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(823, 34);
            cmbClientes.TabIndex = 0;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.SeaShell;
            cmbProductos.Font = new Font("Copperplate Gothic Light", 12F);
            cmbProductos.ForeColor = Color.FromArgb(64, 0, 0);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(183, 113);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(823, 34);
            cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(21, 118);
            label1.Name = "label1";
            label1.Size = new Size(164, 26);
            label1.TabIndex = 2;
            label1.Text = "Productos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(26, 42);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 4;
            label3.Text = "Clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(26, 193);
            label2.Name = "label2";
            label2.Size = new Size(137, 26);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(183, 192);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(183, 34);
            txtCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Copperplate Gothic Light", 12F);
            lblTotal.ForeColor = Color.FromArgb(64, 0, 0);
            lblTotal.Location = new Point(183, 272);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 26);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "$.-";
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalle.BackgroundColor = Color.SeaShell;
            dgvDetalle.BorderStyle = BorderStyle.Fixed3D;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(16, 423);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(991, 668);
            dgvDetalle.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(64, 268);
            label4.Name = "label4";
            label4.Size = new Size(100, 26);
            label4.TabIndex = 12;
            label4.Text = "Total: ";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1023, 1050);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(label4);
            Controls.Add(dgvDetalle);
            Controls.Add(lblTotal);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbProductos);
            Controls.Add(cmbClientes);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VENTAS - ATELIER SARKANY";
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
        private DataGridView dgvDetalle;
        private Label label4;
    }
}