using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactExpressDesktop.Presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gESTIONARUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fu = new frmUsuarios();
            fu.ShowDialog();
        }

        private void rEGISTRARPROVINCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincias fp = new frmProvincias();
            fp.Show();
        }

        private void rEGISTRARSECTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectores fs = new frmSectores();
            fs.Show();
        }

        private void rEGISTRARCATEGORIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias fc = new frmCategorias();
            fc.Show();
        }
    }
}
