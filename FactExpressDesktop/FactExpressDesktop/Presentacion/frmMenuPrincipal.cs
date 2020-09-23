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

        private void rEGISTRARPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos fpd = new frmProductos();
            fpd.Show();
        }

        private void rEGISTRARCLENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes fct = new frmClientes();
            fct.Show();
        }

        private void rEGISTRARPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores fpv = new frmProveedores();
            fpv.Show();
        }

        private void gESTIONAREMPRESALOCALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa fe = new frmEmpresa();
            fe.ShowDialog();
        }

        private void cREARPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidos fcp = new frmPedidos();
            fcp.ShowDialog();
        }

        private void pEDIDOSPENDIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarPedidos fg = new frmGestionarPedidos();
            fg.Show();
        }

        private void aSIGNARPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarPedidos fa = new frmAsignarPedidos();
            fa.Show();
        }
    }
}
