using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        //declaro mi banner
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }


        #region botonera
        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new FormClientes();
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al abrir el formulario de Clientes",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVestidos_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormVestidos form = new FormVestidos();
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al abrir el formulario de Vestidos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnCalzado_Click(object sender, EventArgs e)
        {
            try
            {
                FormCalzados form = new FormCalzados();
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al abrir el formulario de Calzado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormVentas form = new FormVentas();
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al abrir el formulario de Ventas",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            try
            {
                using var form = new FormCitas();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al abrir Citas:\n{ex.Message}\n\n{ex.StackTrace}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnPagos_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormPagos form = new FormPagos();
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al abrir el formulario de Pagos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirmación de salida
                var respuesta = MessageBox.Show(
                    "¿Estás seguro que deseas salir de la aplicación?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    // Cierra todos los formularios y termina la aplicación
                    MessageBox.Show(
                    "Cerrando la aplicación"
                );
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                // En caso de error inesperado, muestro un mensaje amable
                MessageBox.Show(
                    "Ocurrió un error al intentar salir:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }
        }

        #endregion




    }


}
