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
    public partial class frmAsignarPedidos : Form
    {
        //DataPedidoAsignado dPedidoAsignado = new DataPedidoAsignado();
        DataUsuario dUsuario = new DataUsuario();
        DataPedido dPedido = new DataPedido();

        int codCliente;
        decimal subTotal = 0;
        decimal totalGanancia = 0;
        string estado = "";
        DateTime fechaActual;

        public frmAsignarPedidos()
        {
            InitializeComponent();
        }

        private void frmAsignarPedidos_Load(object sender, EventArgs e)
        {
            cargarOperadoresAll();
            cargarPedidosPendientes();
        }

        public void cargarOperadoresAll()
        {

            dUsuario.listarUsuariosParaAsignar(dgvOperadores);

        }

        public void cargarPedidosPendientes()
        {
            dPedido.listarPedidosPendientesParaAsignar(dgvPedidosPendientes);

        }

        public void cargarPedidosAsignados()
        {
            if (txtCodigoOperador.Text != "")
            {
                dPedido.CodUsuario = txtCodigoOperador.Text;
                dPedido.BuscarPedidosAsignadosUsuario(dgvPedidosAsignados);
            }

        }

        public void LimpiarAll()
        {
            fechaActual = DateTime.Today;
            txtCodigoPedido.Text = "";
            cbbEstado.Text = "";
            txtSubTotal.Text = "0.00";
            txtTotalDescuento.Text = "0.00";
            txtTotal.Text = "0.00";
            codCliente = 0;
            txtNombreCliente.Text = "";
            dtpFechaEntrega.Text = fechaActual.ToShortDateString();
            txtLugarEntrega.Text = "";
            txtComentario.Text = "";
            txtCodigoOperador.Text = "";
            txtNombreOperador.Text = "";
            dgvPedidosAsignados.DataSource = null;

        }

        public void LimpiarPedido()
        {
            fechaActual = DateTime.Today;
            txtCodigoPedido.Text = "";
            cbbEstado.Text = "";
            txtSubTotal.Text = "0.00";
            txtTotalDescuento.Text = "0.00";
            txtTotal.Text = "0.00";
            codCliente = 0;
            txtNombreCliente.Text = "";
            dtpFechaEntrega.Text = fechaActual.ToShortDateString();
            txtLugarEntrega.Text = "";
            txtComentario.Text = "";
            btnQuitarDeLista.Enabled = false;

        }

        private void dgvOperadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigoOperador.Text = dgvOperadores.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreOperador.Text = dgvOperadores.Rows[e.RowIndex].Cells[1].Value.ToString();

                cargarPedidosAsignados();
                btnCancelar.Enabled = true;

            }
            catch (Exception)
            {


            }
        }

        private void dgvPedidosPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigoPedido.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                codCliente = (int)dgvPedidosPendientes.Rows[e.RowIndex].Cells[1].Value;
                txtNombreCliente.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFechaEntrega.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtLugarEntrega.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTotalDescuento.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTotal.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbbEstado.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtComentario.Text = dgvPedidosPendientes.Rows[e.RowIndex].Cells[8].Value.ToString();

                btnAsignarPedido.Enabled = true;
                btnVerDetalles.Enabled = true;
                btnCancelar.Enabled = true;
                btnQuitarDeLista.Enabled = false;

                subTotal = decimal.Parse(txtTotal.Text) + decimal.Parse(txtTotalDescuento.Text);
                txtSubTotal.Text = subTotal.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione pedido correctamente");

            }

        }

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarPedidosPendientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPedido();
            cargarOperadoresAll();
            cargarPedidosPendientes();
            btnAsignarPedido.Enabled = false;
            btnVerDetalles.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnAsignarPedido_Click(object sender, EventArgs e)
        {
            if (txtCodigoOperador.Text != "")
            {
                if (txtCodigoPedido.Text != "")
                {
                    AsignarPedido();

                }
                else
                {
                    MessageBox.Show("Error - El pedido no tiene codigo");
                }

            }
            else
            {
                MessageBox.Show("Selecciones un Operador para asignarle el pedido");
            }

        }

        public void AsignarPedido()
        {
            estado = "Asignado";
            BuscarGananciaTotalPedido();

            PedidoModel PedidoModel = new PedidoModel
            {
                CodigoPedido = int.Parse(txtCodigoPedido.Text),
                Estado = estado,
                CodUsuarioEntrega = int.Parse(txtCodigoOperador.Text),
                NombreUsuarioEntrega = txtNombreOperador.Text

            };

            if (dPedido.AsignarPedido(PedidoModel) == true)
            {
                //EditarEstadoPedido();
                cargarPedidosAsignados();
                cargarPedidosPendientes();
                LimpiarPedido();
                estado = "";
            }
            else
            {
                MessageBox.Show("Error al asignar Pedido");
                
            }
        }

        public void BuscarGananciaTotalPedido() 
        {
            totalGanancia = Convert.ToDecimal(dPedido.BuscarTotalGanancia(int.Parse(txtCodigoPedido.Text)));
        }
        
        public void EliminarPedidoAsignado() 
        {
            PedidoModel pedidoModel = new PedidoModel
            {
                CodigoPedido = int.Parse(txtCodigoPedido.Text),
                Estado = "Pendiente",
                CodUsuarioEntrega = 0,
                NombreUsuarioEntrega = "Ninguno"

            };

            if (dPedido.QuitarPedidoAsignado(pedidoModel) == true)
            {
                cargarPedidosAsignados();
                cargarPedidosPendientes();
                LimpiarPedido();
                estado = "";
                MessageBox.Show("Agregado a lista de pedido pendientes");
            }
            else
            {
                MessageBox.Show("Error al quitar pedido asignado");

            }
        }
        
      

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarios fu = new frmUsuarios();
            fu.ShowDialog();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitarDeLista_Click(object sender, EventArgs e)
        {
            
            btnQuitarDeLista.Enabled = false;
            EliminarPedidoAsignado();
            
        }

        private void dgvPedidosAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                txtCodigoPedido.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[0].Value.ToString();
                codCliente = (int)dgvPedidosAsignados.Rows[e.RowIndex].Cells[1].Value;
                txtNombreCliente.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFechaEntrega.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtLugarEntrega.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTotalDescuento.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTotal.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbbEstado.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtComentario.Text = dgvPedidosAsignados.Rows[e.RowIndex].Cells[8].Value.ToString();

                btnAsignarPedido.Enabled = false;
                btnVerDetalles.Enabled = false;
                btnCancelar.Enabled = true;
                btnQuitarDeLista.Enabled = true;

                subTotal = decimal.Parse(txtTotal.Text) + decimal.Parse(txtTotalDescuento.Text);
                txtSubTotal.Text = subTotal.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione pedido correctamente");

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarAll();
            cargarOperadoresAll();
            cargarPedidosPendientes();
            btnAsignarPedido.Enabled = false;
            btnVerDetalles.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
