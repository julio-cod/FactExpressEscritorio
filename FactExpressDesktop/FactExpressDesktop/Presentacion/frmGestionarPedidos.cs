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
    public partial class frmGestionarPedidos : Form
    {
        DataPedido dPedido = new DataPedido();
        DataDetallePedido dDetallePedido = new DataDetallePedido();
        DataProducto dProducto = new DataProducto();
        bool pedidoActualizado;
        int codDetallePedido;


        int codPedido;
        string vCategoria = "";
        decimal vGanancia = 0;
        int stock = 0;
        decimal costo = 0;
        decimal subTotal = 0;
        int cantidad = 0;
        decimal precio = 0;
        decimal descuento = 0;
        decimal total = 0;
        decimal totalDescuento = 0;
        decimal totalGanancia = 0;
        DateTime fechaActual;

        public frmGestionarPedidos()
        {
            InitializeComponent();
        }

        private void frmGestionarPedidos_Load(object sender, EventArgs e)
        {
            cargarPedidos();
        }

        public void habilitarTextboxPedidos()
        {
            txtCodigoCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            dtpFechaEntrega.Enabled = true;
            txtLugarEntrega.Enabled = true;
            txtComentario.Enabled = true;
        }

        public void inhabilitarTextboxAll()
        {
            txtCodigoCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            dtpFechaEntrega.Enabled = false;
            txtLugarEntrega.Enabled = false;
            txtComentario.Enabled = false;
            txtCodigoProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtDescuento.Enabled = false;
        }


        public void habilitarTextboxProductos()
        {
            txtCantidad.Enabled = true;
            txtDescuento.Enabled = true;
        }

        public void inhabilitarTextboxProductos()
        {
            txtCantidad.Enabled = false;
            txtDescuento.Enabled = false;
        }


        public void LimpiarTextboxAll()
        {
            txtCodigoPedido.Text = "";
            txtCreadoPor.Text = "";
            cbbEstado.Text = "";
            txtSubTotal.Text = "0.00";
            txtTotalDescuento.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCodigoCliente.Text = "";
            txtNombreCliente.Text = "";
            dtpFechaEntrega.Text = "";
            txtLugarEntrega.Text = "";
            txtComentario.Text = "";
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "1";
            txtPrecio.Text = "0.00";
            txtDescuento.Text = "0.00";

            dgvDetallePedidos.DataSource = null;

        }
        public void LimpiarTextboxProducto()
        {
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "1";
            txtPrecio.Text = "0.00";
            txtDescuento.Text = "0.00";

        }


        public void cargarPedidos()
        {
            if (cbbBuscarPedidos.Text == "Pendientes")
            {
                dPedido.listarPedidosPendientes(dgvPedidos);
            }
            else if (cbbBuscarPedidos.Text == "Asignados")
            {
                dPedido.listarPedidosAsignados(dgvPedidos);
            }
            else if (cbbBuscarPedidos.Text == "")
            {
                cbbBuscarPedidos.Text = "Pendientes";
                dPedido.listarPedidosPendientes(dgvPedidos);
            }

        }

        private void cbbBuscarPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPedidos();
            inhabilitarTextboxAll();
            LimpiarTextboxAll();
            btnGuardarCambios.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminarPedido.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnAgregar.Enabled = false;
            btnQuitarItem.Enabled = false;
            btnCancelarSeleccion.Enabled = false;
            btnBuscarProducto.Enabled = false;
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codPedido = (int)dgvPedidos.Rows[e.RowIndex].Cells[0].Value;
                txtCodigoPedido.Text = dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigoCliente.Text = dgvPedidos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombreCliente.Text = dgvPedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFechaOrden.Text = dgvPedidos.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpFechaEntrega.Text = dgvPedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtLugarEntrega.Text = dgvPedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTotalDescuento.Text = dgvPedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTotal.Text = dgvPedidos.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbbEstado.Text = dgvPedidos.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtComentario.Text = dgvPedidos.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtCreadoPor.Text = dgvPedidos.Rows[e.RowIndex].Cells[10].Value.ToString();

                habilitarTextboxPedidos();
                btnGuardarCambios.Enabled = true;
                btnCancelar.Enabled = true;
                btnEliminarPedido.Enabled = true;
                btnBuscarCliente.Enabled = true;
                btnBuscarProducto.Enabled = true;
                btnAgregar.Enabled = true;

                inhabilitarTextboxProductos();
                LimpiarTextboxProducto();
                btnQuitarItem.Enabled = false;
                btnCancelarSeleccion.Enabled = false;

                subTotal = decimal.Parse(txtTotal.Text) + decimal.Parse(txtTotalDescuento.Text);
                txtSubTotal.Text = subTotal.ToString();

                if (txtCodigoPedido.Text != "")
                {
                    dDetallePedido.Buscar = txtCodigoPedido.Text;
                    dDetallePedido.listarDetallePedidos(dgvDetallePedidos);
                }
                else
                {
                    MessageBox.Show("Error al cargar Detalles del pedido");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione pedido correctamente");
                
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inhabilitarTextboxAll();
            LimpiarTextboxAll();
            cargarPedidos();
            btnGuardarCambios.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminarPedido.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnAgregar.Enabled = false;
            btnQuitarItem.Enabled = false;
            btnCancelarSeleccion.Enabled = false;
            btnBuscarProducto.Enabled = false;
        }

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarPedidos();
        }

        private void dgvDetallePedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codDetallePedido = (int)dgvDetallePedidos.Rows[e.RowIndex].Cells[0].Value;
                txtCodigoProducto.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCantidad.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrecio.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDescuento.Text = dgvDetallePedidos.Rows[e.RowIndex].Cells[5].Value.ToString();

                inhabilitarTextboxProductos();
                btnQuitarItem.Enabled = true;
                btnCancelarSeleccion.Enabled = true;
                txtCantidad.Enabled = true;
                txtDescuento.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione pedido correctamente");

            }


        }

        private void btnCancelarSeleccion_Click(object sender, EventArgs e)
        {

            inhabilitarTextboxProductos();
            LimpiarTextboxProducto();
            btnQuitarItem.Enabled = false;
            btnCancelarSeleccion.Enabled = false;

        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            
            if (dDetallePedido.EliminarDetallePedido(codDetallePedido) == true)
            {
                CalculoEliminarProducto();
                inhabilitarTextboxProductos();

                dDetallePedido.Buscar = txtCodigoPedido.Text;
                dDetallePedido.listarDetallePedidos(dgvDetallePedidos);

                LimpiarTextboxProducto();
                btnQuitarItem.Enabled = false;
                btnCancelarSeleccion.Enabled = false;
                EdidtarPedido();
            }

            else
            {
                MessageBox.Show("Error al quitar producto");
            }
            
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProductoParaGestion fp = new frmBuscarProductoParaGestion();
            fp.pasadoProducto += new frmBuscarProductoParaGestion.pasarDatosProducto(ejecutarDatosProducto);
            fp.ShowDialog();
            txtCodigoProducto.Focus();
        }

        public void ejecutarDatosProducto(string pCodigoProducto, string pDescripcion, string pCategoria, string pPrecio, string pStock)
        {
            txtCodigoProducto.Text = pCodigoProducto;
            txtDescripcion.Text = pDescripcion;
            vCategoria = pCategoria;
            txtPrecio.Text = pPrecio;
            txtDescuento.Text = "0.00";
            vGanancia = 0;
            txtCantidad.Text = "1";

            //pasar datos a las variables para el calculo
            stock = int.Parse(pStock);
            costo = Convert.ToDecimal(dProducto.BuscarCostoProducto(int.Parse(txtCodigoProducto.Text)));
            habilitarTextboxProductos();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "" || txtCodigoPedido.Text == "" || txtCodigoCliente.Text == "" || txtPrecio.Text == "" )
            {
                MessageBox.Show("Error al Agregar Producto - Intentelo nuevamente");
                return;
            }
            else
            {
                if (txtDescuento.Text == "")
                {
                    txtDescuento.Text = "0.00";
                }
                if (txtCantidad.Text == "")
                {
                    txtCantidad.Text = "1";
                }
                CalculoAgregarProducto();
                GuardarDetallePedido();

                dDetallePedido.Buscar = txtCodigoPedido.Text;
                dDetallePedido.listarDetallePedidos(dgvDetallePedidos);

                LimpiarTextboxProducto();


                
            }
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

            vGanancia = (cantidad * precio) - (cantidad * costo);
            //txtGanancia.Text = ganancia.ToString();

            totalGanancia = totalGanancia + vGanancia;
            //txtTotalGanancia.Text = totalGanancia.ToString();
            if (totalDescuento == 0)
            {
                txtTotalDescuento.Text = "0.00";
            }


        }

        public void CalculoEliminarProducto()
        {
            costo = Convert.ToDecimal(dProducto.BuscarCostoProducto(int.Parse(txtCodigoProducto.Text)));
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

            vGanancia = (cantidad * precio) - (cantidad * costo);

            totalGanancia = totalGanancia - vGanancia;
            //txtTotalGanancia.Text = totalGanancia.ToString();

            if (totalDescuento == 0)
            {
                txtTotalDescuento.Text = "0.00";
            }


        }

        public void GuardarDetallePedido()
        {
            fechaActual = DateTime.Today;
            DetallePedidoModel detallePedidoModel = new DetallePedidoModel
            {
                CodPedido = int.Parse(txtCodigoPedido.Text),
                CodProducto = int.Parse(txtCodigoProducto.Text),
                Descripcion = txtDescripcion.Text,
                Categoria = vCategoria,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = decimal.Parse(txtPrecio.Text),
                Descuento = decimal.Parse(txtDescuento.Text),
                Ganancia = vGanancia,
                Fecha = fechaActual

            };

            if (dDetallePedido.CrearDetallePedido(detallePedidoModel) == true)
            {
                EdidtarPedido();
            }
            else
            {
                MessageBox.Show("Error al Agregar Producto");
            }
            
        }

        public void EdidtarPedido()
        {
            
            PedidoModel pedidoModel = new PedidoModel
            {
                Codigo = int.Parse(txtCodigoPedido.Text),
                CodUsuarioDelSistema = 1,
                CodigoCliente = int.Parse(txtCodigoCliente.Text),
                NombreCliente = txtNombreCliente.Text,
                LugarEntrega = txtLugarEntrega.Text,
                FechaOrden = Convert.ToDateTime(dtpFechaOrden.Text),
                FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.Text),
                TotalDescuentos = decimal.Parse(txtTotalDescuento.Text),
                Total = decimal.Parse(txtTotal.Text),
                TotalGanancia = totalGanancia,
                Estado = cbbEstado.Text,
                Comentario = txtComentario.Text

            };

            if (dPedido.EditarPedido(pedidoModel) == true)
            {
                pedidoActualizado = true;
            }
            else
            {
                MessageBox.Show("Error al actualizar Pedido");
                pedidoActualizado = false;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (ValidarVacios() == false)
            {
                MessageBox.Show("Codigo de cliente cliente esta vacio");
                return;
            }
            EdidtarPedido();

            if (pedidoActualizado == true)
            {
                pedidoActualizado = false;
                cargarPedidos();
                inhabilitarTextboxAll();
                LimpiarTextboxAll();
                btnGuardarCambios.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminarPedido.Enabled = false;
                btnBuscarCliente.Enabled = false;
                btnAgregar.Enabled = false;
                btnQuitarItem.Enabled = false;
                btnCancelarSeleccion.Enabled = false;
                btnBuscarProducto.Enabled = false;
                MessageBox.Show("Datos Guardados Correctamente");
            }
            else
            {
                pedidoActualizado = false;
            }

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
                
                return true;
            }


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarClienteParaGestion fcc = new frmBuscarClienteParaGestion();
            fcc.pasadoCliente += new frmBuscarClienteParaGestion.pasarDatosCliente(ejecutarDatosCliente);
            fcc.ShowDialog();
            txtCodigoProducto.Focus();
        }

        public void ejecutarDatosCliente(string codigoCliente, string nombreCliente, string lugarEntrega)
        {
            txtCodigoCliente.Text = codigoCliente;
            txtNombreCliente.Text = nombreCliente;
            txtLugarEntrega.Text = lugarEntrega;
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dPedido.EliminarPedido(int.Parse(txtCodigoPedido.Text)) == true)
            {
                if (dDetallePedido.EliminarDetallePorCodPedido(int.Parse(txtCodigoPedido.Text)) == true)
                {
                    inhabilitarTextboxAll();
                    LimpiarTextboxAll();
                    cargarPedidos();
                    btnGuardarCambios.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEliminarPedido.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnQuitarItem.Enabled = false;
                    btnCancelarSeleccion.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    MessageBox.Show("Pedido eliminado correctamente!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar detalles del pedido!");
                }

            }

            else
            {
                MessageBox.Show("Error al eliminar pedido!");
            }
        }
    }
}
