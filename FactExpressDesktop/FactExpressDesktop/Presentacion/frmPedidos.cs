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
    public partial class frmPedidos : Form
    {
        DataPedido dPedido = new DataPedido();
        DataDetallePedido dDetallePedido = new DataDetallePedido();
        string idPedido = "";
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        public void habilitar_textbox()
        {
            txtCodigoCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            txtLugarEntrega.Enabled = true;

            txtCodigoProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtDescuento.Enabled = true;
            txtComentario.Enabled = true;
            dtpFechaEntrega.Enabled = true;

        }

        public void desabilitar_textbox()
        {

            txtCodigoCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtLugarEntrega.Enabled = false;

            txtCodigoProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtDescuento.Enabled = false;
            txtComentario.Enabled = false;
            dtpFechaEntrega.Enabled = false;

        }
        
        public void LimpiarTodo()
        {
            txtCodigoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtLugarEntrega.Text = "";
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            cbbCategoria.Text = "";
            txtCantidad.Text = "1";
            txtPrecio.Text = "0";
            txtDescuento.Text = "0";
            txtGanancia.Text = "0";
            txtTotalDescuento.Text = "0";
            txtTotalGanancia.Text = "0";
            txtComentario.Text = "";
            dtpFechaEntrega.Text = DateTime.Now.ToString();
            dgvDetallePedidos.DataSource = null;

        }

        public void LimpiarProducto()
        {
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            cbbCategoria.Text = "";
            txtCantidad.Text = "1";
            txtPrecio.Text = "0";
            txtDescuento.Text = "0";
            txtGanancia.Text = "0";

        }

        public void ValidarVacios()
        {
            if (txtCodigoCliente.Text == "")
            {
                MessageBox.Show("Seleccione un Cliente");
                return;
            }
            if (txtNombreCliente.Text == "")
            {
                txtNombreCliente.Text = "Vacio";
            }
            if (txtLugarEntrega.Text == "")
            {
                txtLugarEntrega.Text = "Vacio";
            }
            if (txtComentario.Text == "")
            {
                txtComentario.Text = "Vacio";
            }
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "1";
            }

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            //limpiar();
            habilitar_textbox();

            btnNuevoPedido.Enabled = false;
            
            btnGuardarPedido.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnEliminar.Enabled = true;
            btbcancelar.Enabled = true;
            btnBuscarProducto.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultaClienteDesdePedidos fcc = new frmConsultaClienteDesdePedidos();
            fcc.pasadoCliente += new frmConsultaClienteDesdePedidos.pasarDatosCliente(ejecutarDatosCliente);
            fcc.ShowDialog();
            txtCodigoProducto.Focus();

        }

        public void ejecutarDatosCliente(string codigoCliente, string nombreCliente, string lugarEntrega)
        {
            txtCodigoCliente.Text = codigoCliente;
            txtNombreCliente.Text = nombreCliente;
            txtLugarEntrega.Text = lugarEntrega;
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            btnNuevoPedido.Enabled = true;
            btnBuscarCliente.Enabled = false;
            btnBuscarProducto.Enabled = false;
            btnAgregar.Enabled = false;
            desabilitar_textbox();
            LimpiarTodo();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmConsultaProductoDesdePedido fp = new frmConsultaProductoDesdePedido();
            fp.pasadoProducto += new frmConsultaProductoDesdePedido.pasarDatosProducto(ejecutarDatosProducto);
            fp.ShowDialog();
            txtCodigoProducto.Focus();
        }

        public void ejecutarDatosProducto(string codigoProducto, string descripcion, string categoria,string precio)
        {
            txtCodigoProducto.Text = codigoProducto;
            txtDescripcion.Text = descripcion;
            cbbCategoria.Text = categoria;
            txtPrecio.Text = precio;
        }

        List<DetallePedidoModel> ListadoDetallePedido = new List<DetallePedidoModel>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarVacios();



            ListadoDetallePedido.Add(new DetallePedidoModel() {

                //CodPedido = int.Parse(idPedido),
                CodProducto = int.Parse(txtCodigoProducto.Text),
                Descripcion = txtDescripcion.Text,
                Categoria = cbbCategoria.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = decimal.Parse(txtPrecio.Text),
                Descuento = decimal.Parse(txtDescuento.Text),
                Ganancia = decimal.Parse(txtGanancia.Text),
                Fecha = Convert.ToDateTime(dtpFechaActual.Text)

            });

            LimpiarProducto();
            
            dgvDetallePedidos.DataSource = null;
            dgvDetallePedidos.DataSource = new List<DetallePedidoModel>(ListadoDetallePedido);

            dgvDetallePedidos.Columns[0].Visible = false;
            dgvDetallePedidos.Columns[1].Visible = false;
            dgvDetallePedidos.Columns[8].Visible = false;

            dgvDetallePedidos.Columns[2].Width = 100;
            dgvDetallePedidos.Columns[3].Width = 350;
            dgvDetallePedidos.Columns[4].Width = 200;
            dgvDetallePedidos.Columns[5].Width = 100;
            dgvDetallePedidos.Columns[6].Width = 150;
            dgvDetallePedidos.Columns[7].Width = 150;
            dgvDetallePedidos.Columns[9].Width = 200;

            //dgvDetallePedidos.DataSource = new List<DetallePedidoModel>(ListadoDetallePedido);

        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            GuardarPedido(ListadoDetallePedido);


        }

        public void GuardarPedido(List<DetallePedidoModel> ListadoDetallePedido)
        {
            ValidarVacios();

            PedidoModel pedidoModel = new PedidoModel
            {
                CodUsuarioDelSistema = 1,
                CodigoCliente = int.Parse(txtCodigoCliente.Text),
                NombreCliente = txtNombreCliente.Text,
                LugarEntrega = txtLugarEntrega.Text,
                FechaOrden = Convert.ToDateTime(dtpFechaActual.Text),
                FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.Text),
                TotalDescuentos = decimal.Parse(txtDescuento.Text),
                Total = decimal.Parse(txtTotal.Text),
                TotalGanancia = decimal.Parse(txtTotalGanancia.Text),
                Estado = cbbEstadoPedido.Text,
                Comentario = txtComentario.Text

            };


            idPedido = dPedido.CrearPedido(pedidoModel);

            if (idPedido == "" || idPedido == null)
            {
                MessageBox.Show("ERROR AL CREAR EL PEDIDO");
            }
            else
            {
                foreach (var data in ListadoDetallePedido)
                {
                    
                    DetallePedidoModel detallePedidoModel = new DetallePedidoModel
                    {
                        CodPedido = int.Parse(idPedido),
                        CodProducto = data.CodProducto,
                        Descripcion = data.Descripcion,
                        Categoria = data.Categoria,
                        Cantidad = data.Cantidad,
                        Precio = data.Precio,
                        Descuento = data.Descuento,
                        Ganancia = data.Ganancia,
                        Fecha = data.Fecha

                    };

                    dDetallePedido.CrearDetallePedido(detallePedidoModel);

                    

                }

                LimpiarTodo();
                desabilitar_textbox();
                btnNuevoPedido.Enabled = true;
                btnGuardarPedido.Enabled = false;
                btnBuscarCliente.Enabled = false;
                btnBuscarProducto.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                
                MessageBox.Show("PEDIDO GUARDADO CON EXITO...");


            }

        }

        private void dgvDetallePedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo = (int)dgvClienttes.Rows[e.RowIndex].Cells[0].Value;
            txtCodigoProducto.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescripcion.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbbCategoria.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCantidad.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrecio.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDescuento.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[7].Value.ToString();

            

            habilitar_textbox();
            btnEliminarItem.Enabled = true;
            btnCancelarSeleccion.Enabled = true;
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            ListadoDetallePedido.RemoveAt(dgvDetallePedidos.CurrentRow.Index);

            


            dgvDetallePedidos.DataSource = null;

            dgvDetallePedidos.DataSource = new List<DetallePedidoModel>(ListadoDetallePedido);

            dgvDetallePedidos.Columns[0].Visible = false;
            dgvDetallePedidos.Columns[1].Visible = false;
            dgvDetallePedidos.Columns[8].Visible = false;

            dgvDetallePedidos.Columns[2].Width = 100;
            dgvDetallePedidos.Columns[3].Width = 350;
            dgvDetallePedidos.Columns[4].Width = 200;
            dgvDetallePedidos.Columns[5].Width = 100;
            dgvDetallePedidos.Columns[6].Width = 150;
            dgvDetallePedidos.Columns[7].Width = 150;
            dgvDetallePedidos.Columns[9].Width = 200;

            

            btnEliminarItem.Enabled = false;
            btnCancelarSeleccion.Enabled = false;
        }

        private void btnCancelarSeleccion_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
            btnEliminarItem.Enabled = false;
            btnCancelarSeleccion.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
