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
    class DataProducto
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataProducto()
        {
            conectar = new Conexion();

        }

        public bool guardarProducto(ProductoModel productoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Productos(descripcion,categoria,stock,costo,precio)" +
                                   " values (@descripcion,@categoria,@stock,@costo,@precio)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@descripcion", productoModel.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@categoria", productoModel.Categoria));
            cmd.Parameters.Add(new SqlParameter("@stock", productoModel.Stock));
            cmd.Parameters.Add(new SqlParameter("@costo", productoModel.Costo));
            cmd.Parameters.Add(new SqlParameter("@precio", productoModel.Precio));

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

        public bool EditarProducto(ProductoModel productoModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Productos set descripcion=@descripcion,categoria=@categoria,stock=@stock,costo=@costo,precio=@precio" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", productoModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@descripcion", productoModel.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@categoria", productoModel.Categoria));
            cmd.Parameters.Add(new SqlParameter("@stock", productoModel.Stock));
            cmd.Parameters.Add(new SqlParameter("@costo", productoModel.Costo));
            cmd.Parameters.Add(new SqlParameter("@precio", productoModel.Precio));



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

        public bool EliminarProducto(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Productos where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

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

        public void listarProductosAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Productos", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 350;
            data.Columns[2].Width = 250;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 150;
            data.Columns[5].Width = 150;


            conectar.conn.Close();
        }

        public void BuscarProductoPorDescripcion(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Productos where descripcion like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public void BuscarProductoPorCodigo(DataGridView data)
        {
            try
            {
                conectar.conn.Open();
                SqlCommand comando = new SqlCommand("Select * from Productos where codigo = '" + buscar + "'", conectar.conn);
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

        public void BuscarProductoPorCategoria(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Productos where categoria like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public DataTable CargarComboboxCategorias()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Categoria";
            SqlCommand cmd = new SqlCommand(query, conectar.conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }

        public void listarProductosParaPedidos(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigo,descripcion,categoria,stock,precio from Productos", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 350;
            data.Columns[2].Width = 250;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 150;


            conectar.conn.Close();
        }

        public void BuscarProductoPorDescripcionParaPedidos(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigo,descripcion,categoria,stock,precio from Productos where descripcion like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public void BuscarProductoPorCodigoParaPedidos(DataGridView data)
        {
            try
            {
                conectar.conn.Open();
                SqlCommand comando = new SqlCommand("Select codigo,descripcion,categoria,stock,precio from Productos where codigo = '" + buscar + "'", conectar.conn);
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

        public void BuscarProductoPorCategoriaParaPedidos(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigo,descripcion,categoria,stock,precio from Productos where categoria like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public string BuscarCostoProducto(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;
            string bCosto = "";

            cmd = new SqlCommand("Select costo from Productos where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

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
                        bCosto = reader[0].ToString();
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

            return bCosto;


        }

        public string BuscarStockProducto(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;
            string bStock = "";

            cmd = new SqlCommand("Select stock from Productos where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

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
                    //RECUPERAR EL STOCK AUTOGENERADO

                    if (reader.Read())
                    {
                        bStock = reader[0].ToString();
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

            return bStock;


        }

    }
}
