using FactExpressDesktop.Clases;
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
    public partial class frmConsultaClienteDesdePedidos : Form
    {
        DataCliente dCliente = new DataCliente();
       

        public delegate void pasarDatosCliente(string codigoCliente, string nombreCliente, string lugarEntrega);
        public event pasarDatosCliente pasadoCliente;

        public frmConsultaClienteDesdePedidos()
        {
            InitializeComponent();
        }

        private void frmConsultaClienteDesdePedidos_Load(object sender, EventArgs e)
        {
            cargarClientesAll();
        }

        public void cargarClientesAll()
        {

            dCliente.ListarClientesAll(dgvClienttes);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbBuscarPor.Text == "Nombre")
            {
                if (txtBuscar.Text != "")
                {
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorNombre(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
            else if (cbbBuscarPor.Text == "Codigo")
            {
                if (txtBuscar.Text != "")
                {
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorCodigo(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }

            }
            else if (cbbBuscarPor.Text == "Sector")
            {
                if (txtBuscar.Text != "")
                {
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorSector(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
            else if (cbbBuscarPor.Text == "Provincia")
            {
                if (txtBuscar.Text != "")
                {
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorProvincia(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
            else
            {
                cbbBuscarPor.Text = "Nombre";
                if (txtBuscar.Text != "")
                {
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorNombre(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbbBuscarPor.Text == "Nombre")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorNombre(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarClientesAll();
                }
            }
            else if (cbbBuscarPor.Text == "Codigo")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorCodigo(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarClientesAll();
                }

            }
            else if (cbbBuscarPor.Text == "Sector")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorSector(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarClientesAll();
                }
            }
            else if (cbbBuscarPor.Text == "Provincia")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorProvincia(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarClientesAll();
                }
            }
            else
            {
                cbbBuscarPor.Text = "Nombre";
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dCliente.Buscar = txtBuscar.Text;
                    dCliente.BuscarClientePorNombre(dgvClienttes);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarClientesAll();
                }
            }
        }

        

        private void dgvClienttes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoCliente, nombreCliente,lugarEntrega, direccion, sector, provincia;
          
            try
            {
                codigoCliente = dgvClienttes.CurrentRow.Cells[0].Value.ToString();
                nombreCliente = dgvClienttes.CurrentRow.Cells[1].Value.ToString();
                direccion = dgvClienttes.CurrentRow.Cells[4].Value.ToString();
                sector = dgvClienttes.CurrentRow.Cells[5].Value.ToString();
                provincia = dgvClienttes.CurrentRow.Cells[6].Value.ToString();

                lugarEntrega = direccion +", "+"Sector " + sector +", "+"Provincia: "+ provincia;

                pasadoCliente(codigoCliente, nombreCliente, lugarEntrega);
                
                this.Close();



            }
            catch (Exception)
            {
                this.Close();

            }
        }

        private void btnBuscarFormClientes_Click(object sender, EventArgs e)
        {
            frmClientes fc = new frmClientes();
            fc.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarClientesAll();
        }
    }
}
