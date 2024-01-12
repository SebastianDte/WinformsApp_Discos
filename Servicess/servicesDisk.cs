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
        private List<Disco> diskList;
        public void cargar(List<Disco> diskList, DataGridView dgvDisco)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            diskList = negocio.toList();
            dgvDisco.DataSource = diskList;
            

        }
        public void ocultColumns(DataGridView dgvDisco, PictureBox pxbDiscos)
        {
            dgvDisco.Columns["UrlImagenTapa"].Visible = false;
            //pxbDiscos.Load(diskList[0].UrlImagenTapa);
            dgvDisco.Columns["Id"].Visible = false;
        }
    }
}
