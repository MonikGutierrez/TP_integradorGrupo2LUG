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
        }

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
