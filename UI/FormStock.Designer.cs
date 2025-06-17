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
            label1 = new Label();
            label2 = new Label();
            cmbTipoProducto = new ComboBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            btnAgregarStock = new Button();
            btnLimpiar = new Button();
            dgvStock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Location = new Point(168, 26);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(182, 33);
            cmbTipoProducto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(168, 74);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(182, 31);
            txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 128);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(168, 125);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(182, 31);
            txtCantidad.TabIndex = 6;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(34, 173);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(148, 34);
            btnAgregarStock.TabIndex = 7;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(249, 173);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 34);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar Stock";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(65, 213);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(360, 225);
            dgvStock.TabIndex = 9;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStock);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregarStock);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbTipoProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormStock";
            Text = "FormStock";
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
        private Button btnAgregarStock;
        private Button btnLimpiar;
        private DataGridView dgvStock;
    }
}