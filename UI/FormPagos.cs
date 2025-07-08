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
        private ReservaBusiness reservaBusiness = new ReservaBusiness();
        private PagoBusiness pagoBusiness = new PagoBusiness();

        public FormPagos()
        {
            InitializeComponent();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarPagos();
        }

        private void CargarClientes()
        {
            cmbClientes.DataSource = clienteBusiness.Listar();
            cmbClientes.DisplayMember = "Nombre"; // asegúrate que Cliente tenga esta propiedad o combínalo
            cmbClientes.ValueMember = "Id";
            cmbClientes.SelectedIndex = -1;
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                int clienteId = (int)cmbClientes.SelectedValue;
                List<Reserva> reservas = reservaBusiness.ListarPorCliente(clienteId);
                cmbReservas.DataSource = reservas;
                cmbReservas.DisplayMember = "Id";
                cmbReservas.ValueMember = "Id";
                cmbReservas.SelectedIndex = -1;
            }
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue == null || cmbReservas.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente y una reserva.");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.");
                return;
            }

            Pago nuevoPago = new Pago
            {
                ClienteId = (int)cmbClientes.SelectedValue,
                ReservaId = (int)cmbReservas.SelectedValue,
                FechaPago = dtpFechaPago.Value,
                Monto = monto
            };

            try
            {
                pagoBusiness.Agregar(nuevoPago);
                MessageBox.Show("Pago registrado correctamente.");
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message);
            }
        }

        private void CargarPagos()
        {
            dgvPagos.DataSource = null;
            dgvPagos.DataSource = pagoBusiness.Listar();
        }
    }
}
