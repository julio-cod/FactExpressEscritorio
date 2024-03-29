﻿using FactExpressDesktop.Modelos;
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
    class DataPedido
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        private string codUsuario;
        public string CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }

        public DataPedido()
        {
            conectar = new Conexion();

        }

        public string CrearPedido(PedidoModel pedidoModel)
        {
            SqlCommand cmd = null;
            //bool prueba;
            string idPedido = "";

            cmd = new SqlCommand("insert into Pedidos(codUsuarioDelSistema,nombreUsuarioDelSistema,codigoCliente,nombreCliente,lugarEntrega,fechaOrden,fechaEntrega,totalDescuentos,total,totalGanancia,estado,comentario,codUsuarioEntrega,nombreUsuarioEntrega)" +
                                   " values (@codUsuarioDelSistema,@nombreUsuarioDelSistema,@codigoCliente,@nombreCliente,@lugarEntrega,@fechaOrden,@fechaEntrega,@totalDescuentos,@total,@totalGanancia,@estado,@comentario,@codUsuarioEntrega,@nombreUsuarioEntrega) SELECT SCOPE_IDENTITY();", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codUsuarioDelSistema", pedidoModel.CodUsuarioDelSistema));
            cmd.Parameters.Add(new SqlParameter("@nombreUsuarioDelSistema", pedidoModel.NombreUsuarioDelSistema));
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
            cmd.Parameters.Add(new SqlParameter("@codUsuarioEntrega", pedidoModel.CodUsuarioEntrega));
            cmd.Parameters.Add(new SqlParameter("@nombreUsuarioEntrega", pedidoModel.NombreUsuarioEntrega));

            conectar.abrir();
            //int resultado = cmd.ExecuteNonQuery();
            //cmd = null;

            SqlDataReader reader = cmd.ExecuteReader();

            //conectar.cerrar();
            if (reader.HasRows)
            {
                //prueba = true;
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
                //prueba = false;
            }

            return idPedido;


        }

        public bool EditarPedido(PedidoModel pedidoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Pedidos set codigoCliente=@codigoCliente,nombreCliente=@nombreCliente,lugarEntrega=@lugarEntrega,fechaEntrega=@fechaEntrega,totalDescuentos=@totalDescuentos,total=@total,comentario=@comentario" +
                                   " where codigoPedido= @codigoPedido", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigoPedido", pedidoModel.CodigoPedido));
            cmd.Parameters.Add(new SqlParameter("@codigoCliente", pedidoModel.CodigoCliente));
            cmd.Parameters.Add(new SqlParameter("@nombreCliente", pedidoModel.NombreCliente));
            cmd.Parameters.Add(new SqlParameter("@lugarEntrega", pedidoModel.LugarEntrega));
            cmd.Parameters.Add(new SqlParameter("@fechaEntrega", pedidoModel.FechaEntrega));
            cmd.Parameters.Add(new SqlParameter("@totalDescuentos", pedidoModel.TotalDescuentos));
            cmd.Parameters.Add(new SqlParameter("@total", pedidoModel.Total));
            cmd.Parameters.Add(new SqlParameter("@totalGanancia", pedidoModel.TotalGanancia));
            cmd.Parameters.Add(new SqlParameter("@comentario", pedidoModel.Comentario));

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

        public bool EliminarPedido(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Pedidos where codigoPedido= @codigoPedido", conectar.conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@codigoPedido", codigo));

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

        public void listarPedidosPendientes(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigoPedido,codigoCliente,nombreCliente,fechaOrden,fechaEntrega,lugarEntrega,totalDescuentos,total,estado,comentario,codUsuarioDelSistema,nombreUsuarioDelSistema from Pedidos where estado = 'Pendiente'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 70;
            data.Columns[1].Width = 70;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 90;
            data.Columns[4].Width = 90;
            data.Columns[5].Width = 150;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 100;
            data.Columns[8].Width = 100;
            data.Columns[9].Width = 150;
            data.Columns[10].Width = 70;
            data.Columns[10].Width = 70;


            conectar.conn.Close();
        }

        public void listarPedidosAsignados(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigoPedido,codigoCliente,nombreCliente,fechaOrden,fechaEntrega,lugarEntrega,totalDescuentos,total,estado,comentario,codUsuarioDelSistema,nombreUsuarioDelSistema,codUsuarioEntrega,nombreUsuarioEntrega from Pedidos where estado = 'Asignado'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 70;
            data.Columns[1].Width = 70;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 90;
            data.Columns[4].Width = 90;
            data.Columns[5].Width = 150;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 100;
            data.Columns[8].Width = 100;
            data.Columns[9].Width = 150;
            data.Columns[10].Width = 70;
            data.Columns[10].Width = 70;

            conectar.conn.Close();
        }

        public void listarPedidosEntregados(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigoPedido,codigoCliente,nombreCliente,fechaOrden,fechaEntrega,lugarEntrega,totalDescuentos,total,estado,comentario,codUsuarioDelSistema,nombreUsuarioDelSistema from Pedidos where estado = 'Entregado'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 70;
            data.Columns[1].Width = 70;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 90;
            data.Columns[4].Width = 90;
            data.Columns[5].Width = 150;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 100;
            data.Columns[8].Width = 100;
            data.Columns[9].Width = 150;
            data.Columns[10].Width = 70;
            data.Columns[10].Width = 70;

            conectar.conn.Close();
        }

        public void listarPedidosPendientesParaAsignar(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigoPedido,codigoCliente,nombreCliente,fechaEntrega,lugarEntrega,totalDescuentos,total,estado,comentario from Pedidos where estado = 'Pendiente'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 70;
            data.Columns[1].Width = 70;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 90;
            data.Columns[4].Width = 150;
            data.Columns[5].Width = 100;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 100;
            data.Columns[8].Width = 150;


            conectar.conn.Close();
        }

        public string BuscarTotalGanancia(int codigoPedido)
        {
            SqlCommand cmd = null;
            bool prueba;
            string totalGanancia = "";

            cmd = new SqlCommand("Select totalGanancia from Pedidos where codigoPedido= @codigoPedido", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigoPedido", codigoPedido));

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
                    //RECUPERAR EL COSTO AUTOGENERADO

                    if (reader.Read())
                    {
                        totalGanancia = reader[0].ToString();
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

            return totalGanancia;


        }

        public bool QuitarPedidoAsignado(PedidoModel pedidoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Pedidos set estado=@estado, codUsuarioEntrega=@codUsuarioEntrega, nombreUsuarioEntrega=@nombreUsuarioEntrega" +
                                   " where codigoPedido= @codigoPedido", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigoPedido", pedidoModel.CodigoPedido));
            cmd.Parameters.Add(new SqlParameter("@estado", pedidoModel.Estado));
            cmd.Parameters.Add(new SqlParameter("@codUsuarioEntrega", pedidoModel.CodUsuarioEntrega));
            cmd.Parameters.Add(new SqlParameter("@nombreUsuarioEntrega", pedidoModel.NombreUsuarioEntrega));

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

        public bool AsignarPedido(PedidoModel pedidoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Pedidos set estado=@estado, codUsuarioEntrega=@codUsuarioEntrega, nombreUsuarioEntrega=@nombreUsuarioEntrega" +
                                   " where codigoPedido= @codigoPedido", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigoPedido", pedidoModel.CodigoPedido));
            cmd.Parameters.Add(new SqlParameter("@estado", pedidoModel.Estado));
            cmd.Parameters.Add(new SqlParameter("@codUsuarioEntrega", pedidoModel.CodUsuarioEntrega));
            cmd.Parameters.Add(new SqlParameter("@nombreUsuarioEntrega", pedidoModel.NombreUsuarioEntrega));

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
                SqlCommand comando = new SqlCommand("Select codigoPedido,codigoCliente,nombreCliente,fechaEntrega,lugarEntrega,totalDescuentos,total,estado,comentario from Pedidos where estado = 'Asignado' and codUsuarioEntrega = '" + codUsuario + "'", conectar.conn);
                comando.Connection = conectar.conn;
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                data.DataSource = dt;
                conectar.conn.Close();

            }
            catch (Exception)
            {

                conectar.conn.Close();
            }

        }


        

    }
}
