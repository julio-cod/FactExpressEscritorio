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
        public static int CodUsuarioDelSistemaGlobal = 1;
        public static string nombreUsuarioDelSistemaGlobal = "julio";

        DataPedido dPedido = new DataPedido();
        DataDetallePedido dDetallePedido = new DataDetallePedido();
        DataProducto dProducto = new DataProducto();
        string idPedido = "";
        int codigoProducto;

        //Variables para los calculos
        string estado = "Pendiente";
        int stock = 0;
        int cantidad = 0;
        decimal precio = 0;
        decimal costo = 0;
        decimal descuento = 0;
        decimal ganancia = 0;
        decimal total = 0;
        decimal subTotal = 0;
        decimal totalDescuento = 0;
        decimal totalGanancia = 0;

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
            txtPrecio.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtSubTotal.Text = "0.00";
            txtTotal.Text = "0.00";
            txtTotalDescuento.Text = "0.00";
            totalGanancia = 0;
            txtComentario.Text = "";
            dtpFechaEntrega.Text = DateTime.Now.ToString();
            dgvDetallePedidos.DataSource = null;

            ListadoDetallePedido.Clear();

            stock = 0;
            cantidad = 0;
            precio = 0;
            costo = 0;
            descuento = 0;
            ganancia = 0;
            total = 0;
            subTotal = 0;
            totalDescuento = 0;
            totalGanancia = 0;

        }

        public void LimpiarProducto()
        {
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            cbbCategoria.Text = "";
            txtCantidad.Text = "1";
            txtPrecio.Text = "0.00";
            txtDescuento.Text = "0.00";
            ganancia = 0;

        }

        public bool ValidarVacios()
        {
            if (txtCodigoCliente.Text == "")
            {
                
                return false;
            }
            else
            {
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
                return true;
            }
            

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            //limpiar();
            habilitar_textbox();

            btnNuevoPedido.Enabled = false;
            
            btnGuardarPedido.Enabled = true;
            btnBuscarCliente.Enabled = true;
            //btnEliminar.Enabled = true;
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

        public void ejecutarDatosProducto(string pCodigoProducto, string pDescripcion, string pCategoria,string pPrecio, string pStock)
        {
            txtCodigoProducto.Text = pCodigoProducto;
            txtDescripcion.Text = pDescripcion;
            cbbCategoria.Text = pCategoria;
            txtPrecio.Text = pPrecio;
            txtDescuento.Text = "0.00";
            ganancia = 0;

            //pasar datos a las variables para el calculo
            stock = int.Parse(pStock);
            costo = Convert.ToDecimal(dProducto.BuscarCostoProducto(int.Parse(txtCodigoProducto.Text)));

        }

        List<DetallePedidoModel> ListadoDetallePedido = new List<DetallePedidoModel>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "" || txtDescripcion.Text == "" || cbbCategoria.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "" || ganancia.ToString() == "" || dtpFechaActual.Text == "")
            {
                MessageBox.Show("Error al Seleccionar Producto - Intentelo nuevamente");
                return;
            }
            if (ValidarVacios() == true)
            {
                CalculoAgregarProducto();


                ListadoDetallePedido.Add(new DetallePedidoModel()
                {

                    //CodPedido = int.Parse(idPedido),
                    CodProducto = int.Parse(txtCodigoProducto.Text),
                    Descripcion = txtDescripcion.Text,
                    Categoria = cbbCategoria.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                    Descuento = decimal.Parse(txtDescuento.Text),
                    Ganancia = ganancia,
                    Fecha = Convert.ToDateTime(dtpFechaActual.Text)

                });

                LimpiarProducto();

                dgvDetallePedidos.DataSource = null;
                dgvDetallePedidos.DataSource = new List<DetallePedidoModel>(ListadoDetallePedido);

                EstructutaDataGridView();

                
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente");
                txtCodigoCliente.Focus();
            }
            

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
                CodUsuarioDelSistema = CodUsuarioDelSistemaGlobal,
                NombreUsuarioDelSistema = nombreUsuarioDelSistemaGlobal,
                CodigoCliente = int.Parse(txtCodigoCliente.Text),
                NombreCliente = txtNombreCliente.Text,
                LugarEntrega = txtLugarEntrega.Text,
                FechaOrden = Convert.ToDateTime(dtpFechaActual.Text),
                FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.Text),
                TotalDescuentos = decimal.Parse(txtTotalDescuento.Text),
                Total = decimal.Parse(txtTotal.Text),
                TotalGanancia = totalGanancia,
                Estado = estado,
                Comentario = txtComentario.Text,
                CodUsuarioEntrega = 0,
                NombreUsuarioEntrega = "Ninguno"

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
                //btnEliminar.Enabled = false;
                
                MessageBox.Show("PEDIDO GUARDADO CON EXITO...");


            }

        }

        private void dgvDetallePedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigoProducto = (int)dgvDetallePedidos.Rows[e.RowIndex].Cells[2].Value;
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
            catch (Exception)
            {
                MessageBox.Show("Seleccione un Producto correctamente");
                habilitar_textbox();
                LimpiarProducto();
                btnEliminarItem.Enabled = false;
                btnCancelarSeleccion.Enabled = false;

            }
            

            
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            CalculoEliminarProducto();
            ListadoDetallePedido.RemoveAt(dgvDetallePedidos.CurrentRow.Index);

            dgvDetallePedidos.DataSource = null;
            LimpiarProducto();

            dgvDetallePedidos.DataSource = new List<DetallePedidoModel>(ListadoDetallePedido);

            EstructutaDataGridView();

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

        

        public void CalculoAgregarProducto()
        {
            precio = decimal.Parse(txtPrecio.Text);
            cantidad = int.Parse(txtCantidad.Text);
            descuento = decimal.Parse(txtDescuento.Text);
            stock = stock - cantidad;

            subTotal = subTotal + (cantidad * precio);
            txtSubTotal.Text = subTotal.ToString();

            totalDescuento = totalDescuento + descuento;
            txtTotalDescuento.Text = totalDescuento.ToString();

            total = subTotal - totalDescuento;
            txtTotal.Text = total.ToString();
  
            ganancia = (cantidad * precio) - (cantidad * costo);
            //txtGanancia.Text = ganancia.ToString();

            totalGanancia = totalGanancia + ganancia;
            //txtTotalGanancia.Text = totalGanancia.ToString();
            if (totalDescuento == 0)
            {
                txtTotalDescuento.Text = "0.00";
            }


        }

        public void CalculoEliminarProducto()
        {
            costo = Convert.ToDecimal(dProducto.BuscarCostoProducto(codigoProducto));
            precio = decimal.Parse(txtPrecio.Text);
            cantidad = int.Parse(txtCantidad.Text);
            descuento = decimal.Parse(txtDescuento.Text);
            stock = stock + cantidad;

            subTotal = subTotal - (cantidad * precio);
            txtSubTotal.Text = subTotal.ToString();

            totalDescuento = totalDescuento - descuento;
            txtTotalDescuento.Text = totalDescuento.ToString();

            total = subTotal - totalDescuento;
            txtTotal.Text = total.ToString();

            ganancia = (cantidad * precio) - (cantidad * costo);

            totalGanancia = totalGanancia - ganancia;
            //txtTotalGanancia.Text = totalGanancia.ToString();

            if (totalDescuento == 0)
            {
                txtTotalDescuento.Text = "0.00";
            }


        }

        public void EstructutaDataGridView()
        {
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

            
        }

    }
}
