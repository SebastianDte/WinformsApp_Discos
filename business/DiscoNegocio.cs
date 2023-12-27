using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace business
{
    public class DiscoNegocio
    {
        public List<Disco> toList()
        {
            List<Disco> list = new List<Disco>();
            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.setConsultation("select titulo, FechaLanzamiento, CantidadCanciones,UrlImagenTapa,E.Descripcion as EstiloDescripcion,T.Descripcion as TipoEdicionDescripcion from Discos D,ESTILOS E,TIPOSEDICION T  where E.Id = D.IdEstilo and T.Id = D.IdTipoEdicion");
                dataAccess.executeReading();
                while (dataAccess.Reader.Read()) 
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)dataAccess.Reader["Titulo"];
                    aux.FechaDeLanzamiento = (DateTime)dataAccess.Reader["FechaLanzamiento"];
                    aux.CantidadDeCanciones = (int)dataAccess.Reader["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)dataAccess.Reader["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)dataAccess.Reader["EstiloDescripcion"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Descripcion = (string)dataAccess.Reader["TipoEdicionDescripcion"];
                    list.Add(aux);
                }
                dataAccess.closeConecction();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void add(Disco newDisk)
        {
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.setConsultation("insert into DISCOS (Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa) values ('" + newDisk.Titulo + "', '" + newDisk.FechaDeLanzamiento + "', " + newDisk.CantidadDeCanciones + ", '" + newDisk.UrlImagenTapa + "')");
                dataAccess.ExecuteAction();


               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { dataAccess.closeConecction(); }
        }
            
            
    }
}
