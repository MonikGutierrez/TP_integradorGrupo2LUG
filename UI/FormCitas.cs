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
        private ClienteBusiness clienteBusiness = new ClienteBusiness();



        public FormCitas()
        {
            InitializeComponent();
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarCombos()
        {
            try
            {
                cmbClientes.DataSource = clienteBusiness.ListarTodo();
                cmbClientes.DisplayMember = "NombreCompleto";
                cmbClientes.ValueMember = "Id";
                cmbClientes.SelectedIndex = -1;

                cmbEstadoCita.Items.AddRange(new string[] { "Pendiente", "Confirmada", "Cancelada", "Realizada", "Finalizada", "No asistió" });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarGrilla()
        {
            try
            {
                // Cargar datos
                dgvCitas.DataSource = null;
                dgvCitas.DataSource = citaBusiness.ListarTodo();

                // Fuente general
                var fuenteGeneral = new Font("Segoe UI", 10, FontStyle.Regular);

                // Estilo general
                dgvCitas.DefaultCellStyle.Font = fuenteGeneral;
                dgvCitas.RowsDefaultCellStyle.Font = fuenteGeneral;
                dgvCitas.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvCitas.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvCitas.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvCitas.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvCitas.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
                dgvCitas.GridColor = Color.LightGray;

                // Configuración general
                dgvCitas.RowHeadersVisible = false;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.AllowUserToAddRows = false;
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Estilo encabezado
                dgvCitas.EnableHeadersVisualStyles = false;
                dgvCitas.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgvCitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvCitas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvCitas.ColumnHeadersHeight = 30;

                // Limpiar selección inicial
                dgvCitas.ClearSelection();

                // Forzar fuente en cada columna
                foreach (DataGridViewColumn col in dgvCitas.Columns)
                {
                    col.DefaultCellStyle.Font = fuenteGeneral;
                }

                // Forzar fuente celda por celda (previene glitch visual con texto en mayúscula)
                dgvCitas.CellFormatting -= dgvCitas_CellFormatting; // Por las dudas, evita doble suscripción
                dgvCitas.CellFormatting += dgvCitas_CellFormatting;

                // Ocultar columnas internas
                if (dgvCitas.Columns.Contains("Cliente"))
                    dgvCitas.Columns["Cliente"].Visible = false;

                if (dgvCitas.Columns.Contains("ProductoId"))
                    dgvCitas.Columns["ProductoId"].Visible = false;

                if (dgvCitas.Columns.Contains("Producto"))
                    dgvCitas.Columns["Producto"].Visible = false;

                // Renombrar columnas visibles
                if (dgvCitas.Columns.Contains("NombreCliente"))
                    dgvCitas.Columns["NombreCliente"].HeaderText = "Cliente";

                if (dgvCitas.Columns.Contains("FechaHora"))
                    dgvCitas.Columns["FechaHora"].HeaderText = "Fecha y Hora";

                if (dgvCitas.Columns.Contains("TipoEstado"))
                    dgvCitas.Columns["TipoEstado"].HeaderText = "Estado";

                if (dgvCitas.Columns.Contains("Observaciones"))
                    dgvCitas.Columns["Observaciones"].HeaderText = "Observaciones";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar la grilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientes.SelectedItem == null)
                    throw new Exception("No ha seleccionado un cliente.");

                if (cmbEstadoCita.SelectedItem == null)
                    throw new Exception("No ha seleccionado un estado para la cita.");

                if (dtpFechaHora.Value < DateTime.Now)
                    throw new Exception("Las citas deben ser programadas con por lo menos 24 hs. de antelación.");

                Cita nuevaCita = new Cita
                {
                    ClienteId = (int)cmbClientes.SelectedValue,
                    FechaHora = dtpFechaHora.Value,
                    TipoEstado = cmbEstadoCita.SelectedItem.ToString(),
                    Observaciones = txtObservaciones.Text

                };

                citaBusiness.Agregar(nuevaCita);
                MessageBox.Show("Cita registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            try
            {
                Cita citaSeleccionada = (Cita)dgvCitas.CurrentRow?.DataBoundItem;
                if (citaSeleccionada == null || citaSeleccionada.Id <= 0)
                {
                    MessageBox.Show("Seleccione una cita para modificar desde la grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbClientes.SelectedItem == null || cmbEstadoCita.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un estado de cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                {
                    citaSeleccionada.Id = Convert.ToInt32(lblId.Text);
                    citaSeleccionada.ClienteId = ((Cliente)cmbClientes.SelectedItem).Id;
                    citaSeleccionada.FechaHora = dtpFechaHora.Value;
                    citaSeleccionada.TipoEstado = cmbEstadoCita.SelectedItem.ToString();
                    citaSeleccionada.Observaciones = txtObservaciones.Text;

                    citaBusiness.Modificar(citaSeleccionada);

                }

                MessageBox.Show("Cita modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
                citaSeleccionada = null; // Resetear la cita seleccionada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCitas.SelectedRows.Count > 0)
                {
                    Cita citaSeleccionada = (Cita)dgvCitas.SelectedRows[0].DataBoundItem;
                    lblId.Text = citaSeleccionada.Id.ToString();
                    cmbClientes.SelectedValue = citaSeleccionada.ClienteId;
                    dtpFechaHora.Value = citaSeleccionada.FechaHora;
                    cmbEstadoCita.SelectedItem = citaSeleccionada.TipoEstado;
                    txtObservaciones.Text = citaSeleccionada.Observaciones ?? string.Empty;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                lblId.Text = "";
                cmbClientes.SelectedIndex = -1;
                dtpFechaHora.Value = DateTime.Now;
                cmbEstadoCita.SelectedIndex = -1;
                txtObservaciones.Text = "";

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione una cita para eliminar desde la grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar esta cita? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                Cita cita = new Cita();
                cita.Id = Convert.ToInt32(lblId.Text);

                citaBusiness.Eliminar(cita);
                MessageBox.Show("Cita eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCita_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                MessageBox.Show("Campos limpiados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar campos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var fuente = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvCitas.Rows[e.RowIndex].DefaultCellStyle.Font = fuente;
        }
    }

}