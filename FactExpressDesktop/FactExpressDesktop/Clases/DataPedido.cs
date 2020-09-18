using FactExpressDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactExpressDesktop.Clases
{
    class DataPedido
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataPedido()
        {
            conectar = new Conexion();

        }

        public string CrearPedido(PedidoModel pedidoModel)
        {
            SqlCommand cmd = null;
            bool prueba;
            string idPedido = "";

            cmd = new SqlCommand(" insert into Pedidos(codUsuarioDelSistema,codigoCliente,nombreCliente,lugarEntrega,fechaOrden,fechaEntrega,totalDescuentos,total,totalGanancia,estado,comentario)" +
                                   " values (@codUsuarioDelSistema,@codigoCliente,@nombreCliente,@lugarEntrega,@fechaOrden,@fechaEntrega,@totalDescuentos,@total,@totalGanancia,@estado,@comentario) SELECT SCOPE_IDENTITY();", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codUsuarioDelSistema", pedidoModel.CodUsuarioDelSistema));
            cmd.Parameters.Add(new SqlParameter("@codigoCliente", pedidoModel.CodigoCliente));
            cmd.Parameters.Add(new SqlParameter("@nombreCliente", pedidoModel.NombreCliente));
            cmd.Parameters.Add(new SqlParameter("@lugarEntrega", pedidoModel.LugarEntrega));
            cmd.Parameters.Add(new SqlParameter("@fechaOrden", pedidoModel.FechaOrden));
            cmd.Parameters.Add(new SqlParameter("@fechaEntrega", pedidoModel.FechaEntrega));
            cmd.Parameters.Add(new SqlParameter("@totalDescuentos", pedidoModel.TotalDescuentos));
            cmd.Parameters.Add(new SqlParameter("@total", pedidoModel.Total));
            cmd.Parameters.Add(new SqlParameter("@totalGanancia", pedidoModel.TotalGanancia));
            cmd.Parameters.Add(new SqlParameter("@estado", pedidoModel.Estado));
            cmd.Parameters.Add(new SqlParameter("@comentario", pedidoModel.Comentario));

            conectar.abrir();
            //int resultado = cmd.ExecuteNonQuery();
            //cmd = null;

            SqlDataReader reader = cmd.ExecuteReader();

            //conectar.cerrar();
            if (reader.HasRows)
            {
                prueba = true;
                try
                {
                    //RECUPERAR EL CODIGO AUTOGENERADO
                    
                    if (reader.Read())
                    {
                        idPedido = reader[0].ToString();
                    }

                }
                catch (Exception e)
                {
                    //objVenta.Estado = 1;

                }
                finally
                {
                    cmd = null;
                    conectar.cerrar();
                }


            }
            else
            {
                prueba = false;
            }

           


            return idPedido;


        }
    }
}
