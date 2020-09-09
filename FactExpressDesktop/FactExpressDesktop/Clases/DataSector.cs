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
    class DataSector
    {
        Conexion conectar;


        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public DataSector()
        {
            conectar = new Conexion();

        }

        public bool guardarSector(SectorModel sectorModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand(" insert into Sectores(nombreSector,provincia)" +
                                   " values (@nombreSector,@provincia)", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@nombreSector", sectorModel.NombreSector));
            cmd.Parameters.Add(new SqlParameter("@provincia", sectorModel.Provincia));

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

        public bool EditarSector(SectorModel sectorModel)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("update Sectores set nombreSector=@nombreSector,provincia=@provincia" +
                                   " where codigo= @codigo", conectar.conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@codigo", sectorModel.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombreSector", sectorModel.NombreSector));
            cmd.Parameters.Add(new SqlParameter("@provincia", sectorModel.Provincia));


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

        public bool EliminarSector(int codigo)
        {
            SqlCommand cmd = null;
            bool prueba;

            cmd = new SqlCommand("delete from Sectores where codigo= @codigo", conectar.conn);

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

        public void listarSectoresAll(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Sectores", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 80;
            data.Columns[1].Width = 170;
            data.Columns[2].Width = 170;


            conectar.conn.Close();
        }

        public void BuscarSectorPorNombre(DataGridView data)
        {
            conectar.conn.Open();
            SqlCommand comando = new SqlCommand("Select * from Sectores where nombreSector like ('%" + buscar + "%')", conectar.conn);
            comando.Connection = conectar.conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conectar.conn.Close();
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
