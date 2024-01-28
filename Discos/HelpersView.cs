using business;
using dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discos
{
    public class HelpersView
    {
        public void uploadImage(string imagen,PictureBox pxbDiscos)
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
        public void loadData(ref List<Disco>  diskList, ref DataGridView dgvDisco)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            diskList = negocio.toList();
            dgvDisco.DataSource = diskList;
            hideColumns(ref dgvDisco);
        }
        public void hideColumns(ref DataGridView dgvDisco)
        {
            dgvDisco.Columns["UrlImagenTapa"].Visible = false;
            dgvDisco.Columns["Id"].Visible = false;
        }
        public void SeleccionarYProcesarImagenlocal(OpenFileDialog archivo,string destinoArchivo,string destinoCarpeta)
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
        public string GetUniqueFileName(string folder, string fileName)
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
        public bool verificarExitenciaDeImagen(TextBox txtUrlImgTapa)
        {
            if (!string.IsNullOrEmpty(txtUrlImgTapa.Text))
            {
                return true;
            }
            else
                return false;
        }
        public void eliminarImagenLocal(string rutaImagen)
        {
            if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
            {
                Task.Delay(500).ContinueWith(_ =>
                {
                    File.Delete(rutaImagen);
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
    }
}
