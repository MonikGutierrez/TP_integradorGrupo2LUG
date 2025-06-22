namespace UI
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnVestidos = new Button();
            btnCalzado = new Button();
            btnReservas = new Button();
            btnCitas = new Button();
            btnVentas = new Button();
            btnStock = new Button();
            groupBox1 = new GroupBox();
            btnPagos = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.RosyBrown;
            btnClientes.Location = new Point(61, 107);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(111, 68);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVestidos
            // 
            btnVestidos.BackColor = Color.Khaki;
            btnVestidos.Location = new Point(70, 225);
            btnVestidos.Name = "btnVestidos";
            btnVestidos.Size = new Size(111, 55);
            btnVestidos.TabIndex = 1;
            btnVestidos.Text = "Vestidos";
            btnVestidos.UseVisualStyleBackColor = false;
            // 
            // btnCalzado
            // 
            btnCalzado.BackColor = SystemColors.ActiveCaption;
            btnCalzado.Location = new Point(223, 227);
            btnCalzado.Name = "btnCalzado";
            btnCalzado.Size = new Size(111, 50);
            btnCalzado.TabIndex = 2;
            btnCalzado.Text = "Calzado";
            btnCalzado.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.DarkSeaGreen;
            btnReservas.Location = new Point(379, 110);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(111, 67);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.NavajoWhite;
            btnCitas.Location = new Point(223, 110);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(111, 65);
            btnCitas.TabIndex = 4;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.MediumPurple;
            btnVentas.Location = new Point(379, 227);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(111, 57);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Aquamarine;
            btnStock.Location = new Point(141, 338);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(111, 53);
            btnStock.TabIndex = 6;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnPagos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnReservas);
            groupBox1.Controls.Add(btnStock);
            groupBox1.Controls.Add(btnVestidos);
            groupBox1.Controls.Add(btnCitas);
            groupBox1.Controls.Add(btnVentas);
            groupBox1.Controls.Add(btnCalzado);
            groupBox1.Location = new Point(39, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 600);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.IndianRed;
            btnPagos.Location = new Point(297, 338);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(111, 53);
            btnPagos.TabIndex = 8;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(141, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 52);
            label1.TabIndex = 7;
            label1.Text = "Atelier Sarkany";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 665);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "FormularioPrincipal";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnVestidos;
        private Button btnCalzado;
        private Button btnReservas;
        private Button btnCitas;
        private Button btnVentas;
        private Button btnStock;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnPagos;
    }
}
