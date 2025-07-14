using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPagos : Form
    {
        private ClienteBusiness clienteBusiness = new ClienteBusiness();

        private PagoBusiness pagoBusiness = new PagoBusiness();
        private Pago pagoSeleccionado;
        private Venta ventaCobrar;

        public FormPagos()
        {
            InitializeComponent();

        }

        public FormPagos(Venta venta)
        {

            InitializeComponent();
            this.ventaCobrar = venta;
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {

            CargarCombobox();
            CargarGrilla();
            CargarVenta();

        }

        private void CargarVenta()
        {
            try
            {
                lblVentaId.Text = this.ventaCobrar.Id.ToString();
                if (this.ventaCobrar.Cliente != null)
                {
                    txtCliente.Text = this.ventaCobrar.Cliente.ToString();
                }

                txtMonto.Text = this.ventaCobrar.Total.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarCombobox()
        {

            var metodos = new List<string>
            {
            "Efectivo",
            "Tarjeta de Crédito",
            "Tarjeta de Débito",
            "Transferencia",
            "Cheque",
            "QR"
            };

            cmbMedioPago.DataSource = metodos;
            cmbMedioPago.SelectedIndex = -1;

        }


        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {

                if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.");
                    return;
                }

                if (cmbMedioPago.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese un medio de pago habilitado");
                    return;
                }

                Pago pago = new Pago();
                pago.MedioPago = cmbMedioPago.SelectedItem.ToString();
                pago.Monto = monto;
                pago.Fecha = dtpFechaPago.Value;
                pago.VentaId = this.ventaCobrar.Id;
                

                pagoBusiness.Agregar(pago);
                MessageBox.Show("Pago registrado correctamente.");
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                // Sobre lo visual:
                dgvPagos.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;    // fondo de la celda seleccionada
                dgvPagos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;     // texto de la celda seleccionada

                // Color distinto cuando la fila completa está seleccionada:
                dgvPagos.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvPagos.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

                dgvPagos.DataSource = null;
                dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Autoajusta el tamaño de columnas al contenido
                dgvPagos.RowHeadersVisible = false; // saca el encabezado lateral
                dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona todo el registro
                dgvPagos.AllowUserToAddRows = false; // evita la fila en blanco al final
                dgvPagos.DataSource = null;
                dgvPagos.DataSource = pagoBusiness.ListarTodo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            try
            {
                cmbMedioPago.SelectedIndex = -1;
                txtMonto.Text = string.Empty;
                dtpFechaPago.Value = DateTime.Now;
                pagoSeleccionado = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un pago para eliminar.");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar este pago? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                Pago pago = new Pago();
                pago.Id = Convert.ToInt32(lblId.Text);
                pagoBusiness.Eliminar(pago);

                MessageBox.Show("Pago eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPagos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPagos.SelectedRows.Count > 0)
                {
                    Pago pagoSeleccionado = (Pago)dgvPagos.SelectedRows[0].DataBoundItem;
                    lblId.Text = pagoSeleccionado.Id.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado al seleccionar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
