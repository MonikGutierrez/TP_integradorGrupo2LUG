using BLL;
using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Reflection;
using System.Windows.Forms;


namespace UI
{
    public partial class FormVestidos : Form {
        private VestidoBusiness negocio = new VestidoBusiness();
        private Vestido vestidoSeleccionado;

        public FormVestidos() {
            InitializeComponent();
        }

        private void FormVestidos_Load(object sender, EventArgs e) {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] {
                "DISPONIBLE", "RESERVADO", "EN AJUSTE", "VENDIDO", "DEVUELTO", "EN LAVADO", "EN REVISIÓN", "DADO DE BAJA"
            });

            cmbTalle.Items.Clear();
            cmbTalle.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL" });

            cmbTemporada.Items.Clear();
            cmbTemporada.Items.AddRange(new string[] { "Primavera-Verano", "Otoño-Invierno" });

            cmbModelo.Items.Clear();
            cmbModelo.Items.AddRange(new string[] {
                "Vestido de Gala", "Vestido de Coctel", "Vestido Largo Elegante",
                "Vestido Corto para Eventos", "Vestido Casual Urbano", "Vestido de Novia"
            });

            CargarGrilla();
        }

        private void CargarGrilla() {
            dgvVestidos.DataSource = null;
            dgvVestidos.DataSource = negocio.Listar();
            dgvVestidos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                Vestido nuevo = new Vestido {
                    Nombre = txtNombreVest.Text,
                    Estado = cmbEstado.Text,
                    Descripcion = txtDescripcionVestido.Text,
                    Modelo = cmbModelo.Text,
                    Color = txtColor.Text,
                    Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : 0,
                    Temporada = cmbTemporada.Text,
                    Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                    Talle = cmbTalle.Text,
                    Disenador = txtDisenador.Text,
                    TiempoAjusteHoras = int.TryParse(txtHorasAjuste.Text, out int horas) ? horas : 0,
                    EsUnico = ckbSi.Checked,
                    FechaUltimoAjuste = dtpUltimoAjuste.Value
                };

                negocio.Agregar(nuevo);
                MessageBox.Show("Vestido agregado correctamente");
                LimpiarCampos();
                CargarGrilla();
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (vestidoSeleccionado == null) {
                MessageBox.Show("Seleccione un vestido para modificar.");
                return;
            }

            try {
                vestidoSeleccionado.Nombre = txtNombreVest.Text;
                vestidoSeleccionado.Estado = cmbEstado.Text;
                vestidoSeleccionado.Descripcion = txtDescripcionVestido.Text;
                vestidoSeleccionado.Modelo = cmbModelo.Text;
                vestidoSeleccionado.Color = txtColor.Text;
                vestidoSeleccionado.Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : 0;
                vestidoSeleccionado.Temporada = cmbTemporada.Text;
                vestidoSeleccionado.Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0;
                vestidoSeleccionado.Talle = cmbTalle.Text;
                vestidoSeleccionado.Disenador = txtDisenador.Text;
                vestidoSeleccionado.TiempoAjusteHoras = int.TryParse(txtHorasAjuste.Text, out int h) ? h : 0;
                vestidoSeleccionado.EsUnico = ckbSi.Checked;
                vestidoSeleccionado.FechaUltimoAjuste = dtpUltimoAjuste.Value;

                negocio.Modificar(vestidoSeleccionado);
                MessageBox.Show("Vestido modificado correctamente");
                LimpiarCampos();
                CargarGrilla();
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (vestidoSeleccionado == null) {
                MessageBox.Show("Seleccione un vestido para eliminar.");
                return;
            }

            var confirmar = MessageBox.Show("¿Está segura de eliminar el vestido?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes) {
                try {
                    negocio.Eliminar(vestidoSeleccionado.Id);
                    MessageBox.Show("Vestido eliminado correctamente.");
                    LimpiarCampos();
                    CargarGrilla();
                } catch (SqlException ex) when (ex.Number == 547) // FK constraint error
                  {
                    MessageBox.Show("No se puede eliminar el vestido porque está asociado a una reserva.", "Error");
                } catch (Exception ex) {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }


        private void dgvVestidos_SelectionChanged(object sender, EventArgs e) {
            if (dgvVestidos.SelectedRows.Count > 0) {
                vestidoSeleccionado = (Vestido)dgvVestidos.SelectedRows[0].DataBoundItem;
                txtNombreVest.Text = vestidoSeleccionado.Nombre;
                cmbEstado.Text = vestidoSeleccionado.Estado;
                txtDescripcionVestido.Text = vestidoSeleccionado.Descripcion;
                cmbModelo.Text = vestidoSeleccionado.Modelo;
                txtColor.Text = vestidoSeleccionado.Color;
                txtPrecio.Text = vestidoSeleccionado.Precio.ToString();
                cmbTemporada.Text = vestidoSeleccionado.Temporada;
                txtStock.Text = vestidoSeleccionado.Stock.ToString();
                cmbTalle.Text = vestidoSeleccionado.Talle;
                txtDisenador.Text = vestidoSeleccionado.Disenador;
                txtHorasAjuste.Text = vestidoSeleccionado.TiempoAjusteHoras.ToString();
                dtpUltimoAjuste.Value = vestidoSeleccionado.FechaUltimoAjuste ?? DateTime.Now;
                ckbSi.Checked = vestidoSeleccionado.EsUnico;
            }
        }

        private void LimpiarCampos() {
            cmbModelo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbTemporada.SelectedIndex = -1;
            cmbTalle.SelectedIndex = -1;
            txtDisenador.Clear();
            txtHorasAjuste.Clear();
            txtColor.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombreVest.Clear();
            txtDescripcionVestido.Clear();
            ckbSi.Checked = false;
            dtpUltimoAjuste.Value = DateTime.Now;
            vestidoSeleccionado = null;
        }

        private void btnLimpiarVestidos_Click(object sender, EventArgs e) {
            LimpiarCampos();
        }
    }
}
