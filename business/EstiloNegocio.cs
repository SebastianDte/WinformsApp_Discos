using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace business
{
    public class EstiloNegocio
    {
        public List<Estilo> toList()
        {
            List<Estilo> list = new List<Estilo>();
            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.setConsultation("SELECT Id, Descripcion FROM ESTILOS");
                dataAccess.executeReading();
                while (dataAccess.Reader.Read())
                {
                    Estilo aux = new Estilo();
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
