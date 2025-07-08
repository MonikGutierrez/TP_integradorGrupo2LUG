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
            Button btnModificar;
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            cmbClientes = new ComboBox();
            label2 = new Label();
            cmbReservas = new ComboBox();
            label3 = new Label();
            dtpFechaPago = new DateTimePicker();
            label4 = new Label();
            txtMonto = new TextBox();
            dgvPagos = new DataGridView();
            cmbMedioPago = new ComboBox();
            label5 = new Label();
            cmbTipoPago = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnConfirmarPago = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
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
            btnConfirmarPago.Location = new Point(233, 287);
            btnConfirmarPago.Margin = new Padding(2);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(126, 26);
            btnConfirmarPago.TabIndex = 25;
            btnConfirmarPago.Text = "CONFIRMAR";
            btnConfirmarPago.UseVisualStyleBackColor = false;
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
            btnEliminar.Location = new Point(518, 287);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 26);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.BackColor = Color.Bisque;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnModificar.FlatAppearance.BorderSize = 3;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.FromArgb(64, 0, 0);
            btnModificar.Location = new Point(376, 287);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 26);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(9, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 18);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(171, 24);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(806, 24);
            cmbClientes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(9, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 2;
            label2.Text = "Reserva:";
            // 
            // cmbReservas
            // 
            cmbReservas.BackColor = Color.SeaShell;
            cmbReservas.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReservas.ForeColor = Color.FromArgb(64, 0, 0);
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(171, 62);
            cmbReservas.Margin = new Padding(2);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(806, 24);
            cmbReservas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(9, 109);
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
            dtpFechaPago.Location = new Point(171, 106);
            dtpFechaPago.Margin = new Padding(2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(806, 22);
            dtpFechaPago.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(11, 205);
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
            txtMonto.Location = new Point(171, 201);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 22);
            txtMonto.TabIndex = 7;
            // 
            // dgvPagos
            // 
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPagos.BackgroundColor = Color.SeaShell;
            dgvPagos.BorderStyle = BorderStyle.Fixed3D;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(14, 358);
            dgvPagos.Margin = new Padding(2);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 62;
            dgvPagos.Size = new Size(983, 281);
            dgvPagos.TabIndex = 9;
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.BackColor = Color.SeaShell;
            cmbMedioPago.Font = new Font("Bookman Old Style", 9F);
            cmbMedioPago.ForeColor = Color.FromArgb(64, 0, 0);
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(171, 153);
            cmbMedioPago.Margin = new Padding(2);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(806, 24);
            cmbMedioPago.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(11, 155);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 18);
            label5.TabIndex = 26;
            label5.Text = "Forma de pago(*):";
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.BackColor = Color.SeaShell;
            cmbTipoPago.Font = new Font("Bookman Old Style", 9F);
            cmbTipoPago.ForeColor = Color.FromArgb(64, 0, 0);
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(880, 240);
            cmbTipoPago.Margin = new Padding(2);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(60, 24);
            cmbTipoPago.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(834, 287);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 28;
            label6.Text = "Tipo de pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(17, 344);
            label8.Name = "label8";
            label8.Size = new Size(113, 12);
            label8.TabIndex = 35;
            label8.Text = "Listado de pagos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(cmbTipoPago);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbMedioPago);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnConfirmarPago);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFechaPago);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbReservas);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbClientes);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 323);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestionar Pagos";
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1007, 647);
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
        private ComboBox cmbClientes;
        private Label label2;
        private ComboBox cmbReservas;
        private Label label3;
        private DateTimePicker dtpFechaPago;
        private Label label4;
        private TextBox txtMonto;
        private DataGridView dgvPagos;
        private ComboBox cmbMedioPago;
        private Label label5;
        private ComboBox cmbTipoPago;
        private Label label6;
        private Label label8;
        private GroupBox groupBox1;
    }
}
