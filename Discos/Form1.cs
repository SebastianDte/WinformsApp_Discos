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
namespace Discos
{
    public partial class FrmDisco : Form
    {
        private List<Disco> diskList;
        private string destinoArchivo;

        public FrmDisco()
        {
            InitializeComponent();
        } 
        private void FrmDisco_Load(object sender, EventArgs e)
        {
            loadData();
            hideColumns();
            cboCampo.Items.Add("Titulo");
            cboCampo.Items.Add("Cantidad de Canciones");
            cboCampo.Items.Add("Estilo");
        }
        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDisco.CurrentRow != null)
            {
                Disco selected = (Disco)dgvDisco.CurrentRow.DataBoundItem;
                uploadImage(selected.UrlImagenTapa);
            }    
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNewDisk newDisk = new frmNewDisk();
            newDisk.ShowDialog();            
            loadData();
            hideColumns();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvDisco.CurrentRow != null)
            {
                Disco select;
                select = (Disco)dgvDisco.CurrentRow.DataBoundItem;
                frmNewDisk updateDisk = new frmNewDisk(select);
                updateDisk.ShowDialog();
                loadData();
                hideColumns();
            }
            else { MessageBox.Show("Seleccione un elemento de la lista"); }
            
        }
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            Disco select;
            try
            {
                    if (dgvDisco.CurrentRow != null)
                    {
                        DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminarlo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                        select = (Disco)dgvDisco.CurrentRow.DataBoundItem;

                        // Paso 1: Obtener la ruta de la imagen asociada
                        string rutaImagen = select.UrlImagenTapa; // Ajusta esto según la estructura de tu clase Disco

                        // Paso 2: Eliminar el disco de la base de datos
                        using (FileStream fs = new FileStream(destinoArchivo, FileMode.Open, FileAccess.ReadWrite)) { }
                        discoNegocio.delete(select.Id);

                        // Paso 3: Eliminar la imagen asociada
                        if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
                        {
                            File.Delete(rutaImagen);
                        }
                            loadData();
                            hideColumns();
                        }                                 
                    }
                    else { MessageBox.Show("Seleccione un elemento de la Lista"); }     
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvDisco.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        //Metodos
        private void loadData()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            diskList = negocio.toList();
            dgvDisco.DataSource = diskList;
            
        }
        private void hideColumns()
        {
            dgvDisco.Columns["UrlImagenTapa"].Visible = false;
            pxbDiscos.Load(diskList[0].UrlImagenTapa);
            dgvDisco.Columns["Id"].Visible = false;
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


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listFilter;
            string filter = txtFiltro.Text;
            if (filter.Length >= 2)
            {
                listFilter = diskList.FindAll(x => x.Titulo.ToUpper().Contains(filter.ToUpper()));
            }
            else
            {
                listFilter = diskList;
            }
            dgvDisco.DataSource = null;
            dgvDisco.DataSource = listFilter;
            hideColumns();
    }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cboCampo.SelectedItem.ToString();

            if(option == "Cantidad de Canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
        }
    }
}

