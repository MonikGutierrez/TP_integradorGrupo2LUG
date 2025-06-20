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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Button btnConfirmarVenta;
            Button btnAgregarProducto;
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
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.Font = new Font("Copperplate Gothic Light", 12F);
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(128, 22);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(577, 25);
            cmbClientes.TabIndex = 0;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.SeaShell;
            cmbProductos.Font = new Font("Copperplate Gothic Light", 12F);
            cmbProductos.ForeColor = Color.FromArgb(64, 0, 0);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(128, 68);
            cmbProductos.Margin = new Padding(2);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(577, 25);
            cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(15, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 2;
            label1.Text = "Productos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(18, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 4;
            label3.Text = "Clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(18, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(128, 115);
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
            lblTotal.Location = new Point(128, 163);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 17);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "$.-";
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle4.BackColor = Color.SeaShell;
            dataGridViewCellStyle4.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalle.BackgroundColor = Color.SeaShell;
            dgvDetalle.BorderStyle = BorderStyle.Fixed3D;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(11, 254);
            dgvDetalle.Margin = new Padding(2);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(694, 401);
            dgvDetalle.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(45, 161);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 12;
            label4.Text = "Total: ";
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
            btnConfirmarVenta.Location = new Point(401, 188);
            btnConfirmarVenta.Margin = new Padding(2);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(185, 30);
            btnConfirmarVenta.TabIndex = 25;
            btnConfirmarVenta.Text = "CONFIRMAR VENTA";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
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
            btnAgregarProducto.Location = new Point(162, 188);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(199, 30);
            btnAgregarProducto.TabIndex = 29;
            btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(716, 666);
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
            Margin = new Padding(2);
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