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
    class DataProvincia
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataProvincia()
        {
            conectar = new Conexion();

        }

        public bool guardarProvincia(ProvinciaModel provinciaModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("insert into Provincias(nombreProvincia)" +
                                   " values (@nombreProvincia)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreProvincia", provinciaModel.NombreProvincia));

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

        public bool EditarProvincia(ProvinciaModel provinciaModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Provincias set nombreProvincia=@nombreProvincia" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", provinciaModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombreProvincia", provinciaModel.NombreProvincia));


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

        public bool EliminarProvincia(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Provincias where codigo= @codigo", conectar.conn);

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

        public void listarProvinciasAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Provincias", conectar.conn);
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

        public void BuscarProvinciaPorNombre(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Provincias where nombreProvincia like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public bool ValidarProvinciaExiste(string provincia)
        {
            bool provinciaExiste;

            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Provincias where nombreProvincia = ('" + provincia + "')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                provinciaExiste = true;
            }
            else
            {
                provinciaExiste = false;
            }
            conectar.conn.Close();

            return provinciaExiste;

        }

    }
}
