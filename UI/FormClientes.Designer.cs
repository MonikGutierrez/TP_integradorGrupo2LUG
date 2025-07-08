namespace UI
{
    partial class FormClientes
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
            Button btnAlta;
            Button btnModificar;
            Button btnEliminar;
            Button btnLimpiar;
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvClientes = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtDNI = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAlta = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAlta.BackColor = Color.RosyBrown;
            btnAlta.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnAlta.FlatAppearance.BorderSize = 3;
            btnAlta.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAlta.FlatStyle = FlatStyle.Popup;
            btnAlta.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.ForeColor = SystemColors.ControlLightLight;
            btnAlta.Location = new Point(221, 220);
            btnAlta.Margin = new Padding(3, 2, 3, 2);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(152, 32);
            btnAlta.TabIndex = 24;
            btnAlta.Text = "AGREGAR";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
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
            btnModificar.Location = new Point(394, 220);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(152, 32);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            btnEliminar.Location = new Point(565, 220);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 32);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.SeaShell;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(64, 0, 0);
            btnLimpiar.Location = new Point(740, 220);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(152, 32);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.SeaShell;
            txtNombre.Font = new Font("Bookman Old Style", 9F);
            txtNombre.ForeColor = Color.FromArgb(64, 0, 0);
            txtNombre.Location = new Point(101, 25);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(971, 22);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.SeaShell;
            txtApellido.Font = new Font("Bookman Old Style", 9F);
            txtApellido.ForeColor = Color.FromArgb(64, 0, 0);
            txtApellido.Location = new Point(101, 69);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(971, 22);
            txtApellido.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.SeaShell;
            txtEmail.Font = new Font("Bookman Old Style", 9F);
            txtEmail.ForeColor = Color.FromArgb(64, 0, 0);
            txtEmail.Location = new Point(101, 190);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(971, 22);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.SeaShell;
            txtTelefono.Font = new Font("Bookman Old Style", 9F);
            txtTelefono.ForeColor = Color.FromArgb(64, 0, 0);
            txtTelefono.Location = new Point(101, 145);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(971, 22);
            txtTelefono.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 18);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(32, 194);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 8;
            label4.Text = "Telefono:";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.BackgroundColor = Color.SeaShell;
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.GridColor = Color.Silver;
            dgvClientes.Location = new Point(35, 314);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(1078, 346);
            dgvClientes.TabIndex = 12;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAlta);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(35, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1078, 267);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion de clientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(35, 297);
            label5.Name = "label5";
            label5.Size = new Size(129, 12);
            label5.TabIndex = 31;
            label5.Text = "Listado de clientes";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.SeaShell;
            txtDNI.Font = new Font("Bookman Old Style", 9F);
            txtDNI.ForeColor = Color.FromArgb(64, 0, 0);
            txtDNI.Location = new Point(101, 105);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(971, 22);
            txtDNI.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(50, 109);
            label6.Name = "label6";
            label6.Size = new Size(45, 18);
            label6.TabIndex = 32;
            label6.Text = "DNI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(64, 0, 0);
            label7.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(165, 110);
            label7.Name = "label7";
            label7.Size = new Size(283, 12);
            label7.TabIndex = 32;
            label7.Text = "AGREGADO, HAY QUE MODIFICAR CODIGO";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(11F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1164, 678);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLIENTES - ATELIER SARKANY";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvClientes;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtDNI;
        private Label label6;
        private Label label7;
    }
}