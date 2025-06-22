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
            btnPagos = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBoxLogo = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.RosyBrown;
            btnClientes.Font = new Font("Copperplate Gothic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.FromArgb(64, 0, 0);
            btnClientes.Location = new Point(2, 2);
            btnClientes.Margin = new Padding(2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(276, 172);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CLIENTES";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVestidos
            // 
            btnVestidos.BackColor = Color.Silver;
            btnVestidos.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnVestidos.ForeColor = Color.FromArgb(64, 0, 0);
            btnVestidos.Location = new Point(290, 2);
            btnVestidos.Margin = new Padding(2);
            btnVestidos.Name = "btnVestidos";
            btnVestidos.Size = new Size(276, 172);
            btnVestidos.TabIndex = 1;
            btnVestidos.Text = "VESTIDOS";
            btnVestidos.TextAlign = ContentAlignment.BottomCenter;
            btnVestidos.UseVisualStyleBackColor = false;
            // 
            // btnCalzado
            // 
            btnCalzado.BackColor = Color.FromArgb(64, 0, 0);
            btnCalzado.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnCalzado.ForeColor = Color.SeaShell;
            btnCalzado.Location = new Point(576, 2);
            btnCalzado.Margin = new Padding(2);
            btnCalzado.Name = "btnCalzado";
            btnCalzado.Size = new Size(276, 172);
            btnCalzado.TabIndex = 2;
            btnCalzado.Text = "CALZADOS";
            btnCalzado.TextAlign = ContentAlignment.BottomCenter;
            btnCalzado.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.RosyBrown;
            btnReservas.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnReservas.ForeColor = Color.FromArgb(64, 0, 0);
            btnReservas.Location = new Point(290, 178);
            btnReservas.Margin = new Padding(2);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(276, 172);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "RESERVAS";
            btnReservas.TextAlign = ContentAlignment.BottomCenter;
            btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(64, 0, 0);
            btnCitas.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnCitas.ForeColor = Color.SeaShell;
            btnCitas.Location = new Point(2, 178);
            btnCitas.Margin = new Padding(2);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(276, 172);
            btnCitas.TabIndex = 4;
            btnCitas.Text = "CITAS";
            btnCitas.TextAlign = ContentAlignment.BottomCenter;
            btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Silver;
            btnVentas.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnVentas.ForeColor = Color.FromArgb(64, 0, 0);
            btnVentas.Location = new Point(576, 178);
            btnVentas.Margin = new Padding(2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(276, 172);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "VENTAS";
            btnVentas.TextAlign = ContentAlignment.BottomCenter;
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Silver;
            btnStock.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnStock.ForeColor = Color.FromArgb(64, 0, 0);
            btnStock.Location = new Point(2, 354);
            btnStock.Margin = new Padding(2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(276, 153);
            btnStock.TabIndex = 6;
            btnStock.Text = "STOCK";
            btnStock.TextAlign = ContentAlignment.BottomCenter;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click_1;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(64, 0, 0);
            btnPagos.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnPagos.ForeColor = Color.SeaShell;
            btnPagos.Location = new Point(290, 354);
            btnPagos.Margin = new Padding(2);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(276, 153);
            btnPagos.TabIndex = 8;
            btnPagos.Text = "PAGOS";
            btnPagos.TextAlign = ContentAlignment.BottomCenter;
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(11, 366);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 36);
            label1.TabIndex = 7;
            label1.Text = "Atelier Sarkany";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1742172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8257828F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 283F));
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(btnPagos, 1, 2);
            tableLayoutPanel1.Controls.Add(btnStock, 0, 2);
            tableLayoutPanel1.Controls.Add(btnReservas, 1, 1);
            tableLayoutPanel1.Controls.Add(btnVentas, 2, 1);
            tableLayoutPanel1.Controls.Add(btnCalzado, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCitas, 0, 1);
            tableLayoutPanel1.Controls.Add(btnVestidos, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClientes, 0, 0);
            tableLayoutPanel1.Location = new Point(2, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Size = new Size(858, 509);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 100);
            panel1.TabIndex = 9;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.SeaShell;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(870, 97);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 63);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Copperplate Gothic Bold", 27.75F);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(576, 354);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(276, 153);
            button1.TabIndex = 9;
            button1.Text = "SALIR";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 615);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormPrincipal";
            Text = "Bienvenido a Atelier Sarkany";
            Load += FormPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnVestidos;
        private Button btnCalzado;
        private Button btnReservas;
        private Button btnCitas;
        private Button btnVentas;
        private Button btnStock;
        private Label label1;
        private Button btnPagos;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBoxLogo;
        private Label label2;
        private Button button1;
    }
}
