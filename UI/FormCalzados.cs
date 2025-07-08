using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FormCalzados : Form {
        private CalzadoBusiness calzadoBusiness = new CalzadoBusiness();
        private Calzado calzadoSeleccionado;

        public FormCalzados() {
            InitializeComponent();
        }

        private void FormCalzados_Load(object sender, EventArgs e) {
            CargarGrilla();
        }

        private void CargarGrilla() {
            dgvCalzados.DataSource = null;
            dgvCalzados.DataSource = calzadoBusiness.Listar();
            dgvCalzados.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                Calzado nuevo = new Calzado() {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Modelo = txtModelo.Text,
                    Color = txtColor.Text,
                    Temporada = txtTemporada.Text,
                    Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : -1,
                    Stock = int.TryParse(txtStock.Text, out int stock) ? stock : -1,
                    FechaCreacion = DateTime.Now,
                    FechaUltimaModificacion = DateTime.Now,
                    Numero = decimal.TryParse(txtNumero.Text, out decimal numero) ? numero : -1,
                    Categoria = txtCategoria.Text,
                    StockMinimo = int.TryParse(txtStockMinimo.Text, out int stockMinimo) ? stockMinimo : -1
                };

                calzadoBusiness.Agregar(nuevo);
                MessageBox.Show("Calzado agregado correctamente");
                LimpiarCampos();
                CargarGrilla();
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (calzadoSeleccionado == null) {
                MessageBox.Show("Seleccione un calzado para modificar.");
                return;
            }

            try {
                calzadoSeleccionado.Nombre = txtNombre.Text;
                calzadoSeleccionado.Descripcion = txtDescripcion.Text;
                calzadoSeleccionado.Modelo = txtModelo.Text;
                calzadoSeleccionado.Color = txtColor.Text;
                calzadoSeleccionado.Temporada = txtTemporada.Text;
                calzadoSeleccionado.Precio = decimal.Parse(txtPrecio.Text);
                calzadoSeleccionado.Stock = int.Parse(txtStock.Text);
                calzadoSeleccionado.FechaUltimaModificacion = DateTime.Now;
                calzadoSeleccionado.Numero = decimal.Parse(txtNumero.Text);
                calzadoSeleccionado.Categoria = txtCategoria.Text;
                calzadoSeleccionado.StockMinimo = int.Parse(txtStockMinimo.Text);

                calzadoBusiness.Modificar(calzadoSeleccionado);
                MessageBox.Show("Calzado modificado correctamente");
                LimpiarCampos();
                CargarGrilla();
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (calzadoSeleccionado == null) {
                MessageBox.Show("Seleccione un calzado para eliminar.");
                return;
            }

            var confirmar = MessageBox.Show("¿Está seguro de eliminar el calzado?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes) {
                calzadoBusiness.Eliminar(calzadoSeleccionado.Id);
                MessageBox.Show("Calzado eliminado correctamente");
                LimpiarCampos();
                CargarGrilla();
            }
        }

        private void dgvCalzados_SelectionChanged(object sender, EventArgs e) {
            if (dgvCalzados.SelectedRows.Count > 0) {
                calzadoSeleccionado = (Calzado)dgvCalzados.SelectedRows[0].DataBoundItem;
                txtNombre.Text = calzadoSeleccionado.Nombre;
                txtDescripcion.Text = calzadoSeleccionado.Descripcion;
                txtModelo.Text = calzadoSeleccionado.Modelo;
                txtColor.Text = calzadoSeleccionado.Color;
                txtTemporada.Text = calzadoSeleccionado.Temporada;
                txtPrecio.Text = calzadoSeleccionado.Precio.ToString();
                txtStock.Text = calzadoSeleccionado.Stock.ToString();
                txtNumero.Text = calzadoSeleccionado.Numero.ToString();
                txtCategoria.Text = calzadoSeleccionado.Categoria;
                txtStockMinimo.Text = calzadoSeleccionado.StockMinimo.ToString();
            }
        }

        private void LimpiarCampos() {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtTemporada.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNumero.Text = "";
            txtCategoria.Text = "";
            txtStockMinimo.Text = "";
            calzadoSeleccionado = null;
        }

        private void btnLimpiarCalzado_Click(object sender, EventArgs e) {
            try {
                LimpiarCampos();
            } catch (Exception ex) {
                MessageBox.Show(
                    "Ocurrió un error al limpiar los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void label11_Click(object sender, EventArgs e) {

        }
    }
}
