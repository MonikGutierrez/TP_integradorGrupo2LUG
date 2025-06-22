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

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Button btnConfirmarCita;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
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

            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Text = "Confirmar Cita";
           // btnConfirmarCita.Click += btnConfirmarCita_Click;
            Controls.Add(btnConfirmarCita);

            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmarCita
            // 
            btnConfirmarCita.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmarCita.BackColor = Color.RosyBrown;
            btnConfirmarCita.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnConfirmarCita.FlatAppearance.BorderSize = 3;
            btnConfirmarCita.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnConfirmarCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmarCita.FlatStyle = FlatStyle.Popup;
            btnConfirmarCita.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarCita.ForeColor = SystemColors.ControlLightLight;
            btnConfirmarCita.Location = new Point(356, 187);
            btnConfirmarCita.Margin = new Padding(2);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Size = new Size(185, 30);
            btnConfirmarCita.TabIndex = 24;
            btnConfirmarCita.Text = "CONFIRMAR";
            btnConfirmarCita.UseVisualStyleBackColor = false;
            btnConfirmarCita.Click += btnConfirmarCita_Click;
            // 

            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(30, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";

            label1.Size = new Size(84, 17);

            label1.TabIndex = 0;
            label1.Text = "Reserva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(30, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";

            label2.Size = new Size(127, 17);

            label2.TabIndex = 1;
            label2.Text = "Fecha y Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(30, 113);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";

            label3.Size = new Size(76, 17);

            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(30, 153);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";

            label4.Size = new Size(145, 17);

            label4.TabIndex = 3;
            label4.Text = "Observaciones:";
            // 
            // cmbReservas
            // 
            cmbReservas.BackColor = Color.SeaShell;
            cmbReservas.ForeColor = Color.Silver;
            cmbReservas.FormattingEnabled = true;
            cmbReservas.Location = new Point(179, 22);
            cmbReservas.Margin = new Padding(2);
            cmbReservas.Name = "cmbReservas";

            cmbReservas.Size = new Size(401, 20);

            cmbReservas.TabIndex = 4;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.CalendarMonthBackground = Color.SeaShell;
            dtpFechaHora.Location = new Point(179, 65);
            dtpFechaHora.Margin = new Padding(2);
            dtpFechaHora.Name = "dtpFechaHora";

            dtpFechaHora.Size = new Size(397, 21);

            dtpFechaHora.TabIndex = 5;
            dtpFechaHora.ValueChanged += dtpFechaHora_ValueChanged;
            // 
            // cmbEstadoCita
            // 
            cmbEstadoCita.BackColor = Color.SeaShell;
            cmbEstadoCita.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstadoCita.FormattingEnabled = true;
            cmbEstadoCita.Location = new Point(179, 110);
            cmbEstadoCita.Margin = new Padding(2);
            cmbEstadoCita.Name = "cmbEstadoCita";

            cmbEstadoCita.Size = new Size(397, 20);

            cmbEstadoCita.TabIndex = 6;
            // 
            // dgvCitas
            // 
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitas.BackgroundColor = Color.SeaShell;
            dgvCitas.BorderStyle = BorderStyle.Fixed3D;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(11, 258);
            dgvCitas.Margin = new Padding(2);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(890, 388);
            dgvCitas.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.SeaShell;
            txtObservaciones.ForeColor = Color.FromArgb(64, 0, 0);
            txtObservaciones.Location = new Point(179, 151);
            txtObservaciones.Margin = new Padding(2);
            txtObservaciones.Name = "txtObservaciones";

            txtObservaciones.Size = new Size(722, 21);
            txtObservaciones.TabIndex = 8;
            // 
            // btnConfirmarCita
            // 
            btnConfirmarCita.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmarCita.BackColor = Color.RosyBrown;
            btnConfirmarCita.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnConfirmarCita.FlatAppearance.BorderSize = 3;
            btnConfirmarCita.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnConfirmarCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmarCita.FlatStyle = FlatStyle.Popup;
            btnConfirmarCita.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarCita.ForeColor = SystemColors.ControlLightLight;
            btnConfirmarCita.Location = new Point(356, 187);
            btnConfirmarCita.Margin = new Padding(2);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Size = new Size(185, 30);
            btnConfirmarCita.TabIndex = 24;
            btnConfirmarCita.Text = "CONFIRMAR";
            btnConfirmarCita.UseVisualStyleBackColor = false;
            btnConfirmarCita.Click += btnConfirmarCita_Click;
            // 
            // FormCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(917, 653);

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
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormCitas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CITAS - ATELIER SARKANY";
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