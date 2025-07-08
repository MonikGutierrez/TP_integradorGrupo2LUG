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
            Button btnConfirmar;
            Button btnLimpiarReserva;
            Button btnEliminarReserva;
            Button btnModificarReserva;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            groupBox1 = new GroupBox();
            btnConfirmar = new Button();
            btnLimpiarReserva = new Button();
            btnEliminarReserva = new Button();
            btnModificarReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            btnConfirmar.Location = new Point(387, 140);
            btnConfirmar.Margin = new Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(157, 40);
            btnConfirmar.TabIndex = 25;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnLimpiarReserva
            // 
            btnLimpiarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarReserva.BackColor = Color.SeaShell;
            btnLimpiarReserva.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiarReserva.FlatAppearance.BorderSize = 3;
            btnLimpiarReserva.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiarReserva.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarReserva.FlatStyle = FlatStyle.Popup;
            btnLimpiarReserva.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarReserva.ForeColor = Color.FromArgb(64, 0, 0);
            btnLimpiarReserva.Location = new Point(548, 187);
            btnLimpiarReserva.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarReserva.Name = "btnLimpiarReserva";
            btnLimpiarReserva.Size = new Size(157, 39);
            btnLimpiarReserva.TabIndex = 32;
            btnLimpiarReserva.Text = "LIMPIAR";
            btnLimpiarReserva.UseVisualStyleBackColor = false;
            // 
            // btnEliminarReserva
            // 
            btnEliminarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarReserva.BackColor = Color.Black;
            btnEliminarReserva.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnEliminarReserva.FlatAppearance.BorderSize = 3;
            btnEliminarReserva.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEliminarReserva.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarReserva.FlatStyle = FlatStyle.Popup;
            btnEliminarReserva.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarReserva.ForeColor = SystemColors.ControlLightLight;
            btnEliminarReserva.Location = new Point(548, 140);
            btnEliminarReserva.Margin = new Padding(2);
            btnEliminarReserva.Name = "btnEliminarReserva";
            btnEliminarReserva.Size = new Size(157, 40);
            btnEliminarReserva.TabIndex = 33;
            btnEliminarReserva.Text = "ELIMINAR";
            btnEliminarReserva.UseVisualStyleBackColor = false;
            // 
            // btnModificarReserva
            // 
            btnModificarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarReserva.BackColor = Color.Bisque;
            btnModificarReserva.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnModificarReserva.FlatAppearance.BorderSize = 3;
            btnModificarReserva.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnModificarReserva.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarReserva.FlatStyle = FlatStyle.Popup;
            btnModificarReserva.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarReserva.ForeColor = Color.FromArgb(64, 0, 0);
            btnModificarReserva.Location = new Point(387, 186);
            btnModificarReserva.Margin = new Padding(2);
            btnModificarReserva.Name = "btnModificarReserva";
            btnModificarReserva.Size = new Size(156, 40);
            btnModificarReserva.TabIndex = 34;
            btnModificarReserva.Text = "MODIFICAR";
            btnModificarReserva.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(12, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 18);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(12, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 1;
            label2.Text = "Vestido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(13, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 18);
            label3.TabIndex = 2;
            label3.Text = "Fecha Reserva:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(13, 111);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 18);
            label4.TabIndex = 3;
            label4.Text = "Fecha Expiracion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(10, 175);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(197, 18);
            label5.TabIndex = 4;
            label5.Text = "Monto de la reserva:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(12, 143);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 18);
            label6.TabIndex = 5;
            label6.Text = "Forma de pago:";
            // 
            // cmbClientes
            // 
            cmbClientes.ForeColor = Color.FromArgb(64, 0, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(207, 16);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(499, 20);
            cmbClientes.TabIndex = 7;
            // 
            // cmbVestidos
            // 
            cmbVestidos.ForeColor = Color.FromArgb(64, 0, 0);
            cmbVestidos.FormattingEnabled = true;
            cmbVestidos.Location = new Point(207, 45);
            cmbVestidos.Margin = new Padding(2);
            cmbVestidos.Name = "cmbVestidos";
            cmbVestidos.Size = new Size(499, 20);
            cmbVestidos.TabIndex = 8;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Location = new Point(207, 76);
            dtpFechaReserva.Margin = new Padding(2);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(499, 21);
            dtpFechaReserva.TabIndex = 9;
            // 
            // dtpFechaExpiracion
            // 
            dtpFechaExpiracion.Location = new Point(207, 108);
            dtpFechaExpiracion.Margin = new Padding(2);
            dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            dtpFechaExpiracion.Size = new Size(499, 21);
            dtpFechaExpiracion.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.ForeColor = Color.FromArgb(64, 0, 0);
            txtMonto.Location = new Point(207, 172);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(147, 21);
            txtMonto.TabIndex = 11;
            // 
            // cmbEstado
            // 
            cmbEstado.ForeColor = Color.FromArgb(64, 0, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(207, 141);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(147, 20);
            cmbEstado.TabIndex = 12;
            // 
            // dgvReservas
            // 
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservas.BackgroundColor = Color.SeaShell;
            dgvReservas.BorderStyle = BorderStyle.Fixed3D;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(5, 259);
            dgvReservas.Margin = new Padding(2);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 62;
            dgvReservas.Size = new Size(721, 322);
            dgvReservas.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificarReserva);
            groupBox1.Controls.Add(btnEliminarReserva);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnLimpiarReserva);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(dtpFechaExpiracion);
            groupBox1.Controls.Add(dtpFechaReserva);
            groupBox1.Controls.Add(cmbVestidos);
            groupBox1.Controls.Add(cmbClientes);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(5, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 238);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión reservas";
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(743, 592);
            Controls.Add(groupBox1);
            Controls.Add(dgvReservas);
            Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "FormReservas";
            Text = "RESERVAS - ATELIER SARKANY";
            Load += FormReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Button btnConfirmar;
        private GroupBox groupBox1;
    }
}