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
    class DataCliente
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataCliente()
        {
            conectar = new Conexion();

        }

        public bool GuardarCliente(ClienteModel clienteModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Clientes(nombreCliente,telefono,correo,direccion,sector,provincia)" +
                                   " values (@nombreCliente,@telefono,@correo,@direccion,@sector,@provincia)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreCliente", clienteModel.NombreCliente));
            cmd.Parameters.Add(new SqlParameter("@telefono", clienteModel.Telefono));
            cmd.Parameters.Add(new SqlParameter("@correo", clienteModel.Correo));
            cmd.Parameters.Add(new SqlParameter("@direccion", clienteModel.Direccion));
            cmd.Parameters.Add(new SqlParameter("@sector", clienteModel.Sector));
            cmd.Parameters.Add(new SqlParameter("@provincia", clienteModel.Provincia));

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

        public bool EditarCliente(ClienteModel clienteModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Clientes set nombreCliente=@nombreCliente,telefono=@telefono,correo=@correo,direccion=@direccion,sector=@sector,provincia=@provincia" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", clienteModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombreCliente", clienteModel.NombreCliente));
            cmd.Parameters.Add(new SqlParameter("@telefono", clienteModel.Telefono));
            cmd.Parameters.Add(new SqlParameter("@correo", clienteModel.Correo));
            cmd.Parameters.Add(new SqlParameter("@direccion", clienteModel.Direccion));
            cmd.Parameters.Add(new SqlParameter("@sector", clienteModel.Sector));
            cmd.Parameters.Add(new SqlParameter("@provincia", clienteModel.Provincia));



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

        public bool EliminarCliente(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Clientes where codigo= @codigo", conectar.conn);

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

        public void ListarClientesAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Clientes", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 200;
            data.Columns[2].Width = 100;
            data.Columns[3].Width = 200;
            data.Columns[4].Width = 150;
            data.Columns[5].Width = 200;
            data.Columns[6].Width = 200;

            conectar.conn.Close();
        }

        public void BuscarClientePorNombre(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Clientes where nombreCliente like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public void BuscarClientePorCodigo(DataGridView data)
        {
            try
            {
                conectar.conn.Open();
                SqlCommand comando = new SqlCommand("Select * from Clientes where codigo = '" + buscar + "'", conectar.conn);
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

        public void BuscarClientePorSector(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Clientes where sector like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public void BuscarClientePorProvincia(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Clientes where provincia like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public DataTable CargarComboboxSectores()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Sectores";
            SqlCommand cmd = new SqlCommand(query, conectar.conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }

        public DataTable CargarComboboxProvincias()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Provincias";
            SqlCommand cmd = new SqlCommand(query, conectar.conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }
    }
}
