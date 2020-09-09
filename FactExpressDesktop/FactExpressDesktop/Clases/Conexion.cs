using FactExpressDesktop.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactExpressDesktop.Clases
{
    class Conexion
    {
        public static string enlace()
        {
            return Settings.Default.FactExpressConnectionString;

          
        }

        public static SqlConnection ObtenerConexion()
        {

            SqlConnection conectar = new SqlConnection(enlace());


            try
            {
                conectar.Open();
            }
            catch (Exception)
            {


            }

            return conectar;



        }
        public static string conexion = enlace();



        string connStr = enlace();



        public SqlConnection conn;
        public Conexion()
        {
            conn = new SqlConnection(connStr);
        }

        public void abrir()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public void cerrar()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }

        public SqlConnection Conectar()
        {
            try
            {
                conn.Open();
            }
            catch
            {


            }
            return conn;
        }

        public SqlConnection Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch
            {

            }
            return conn;
        }
    }
}
