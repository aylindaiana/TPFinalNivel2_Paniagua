using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domino;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select Id, Descripcion From MARCAS");
                datos.EjecutarLectura();
                SqlDataReader lector = datos.Lector;
                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Descipcion = (string)lector["Descripcion"];

                    listaMarcas.Add(aux);
                }
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConeccion();
            }
        }
        public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into MARCAS (Descripcion) values (@Descripcion)");
                datos.SetearParametro("@Descripcion", nuevo.Descipcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConeccion();
            }
        }
    }
}
