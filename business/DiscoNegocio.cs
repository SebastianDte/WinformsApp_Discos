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
                dataAccess.setConsultation("select d.Id,titulo, FechaLanzamiento, CantidadCanciones,UrlImagenTapa,E.Descripcion as EstiloDescripcion,T.Descripcion as TipoEdicionDescripcion,D.IdEstilo,D.IdTipoEdicion from Discos D,ESTILOS E,TIPOSEDICION T  where E.Id = D.IdEstilo and T.Id = D.IdTipoEdicion");
                dataAccess.executeReading();
                while (dataAccess.Reader.Read()) 
                {
                    Disco aux = new Disco();
                    aux.Id = (int)dataAccess.Reader["Id"];
                    aux.Titulo = (string)dataAccess.Reader["Titulo"];
                    aux.FechaDeLanzamiento = (DateTime)dataAccess.Reader["FechaLanzamiento"];
                    aux.CantidadDeCanciones = (int)dataAccess.Reader["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)dataAccess.Reader["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)dataAccess.Reader["EstiloDescripcion"];
                    aux.Estilo.Id = (int)dataAccess.Reader["IdEstilo"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Descripcion = (string)dataAccess.Reader["TipoEdicionDescripcion"];
                    aux.TipoEdicion.Id = (int)dataAccess.Reader["IdTipoEdicion"];
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
                dataAccess.setConsultation("insert into DISCOS (Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,idEstilo,IdTipoEdicion) values (@Titulo,@FechaDeLanzamiento,@CantidadCanciones,@UrlImagenTapa,@idEstilo,@idTipoEdicion)");
                dataAccess.setParameters("@Titulo", newDisk.Titulo);
                dataAccess.setParameters("@FechaDeLanzamiento", newDisk.FechaDeLanzamiento);
                dataAccess.setParameters("@CantidadCanciones", newDisk.CantidadDeCanciones);
                dataAccess.setParameters("@UrlImagenTapa",newDisk.UrlImagenTapa);
                dataAccess.setParameters("@idEstilo",newDisk.Estilo.Id);
                dataAccess.setParameters("@idTipoEdicion", newDisk.TipoEdicion.Id);
                dataAccess.ExecuteAction();           
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { dataAccess.closeConecction(); }
        } 
        
        public void update(Disco updateDisk) 
        {
            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.setConsultation("update DISCOS set Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento,CantidadCanciones = @CantidadCanciones,UrlImagenTapa = @UrlImagenTapa,IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipoEdicion where id = @id");
                dataAccess.setParameters("@Titulo", updateDisk.Titulo);
                dataAccess.setParameters("@FechaLanzamiento", updateDisk.FechaDeLanzamiento);
                dataAccess.setParameters("@CantidadCanciones", updateDisk.CantidadDeCanciones);
                dataAccess.setParameters("@UrlImagenTapa", updateDisk.UrlImagenTapa);
                dataAccess.setParameters("@IdEstilo", updateDisk.Estilo.Id);
                dataAccess.setParameters("@IdTipoEdicion", updateDisk.TipoEdicion.Id);
                dataAccess.setParameters("@id", updateDisk.Id);
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
