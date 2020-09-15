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
    class DataProveedor
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataProveedor()
        {
            conectar = new Conexion();

        }

        public bool GuardarProveedor(ProveedorModel proveedorModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Proveedores(nombreProveedor,telefono,celular,direccion)" +
                                   " values (@nombreProveedor,@telefono,@celular,@direccion)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreProveedor", proveedorModel.NombreProveedor));
            cmd.Parameters.Add(new SqlParameter("@telefono", proveedorModel.Telefono));
            cmd.Parameters.Add(new SqlParameter("@celular", proveedorModel.Celular));
            cmd.Parameters.Add(new SqlParameter("@direccion", proveedorModel.Direccion));

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

        public bool EditarProveedor(ProveedorModel proveedorModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Proveedores set nombreProveedor=@nombreProveedor,telefono=@telefono,celular=@celular,direccion=@direccion" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", proveedorModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombreProveedor", proveedorModel.NombreProveedor));
            cmd.Parameters.Add(new SqlParameter("@telefono", proveedorModel.Telefono));
            cmd.Parameters.Add(new SqlParameter("@celular", proveedorModel.Celular));
            cmd.Parameters.Add(new SqlParameter("@direccion", proveedorModel.Direccion));



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

        public bool EliminarProveedor(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Proveedores where codigo= @codigo", conectar.conn);

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

        public void ListarProveedoresAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Proveedores", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 300;
            data.Columns[2].Width = 150;
            data.Columns[3].Width = 150;
            data.Columns[4].Width = 400;

            conectar.conn.Close();
        }

        public void BuscarProveedorPorNombre(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Proveedores where nombreProveedor like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public void BuscarProveedorPorCodigo(DataGridView data)
        {
            try
            {
                conectar.conn.Open();
                SqlCommand comando = new SqlCommand("Select * from Proveedores where codigo = '" + buscar + "'", conectar.conn);
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
