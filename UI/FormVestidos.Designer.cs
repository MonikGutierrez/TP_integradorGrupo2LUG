namespace UI
{
    partial class FormVestidos
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtId = new TextBox();
            txtTemporada = new TextBox();
            txtColor = new TextBox();
            txtPrecio = new TextBox();
            txtModelo = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtTalle = new TextBox();
            txtDiseñador = new TextBox();
            txtTiempoAjuste = new TextBox();
            cmbEstado = new ComboBox();
            label12 = new Label();
            dgvVestido = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVestido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Manual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 61);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Vestido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 95);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 138);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 3;
            label4.Text = "Modelo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 173);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 210);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 5;
            label6.Text = "Temporada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 248);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 282);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 7;
            label8.Text = "Stock";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 322);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 8;
            label9.Text = "Talle del vestido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 364);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 9;
            label10.Text = "Diseñador";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 400);
            label11.Name = "label11";
            label11.Size = new Size(224, 25);
            label11.TabIndex = 10;
            label11.Text = "Tiempo de Ajuste en horas";
            // 
            // txtId
            // 
            txtId.Location = new Point(178, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 11;
            // 
            // txtTemporada
            // 
            txtTemporada.Location = new Point(178, 207);
            txtTemporada.Name = "txtTemporada";
            txtTemporada.Size = new Size(150, 31);
            txtTemporada.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(178, 167);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(150, 31);
            txtColor.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(178, 242);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 14;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(178, 132);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(150, 31);
            txtModelo.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(178, 95);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 17;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(178, 276);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 18;
            // 
            // txtTalle
            // 
            txtTalle.Location = new Point(178, 316);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new Size(150, 31);
            txtTalle.TabIndex = 19;
            // 
            // txtDiseñador
            // 
            txtDiseñador.Location = new Point(178, 358);
            txtDiseñador.Name = "txtDiseñador";
            txtDiseñador.Size = new Size(150, 31);
            txtDiseñador.TabIndex = 20;
            // 
            // txtTiempoAjuste
            // 
            txtTiempoAjuste.Location = new Point(222, 400);
            txtTiempoAjuste.Name = "txtTiempoAjuste";
            txtTiempoAjuste.Size = new Size(150, 31);
            txtTiempoAjuste.TabIndex = 21;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(436, 26);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 33);
            cmbEstado.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(361, 29);
            label12.Name = "label12";
            label12.Size = new Size(66, 25);
            label12.TabIndex = 23;
            label12.Text = "Estado";
            // 
            // dgvVestido
            // 
            dgvVestido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVestido.Location = new Point(361, 65);
            dgvVestido.Name = "dgvVestido";
            dgvVestido.RowHeadersWidth = 62;
            dgvVestido.Size = new Size(360, 225);
            dgvVestido.TabIndex = 24;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(389, 296);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(164, 34);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar Vestido";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(389, 355);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(164, 34);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar Vestido ";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(389, 404);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(164, 34);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar Vestido";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormVestidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVestido);
            Controls.Add(label12);
            Controls.Add(cmbEstado);
            Controls.Add(txtTiempoAjuste);
            Controls.Add(txtDiseñador);
            Controls.Add(txtTalle);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtModelo);
            Controls.Add(txtPrecio);
            Controls.Add(txtColor);
            Controls.Add(txtTemporada);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormVestidos";
            Text = "FormVestidos";
            ((System.ComponentModel.ISupportInitialize)dgvVestido).EndInit();
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
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtId;
        private TextBox txtTemporada;
        private TextBox txtColor;
        private TextBox txtPrecio;
        private TextBox txtModelo;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtTalle;
        private TextBox txtDiseñador;
        private TextBox txtTiempoAjuste;
        private ComboBox cmbEstado;
        private Label label12;
        private DataGridView dgvVestido;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}