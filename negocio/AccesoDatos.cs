using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;

        private SqlCommand comando;
        private SqlDataReader lector;
        private string consulta; //aca guarda la consulta a llamar

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos() //creo su constructor
        {
            conexion = new SqlConnection("server=¨.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void SetearConsulta(string Consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = Consulta;
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void CerrarConeccion()
        {
            if (lector != null) { lector.Close(); }
            conexion.Close();
        }

        public object EjecutarEscalar ()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                return comando.ExecuteScalar(); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
