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
    public partial class frmProductos : Form
    {
        DataProducto dProducto = new DataProducto();
        int codigo;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargarProductosAll();
        }

        public void cargarProductosAll()
        {

            dProducto.listarProductosAll(dgvProductos);
            cargarComboboxCategorias();
        }

        public void cargarComboboxCategorias()
        {
            cbbCategorias.DataSource = dProducto.CargarComboboxCategorias();
            cbbCategorias.DisplayMember = "nombreCategoria";
            cbbCategorias.ValueMember = "codigo";

        }

        public void desabilitar_textbox()
        {

            txtDescripcion.Enabled = false;
            cbbCategorias.Enabled = false;
            txtStock.Enabled = false;
            txtCosto.Enabled = false;
            txtPrecio.Enabled = false;

        }
        public void habilitar_textbox()
        {
            txtDescripcion.Enabled = true;
            cbbCategorias.Enabled = true;
            txtStock.Enabled = true;
            txtCosto.Enabled = true;
            txtPrecio.Enabled = true;

        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cbbCategorias.Text = "";
            txtStock.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbbCategorias.Text == "")
            {
                cbbCategorias.Text = "Ninguna";
            }
            if (txtDescripcion.Text == "" || cbbCategorias.Text == "" || cbbCategorias.Text == "" || txtStock.Text == "" || txtCosto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                ProductoModel productoModel = new ProductoModel
                {
                    Descripcion = txtDescripcion.Text,
                    Categoria = cbbCategorias.Text,
                    Stock = int.Parse(txtStock.Text),
                    Costo = decimal.Parse(txtCosto.Text),
                    Precio = decimal.Parse(txtPrecio.Text)

                };

                if (dProducto.guardarProducto(productoModel) == true)
                {
                    cargarProductosAll();

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
            if (cbbCategorias.Text == "")
            {
                cbbCategorias.Text = "Ninguna";
            }
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || cbbCategorias.Text == "" || cbbCategorias.Text == "" || txtStock.Text == "" || txtCosto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                ProductoModel productoModel = new ProductoModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    Descripcion = txtDescripcion.Text,
                    Categoria = cbbCategorias.Text,
                    Stock = int.Parse(txtStock.Text),
                    Costo = decimal.Parse(txtCosto.Text),
                    Precio = decimal.Parse(txtPrecio.Text)

                };
                

                if (dProducto.EditarProducto(productoModel) == true)
                {
                    cargarProductosAll();

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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = (int)dgvProductos.Rows[e.RowIndex].Cells[0].Value;
                txtCodigo.Text = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbCategorias.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCosto.Text = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();

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
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar este Producto?", "Eliminar Sector", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dProducto.EliminarProducto(codigo) == true)
                {
                    cargarProductosAll();

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
                    MessageBox.Show("error Eliminando El Sector");
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
            if (cbbBuscarPor.Text == "Descripcion")
            {
                if (txtBuscar.Text != "")
                {
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorDescripcion(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
            else if (cbbBuscarPor.Text == "Codigo")
            {
                if (txtBuscar.Text != "")
                {
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorCodigo(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }

            }
            else if (cbbBuscarPor.Text == "Categoria")
            {
                if (txtBuscar.Text != "")
                {
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorCategoria(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
            else
            {
                cbbBuscarPor.Text = "Descripcion";
                if (txtBuscar.Text != "")
                {
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorDescripcion(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbbBuscarPor.Text == "Descripcion")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorDescripcion(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProductosAll();
                }
            }
            else if (cbbBuscarPor.Text == "Codigo")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorCodigo(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProductosAll();
                }
            }
            else if (cbbBuscarPor.Text == "Categoria")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorCategoria(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProductosAll();
                }
            }
            else
            {
                cbbBuscarPor.Text = "Descripcion";
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dProducto.Buscar = txtBuscar.Text;
                    dProducto.BuscarProductoPorDescripcion(dgvProductos);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProductosAll();
                }
            }
        }

        private void cbbCategorias_Click(object sender, EventArgs e)
        {
            string categoria = cbbCategorias.Text;
            cargarComboboxCategorias();
            cbbCategorias.Text = categoria;
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

        private void btnBuscformCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias fc = new frmCategorias();
            fc.ShowDialog();
        }
    }
}
