using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discos
{
    public partial class FrmDisco : Form
    {
        public FrmDisco()
        {
            InitializeComponent();
        }

        private void FrmDisco_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            dgvDisco.DataSource = negocio.listar();
        }
    }
}
