namespace UI
{
    partial class FormCitas
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
            cmbReservas = new ComboBox();
            dtpFechaHora = new DateTimePicker();
            cmbEstadoCita = new ComboBox();
            dgvCitas = new DataGridView();
            txtObservaciones = new TextBox();
            btnConfirmarCita = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha y Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 169);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 3;
            label4.Text = "Observaciones";
            // 
            // cmbReservas
            // 
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(149, 24);
            cmbReservas.Name = "cmbReservas";
            cmbReservas.Size = new Size(182, 33);
            cmbReservas.TabIndex = 4;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Location = new Point(149, 68);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(300, 31);
            dtpFechaHora.TabIndex = 5;
            // 
            // cmbEstadoCita
            // 
            cmbEstadoCita.FormattingEnabled = true;
            cmbEstadoCita.Location = new Point(149, 122);
            cmbEstadoCita.Name = "cmbEstadoCita";
            cmbEstadoCita.Size = new Size(182, 33);
            cmbEstadoCita.TabIndex = 6;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(12, 270);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(767, 225);
            dgvCitas.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(149, 169);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(182, 31);
            txtObservaciones.TabIndex = 8;
            // 
            // btnConfirmarCita
            // 
            btnConfirmarCita.Location = new Point(167, 215);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Size = new Size(145, 34);
            btnConfirmarCita.TabIndex = 9;
            btnConfirmarCita.Text = "Confirmar Cita";
            btnConfirmarCita.UseVisualStyleBackColor = true;
            btnConfirmarCita.Click += BtnConfirmarCita_Click;
            // 
            // FormCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(btnConfirmarCita);
            Controls.Add(txtObservaciones);
            Controls.Add(dgvCitas);
            Controls.Add(cmbEstadoCita);
            Controls.Add(dtpFechaHora);
            Controls.Add(cmbReservas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCitas";
            Text = "FormCitas";
            Load += FormCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbReservas;
        private DateTimePicker dtpFechaHora;
        private ComboBox cmbEstadoCita;
        private DataGridView dgvCitas;
        private TextBox txtObservaciones;
        private Button btnConfirmarCita;
    }
}