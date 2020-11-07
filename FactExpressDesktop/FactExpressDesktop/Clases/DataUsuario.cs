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
    class DataUsuario
    {
        Conexion conectar;

        //bool usuarioExiste = false;

        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataUsuario()
        {
            conectar = new Conexion();

        }

        public bool guardarUsuario(UsuarioModel usuarioModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Usuarios(usuario, clave,tipo,estado)" +
                                   " values (@usuario,@clave,@tipo,@estado)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@usuario", usuarioModel.Usuario));
            cmd.Parameters.Add(new SqlParameter("@clave", usuarioModel.Clave));
            cmd.Parameters.Add(new SqlParameter("@tipo", usuarioModel.Tipo));
            cmd.Parameters.Add(new SqlParameter("@estado", usuarioModel.Estado));

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

        public bool EditarUsuario(UsuarioModel usuarioModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Usuarios set usuario=@usuario,clave=@clave,tipo=@tipo,estado=@estado" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", usuarioModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@usuario", usuarioModel.Usuario));
            cmd.Parameters.Add(new SqlParameter("@clave", usuarioModel.Clave));
            cmd.Parameters.Add(new SqlParameter("@tipo", usuarioModel.Tipo));
            cmd.Parameters.Add(new SqlParameter("@estado", usuarioModel.Estado));


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

        public bool EliminarUsuario(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Usuarios where codigo= @codigo", conectar.conn);

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

        public void listarUsuariosAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 130;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 120;


            conectar.conn.Close();
        }

        public void listarUsuariosActivos(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios where estado = 'Activo'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 130;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 120;


            conectar.conn.Close();
        }

        public void listarUsuariosInactivos(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios where estado = 'Inactivo'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 130;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 120;


            conectar.conn.Close();
        }

        public void listarUsuariosPendientes(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios where estado = 'Pendiente'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 130;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 120;


            conectar.conn.Close();
        }

        public void listarUsuariosBloqueados(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios where estado = 'Bloqueado'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 130;
            data.Columns[2].Width = 120;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 120;


            conectar.conn.Close();
        }

        public void BuscarUsuariosPorNombre(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios where usuario like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
        }

        public bool ValidarNombreExiste(string usuario)
        {
            bool usuarioExiste;

            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios where usuario = ('" + usuario + "')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                usuarioExiste = true;
            }
            else
            {
                usuarioExiste = false;
            }
            conectar.conn.Close();

            return usuarioExiste;

        }

        public void listarUsuariosParaAsignar(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select codigo,usuario,tipo,estado from Usuarios where estado = 'Activo'", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 120;
            data.Columns[2].Width = 100;
            data.Columns[3].Width = 120;


            conectar.conn.Close();
        }

    }
}
