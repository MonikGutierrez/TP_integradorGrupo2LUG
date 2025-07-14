using System;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormVestidos : Form
    {
        private VestidoBusiness vestidoBusiness = new VestidoBusiness();
        private ProductoBusiness productoBusiness = new ProductoBusiness();


        public FormVestidos()
        {

            InitializeComponent();
            dgvVestidos.SelectionChanged += dgvVestidos_SelectionChanged; //Asegiramos el evento
        }

        private void FormVestidos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void CargarCombos()
        {
            try
            {
                cmbTalle.Items.AddRange(new string[] { "S", "M", "L", "XL", "XXL" });
                cmbTalle.SelectedIndex = -1;

                cmbModelo.Items.AddRange(new string[] { "Corte A", "Sirena", "Imperio", "Princesa", "Recto" });
                cmbModelo.SelectedIndex = -1;

                cmbTemporada.Items.AddRange(new string[] { "Primavera", "Verano", "Otoño", "Invierno" });
                cmbTemporada.SelectedIndex = -1;

                cmbEstado.Items.AddRange(new string[] { "Disponible", "Reservado", "En ajuste", "Vendido" });
                cmbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combobox en el formulario: " + ex.Message);
            }

        }

        private void CargarGrilla()
        {
            try
            {
                // Cargar datos
                var listaVestidos = productoBusiness.ListarTodoVestido();
                dgvVestidos.DataSource = null;
                dgvVestidos.DataSource = listaVestidos;

                // Estilo general
                dgvVestidos.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvVestidos.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvVestidos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvVestidos.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvVestidos.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvVestidos.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;

                // Configuración general
                dgvVestidos.RowHeadersVisible = false;
                dgvVestidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvVestidos.AllowUserToAddRows = false;
                dgvVestidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Estilo de encabezado
                dgvVestidos.EnableHeadersVisualStyles = false;
                dgvVestidos.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgvVestidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvVestidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvVestidos.ColumnHeadersHeight = 30;

                // Limpiar selección inicial
                dgvVestidos.ClearSelection();

                // Renombrar columnas
                if (dgvVestidos.Columns.Contains("Id"))
                    dgvVestidos.Columns["Id"].HeaderText = "Id";

                if (dgvVestidos.Columns.Contains("Nombre"))
                    dgvVestidos.Columns["Nombre"].HeaderText = "Nombre";

                if (dgvVestidos.Columns.Contains("Descripcion"))
                    dgvVestidos.Columns["Descripcion"].HeaderText = "Descripción";

                if (dgvVestidos.Columns.Contains("Modelo"))
                    dgvVestidos.Columns["Modelo"].HeaderText = "Modelo";

                if (dgvVestidos.Columns.Contains("Color"))
                    dgvVestidos.Columns["Color"].HeaderText = "Color";

                if (dgvVestidos.Columns.Contains("Temporada"))
                    dgvVestidos.Columns["Temporada"].HeaderText = "Temporada";

                if (dgvVestidos.Columns.Contains("Talle"))
                    dgvVestidos.Columns["Talle"].HeaderText = "Talle";

                if (dgvVestidos.Columns.Contains("Disenador"))
                    dgvVestidos.Columns["Disenador"].HeaderText = "Diseñador";

                if (dgvVestidos.Columns.Contains("TiempoAjusteHoras"))
                    dgvVestidos.Columns["TiempoAjusteHoras"].HeaderText = "Horas Ajuste";

                if (dgvVestidos.Columns.Contains("FechaUltimaModificacion"))
                    dgvVestidos.Columns["FechaUltimaModificacion"].HeaderText = "Último Ajuste";

                if (dgvVestidos.Columns.Contains("Precio"))
                    dgvVestidos.Columns["Precio"].HeaderText = "Precio (ARS)";

                if (dgvVestidos.Columns.Contains("Estado"))
                    dgvVestidos.Columns["Estado"].HeaderText = "Estado";

                if (dgvVestidos.Columns.Contains("EsUnico"))
                    dgvVestidos.Columns["EsUnico"].HeaderText = "Es único";

                // Ocultar columnas no necesarias
                if (dgvVestidos.Columns.Contains("Stock"))
                    dgvVestidos.Columns["Stock"].Visible = false;

                if (dgvVestidos.Columns.Contains("ProductoCompleto"))
                    dgvVestidos.Columns["ProductoCompleto"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Vestido nuevo = new Vestido
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcionVestido.Text,
                    Modelo = cmbModelo.Text,
                    Color = txtColor.Text,
                    Temporada = cmbTemporada.Text,
                    Talle = cmbTalle.Text,
                    Disenador = txtDisenador.Text,
                    TiempoAjusteHoras = int.Parse(txtHorasAjuste.Text),
                    FechaUltimaModificacion = dtpUltimoAjuste.Value,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Estado = cmbEstado.Text,
                    EsUnico = ckbSi.Checked,
                    Stock = ckbSi.Checked ? 1 : int.Parse(txtStock.Text)
                };

                vestidoBusiness.Agregar(nuevo);
                MessageBox.Show("Vestido agregado correctamente.");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar vestido: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {

                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un vestido para modificar.");
                    return;
                }

                Vestido vestidoNuevo = new Vestido();
                vestidoNuevo.Id = Convert.ToInt32(lblId.Text);
                vestidoNuevo.Nombre = txtNombre.Text;
                vestidoNuevo.Descripcion = txtDescripcionVestido.Text;
                vestidoNuevo.Modelo = cmbModelo.Text;
                vestidoNuevo.Color = txtColor.Text;
                vestidoNuevo.Temporada = cmbTemporada.Text;
                vestidoNuevo.Talle = cmbTalle.Text;
                vestidoNuevo.Disenador = txtDisenador.Text;
                vestidoNuevo.TiempoAjusteHoras = int.Parse(txtHorasAjuste.Text);
                vestidoNuevo.FechaUltimaModificacion = Convert.ToDateTime(dtpUltimoAjuste.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                vestidoNuevo.Precio = decimal.Parse(txtPrecio.Text);
                vestidoNuevo.Estado = cmbEstado.Text;
                vestidoNuevo.EsUnico = ckbSi.Checked;
                vestidoNuevo.Stock = ckbSi.Checked ? 1 : int.Parse(txtStock.Text);

                vestidoBusiness.Modificar(vestidoNuevo);
                MessageBox.Show("Vestido modificado correctamente.");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar vestido: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un vestido para eliminar.");
                    return;

                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el vestido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Vestido vestido = dgvVestidos.SelectedRows[0].DataBoundItem as Vestido;
                        vestidoBusiness.Eliminar(vestido);
                        MessageBox.Show("Vestido eliminado correctamente.");
                        CargarGrilla();
                        LimpiarCampos();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void dgvVestidos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVestidos.SelectedRows.Count > 0)
                {
                    Vestido vestidoSeleccionado = (Vestido)dgvVestidos.SelectedRows[0].DataBoundItem;

                    lblId.Text = vestidoSeleccionado.Id.ToString();
                    txtNombre.Text = vestidoSeleccionado.Nombre;
                    txtDescripcionVestido.Text = vestidoSeleccionado.Descripcion;
                    cmbModelo.Text = vestidoSeleccionado.Modelo;
                    txtColor.Text = vestidoSeleccionado.Color;
                    cmbTemporada.Text = vestidoSeleccionado.Temporada;
                    cmbTalle.Text = vestidoSeleccionado.Talle;
                    txtDisenador.Text = vestidoSeleccionado.Disenador;
                    txtHorasAjuste.Text = vestidoSeleccionado.TiempoAjusteHoras.ToString();
                    dtpUltimoAjuste.Value = vestidoSeleccionado.FechaUltimaModificacion;
                    txtPrecio.Text = vestidoSeleccionado.Precio.ToString();
                    cmbEstado.Text = vestidoSeleccionado.Estado;
                    ckbSi.Checked = vestidoSeleccionado.EsUnico;
                    txtStock.Text = vestidoSeleccionado.Stock.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar vestido: " + ex.Message);
            }
        }

        private void btnLimpiarVestidos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            try
            {
                lblId.Text = "";
                txtNombre.Text = "";
                txtDescripcionVestido.Text = "";
                cmbModelo.SelectedIndex = -1;
                txtColor.Text = "";
                cmbTemporada.SelectedIndex = -1;
                cmbTalle.SelectedIndex = -1;
                txtDisenador.Text = "";
                cmbEstado.SelectedIndex = -1;
                txtHorasAjuste.Text = "";
                dtpUltimoAjuste.Value = DateTime.Now;
                txtPrecio.Text = "";
                txtStock.Text = "";
                ckbSi.Checked = false;
                txtStock.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar el formulario: " + ex.Message);
            }


        }

        private void ckbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSi.Checked)
            {
                txtStock.Text = "1";
                txtStock.Enabled = false;
            }
            else
            {
                txtStock.Enabled = true;
            }
        }

    }
}
