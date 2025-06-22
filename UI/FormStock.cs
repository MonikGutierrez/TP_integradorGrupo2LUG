using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Collections.Generic;

namespace UI
{
    public partial class FormStock : Form
    {
        private StockBusiness business = new StockBusiness();

        public FormStock()
        {
            InitializeComponent();
            Load += FormStock_Load;
            btnAgregarStock.Click += btnAgregarStock_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            cmbTipoProducto.Items.Add("Calzado");
            cmbTipoProducto.Items.Add("Vestido");
            cmbTipoProducto.SelectedIndex = 0;

            RefrescarGrilla();
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Datos inválidos");
                return;
            }

            Stock stock = new Stock
            {
                TipoProducto = cmbTipoProducto.SelectedItem.ToString(),
                Descripcion = txtDescripcion.Text.Trim(),
                Cantidad = cantidad
            };

            business.Agregar(stock);
            MessageBox.Show("Stock agregado con éxito");
            Limpiar();
            RefrescarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtCantidad.Clear();
            cmbTipoProducto.SelectedIndex = 0;
        }

        private void RefrescarGrilla()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = business.Listar();
        }

      
    }
}