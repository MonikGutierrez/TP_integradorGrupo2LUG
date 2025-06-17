using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Load += FormPrincipal_Load;
            btnClientes.Click += btnClientes_Click;
            btnVestidos.Click += btnVestidos_Click;
            btnCalzado.Click += btnCalzados_Click;
            btnVentas.Click += btnVentas_Click;
            btnReservas.Click += btnReservas_Click;
            btnCitas.Click += btnCitas_Click;
            btnPagos.Click += btnPagos_Click;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Código opcional al cargar la app
        }

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
    }

}
