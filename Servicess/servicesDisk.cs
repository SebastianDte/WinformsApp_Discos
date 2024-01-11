using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using business;
using System.Windows.Forms;

namespace Servicess
{
    public class serviceDisk
    {
        public void cargar(List<Disco> diskList, DataGridView dgvDisco)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            diskList = negocio.toList();
            dgvDisco.DataSource = diskList;

        }
    }
}
