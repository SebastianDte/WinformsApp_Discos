using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace business
{
    public class TipoEdicionNegocio
    {
        DataAccess dataAccess = new DataAccess();
        public List<TipoEdicion>tolist()
        {
            List<TipoEdicion> list = new List<TipoEdicion>();
            try
            {
                dataAccess.setConsultation("SELECT Id, Descripcion FROM TIPOSEDICION");
                dataAccess.executeReading();
                while (dataAccess.Reader.Read())
                {
                    TipoEdicion aux = new TipoEdicion();
                    aux.Id = (int)dataAccess.Reader["Id"];
                    aux.Descripcion = (string)dataAccess.Reader["Descripcion"];
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
    }
}
