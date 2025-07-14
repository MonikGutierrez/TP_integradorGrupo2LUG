using System;
using System.Linq;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormVentas : Form
    {
        private VentaBusiness ventaBusiness = new VentaBusiness();
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private Venta ventaEnCurso;

        public FormVentas()
        {
            InitializeComponent();

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            try
            {
                cmbClientes.DataSource = clienteBusiness.ListarTodo();
                cmbClientes.DisplayMember = "NombreCompleto";
                cmbClientes.ValueMember = "Id";
                cmbClientes.SelectedIndex = -1;

                cmbProducto.DataSource = productoBusiness.ListarTodo();
                cmbProducto.DisplayMember = "ProductoCompleto";
                cmbProducto.ValueMember = "Id";
                cmbProducto.SelectedIndex = -1;

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CargarGrilla()
        {
            try
            {
                // Cargar datos
                dgvVentas.DataSource = null;
                dgvVentas.DataSource = ventaBusiness.ListarTodo();

                // Fuente general
                var fuenteGeneral = new Font("Segoe UI", 10, FontStyle.Regular);

                // Estilo general de celdas
                dgvVentas.DefaultCellStyle.Font = fuenteGeneral;
                dgvVentas.RowsDefaultCellStyle.Font = fuenteGeneral;
                dgvVentas.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvVentas.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvVentas.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvVentas.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
                dgvVentas.GridColor = Color.LightGray;

                // Configuración general
                dgvVentas.RowHeadersVisible = false;
                dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvVentas.AllowUserToAddRows = false;
                dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Estilo de encabezado
                dgvVentas.EnableHeadersVisualStyles = false;
                dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvVentas.ColumnHeadersHeight = 30;

                // Limpiar selección inicial
                dgvVentas.ClearSelection();

                // Forzar fuente en cada columna
                foreach (DataGridViewColumn col in dgvVentas.Columns)
                {
                    col.DefaultCellStyle.Font = fuenteGeneral;
                }

                // Forzar fuente también celda por celda (soluciona problema visual)
                dgvVentas.CellFormatting -= dgvVentas_CellFormatting; // Por si ya estaba suscripto
                dgvVentas.CellFormatting += dgvVentas_CellFormatting;

                // Ocultar columnas no relevantes
                if (dgvVentas.Columns.Contains("Id"))
                    dgvVentas.Columns["Id"].Visible = false;

                if (dgvVentas.Columns.Contains("VentaId"))
                    dgvVentas.Columns["VentaId"].Visible = false;

                if (dgvVentas.Columns.Contains("ProductoId"))
                    dgvVentas.Columns["ProductoId"].Visible = false;

                if (dgvVentas.Columns.Contains("ClienteId"))
                    dgvVentas.Columns["ClienteId"].Visible = false;

                // Renombrar columnas visibles
                if (dgvVentas.Columns.Contains("PrecioUnitario"))
                    dgvVentas.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";

                if (dgvVentas.Columns.Contains("NombreProducto"))
                    dgvVentas.Columns["NombreProducto"].HeaderText = "Producto";

                // Cargar la grilla secundaria de carrito
                CargarGrillaCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void CargarGrillaCarrito()
        {
            // CARRITO Sobre lo visual:
            dgvCarrito.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;    // fondo de la celda seleccionada
            dgvCarrito.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;     // texto de la celda seleccionada

            // Color distinto cuando la fila completa está seleccionada:
            dgvCarrito.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
            dgvCarrito.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Autoajusta el tamaño de columnas al contenido
            dgvCarrito.RowHeadersVisible = false; // saca el encabezado lateral
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona todo el registro
            dgvCarrito.AllowUserToAddRows = false; // evita la fila en blanco al final
            dgvCarrito.DataSource = null;

            if (ventaEnCurso != null)
            {
                dgvCarrito.DataSource = ventaEnCurso.Detalles.ToList(); // copia para evitar referencia duplicada
                dgvCarrito.ClearSelection();
                dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvCarrito.Columns.Contains("Id"))
                    dgvCarrito.Columns["Id"].Visible = false;
                if (dgvCarrito.Columns.Contains("VentaId"))
                    dgvCarrito.Columns["VentaId"].Visible = false;
                if (dgvCarrito.Columns.Contains("ProductoId"))
                    dgvCarrito.Columns["ProductoId"].Visible = false;
                if (dgvCarrito.Columns.Contains("PrecioUnitario"))
                    dgvCarrito.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                if (dgvCarrito.Columns.Contains("NombreProducto"))
                    dgvCarrito.Columns["NombreProducto"].HeaderText = "Producto";
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventaEnCurso != null)
                    throw new Exception("Existe una compra en curso, por favor, termine de llenar su carrito");

                if (cmbProducto.SelectedItem == null)
                    throw new Exception("No ha seleccionado un producto.");

                if (txtCantidad.Text == "" || Convert.ToInt32(txtCantidad.Text) <= 0)
                    throw new Exception("No ha ingresado la cantidad del/los producto/s");

                Venta ventaIndividual = new Venta();
                if (cmbClientes.SelectedItem != null)
                {
                    ventaIndividual.ClienteId = (int)cmbClientes.SelectedValue;
                }
                ventaIndividual.FechaVenta = DateTime.Now;

                DetalleVenta nuevoDetalle = new DetalleVenta();
                nuevoDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                nuevoDetalle.ProductoId = (int)cmbProducto.SelectedValue;
                nuevoDetalle.PrecioUnitario = Convert.ToDecimal(((Producto)cmbProducto.SelectedItem).Precio);
                ventaIndividual.Detalles.Add(nuevoDetalle);
                ventaIndividual.Total = ventaIndividual.CalcularTotalVenta();
                ventaBusiness.Agregar(ventaIndividual);

                MessageBox.Show("Venta única registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar venta individual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                    throw new Exception("Debe ingresar la cantidad del producto a vender.");

                if (Convert.ToInt32(txtCantidad.Text) <= 0)
                    throw new Exception("La cantidad del producto a vender debe ser mayor a 0.");

                if (cmbProducto.SelectedItem == null)
                    throw new Exception("Debe seleccionar un producto válido.");

                if (this.ventaEnCurso == null)
                {
                    this.ventaEnCurso = new Venta();

                    if (cmbClientes.SelectedItem != null)
                    {
                        ventaEnCurso.ClienteId = (int)cmbClientes.SelectedValue;
                    }
                    cmbClientes.Enabled = false; // Deshabilita selección de cliente una vez que se inicia la venta
                    ventaEnCurso.FechaVenta = DateTime.Now;
                }

                DetalleVenta nuevoDetalle = new DetalleVenta();
                nuevoDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                nuevoDetalle.ProductoId = (int)cmbProducto.SelectedValue;
                nuevoDetalle.PrecioUnitario = Convert.ToDecimal(((Producto)cmbProducto.SelectedItem).Precio);
                nuevoDetalle.producto = (Producto)cmbProducto.SelectedItem;
                ventaEnCurso.Detalles.Add(nuevoDetalle);
                ventaEnCurso.Total = ventaEnCurso.CalcularTotalVenta();
                lblMostrarTotal.Text = $"{ventaEnCurso.Total}";


                CargarGrillaCarrito();
                LimpiarCamposProducto();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (ventaEnCurso == null)
                    throw new Exception("No hay una venta activa.");

                if (ventaEnCurso.Detalles.Count == 0)
                    throw new Exception("No hay productos cargados.");

                ventaBusiness.Agregar(ventaEnCurso);


                MessageBox.Show("¡Venta confirmada y registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCampos();
                CargarGrillaCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LimpiarCampos()
        {
            try
            {
                cmbClientes.SelectedIndex = -1;
                cmbClientes.Enabled = true; // Habilitar selección de cliente nuevamente
                cmbProducto.SelectedIndex = -1;
                txtCantidad.Clear();
                lblMostrarTotal.Text = "0";
                this.ventaEnCurso = null;
                LimpiarCamposProducto();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LimpiarCamposProducto()
        {
            try
            {
                cmbProducto.SelectedIndex = -1;
                txtCantidad.Clear();
            }
            catch (Exception)
            {

                throw;
            }


        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(lblId.Text) <= 0)
                    throw new Exception("Seleccione una venta para eliminar.");

                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Venta venta = new Venta
                    {
                        Id = Convert.ToInt32(lblId.Text)
                    };
                    ventaBusiness.Eliminar(venta);
                    MessageBox.Show("Venta eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrilla();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccione una venta para cobrar.");
                }

                var ventaSeleccionada = dgvVentas.SelectedRows[0].DataBoundItem as Venta;

                if (ventaSeleccionada == null || ventaSeleccionada.Id <= 0)
                {
                    throw new Exception("La venta seleccionada no es válida.");
                }

                using var form = new FormPagos(ventaSeleccionada);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cobrar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.SelectedRows.Count > 0)
                {
                    Venta ventaSeleccionado = (Venta)dgvVentas.SelectedRows[0].DataBoundItem;
                    lblId.Text = ventaSeleccionado.Id.ToString();
                    lblMostrarTotal.Text = ventaSeleccionado.Total.ToString();
                    cmbClientes.SelectedValue = ventaSeleccionado.ClienteId;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado al seleccionar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var fuente = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvVentas.Rows[e.RowIndex].DefaultCellStyle.Font = fuente;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new FormClientes();
                form.ShowDialog();
                CargarCombos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado al agregar cliente a la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
