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
            Button btnConfirmarCita;
            Button btnLimpiarCita;
            Button btnModificarCita;
            Button btnEliminarCita;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbClientes = new ComboBox();
            dtpFechaHora = new DateTimePicker();
            cmbEstadoCita = new ComboBox();
            dgvCitas = new DataGridView();
            txtObservaciones = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            lblId = new Label();
            label5 = new Label();
            btnConfirmarCita = new Button();
            btnLimpiarCita = new Button();
            btnModificarCita = new Button();
            btnEliminarCita = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            groupBox1.SuspendLayout();
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
            btnConfirmarCita.Location = new Point(236, 207);
            btnConfirmarCita.Margin = new Padding(2);
            btnConfirmarCita.Name = "btnConfirmarCita";
            btnConfirmarCita.Size = new Size(132, 38);
            btnConfirmarCita.TabIndex = 24;
            btnConfirmarCita.Text = "AGREGAR";
            btnConfirmarCita.UseVisualStyleBackColor = false;
            btnConfirmarCita.Click += btnConfirmarCita_Click;
            // 
            // btnLimpiarCita
            // 
            btnLimpiarCita.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarCita.BackColor = Color.SeaShell;
            btnLimpiarCita.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiarCita.FlatAppearance.BorderSize = 3;
            btnLimpiarCita.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiarCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCita.FlatStyle = FlatStyle.Popup;
            btnLimpiarCita.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCita.ForeColor = Color.FromArgb(64, 0, 0);
            btnLimpiarCita.Location = new Point(683, 205);
            btnLimpiarCita.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCita.Name = "btnLimpiarCita";
            btnLimpiarCita.Size = new Size(133, 40);
            btnLimpiarCita.TabIndex = 71;
            btnLimpiarCita.Text = "LIMPIAR";
            btnLimpiarCita.UseVisualStyleBackColor = false;
            btnLimpiarCita.Click += btnLimpiarCita_Click;
            // 
            // btnModificarCita
            // 
            btnModificarCita.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarCita.BackColor = Color.Bisque;
            btnModificarCita.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnModificarCita.FlatAppearance.BorderSize = 3;
            btnModificarCita.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnModificarCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarCita.FlatStyle = FlatStyle.Popup;
            btnModificarCita.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarCita.ForeColor = Color.FromArgb(64, 0, 0);
            btnModificarCita.Location = new Point(384, 205);
            btnModificarCita.Margin = new Padding(2);
            btnModificarCita.Name = "btnModificarCita";
            btnModificarCita.Size = new Size(133, 40);
            btnModificarCita.TabIndex = 72;
            btnModificarCita.Text = "MODIFICAR";
            btnModificarCita.UseVisualStyleBackColor = false;
            btnModificarCita.Click += btnModificarCita_Click;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarCita.BackColor = Color.Black;
            btnEliminarCita.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnEliminarCita.FlatAppearance.BorderSize = 3;
            btnEliminarCita.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEliminarCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarCita.FlatStyle = FlatStyle.Popup;
            btnEliminarCita.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCita.ForeColor = SystemColors.ControlLightLight;
            btnEliminarCita.Location = new Point(532, 205);
            btnEliminarCita.Margin = new Padding(2);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(133, 40);
            btnEliminarCita.TabIndex = 71;
            btnEliminarCita.Text = "ELIMINAR";
            btnEliminarCita.UseVisualStyleBackColor = false;
            btnEliminarCita.Click += btnEliminarCita_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(20, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 0;
            label1.Text = "Cliente(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(20, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 1;
            label2.Text = "Fecha y Hora(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(20, 133);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 2;
            label3.Text = "Estado(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(19, 175);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 3;
            label4.Text = "Observaciones:";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.SeaShell;
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(176, 44);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(698, 20);
            cmbClientes.TabIndex = 4;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.CalendarMonthBackground = Color.SeaShell;
            dtpFechaHora.Location = new Point(176, 87);
            dtpFechaHora.Margin = new Padding(2);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(698, 21);
            dtpFechaHora.TabIndex = 5;
            // 
            // cmbEstadoCita
            // 
            cmbEstadoCita.BackColor = Color.SeaShell;
            cmbEstadoCita.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstadoCita.FormattingEnabled = true;
            cmbEstadoCita.Location = new Point(176, 132);
            cmbEstadoCita.Margin = new Padding(2);
            cmbEstadoCita.Name = "cmbEstadoCita";
            cmbEstadoCita.Size = new Size(341, 20);
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
            dgvCitas.Location = new Point(3, 290);
            dgvCitas.Margin = new Padding(2);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(903, 356);
            dgvCitas.TabIndex = 7;
            dgvCitas.CellBorderStyleChanged += dgvCitas_SelectionChanged;
            dgvCitas.Click += dgvCitas_SelectionChanged;
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.SeaShell;
            txtObservaciones.ForeColor = Color.FromArgb(64, 0, 0);
            txtObservaciones.Location = new Point(176, 173);
            txtObservaciones.Margin = new Padding(2);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(698, 21);
            txtObservaciones.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(3, 273);
            label6.Name = "label6";
            label6.Size = new Size(107, 12);
            label6.TabIndex = 69;
            label6.Text = "Listado de citas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(btnModificarCita);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnLimpiarCita);
            groupBox1.Controls.Add(btnEliminarCita);
            groupBox1.Controls.Add(btnConfirmarCita);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(cmbEstadoCita);
            groupBox1.Controls.Add(dtpFechaHora);
            groupBox1.Controls.Add(cmbClientes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 256);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión citas";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.ScrollBar;
            lblId.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(64, 0, 0);
            lblId.Location = new Point(53, 18);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(23, 18);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 18);
            label5.TabIndex = 74;
            label5.Text = "Id:";
            // 
            // FormCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(917, 655);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(dgvCitas);
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormCitas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CITAS - ATELIER SARKANY";
            Load += FormCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbClientes;
        private DateTimePicker dtpFechaHora;
        private ComboBox cmbEstadoCita;
        private DataGridView dgvCitas;
        private TextBox txtObservaciones;
        private Button btnConfirmarCita;
        private Label label6;
        private GroupBox groupBox1;
        private Label lblId;
        private Label label5;
    }
    
}