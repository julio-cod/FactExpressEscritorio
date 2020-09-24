using FactExpressDesktop.Clases;
using FactExpressDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactExpressDesktop.Presentacion
{
    public partial class frmCategorias : Form
    {
        DataCategoria dCategoria = new DataCategoria();
        int codigo;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategoriassAll();
        }
        public void cargarCategoriassAll()
        {

            dCategoria.listarCategoriasAll(dgvCategorias);

        }
        public void desabilitar_textbox()
        {

            txtNombreCategoria.Enabled = false;

        }
        public void habilitar_textbox()
        {

            txtNombreCategoria.Enabled = true;

        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            txtNombreCategoria.Text = "";

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar_textbox();
            btnGuardar.Visible = true;
            btnnuevo.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btbcancelar.Enabled = true;
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            desabilitar_textbox();
            btnGuardar.Visible = false;
            btnnuevo.Visible = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btbcancelar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                CategoriaModel categoriaModel = new CategoriaModel
                {
                    NombreCategoria = txtNombreCategoria.Text

                };

                if (dCategoria.guardarCategoria(categoriaModel) == true)
                {
                    cargarCategoriassAll();

                    limpiar();

                    desabilitar_textbox();
                    btnGuardar.Visible = false;
                    btnnuevo.Visible = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btbcancelar.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Error al guardar datos");
                }



            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "" || txtCodigo.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                CategoriaModel categoriaModel = new CategoriaModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    NombreCategoria = txtNombreCategoria.Text

                };

                if (dCategoria.EditarCategoria(categoriaModel) == true)
                {
                    cargarCategoriassAll();

                    limpiar();

                    desabilitar_textbox();
                    btnGuardar.Visible = false;
                    btnnuevo.Visible = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btbcancelar.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Error al editar datos");
                }

            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = (int)dgvCategorias.Rows[e.RowIndex].Cells[0].Value;
                txtCodigo.Text = dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreCategoria.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();

                habilitar_textbox();
                btnGuardar.Visible = false;
                btnnuevo.Visible = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btbcancelar.Enabled = true;
            }
            catch (Exception)
            {

            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar esta Categoria?", "Eliminar Categoria", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dCategoria.EliminarCategoria(codigo) == true)
                {
                    cargarCategoriassAll();

                    limpiar();

                    desabilitar_textbox();

                    btnGuardar.Visible = false;
                    btnnuevo.Visible = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btbcancelar.Enabled = false;

                }

                else
                {
                    MessageBox.Show("error Eliminando La Categoria");
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {
                limpiar();

                desabilitar_textbox();
                btnGuardar.Visible = false;
                btnnuevo.Visible = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btbcancelar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dCategoria.Buscar = txtBuscar.Text;
                dCategoria.BuscarCategoriaPorNombre(dgvCategorias);
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                btnBuscar.Enabled = true;
                dCategoria.Buscar = txtBuscar.Text;
                dCategoria.BuscarCategoriaPorNombre(dgvCategorias);
            }
            else
            {
                btnBuscar.Enabled = false;
                cargarCategoriassAll();
            }
        }
    }
}
