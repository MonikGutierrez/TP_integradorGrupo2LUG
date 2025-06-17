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
            btnConfirmar = new Button();
            dgvReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 56);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 1;
            label2.Text = "Vestido Disponible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 103);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha Reserva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 156);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha Expiracion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 206);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 4;
            label5.Text = "Monto Reservado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 250);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(207, 6);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(182, 33);
            cmbClientes.TabIndex = 7;
            // 
            // cmbVestidos
            // 
            cmbVestidos.FormattingEnabled = true;
            cmbVestidos.Location = new Point(207, 48);
            cmbVestidos.Name = "cmbVestidos";
            cmbVestidos.Size = new Size(182, 33);
            cmbVestidos.TabIndex = 8;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Location = new Point(207, 97);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(334, 31);
            dtpFechaReserva.TabIndex = 9;
            // 
            // dtpFechaExpiracion
            // 
            dtpFechaExpiracion.Location = new Point(207, 156);
            dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            dtpFechaExpiracion.Size = new Size(334, 31);
            dtpFechaExpiracion.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(207, 200);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 31);
            txtMonto.TabIndex = 11;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(207, 247);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 33);
            cmbEstado.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(207, 286);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(32, 326);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 62;
            dgvReservas.Size = new Size(707, 225);
            dgvReservas.TabIndex = 14;
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(dgvReservas);
            Controls.Add(btnConfirmar);
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
            Name = "FormReservas";
            Text = "FormReservas";
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
        private Button btnConfirmar;
        private DataGridView dgvReservas;
    }
}