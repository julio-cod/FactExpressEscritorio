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
    class DataDetallePedido
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataDetallePedido()
        {
            conectar = new Conexion();

        }

        public bool CrearDetallePedido(DetallePedidoModel detallePedidoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into DetallePedido(codPedido,codProducto,descripcion,categoria,cantidad,precio,descuento,ganancia,fecha)" +
                                   " values (@codPedido,@codProducto,@descripcion,@categoria,@cantidad,@precio,@descuento,@ganancia,@fecha)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codPedido", detallePedidoModel.CodPedido));
            cmd.Parameters.Add(new SqlParameter("@codProducto", detallePedidoModel.CodProducto));
            cmd.Parameters.Add(new SqlParameter("@descripcion", detallePedidoModel.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@categoria", detallePedidoModel.Categoria));
            cmd.Parameters.Add(new SqlParameter("@cantidad", detallePedidoModel.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@precio", detallePedidoModel.Precio));
            cmd.Parameters.Add(new SqlParameter("@descuento", detallePedidoModel.Descuento));
            cmd.Parameters.Add(new SqlParameter("@ganancia", detallePedidoModel.Ganancia));
            cmd.Parameters.Add(new SqlParameter("@fecha", detallePedidoModel.Fecha));

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
    }
}
