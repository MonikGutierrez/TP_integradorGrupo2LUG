namespace UI
{
    partial class FormPagos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            cmbClientes = new ComboBox();
            label2 = new Label();
            cmbReservas = new ComboBox();
            label3 = new Label();
            dtpFechaPago = new DateTimePicker();
            label4 = new Label();
            txtMonto = new TextBox();
            btnConfirmarPago = new Button();
            dgvPagos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente";

            // cmbClientes
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(150, 20);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(200, 33);
            cmbClientes.TabIndex = 1;

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Reserva";

            // cmbReservas
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(150, 70);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(200, 33);
            cmbReservas.TabIndex = 3;

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Pago";

            // dtpFechaPago
            dtpFechaPago.Location = new Point(150, 120);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(300, 31);
            dtpFechaPago.TabIndex = 5;

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(20, 170);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "Monto";

            // txtMonto
            txtMonto.Location = new Point(150, 170);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 31);
            txtMonto.TabIndex = 7;

            // btnConfirmarPago
            btnConfirmarPago.Location = new Point(150, 220);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(150, 35);
            btnConfirmarPago.TabIndex = 8;
            btnConfirmarPago.Text = "Confirmar Pago";
            btnConfirmarPago.UseVisualStyleBackColor = true;
            btnConfirmarPago.Click += btnConfirmarPago_Click;

            // dgvPagos
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(20, 280);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 62;
            dgvPagos.Size = new Size(600, 200);
            dgvPagos.TabIndex = 9;

            // FormPagos
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 500);
            Controls.Add(dgvPagos);
            Controls.Add(btnConfirmarPago);
            Controls.Add(txtMonto);
            Controls.Add(label4);
            Controls.Add(dtpFechaPago);
            Controls.Add(label3);
            Controls.Add(cmbReservas);
            Controls.Add(label2);
            Controls.Add(cmbClientes);
            Controls.Add(label1);
            Name = "FormPagos";
            Text = "Gestión de Pagos";
            Load += FormPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbClientes;
        private Label label2;
        private ComboBox cmbReservas;
        private Label label3;
        private DateTimePicker dtpFechaPago;
        private Label label4;
        private TextBox txtMonto;
        private Button btnConfirmarPago;
        private DataGridView dgvPagos;
    }
}
