using FactExpressDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactExpressDesktop.Clases
{
    class DataPedidoAsignado
    {
        Conexion conectar;


        private string codUsuario;
        public string CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }

        public DataPedidoAsignado()
        {
            conectar = new Conexion();

        }

        public bool AsignarPedido(PedidoAsignadoModel pedidoAsignadoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into PedidosAsignados(codPedido,codUsuarioEnttrega,nombreUsuario,codigoCliente,nombreCliente,lugarEntrega,fechaEntrega,totalDescuentos,total,totalGanancia,estado,comentario)" +
                                   " values (@codPedido,@codUsuarioEnttrega,@nombreUsuario,@codigoCliente,@nombreCliente,@lugarEntrega,@fechaEntrega,@totalDescuentos,@total,@totalGanancia,@estado,@comentario)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codPedido", pedidoAsignadoModel.CodPedido));
            cmd.Parameters.Add(new SqlParameter("@codUsuarioEnttrega", pedidoAsignadoModel.CodUsuarioEnttrega));
            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", pedidoAsignadoModel.NombreUsuario));
            cmd.Parameters.Add(new SqlParameter("@codigoCliente", pedidoAsignadoModel.CodigoCliente));
            cmd.Parameters.Add(new SqlParameter("@nombreCliente", pedidoAsignadoModel.NombreCliente));
            cmd.Parameters.Add(new SqlParameter("@lugarEntrega", pedidoAsignadoModel.LugarEntrega));
            cmd.Parameters.Add(new SqlParameter("@fechaEntrega", pedidoAsignadoModel.FechaEntrega));
            cmd.Parameters.Add(new SqlParameter("@totalDescuentos", pedidoAsignadoModel.TotalDescuentos));
            cmd.Parameters.Add(new SqlParameter("@total", pedidoAsignadoModel.Total));
            cmd.Parameters.Add(new SqlParameter("@totalGanancia", pedidoAsignadoModel.TotalGanancia));
            cmd.Parameters.Add(new SqlParameter("@estado", pedidoAsignadoModel.Estado));
            cmd.Parameters.Add(new SqlParameter("@comentario", pedidoAsignadoModel.Comentario));

            conectar.abrir();
            int resultado = cmd.ExecuteNonQuery();
            cmd = null;
            conectar.cerrar();
            if (resultado > 0)
            {
                prueba = true;
            }
            else
            {
                prueba = false;
            }


            return prueba;


        }

        public void BuscarPedidosAsignadosUsuario(DataGridView data)
        {
            try
            {
                conectar.conn.Open();
                SqlCommand comando = new SqlCommand("Select codigo,codPedido,codigoCliente,nombreCliente,fechaEntrega,lugarEntrega,totalDescuentos,total,estado,comentario from PedidosAsignados where codUsuarioEnttrega = '" + codUsuario + "'", conectar.conn);
                comando.Connection = conectar.conn;
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[0].Width = 0;
                conectar.conn.Close();
            }
            catch (Exception)
            {

                conectar.conn.Close();
            }

        }

        public bool EliminarPedidoAsignado(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from PedidosAsignados where codPedido= @codPedido", conectar.conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@codPedido", codigo));

            conectar.abrir();
            int resultado = cmd.ExecuteNonQuery();
            cmd = null;
            conectar.cerrar();
            if (resultado > 0)
            {
                prueba = true;
            }
            else
            {
                prueba = false;
            }

            return prueba;

        }

        public void listarPedidosAsignados(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codPedido,codUsuarioEnttrega,nombreUsuario,codigoCliente,nombreCliente,lugarEntrega,fechaEntrega,totalDescuentos,total,estado,comentario from PedidosAsignados", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 70;
            data.Columns[2].Width = 70;
            data.Columns[3].Width = 120;
            data.Columns[4].Width = 90;
            data.Columns[5].Width = 90;
            data.Columns[6].Width = 150;
            data.Columns[7].Width = 100;
            data.Columns[8].Width = 100;
            data.Columns[9].Width = 150;
            data.Columns[10].Width = 70;


            conectar.conn.Close();
        }

    }
}
