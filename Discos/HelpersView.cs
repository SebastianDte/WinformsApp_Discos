using business;
using dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
        public bool validarFiltro(ref ComboBox cboCampo,ComboBox cboCriterio, TextBox txtFiltroAvanzado)
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el Campo");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el Criterio");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Cantidad de Canciones")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numericos");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Cantidad de Canciones solo admite Numeros");
                    return true;
                }

            }

            return false;
        }
        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                { 
                    return false;
                }
            }
            return true;
        }
        public bool validacionTexto(ref TextBox txt, ErrorProvider errorProvider1)
        {
            string titulo = txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(titulo))
            {
                errorProvider1.SetError(txt, "El campo no puede estar vacío");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            // Verificar que el campo tenga más de 3 caracteres
            if (titulo.Length < 3)
            {
                errorProvider1.SetError(txt, "Ingrese más de 3 caracteres");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            // Verificar que el campo contenga solo letras
            //if (!Regex.IsMatch(titulo, @"^[a-zA-Z]+$"))
            //{
            //    errorProvider1.SetError(txt, "Ingrese solo letras");
            //    return false;
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
            return true;
        }
        public  bool ValidarNumerico(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Este campo no puede estar vacío.");
                textBox.Focus();
                return false;
            }
            else
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    errorProvider.SetError(textBox, "Por favor ingrese solo números.");
                    textBox.Focus();
                    return false;
                }
                else
                {
                    errorProvider.Clear();
                    return true;
                }
            }

        }
        public void customizeDesing(ref Panel panelSubMenuDiscos, Panel panelSubMenuBuscar)
        {
            panelSubMenuDiscos.Visible = false;
            panelSubMenuBuscar.Visible = false;
        }
        public void hideSubMenu(ref Panel panelSubMenuDiscos, Panel panelSubMenuBuscar )
        {
            if (panelSubMenuDiscos.Visible == true)
                panelSubMenuDiscos.Visible = false;
            if (panelSubMenuBuscar.Visible == true)
                panelSubMenuBuscar.Visible = false;
        }
        public void showSubMenu(ref Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu(ref submenu,submenu);
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
    }
}
