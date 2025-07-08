using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BLL;
using Entity;

namespace UI
{
    public partial class FormVentas : Form
    {
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private VestidoBusiness vestidoBusiness = new VestidoBusiness();
        private CalzadoBusiness calzadoBusiness = new CalzadoBusiness();
        private VentaBusiness ventaBusiness = new VentaBusiness();

        private List<DetalleVenta> detalleTemporal = new List<DetalleVenta>();

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = clienteBusiness.Listar();
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "Id";

            List<Producto> productos = new List<Producto>();
            productos.AddRange(vestidoBusiness.Listar());
            productos.AddRange(calzadoBusiness.Listar());

            cmbProductos.DataSource = productos;
            cmbProductos.DisplayMember = "Descripcion";
            cmbProductos.ValueMember = "Id";

            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detalleTemporal;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            Producto producto = (Producto)cmbProductos.SelectedItem;

            DetalleVenta detalle = new DetalleVenta
            {
                Producto = producto,
                ProductoId = producto.Id,
                Cantidad = cantidad,
                PrecioUnitario = producto.Precio
            };

            detalleTemporal.Add(detalle);
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detalleTemporal;
            ActualizarTotal();
            txtCantidad.Clear();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (detalleTemporal.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.");
                return;
            }

            Venta venta = new Venta
            {
                ClienteId = (int)cmbClientes.SelectedValue,
                Fecha = DateTime.Now,
                Total = CalcularTotal(),
                Estado = "Finalizada",
                MetodoPago = "Efectivo",
                Detalles = detalleTemporal
            };

            ventaBusiness.Agregar(venta);
            MessageBox.Show("Venta registrada con éxito.");
            detalleTemporal.Clear();
            dgvDetalle.DataSource = null;
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = "$" + CalcularTotal().ToString("0.00");
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var d in detalleTemporal)
            {
                total += d.PrecioUnitario * d.Cantidad;
            }
            return total;
        }
    }
}
