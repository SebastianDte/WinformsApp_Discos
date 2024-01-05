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
        private Disco disk = null;

        
        public frmNewDisk()
        {
            InitializeComponent();
            
        }
        public frmNewDisk(Disco select)
        {
            InitializeComponent();
            this.disk = select;
            Text = "Modificar Disco";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            DiscoNegocio discoNegocio = new DiscoNegocio();
            
            try
            {
                if (disk == null)
                     disk = new Disco();
                
                
                disk.Titulo = txtTitulo.Text;
                disk.FechaDeLanzamiento = dtpFechaLanzamiento.Value;
                disk.CantidadDeCanciones = int.Parse(txtCantCanciones.Text);
                disk.UrlImagenTapa = txtUrlImgTapa.Text;
                disk.Estilo = (Estilo)cboEstilo.SelectedItem;
                disk.TipoEdicion = (TipoEdicion)cboTipoEdicion.SelectedItem;

                if(disk.Id != 0 )
                {
                    discoNegocio.update(disk);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    discoNegocio.add(disk);
                    MessageBox.Show("Agregado exisotsamente");
                }
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
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboTipoEdicion.DataSource = tipoEdicionNegocio.tolist();
                cboTipoEdicion.ValueMember = "Id";
                cboTipoEdicion.DisplayMember = "Descripcion";
                if(disk!= null )
                {
                    txtTitulo.Text = disk.Titulo;
                    dtpFechaLanzamiento.Value = disk.FechaDeLanzamiento;
                    txtCantCanciones.Text = disk.CantidadDeCanciones.ToString();
                    uploadImage(disk.UrlImagenTapa);
                    cboEstilo.SelectedValue = disk.Estilo.Id;
                    cboTipoEdicion.SelectedValue = disk.TipoEdicion.Id;
                    
                }

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
