using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BLL;
using Entity;

namespace UI {
    public partial class FormVentas : Form {
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private VestidoBusiness vestidoBusiness = new VestidoBusiness();
        private CalzadoBusiness calzadoBusiness = new CalzadoBusiness();
        private VentaBusiness ventaBusiness = new VentaBusiness();
        private DetalleVenta itemSeleccionado;
        private BindingList<DetalleVenta> itemsCarrito = new BindingList<DetalleVenta>();

        public FormVentas() {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e) {
            cmbClientes.DataSource = clienteBusiness.Listar();
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "Id";

            cmbMetodoDePago.Items.AddRange(new string[] {
                "EFECTIVO", "TARJETA DE CRÉDITO", "TARJETA DE DÉBITO", "TRANSFERENCIA", "QR"
            });

            List<Producto> productos = new List<Producto>();
            productos.AddRange(vestidoBusiness.Listar());
            productos.AddRange(calzadoBusiness.Listar());

            cmbProductos.DataSource = productos;
            cmbProductos.DisplayMember = "Descripcion";
            cmbProductos.ValueMember = "Id";

            dgvCarrito.DataSource = itemsCarrito;
            LimpiarSeleccionCarrito();
            ActualizarTablaVentas();
            ActualizarTotal();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e) {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0) {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            Producto producto = (Producto)cmbProductos.SelectedItem;

            DetalleVenta detalle = new DetalleVenta {
                ProductoId = producto.Id,
                Cantidad = cantidad,
                PrecioUnitario = producto.Precio,
            };

            itemsCarrito.Add(detalle);
            LimpiarSeleccionCarrito();
            ActualizarTotal();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e) {
            if (itemsCarrito.Count == 0) {
                MessageBox.Show("Debe agregar al menos un producto.");
                return;
            }

            Venta venta = new Venta {
                ClienteId = (int)cmbClientes.SelectedValue,
                Fecha = DateTime.Now,
                Total = CalcularTotal(),
                Estado = "Finalizada",
                MetodoPago = cmbMetodoDePago.Text,
                Detalles = itemsCarrito.ToList()
            };

            ventaBusiness.Agregar(venta);
            MessageBox.Show("Venta registrada con éxito.");
            itemsCarrito.Clear();
            LimpiarSeleccionCarrito();
            ActualizarTotal();
            ActualizarTablaVentas();
        }

        private void ActualizarTotal() {
            if(itemsCarrito.Count > 0) {
                lblTotal.Text = "$" + CalcularTotal().ToString("0.00");
            } else {
                lblTotal.Text = "$ ----------";
            }
        }

        private decimal CalcularTotal() {
            decimal total = 0;
            foreach (var d in itemsCarrito) {
                total += d.PrecioUnitario * d.Cantidad;
            }
            return total;
        }

        private void ActualizarTablaVentas() {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventaBusiness.Listar();
            dgvVentas.ClearSelection();
        }

        private void LimpiarSeleccionCarrito() {
            dgvCarrito.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvCarrito.CurrentRow != null) {
                itemsCarrito.RemoveAt(dgvCarrito.CurrentRow.Index);
                ActualizarTotal();
                ActualizarTablaVentas();
            }
        }
    }
}