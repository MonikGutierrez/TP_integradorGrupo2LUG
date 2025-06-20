namespace UI
{
    partial class FormReservas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Button btnConfirmar;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbClientes = new ComboBox();
            cmbVestidos = new ComboBox();
            dtpFechaReserva = new DateTimePicker();
            dtpFechaExpiracion = new DateTimePicker();
            txtMonto = new TextBox();
            cmbEstado = new ComboBox();
            dgvReservas = new DataGridView();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(32, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(32, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Vestido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(37, 81);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 2;
            label3.Text = "Fecha Reserva:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(32, 114);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 17);
            label4.TabIndex = 3;
            label4.Text = "Fecha Expiracion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Light", 12F);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(35, 182);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 4;
            label5.Text = "Monto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Light", 12F);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(35, 147);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 5;
            label6.Text = "Estado:";
            // 
            // cmbClientes
            // 
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(222, 18);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(499, 20);
            cmbClientes.TabIndex = 7;
            // 
            // cmbVestidos
            // 
            cmbVestidos.ForeColor = Color.FromArgb(64, 0, 0);
            cmbVestidos.FormattingEnabled = true;
            cmbVestidos.Location = new Point(222, 47);
            cmbVestidos.Margin = new Padding(2);
            cmbVestidos.Name = "cmbVestidos";
            cmbVestidos.Size = new Size(499, 20);
            cmbVestidos.TabIndex = 8;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Location = new Point(222, 78);
            dtpFechaReserva.Margin = new Padding(2);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(499, 21);
            dtpFechaReserva.TabIndex = 9;
            // 
            // dtpFechaExpiracion
            // 
            dtpFechaExpiracion.Location = new Point(222, 110);
            dtpFechaExpiracion.Margin = new Padding(2);
            dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            dtpFechaExpiracion.Size = new Size(499, 21);
            dtpFechaExpiracion.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.ForeColor = Color.FromArgb(64, 0, 0);
            txtMonto.Location = new Point(222, 178);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 21);
            txtMonto.TabIndex = 11;
            // 
            // cmbEstado
            // 
            cmbEstado.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(222, 143);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(147, 20);
            cmbEstado.TabIndex = 12;
            // 
            // dgvReservas
            // 
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservas.BackgroundColor = Color.SeaShell;
            dgvReservas.BorderStyle = BorderStyle.Fixed3D;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(37, 235);
            dgvReservas.Margin = new Padding(2);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 62;
            dgvReservas.Size = new Size(689, 346);
            dgvReservas.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.BackColor = Color.RosyBrown;
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnConfirmar.FlatAppearance.BorderSize = 3;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Location = new Point(529, 175);
            btnConfirmar.Margin = new Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(192, 24);
            btnConfirmar.TabIndex = 25;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(770, 592);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvReservas);
            Controls.Add(cmbEstado);
            Controls.Add(txtMonto);
            Controls.Add(dtpFechaExpiracion);
            Controls.Add(dtpFechaReserva);
            Controls.Add(cmbVestidos);
            Controls.Add(cmbClientes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "FormReservas";
            Text = "RESERVAS - ATELIER SARKANY";
            Load += FormReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbClientes;
        private ComboBox cmbVestidos;
        private DateTimePicker dtpFechaReserva;
        private DateTimePicker dtpFechaExpiracion;
        private TextBox txtMonto;
        private ComboBox cmbEstado;
        private DataGridView dgvReservas;
    }
}