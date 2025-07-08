using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormReservas : Form
    {
        private ReservaBusiness reservaBusiness = new ReservaBusiness();

        public FormReservas()
        {
            InitializeComponent();
            //btnConfirmar.Click += btnConfirmar_Click;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = new Reserva()
                {
                    ClienteId = (int)cmbClientes.SelectedValue,
                    VestidoId = (int)cmbVestidos.SelectedValue,
                    FechaReserva = dtpFechaReserva.Value.Date,
                    FechaExpiracion = dtpFechaExpiracion.Value.Date,
                    MontoReservado = decimal.Parse(txtMonto.Text),
                    Estado = cmbEstado.SelectedItem.ToString()
                };

                reservaBusiness.Agregar(reserva);
                MessageBox.Show("Reserva registrada con éxito.");

                RefrescarGrilla();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private VestidoBusiness vestidoBusiness = new VestidoBusiness();

        private void FormReservas_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar clientes
                cmbClientes.DataSource = clienteBusiness.Listar();
                cmbClientes.DisplayMember = "Nombre, Apellido"; // Usar ToString() override
                cmbClientes.ValueMember = "Id";

                // Cargar vestidos disponibles
                cmbVestidos.DataSource = vestidoBusiness.Listar();
                cmbVestidos.DisplayMember = "Nombre"; // Cambiar si tu clase tiene otro nombre
                cmbVestidos.ValueMember = "Id";

                // Estado manual
                cmbEstado.Items.Add("Activa");
                cmbEstado.Items.Add("Anulada");
                cmbEstado.Items.Add("Expirada");

                RefrescarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void RefrescarGrilla()
        {
            var reservas = reservaBusiness.Listar();

            var reservasAMostrar = reservas.Select(r => new
            {
                r.Id,
                r.ClienteId,
                r.VestidoId,
                r.FechaReserva,
                r.FechaExpiracion,
                r.MontoReservado,
                r.Estado,
             
            }).ToList();

            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservasAMostrar;
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
