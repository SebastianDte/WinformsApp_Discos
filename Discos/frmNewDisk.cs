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
    public partial class frmNewDisk : Form
    {
        public frmNewDisk()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco disk = new Disco();
            DiscoNegocio discoNegocio = new DiscoNegocio();
            
            try
            {
                disk.Titulo = txtTitulo.Text;
                disk.FechaDeLanzamiento = dtpFechaLanzamiento.Value;
                disk.CantidadDeCanciones = int.Parse(txtCantCanciones.Text);
                disk.UrlImagenTapa = txtUrlImgTapa.Text;
                disk.Estilo = (Estilo)cboEstilo.SelectedItem;
                disk.TipoEdicion = (TipoEdicion)cboTipoEdicion.SelectedItem;
                discoNegocio.add(disk);
                MessageBox.Show("Agregado exisotsamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmNewDisk_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoEdicionNegocio = new TipoEdicionNegocio();

            try
            {
                cboEstilo.DataSource = estiloNegocio.toList();
                cboTipoEdicion.DataSource = tipoEdicionNegocio.tolist();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtUrlImgTapa_Leave(object sender, EventArgs e)
        {
            uploadImage(txtUrlImgTapa.Text);

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

        
    }
}
