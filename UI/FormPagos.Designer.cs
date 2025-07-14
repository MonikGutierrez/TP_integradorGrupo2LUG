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
            Button btnEliminar;
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            dtpFechaPago = new DateTimePicker();
            label4 = new Label();
            txtMonto = new TextBox();
            dgvPagos = new DataGridView();
            cmbMedioPago = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            lblVentaId = new Label();
            label6 = new Label();
            txtCliente = new TextBox();
            lblId = new Label();
            label2 = new Label();
            btnConfirmarPago = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            btnConfirmarPago.Location = new Point(273, 247);
            btnConfirmarPago.Margin = new Padding(2);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(141, 32);
            btnConfirmarPago.TabIndex = 25;
            btnConfirmarPago.Text = "CONFIRMAR";
            btnConfirmarPago.UseVisualStyleBackColor = false;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
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
            btnEliminar.Location = new Point(429, 247);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 32);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminarPago_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(86, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 18);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(9, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 18);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Pago(*):";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.CalendarFont = new Font("Bookman Old Style", 9F);
            dtpFechaPago.CalendarMonthBackground = Color.SeaShell;
            dtpFechaPago.Font = new Font("Bookman Old Style", 9F);
            dtpFechaPago.Location = new Point(171, 100);
            dtpFechaPago.Margin = new Padding(2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(265, 22);
            dtpFechaPago.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(29, 212);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 18);
            label4.TabIndex = 6;
            label4.Text = "Monto total(*):";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.SeaShell;
            txtMonto.Font = new Font("Bookman Old Style", 9F);
            txtMonto.ForeColor = Color.FromArgb(64, 0, 0);
            txtMonto.Location = new Point(171, 211);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(265, 22);
            txtMonto.TabIndex = 7;
            // 
            // dgvPagos
            // 
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPagos.BackgroundColor = Color.SeaShell;
            dgvPagos.BorderStyle = BorderStyle.Fixed3D;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(12, 340);
            dgvPagos.Margin = new Padding(2);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 62;
            dgvPagos.Size = new Size(817, 259);
            dgvPagos.TabIndex = 9;
            dgvPagos.SelectionChanged += dgvPagos_SelectionChanged;
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.BackColor = Color.SeaShell;
            cmbMedioPago.Font = new Font("Bookman Old Style", 9F);
            cmbMedioPago.ForeColor = Color.FromArgb(64, 0, 0);
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(171, 159);
            cmbMedioPago.Margin = new Padding(2);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(265, 24);
            cmbMedioPago.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(11, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 18);
            label5.TabIndex = 26;
            label5.Text = "Forma de pago(*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(12, 325);
            label8.Name = "label8";
            label8.Size = new Size(113, 12);
            label8.TabIndex = 35;
            label8.Text = "Listado de pagos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblVentaId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbMedioPago);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnConfirmarPago);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFechaPago);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(818, 300);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestionar Pagos";
            // 
            // lblVentaId
            // 
            lblVentaId.AutoSize = true;
            lblVentaId.BackColor = SystemColors.ScrollBar;
            lblVentaId.Font = new Font("Copperplate Gothic Bold", 12F);
            lblVentaId.ForeColor = Color.FromArgb(64, 0, 0);
            lblVentaId.Location = new Point(174, 20);
            lblVentaId.Name = "lblVentaId";
            lblVentaId.Size = new Size(0, 18);
            lblVentaId.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ScrollBar;
            label6.Font = new Font("Copperplate Gothic Bold", 12F);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(546, 22);
            label6.Name = "label6";
            label6.Size = new Size(33, 18);
            label6.TabIndex = 39;
            label6.Text = "Id: ";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.SeaShell;
            txtCliente.Font = new Font("Bookman Old Style", 9F);
            txtCliente.ForeColor = Color.FromArgb(64, 0, 0);
            txtCliente.Location = new Point(171, 52);
            txtCliente.Margin = new Padding(2);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(634, 22);
            txtCliente.TabIndex = 38;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.ScrollBar;
            lblId.Font = new Font("Copperplate Gothic Bold", 12F);
            lblId.ForeColor = Color.FromArgb(64, 0, 0);
            lblId.Location = new Point(579, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Copperplate Gothic Bold", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(80, 23);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 35;
            label2.Text = "Venta Id: ";
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(848, 619);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(dgvPagos);
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 0, 0);
            Margin = new Padding(2);
            Name = "FormPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGOS - ATELIER SARKANY";
            Load += FormPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dtpFechaPago;
        private Label label4;
        private TextBox txtMonto;
        private DataGridView dgvPagos;
        private ComboBox cmbMedioPago;
        private Label label5;
        private Label label8;
        private GroupBox groupBox1;
        private Label label2;
        private Label lblId;
        private TextBox txtCliente;
        private Label lblVentaId;
        private Label label6;
    }
}
