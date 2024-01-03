using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using business;
namespace Discos
{
    public partial class FrmDisco : Form
    {
        private List<Disco> diskList;
        public FrmDisco()
        {
            InitializeComponent();
        }

        private void FrmDisco_Load(object sender, EventArgs e)
        {
            cargar();

            
        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            
            Disco selected = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            uploadImage(selected.UrlImagenTapa);
        }

        private void uploadImage(string imagen)
        {
            try
            {
                pxbDiscos.Load(imagen);
            }
            catch (Exception)
            {

                pxbDiscos.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNewDisk newDisk = new frmNewDisk();
            newDisk.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            diskList = negocio.toList();
            dgvDisco.DataSource = diskList;
            dgvDisco.Columns["UrlImagenTapa"].Visible = false;
            pxbDiscos.Load(diskList[0].UrlImagenTapa);
        }
    }
}
