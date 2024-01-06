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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco select;
            select = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            frmNewDisk updateDisk = new frmNewDisk(select);
            updateDisk.ShowDialog();
            cargar();
        }
        private void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            diskList = negocio.toList();
            dgvDisco.DataSource = diskList;
            dgvDisco.Columns["UrlImagenTapa"].Visible = false;
            pxbDiscos.Load(diskList[0].UrlImagenTapa);
            dgvDisco.Columns["Id"].Visible = false;
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            Disco select;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminarlo?", "Eliminando...",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    select = (Disco)dgvDisco.CurrentRow.DataBoundItem;
                    discoNegocio.delete(select.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    } 
}

