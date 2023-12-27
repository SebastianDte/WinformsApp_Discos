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

                discoNegocio.add(disk);
                MessageBox.Show("Agregado exisotsamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
