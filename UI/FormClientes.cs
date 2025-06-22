using System;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormClientes : Form
    {
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private Cliente clienteSeleccionado;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteBusiness.Listar();
            dgvClientes.ClearSelection();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //renombro encabezados
            dgvClientes.Columns[0].HeaderText = "Código";          // primera columna
            dgvClientes.Columns[dgvClientes.Columns.Count - 1].HeaderText = "Fecha Registro"; // última

            // Selecciona siempre la fila completa al hacer clic en cualquier celda
            this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Desactivo que se puedan seleccionar varias filas a la vez
            this.dgvClientes.MultiSelect = false;

            // Fuerza Courier New en todas las celdas (filas pares e impares)
            this.dgvClientes.DefaultCellStyle.Font =
                new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular,
                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.AlternatingRowsDefaultCellStyle.Font =
                new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular,
                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // --- Selección con mismo resaltado en TODAS las filas ---
            dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;
            dgvClientes.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvClientes.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Silver;
            dgvClientes.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 0, 0);

            // Fuerza Courier New en encabezados
            this.dgvClientes.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold,
                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        #region ABM + Clean
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    FechaRegistro = DateTime.Now
                };

                clienteBusiness.Agregar(nuevo);
                MessageBox.Show("Cliente agregado correctamente");
                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
                return;
            }

            try
            {
                clienteSeleccionado.Nombre = txtNombre.Text;
                clienteSeleccionado.Apellido = txtApellido.Text;
                clienteSeleccionado.Email = txtEmail.Text;
                clienteSeleccionado.Telefono = txtTelefono.Text;

                clienteBusiness.Modificar(clienteSeleccionado);
                MessageBox.Show("Cliente modificado correctamente");
                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            var confirmar = MessageBox.Show("¿Está seguro de eliminar al cliente?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                clienteBusiness.Eliminar(clienteSeleccionado.Id);
                MessageBox.Show("Cliente eliminado correctamente");
                LimpiarCampos();
                CargarGrilla();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtApellido.Text = clienteSeleccionado.Apellido;
                txtEmail.Text = clienteSeleccionado.Email;
                txtTelefono.Text = clienteSeleccionado.Telefono;
            }
        }

        #endregion

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            clienteSeleccionado = null;
        }


    }
}
