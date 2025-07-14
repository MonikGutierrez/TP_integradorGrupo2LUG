using System;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormCalzados : Form
    {
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private CalzadoBusiness calzadoBusiness = new CalzadoBusiness();


        public FormCalzados()
        {
            InitializeComponent();
        }

        private void FormCalzados_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                // PRIMERO: Cargar datos
                var listaCalzados = productoBusiness.ListarTodoCalzado();
                dgvCalzados.DataSource = null;
                dgvCalzados.DataSource = listaCalzados;

                // Estilo general
                dgvCalzados.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvCalzados.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvCalzados.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvCalzados.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvCalzados.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvCalzados.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;

                // Configuración general
                dgvCalzados.RowHeadersVisible = false;
                dgvCalzados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCalzados.AllowUserToAddRows = false;
                dgvCalzados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // AHORA: Encabezados visuales
                dgvCalzados.EnableHeadersVisualStyles = false;
                dgvCalzados.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgvCalzados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvCalzados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvCalzados.ColumnHeadersHeight = 30;

                // Limpiar selección inicial
                dgvCalzados.ClearSelection();

                // Ocultar columnas innecesarias
                if (dgvCalzados.Columns.Contains("Id"))
                    dgvCalzados.Columns["Id"].Visible = false;

                if (dgvCalzados.Columns.Contains("ProductoCompleto"))
                    dgvCalzados.Columns["ProductoCompleto"].Visible = false;

                if (dgvCalzados.Columns.Contains("Id"))
                    dgvCalzados.Columns["Id"].Visible = false;

                // Renombrar encabezados
                if (dgvCalzados.Columns.Contains("Numero"))
                    dgvCalzados.Columns["Numero"].HeaderText = "Número";

                if (dgvCalzados.Columns.Contains("StockMinimo"))
                    dgvCalzados.Columns["StockMinimo"].HeaderText = "Stock Mínimo";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los calzados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Calzado nuevo = new Calzado
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Modelo = cmbModelo.Text,
                    Categoria = cmbCategoria.Text,
                    Temporada = cmbTemporada.Text,
                    Color = txtColor.Text,
                    Numero = Convert.ToDecimal(cmbNumero.Text),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    StockMinimo = Convert.ToInt32(txtStockMinimo.Text),
                    FechaCreacion = DateTime.Now,
                };

                calzadoBusiness.Agregar(nuevo);
                MessageBox.Show("Calzado agregado correctamente.");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar calzado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un calzado para modificar.");
                    return;
                }

                Calzado calzadoNuevo = new Calzado();
                calzadoNuevo.Id = Convert.ToInt32(lblId.Text);
                calzadoNuevo.Nombre = txtNombre.Text;
                calzadoNuevo.Descripcion = txtDescripcion.Text;
                calzadoNuevo.Modelo = cmbModelo.Text;
                calzadoNuevo.Categoria = cmbCategoria.Text;
                calzadoNuevo.Temporada = cmbTemporada.Text;
                calzadoNuevo.Color = txtColor.Text;
                calzadoNuevo.Numero = Convert.ToDecimal(cmbNumero.Text);
                calzadoNuevo.Precio = Convert.ToDecimal(txtPrecio.Text);
                calzadoNuevo.Stock = Convert.ToInt32(txtStock.Text);
                calzadoNuevo.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);

                calzadoBusiness.Modificar(calzadoNuevo);
                MessageBox.Show("Calzado modificado correctamente.");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar calzado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un calzado para eliminar.");
                    return;

                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el calzado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Calzado calzado = dgvCalzados.SelectedRows[0].DataBoundItem as Calzado;
                        calzadoBusiness.Eliminar(calzado);
                        MessageBox.Show("Calzado eliminado correctamente.");
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

        private void btnLimpiarCalzado_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                cmbCategoria.SelectedIndex = -1;
                cmbTemporada.SelectedIndex = -1;
                cmbNumero.SelectedIndex = -1;
                cmbModelo.SelectedIndex = -1;
                txtColor.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
                txtStockMinimo.Text = "";

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void CargarCombos()
        {
            try
            {
                cmbNumero.Items.AddRange(new string[] { "35", "36", "37", "38", "39", "40", "41", "42", "43" });
                cmbNumero.SelectedIndex = -1;

                cmbCategoria.Items.AddRange(new string[] { "Bota", "Borcegos", "Sandalias", "Zapatilla", "Zapatos" });
                cmbCategoria.SelectedIndex = -1;

                cmbTemporada.Items.AddRange(new string[] { "Primavera", "Verano", "Otoño", "Invierno" });
                cmbTemporada.SelectedIndex = -1;

                cmbModelo.Items.AddRange(new string[] { "Bota caña alta", "Bota media caña", "Borcegos altos", "Borcegos caña corta", "Sandalias fiesta", "Sandalias Estilo urbano", "Zapatilla urbana", "Zapatos oficina", "Zapatos fiesta" });
                cmbModelo.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combobox en el formulario: " + ex.Message);
            }

        }

        private void dgvCalzados_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCalzados.SelectedRows.Count > 0)
                {
                    Calzado calzadoSeleccionado = (Calzado)dgvCalzados.SelectedRows[0].DataBoundItem;
                    lblId.Text = calzadoSeleccionado.Id.ToString();
                    txtNombre.Text = calzadoSeleccionado.Nombre;
                    txtDescripcion.Text = calzadoSeleccionado.Descripcion ?? "";
                    cmbModelo.Text = calzadoSeleccionado.Modelo ?? "";
                    cmbCategoria.Text = calzadoSeleccionado.Categoria;
                    cmbTemporada.Text = calzadoSeleccionado.Temporada ?? "";
                    txtColor.Text = calzadoSeleccionado.Color ?? "";
                    cmbNumero.Text = calzadoSeleccionado.Numero.ToString();
                    txtPrecio.Text = calzadoSeleccionado.Precio.ToString();
                    txtStock.Text = calzadoSeleccionado.Stock.ToString();
                    txtStockMinimo.Text = calzadoSeleccionado.StockMinimo.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar calzado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}