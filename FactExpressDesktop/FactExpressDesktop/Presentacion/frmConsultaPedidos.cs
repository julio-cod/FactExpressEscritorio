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
    public partial class frmConsultaPedidos : Form
    {
        DataPedido dPedido = new DataPedido();
        DataPedidoAsignado dPedidoAsignado = new DataPedidoAsignado();
        DataDetallePedido dDetallePedido = new DataDetallePedido();
        int codPedido;
        public frmConsultaPedidos()
        {
            InitializeComponent();
        }

        private void frmConsultaPedidos_Load(object sender, EventArgs e)
        {

        }

        public void cargarPedidos()
        {
            dgvPedidos.DataSource = null;
            dgvDetallePedidos.DataSource = null;

            if (cbbBuscarPedidos.Text == "Pendientes")
            {
                dPedido.listarPedidosPendientes(dgvPedidos);
            }
            else if (cbbBuscarPedidos.Text == "Asignados")
            {
                dPedidoAsignado.listarPedidosAsignados(dgvPedidos);
            }
            else if (cbbBuscarPedidos.Text == "Entregados")
            {
                dPedido.listarPedidosEntregados(dgvPedidos);
            }
            else if (cbbBuscarPedidos.Text == "")
            {
                cbbBuscarPedidos.Text = "Pendientes";
                dPedido.listarPedidosPendientes(dgvPedidos);
            }

            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarPedidos();
        }

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarPedidos();
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codPedido = (int)dgvPedidos.Rows[e.RowIndex].Cells[0].Value;

                if (codPedido.ToString() != "")
                {
                    dDetallePedido.Buscar = codPedido.ToString();
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

        private void cbbBuscarPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPedidos();
            
        }
    }
}
