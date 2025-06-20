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
            Button btnConfirmarPago;
            label1 = new Label();
            cmbClientes = new ComboBox();
            label2 = new Label();
            cmbReservas = new ComboBox();
            label3 = new Label();
            dtpFechaPago = new DateTimePicker();
            label4 = new Label();
            txtMonto = new TextBox();
            dgvPagos = new DataGridView();
            btnConfirmarPago = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(16, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(178, 10);
            cmbClientes.Margin = new Padding(2, 2, 2, 2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(484, 20);
            cmbClientes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(16, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 2;
            label2.Text = "Reserva:";
            // 
            // cmbReservas
            // 
            cmbReservas.BackColor = Color.SeaShell;
            cmbReservas.ForeColor = Color.FromArgb(64, 0, 0);
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(178, 40);
            cmbReservas.Margin = new Padding(2, 2, 2, 2);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(484, 20);
            cmbReservas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(16, 78);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 17);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Pago:";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.CalendarMonthBackground = Color.SeaShell;
            dtpFechaPago.Location = new Point(178, 75);
            dtpFechaPago.Margin = new Padding(2, 2, 2, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(484, 21);
            dtpFechaPago.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(16, 117);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 6;
            label4.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.SeaShell;
            txtMonto.ForeColor = Color.FromArgb(64, 0, 0);
            txtMonto.Location = new Point(178, 117);
            txtMonto.Margin = new Padding(2, 2, 2, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 21);
            txtMonto.TabIndex = 7;
            // 
            // dgvPagos
            // 
            dgvPagos.BackgroundColor = Color.SeaShell;
            dgvPagos.BorderStyle = BorderStyle.Fixed3D;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(16, 226);
            dgvPagos.Margin = new Padding(2, 2, 2, 2);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 62;
            dgvPagos.Size = new Size(646, 257);
            dgvPagos.TabIndex = 9;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmarPago.BackColor = Color.RosyBrown;
            btnConfirmarPago.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnConfirmarPago.FlatAppearance.BorderSize = 3;
            btnConfirmarPago.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnConfirmarPago.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmarPago.FlatStyle = FlatStyle.Popup;
            btnConfirmarPago.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarPago.ForeColor = SystemColors.ControlLightLight;
            btnConfirmarPago.Location = new Point(222, 153);
            btnConfirmarPago.Margin = new Padding(2);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(185, 30);
            btnConfirmarPago.TabIndex = 25;
            btnConfirmarPago.Text = "CONFIRMAR";
            btnConfirmarPago.UseVisualStyleBackColor = false;
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(687, 501);
            Controls.Add(btnConfirmarPago);
            Controls.Add(dgvPagos);
            Controls.Add(txtMonto);
            Controls.Add(label4);
            Controls.Add(dtpFechaPago);
            Controls.Add(label3);
            Controls.Add(cmbReservas);
            Controls.Add(label2);
            Controls.Add(cmbClientes);
            Controls.Add(label1);
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 0, 0);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormPagos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTION PAGOS - ATELIER SARKANY";
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
        private DataGridView dgvPagos;
    }
}
