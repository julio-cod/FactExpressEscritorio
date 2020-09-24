using FactExpressDesktop.Clases;
using FactExpressDesktop.Modelos;
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
    public partial class frmClientes : Form
    {
        DataCliente dCliente = new DataCliente();
        int codigo;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarClientesAll();
        }

        public void cargarClientesAll()
        {

            dCliente.ListarClientesAll(dgvClienttes);
            cargarComboboxSectores();
            cargarComboboxProvincias();
        }

        public void cargarComboboxSectores()
        {
            cbbSector.DataSource = dCliente.CargarComboboxSectores();
            cbbSector.DisplayMember = "nombreSector";
            cbbSector.ValueMember = "codigo";

        }

        public void cargarComboboxProvincias()
        {
            cbbProvincia.DataSource = dCliente.CargarComboboxProvincias();
            cbbProvincia.DisplayMember = "nombreProvincia";
            cbbProvincia.ValueMember = "codigo";

        }

        public void desabilitar_textbox()
        {

            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            cbbSector.Enabled = false;
            cbbProvincia.Enabled = false;

        }
        public void habilitar_textbox()
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            cbbSector.Enabled = true;
            cbbProvincia.Enabled = true;

        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            cbbSector.Text = "";
            cbbProvincia.Text = "";
            txtBuscar.Text = "";

        }

        public void ValidarVacios()
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ninguno";
            }
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Ninguno";
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Ninguna";
            }
            if (cbbSector.Text == "")
            {
                cbbSector.Text = "Ninguno";
            }
            if (cbbProvincia.Text == "")
            {
                cbbProvincia.Text = "Ninguna";
            }
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar_textbox();
            btnGuardar.Visible = true;
            btnnuevo.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btbcancelar.Enabled = true;
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            desabilitar_textbox();
            btnGuardar.Visible = false;
            btnnuevo.Visible = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btbcancelar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarVacios();
            if (txtNombre.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                ClienteModel clienteModel = new ClienteModel
                {
                    NombreCliente = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    Sector = cbbSector.Text,
                    Provincia = cbbProvincia.Text

                };

                if (dCliente.GuardarCliente(clienteModel) == true)
                {
                    cargarClientesAll();

                    limpiar();
                    desabilitar_textbox();
                    btnGuardar.Visible = false;
                    btnnuevo.Visible = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btbcancelar.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Error al guardar datos");
                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ValidarVacios();

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                ClienteModel clienteModel = new ClienteModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    NombreCliente = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    Sector = cbbSector.Text,
                    Provincia = cbbProvincia.Text

                };
               

                if (dCliente.EditarCliente(clienteModel) == true)
                {
                    cargarClientesAll();

                    limpiar();

                    desabilitar_textbox();
                    btnGuardar.Visible = false;
                    btnnuevo.Visible = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btbcancelar.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Error al editar datos");
                }


            }
        }

        private void dgvClienttes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = (int)dgvClienttes.Rows[e.RowIndex].Cells[0].Value;
                txtCodigo.Text = dgvClienttes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvClienttes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefono.Text = dgvClienttes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCorreo.Text = dgvClienttes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDireccion.Text = dgvClienttes.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbSector.Text = dgvClienttes.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbbProvincia.Text = dgvClienttes.Rows[e.RowIndex].Cells[6].Value.ToString();

                habilitar_textbox();
                btnGuardar.Visible = false;
                btnnuevo.Visible = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btbcancelar.Enabled = true;
            }
            catch (Exception)
            {

             
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar este Cliente?", "Eliminar Cliente", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dCliente.EliminarCliente(codigo) == true)
                {
                    cargarClientesAll();

                    limpiar();

                    desabilitar_textbox();

                    btnGuardar.Visible = false;
                    btnnuevo.Visible = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btbcancelar.Enabled = false;

                }

                else
                {
                    MessageBox.Show("Error Eliminando El Cliente");
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {
                limpiar();

                desabilitar_textbox();
                btnGuardar.Visible = false;
                btnnuevo.Visible = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btbcancelar.Enabled = false;
            }
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

        private void cbbSector_Click(object sender, EventArgs e)
        {
            string sector = cbbSector.Text;
            cargarComboboxSectores();
            cbbSector.Text = sector;
        }

        private void cbbProvincia_Click(object sender, EventArgs e)
        {
            string provincia = cbbProvincia.Text;
            cargarComboboxProvincias();
            cbbProvincia.Text = provincia;
        }

        private void btnBuscformSector_Click(object sender, EventArgs e)
        {
            frmSectores fs = new frmSectores();
            fs.ShowDialog();
        }

        private void btnBuscformProvincias_Click(object sender, EventArgs e)
        {
            frmProvincias fp = new frmProvincias();
            fp.ShowDialog();
        }
    }
}
