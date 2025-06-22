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
            FormClientes form = new FormClientes();
            form.ShowDialog();
        }

        private void btnVestidos_Click(object sender, EventArgs e)
        {
            FormVestidos form = new FormVestidos();
            form.ShowDialog();
        }

        private void btnCalzados_Click(object sender, EventArgs e)
        {
            FormCalzados form = new FormCalzados();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas form = new FormVentas();
            form.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas form = new FormReservas();
            form.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FormCitas form = new FormCitas();
            form.ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FormPagos form = new FormPagos();
            form.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock form = new FormStock();
            form.ShowDialog();
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
