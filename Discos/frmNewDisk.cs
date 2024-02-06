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
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Discos
{
    public partial class frmNewDisk : Form
    {
        private Disco disk = null;
        private OpenFileDialog archivo = null;
        HelpersView helpView = new HelpersView();
        private string destinoCarpeta;
        private string destinoArchivo;
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
                if (!helpView.ValidarNumerico(txtCantCanciones, errorProvider1))
                    return;
                disk.CantidadDeCanciones = int.Parse(txtCantCanciones.Text);
                disk.UrlImagenTapa = txtUrlImgTapa.Text;
                disk.Estilo = (Estilo)cboEstilo.SelectedItem;
                disk.TipoEdicion = (TipoEdicion)cboTipoEdicion.SelectedItem;

                if (disk.Id != 0)
                {
                    if (helpView.validacionTexto(ref txtTitulo, errorProvider1))
                    {
                        if (helpView.verificarExitenciaDeImagen(txtUrlImgTapa))
                            helpView.SeleccionarYProcesarImagenlocal(archivo, destinoArchivo, destinoCarpeta);
                        discoNegocio.update(disk);
                        MessageBox.Show("Modificado exitosamente");
                        Close();
                    }     
                }
                else
                {
                    if (helpView.validacionTexto(ref txtTitulo,errorProvider1))
                    {
                        if (helpView.verificarExitenciaDeImagen(txtUrlImgTapa))
                            helpView.SeleccionarYProcesarImagenlocal(archivo, destinoArchivo, destinoCarpeta);
                        discoNegocio.add(disk);
                        MessageBox.Show("Agregado exisotsamente");
                        Close();
                    }
                   
                }
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
                if (disk != null)
                {
                    txtTitulo.Text = disk.Titulo;
                    dtpFechaLanzamiento.Value = disk.FechaDeLanzamiento;
                    txtCantCanciones.Text = disk.CantidadDeCanciones.ToString();
                    txtUrlImgTapa.Text = disk.UrlImagenTapa;
                    helpView.uploadImage(disk.UrlImagenTapa, pxbDiscos);
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
            helpView.uploadImage(txtUrlImgTapa.Text, pxbDiscos);

        }
        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivoDialog = new OpenFileDialog();
            archivoDialog.Filter = "jpg|*.jpg|png|*.png";
            if (archivoDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = archivoDialog; 
                destinoCarpeta = ConfigurationManager.AppSettings["Disk-Img"];
                destinoArchivo = Path.Combine(destinoCarpeta, archivo.SafeFileName);
                txtUrlImgTapa.Text = destinoArchivo;
                helpView.uploadImage(archivo.FileName, pxbDiscos);
            }
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}