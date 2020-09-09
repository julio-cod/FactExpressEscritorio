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
    class DataCategoria
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataCategoria()
        {
            conectar = new Conexion();

        }

        public bool guardarCategoria(CategoriaModel categoriaModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Categoria(nombreCategoria)" +
                                   " values (@nombreCategoria)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreCategoria", categoriaModel.NombreCategoria));

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

        public bool EditarCategoria(CategoriaModel categoriaModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Categoria set nombreCategoria=@nombreCategoria" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", categoriaModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombreCategoria", categoriaModel.NombreCategoria));


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

        public bool EliminarCategoria(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Categoria where codigo= @codigo", conectar.conn);

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

        public void listarCategoriasAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Categoria", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 330;


            conectar.conn.Close();
        }

        public void BuscarCategoriaPorNombre(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Categoria where nombreCategoria like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }
    }
}
