using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Discos
{
    internal class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco>lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=Discos_DB;integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa from discos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read()) 
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaDeLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
