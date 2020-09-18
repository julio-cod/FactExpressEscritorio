using FactExpressDesktop.Clases;
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
    public partial class frmConsultaProductoDesdePedido : Form
    {
        DataProducto dProducto = new DataProducto();

        public delegate void pasarDatosProducto(string codigoProducto, string descripcion, string categoria, string precio);
        public event pasarDatosProducto pasadoProducto;

        public frmConsultaProductoDesdePedido()
        {
            InitializeComponent();
        }

        private void frmConsultaProductoDesdePedido_Load(object sender, EventArgs e)
        {
            cargarProductosAll();
        }

        public void cargarProductosAll()
        {

            dProducto.listarProductosAll(dgvProductos);
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

        private void btnBuscarFormProductos_Click(object sender, EventArgs e)
        {
            frmProductos fp = new frmProductos();
            fp.ShowDialog();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoProducto, descripcion, categoria, precio;

            try
            {
                codigoProducto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                descripcion = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                categoria = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                precio = dgvProductos.CurrentRow.Cells[5].Value.ToString();                

                pasadoProducto(codigoProducto, descripcion, categoria, precio);

                this.Close();

            }
            catch (Exception)
            {
                this.Close();

            }
        }
    }
}
