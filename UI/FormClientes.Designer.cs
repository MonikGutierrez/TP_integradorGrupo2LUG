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
            btnAlta = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            btnAlta.Location = new Point(35, 196);
            btnAlta.Margin = new Padding(3, 2, 3, 2);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(228, 43);
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
            btnModificar.Location = new Point(459, 195);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(240, 43);
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
            btnEliminar.Location = new Point(885, 194);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(228, 43);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.SeaShell;
            txtNombre.ForeColor = Color.FromArgb(64, 0, 0);
            txtNombre.Location = new Point(130, 21);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(983, 34);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.SeaShell;
            txtApellido.ForeColor = Color.FromArgb(64, 0, 0);
            txtApellido.Location = new Point(130, 65);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(983, 34);
            txtApellido.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.SeaShell;
            txtEmail.ForeColor = Color.FromArgb(64, 0, 0);
            txtEmail.Location = new Point(130, 155);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(983, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.SeaShell;
            txtTelefono.ForeColor = Color.FromArgb(64, 0, 0);
            txtTelefono.Location = new Point(130, 110);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(983, 34);
            txtTelefono.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(121, 26);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(131, 26);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(35, 158);
            label3.Name = "label3";
            label3.Size = new Size(89, 26);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(35, 113);
            label4.Name = "label4";
            label4.Size = new Size(143, 26);
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
            dgvClientes.Location = new Point(35, 291);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(1078, 370);
            dgvClientes.TabIndex = 12;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(17F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1164, 678);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(txtApellido);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(dgvClientes);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CLIENTES - ATELIER SARKANY";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
    }
}