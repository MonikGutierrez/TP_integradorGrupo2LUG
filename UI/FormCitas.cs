using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using Entity;

namespace UI
{
    public partial class FormCitas : Form
    {
        private CitaBusiness citaBusiness = new CitaBusiness();
        private ReservaBusiness reservaBusiness = new ReservaBusiness();
        private List<Reserva> reservas;

        public FormCitas()
        {
            InitializeComponent();

        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            //  ReservaBusiness reservaBusiness = new ReservaBusiness();
            cmbReservas.DataSource = reservaBusiness.Listar();
            cmbReservas.DisplayMember = "Id"; // o "Descripcion" si agregaste un ToString() personalizado
            cmbReservas.ValueMember = "Id";

            cmbEstadoCita.Items.AddRange(new string[] { "Confirmada", "Cancelada", "Pendiente" });
        }


        private void RefrescarGrilla()
        {
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = citaBusiness.Listar();
        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReservas.SelectedItem == null || cmbEstadoCita.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una reserva y un estado de cita");
                    return;
                }

                var cita = new Cita
                {
                    ReservaId = ((Reserva)cmbReservas.SelectedItem).Id,
                    FechaHora = dtpFechaHora.Value,
                    TipoEstado = cmbEstadoCita.SelectedItem.ToString(),
                    Observaciones = txtObservaciones.Text
                };

                citaBusiness.Agregar(cita);
                MessageBox.Show("Cita registrada con éxito");
                RefrescarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cita: " + ex.Message);
            }
        }


    }

    // Extensión para mostrar algo legible en el ComboBox
    public static class ReservaExtensions
    {
        public static string Descripcion(this Reserva r)
        {
            return $"Reserva #{r.Id} - Cliente: {r.Cliente?.Nombre} {r.Cliente?.Apellido}";
        }
    }
}
