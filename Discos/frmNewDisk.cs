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

namespace Discos
{
    public partial class frmNewDisk : Form
    {
        private Disco disk = null;
        private OpenFileDialog archivo = null;
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
                disk.CantidadDeCanciones = int.Parse(txtCantCanciones.Text);
                disk.UrlImagenTapa = txtUrlImgTapa.Text;
                disk.Estilo = (Estilo)cboEstilo.SelectedItem;
                disk.TipoEdicion = (TipoEdicion)cboTipoEdicion.SelectedItem;
                if (disk.Id != 0)
                {
                    discoNegocio.update(disk);
                    if (!string.IsNullOrEmpty(txtUrlImgTapa.Text))
                    { 
                        SeleccionarYProcesarImagenlocal();
                    }
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    discoNegocio.add(disk);
                    if (!string.IsNullOrEmpty(txtUrlImgTapa.Text))
                    {
                        SeleccionarYProcesarImagenlocal();
                    }
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
                if (disk != null)
                {
                    txtTitulo.Text = disk.Titulo;
                    dtpFechaLanzamiento.Value = disk.FechaDeLanzamiento;
                    txtCantCanciones.Text = disk.CantidadDeCanciones.ToString();
                    txtUrlImgTapa.Text = disk.UrlImagenTapa;
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
                uploadImage(archivo.FileName);
            }
        }
        private string GetUniqueFileName(string folder, string fileName)
        {
            string uniqueFileName = fileName;

            int counter = 1;
            while (File.Exists(Path.Combine(folder, uniqueFileName)))
            {
                // Si el archivo ya existe, agregar un número al final del nombre del archivo.
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                string fileExtension = Path.GetExtension(fileName);
                uniqueFileName = $"{fileNameWithoutExtension}_{counter}{fileExtension}";

                counter++;
            }
            return Path.Combine(folder, uniqueFileName);
        }
        private void SeleccionarYProcesarImagenlocal()
        {
            if (archivo != null)
            {
                if (File.Exists(destinoArchivo))
                {
                    DialogResult result = MessageBox.Show("La imagen ya existe. ¿Desea reemplazarla?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Reemplazar la imagen existente.
                        try
                        {
                            File.Delete(destinoArchivo);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show($"Error al eliminar la imagen existente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            File.Copy(archivo.FileName, destinoArchivo);                            
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show($"Error al reemplazar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        // Mantener ambos archivos 
                        destinoArchivo = GetUniqueFileName(destinoCarpeta, archivo.SafeFileName);
                        File.Copy(archivo.FileName, destinoArchivo);
                    }  
                }
                else
                {
                    File.Copy(archivo.FileName, destinoArchivo);
                }
            }
        }

    }
}