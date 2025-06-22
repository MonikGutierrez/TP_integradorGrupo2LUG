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
           // Button btnAgregarStock;
           // Button btnLimpiar;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cmbTipoProducto = new ComboBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            dgvStock = new DataGridView();
            btnAgregarStock = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
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
            btnAgregarStock.Location = new Point(99, 250);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(287, 48);
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
            btnLimpiar.Location = new Point(641, 250);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(287, 48);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "BORRAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(149, 26);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(16, 103);
            label2.Name = "label2";
            label2.Size = new Size(178, 26);
            label2.TabIndex = 2;
            label2.Text = "Descripcion:";
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.BackColor = Color.SeaShell;
            cmbTipoProducto.Font = new Font("Copperplate Gothic Light", 12F);
            cmbTipoProducto.ForeColor = Color.FromArgb(64, 0, 0);
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Location = new Point(201, 27);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(725, 34);
            cmbTipoProducto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.SeaShell;
            txtDescripcion.Font = new Font("Copperplate Gothic Light", 12F);
            txtDescripcion.ForeColor = Color.FromArgb(64, 0, 0);
            txtDescripcion.Location = new Point(201, 102);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(725, 34);
            txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(16, 187);
            label3.Name = "label3";
            label3.Size = new Size(137, 26);
            label3.TabIndex = 5;
            label3.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.SeaShell;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.FromArgb(64, 0, 0);
            txtCantidad.Location = new Point(201, 178);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(183, 34);
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
            dgvStock.Location = new Point(16, 392);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(914, 655);
            dgvStock.TabIndex = 9;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(946, 1050);
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

    }
}