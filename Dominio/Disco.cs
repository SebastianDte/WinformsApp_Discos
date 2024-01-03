using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        
        public string Titulo { get; set; }
        [DisplayName("Fecha de Lanzmaiento")]
        public DateTime FechaDeLanzamiento { get; set; }
        [DisplayName("Cantidad de Canciones")]
        public int CantidadDeCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        [DisplayName("Tipo de Edición")]
        public TipoEdicion TipoEdicion { get; set; }

    }
}
