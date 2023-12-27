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

namespace Discos
{
    public partial class FrmDisco : Form
    {
        private List<Disco> listaDicos;
        public FrmDisco()
        {
            InitializeComponent();
        }

        private void FrmDisco_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDicos = negocio.listar();
            dgvDisco.DataSource = listaDicos;
            dgvDisco.Columns["UrlImagenTapa"].Visible = false;
            pxbDiscos.Load(listaDicos[0].UrlImagenTapa);

            
        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            
            Disco seleccionado = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
        }

        private void cargarImagen(string imagen)
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
    }
}
