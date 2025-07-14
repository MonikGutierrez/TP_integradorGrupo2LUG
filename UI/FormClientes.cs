using System;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormClientes : Form
    {
        private ClienteBusiness clienteBusiness = new ClienteBusiness();


        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la lista de clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                // Sobre lo visual:
                dgvClientes.EnableHeadersVisualStyles = false;
                dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvClientes.ColumnHeadersHeight = 30;

                dgvClientes.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvClientes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

                // Color distinto cuando la fila completa está seleccionada:
                dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Color.RosyBrown;
                dgvClientes.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

                dgvClientes.DataSource = null;
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvClientes.RowHeadersVisible = false; // saca el encabezado lateral
                dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona todo el registro
                dgvClientes.AllowUserToAddRows = false; // evita la fila en blanco al final

                //Unifica la fuente general del DataGridView
                dgvClientes.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                dgvClientes.DataSource = clienteBusiness.ListarTodo();
                dgvClientes.ClearSelection();

                // Renombrar encabezados
                dgvClientes.Columns["Id"].HeaderText = "Código";
                dgvClientes.Columns["DNI"].HeaderText = "DNI";
                dgvClientes.Columns["FechaRegistro"].HeaderText = "Fecha Registro";

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text, // Nuevo campo
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    FechaRegistro = DateTime.Now
                };

                clienteBusiness.Agregar(nuevo);
                MessageBox.Show("Cliente agregado correctamente");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un cliente para modificar.");
                    return;
                }

                Cliente clienteNuevo = new Cliente();
                clienteNuevo.Id = Convert.ToInt32(lblId.Text);
                clienteNuevo.Nombre = txtNombre.Text;
                clienteNuevo.Apellido = txtApellido.Text;
                clienteNuevo.DNI = txtDNI.Text; // Nuevo campo
                clienteNuevo.Email = txtEmail.Text;
                clienteNuevo.Telefono = txtTelefono.Text;

                clienteBusiness.Modificar(clienteNuevo);
                MessageBox.Show("Cliente modificado correctamente");
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Seleccione un cliente para eliminar.");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar al cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(lblId.Text);

                clienteBusiness.Eliminar(cliente);
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al limpiar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    Cliente clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                    lblId.Text = clienteSeleccionado.Id.ToString();
                    txtNombre.Text = clienteSeleccionado.Nombre;
                    txtApellido.Text = clienteSeleccionado.Apellido;
                    txtDNI.Text = clienteSeleccionado.DNI;
                    txtEmail.Text = clienteSeleccionado.Email;
                    txtTelefono.Text = clienteSeleccionado.Telefono;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado al seleccionar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            try
            {

                lblId.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDNI.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los campos: " + ex.Message);
            }


        }
    }
}