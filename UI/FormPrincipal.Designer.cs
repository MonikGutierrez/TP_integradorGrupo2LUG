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
            btnSalir = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBoxLogo = new PictureBox();
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
            btnClientes.Image = Properties.Resources.user3;
            btnClientes.ImageAlign = ContentAlignment.TopCenter;
            btnClientes.Location = new Point(2, 2);
            btnClientes.Margin = new Padding(2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(276, 172);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CLIENTES";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVestidos
            // 
            btnVestidos.BackColor = Color.Silver;
            btnVestidos.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnVestidos.ForeColor = Color.FromArgb(64, 0, 0);
            btnVestidos.Image = Properties.Resources.vestidos1;
            btnVestidos.ImageAlign = ContentAlignment.TopCenter;
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
            btnCalzado.Image = Properties.Resources.zapatos;
            btnCalzado.ImageAlign = ContentAlignment.TopCenter;
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
            btnReservas.Image = Properties.Resources.reservas;
            btnReservas.ImageAlign = ContentAlignment.TopCenter;
            btnReservas.Location = new Point(290, 185);
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
            btnCitas.Image = Properties.Resources.citas1;
            btnCitas.ImageAlign = ContentAlignment.TopCenter;
            btnCitas.Location = new Point(2, 185);
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
            btnVentas.Image = Properties.Resources.ventas;
            btnVentas.ImageAlign = ContentAlignment.TopCenter;
            btnVentas.Location = new Point(576, 185);
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
            btnStock.Image = Properties.Resources.stock;
            btnStock.ImageAlign = ContentAlignment.TopCenter;
            btnStock.Location = new Point(2, 368);
            btnStock.Margin = new Padding(2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(276, 172);
            btnStock.TabIndex = 6;
            btnStock.Text = "STOCK";
            btnStock.TextAlign = ContentAlignment.BottomCenter;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(64, 0, 0);
            btnPagos.Font = new Font("Copperplate Gothic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagos.ForeColor = Color.SeaShell;
            btnPagos.Image = Properties.Resources.Pagos2;
            btnPagos.ImageAlign = ContentAlignment.TopCenter;
            btnPagos.Location = new Point(290, 368);
            btnPagos.Margin = new Padding(2);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(276, 172);
            btnPagos.TabIndex = 8;
            btnPagos.Text = "PAGOS";
            btnPagos.TextAlign = ContentAlignment.BottomCenter;
            btnPagos.UseVisualStyleBackColor = false;
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
            tableLayoutPanel1.Controls.Add(btnSalir, 2, 2);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.Size = new Size(858, 544);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Font = new Font("Copperplate Gothic Bold", 27.75F);
            btnSalir.ForeColor = Color.FromArgb(64, 0, 0);
            btnSalir.Image = Properties.Resources.salir;
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(576, 368);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(276, 172);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 63);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.SeaShell;
            pictureBoxLogo.InitialImage = Properties.Resources.Atelier_sarkany_banner;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(870, 97);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 647);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnSalir;
    }
}
