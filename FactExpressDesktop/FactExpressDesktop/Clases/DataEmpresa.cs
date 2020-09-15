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
    class DataEmpresa
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataEmpresa()
        {
            conectar = new Conexion();

        }

        public bool GuardarEmpresa(EmpresaModel empresaModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Empresa(nombreEmpresa,RNC,telefono,correo,direccion,sector,provincia)" +
                                   " values (@nombreEmpresa,@RNC,@telefono,@correo,@direccion,@sector,@provincia)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", empresaModel.NombreEmpresa));
            cmd.Parameters.Add(new SqlParameter("@RNC", empresaModel.RNC));
            cmd.Parameters.Add(new SqlParameter("@telefono", empresaModel.Telefono));
            cmd.Parameters.Add(new SqlParameter("@correo", empresaModel.Correo));
            cmd.Parameters.Add(new SqlParameter("@direccion", empresaModel.Direccion));
            cmd.Parameters.Add(new SqlParameter("@sector", empresaModel.Sector));
            cmd.Parameters.Add(new SqlParameter("@provincia", empresaModel.Provincia));

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

        public bool EditarEmpresa(EmpresaModel empresaModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Empresa set nombreEmpresa=@nombreEmpresa,RNC=@RNC,telefono=@telefono,correo=@correo,direccion=@direccion,sector=@sector,provincia=@provincia" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", empresaModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", empresaModel.NombreEmpresa));
            cmd.Parameters.Add(new SqlParameter("@RNC", empresaModel.RNC));
            cmd.Parameters.Add(new SqlParameter("@telefono", empresaModel.Telefono));
            cmd.Parameters.Add(new SqlParameter("@correo", empresaModel.Correo));
            cmd.Parameters.Add(new SqlParameter("@direccion", empresaModel.Direccion));
            cmd.Parameters.Add(new SqlParameter("@sector", empresaModel.Sector));
            cmd.Parameters.Add(new SqlParameter("@provincia", empresaModel.Provincia));

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

        public bool EliminarEmpresa(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Empresa where codigo= @codigo", conectar.conn);

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

        public void ListarEmpresasAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Empresa", conectar.conn);
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
