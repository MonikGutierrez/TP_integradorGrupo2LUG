namespace UI
{
    partial class FormStock
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Button btnAgregarStock;
            Button btnLimpiar;
            label1 = new Label();
            label2 = new Label();
            cmbTipoProducto = new ComboBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            dgvStock = new DataGridView();
            label4 = new Label();
            btnAgregarStock = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(11, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(11, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 2;
            label2.Text = "Descripcion:";
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.BackColor = Color.SeaShell;
            cmbTipoProducto.Font = new Font("Copperplate Gothic Light", 12F);
            cmbTipoProducto.ForeColor = Color.FromArgb(64, 0, 0);
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Location = new Point(141, 16);
            cmbTipoProducto.Margin = new Padding(2, 2, 2, 2);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(509, 25);
            cmbTipoProducto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.SeaShell;
            txtDescripcion.Font = new Font("Copperplate Gothic Light", 12F);
            txtDescripcion.ForeColor = Color.FromArgb(64, 0, 0);
            txtDescripcion.Location = new Point(141, 61);
            txtDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(509, 25);
            txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(11, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 5;
            label3.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(141, 107);
            txtCantidad.Margin = new Padding(2, 2, 2, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(129, 25);
            txtCantidad.TabIndex = 6;
            // 
            // dgvStock
            // 
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.ForeColor = Color.SeaShell;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStock.BackgroundColor = Color.SeaShell;
            dgvStock.BorderStyle = BorderStyle.Fixed3D;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(11, 235);
            dgvStock.Margin = new Padding(2, 2, 2, 2);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(640, 393);
            dgvStock.TabIndex = 9;
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
            btnAgregarStock.Location = new Point(69, 150);
            btnAgregarStock.Margin = new Padding(2, 2, 2, 2);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(201, 29);
            btnAgregarStock.TabIndex = 24;
            btnAgregarStock.Text = "AGREGAR";
            btnAgregarStock.UseVisualStyleBackColor = false;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Black;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(449, 150);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(201, 29);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "BORRAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(141, 144);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(410, 35);
            label4.TabIndex = 31;
            label4.Text = "ANULAR FORMULARIO";
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(662, 630);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregarStock);
            Controls.Add(dgvStock);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbTipoProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormStock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "STOCK - ATELIER SARKANY";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTipoProducto;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtCantidad;
        private DataGridView dgvStock;
        private Button btnAgregarStock;
        private Button btnLimpiar;
        private Label label4;
    }
}