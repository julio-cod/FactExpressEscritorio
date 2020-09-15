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
    public partial class frmEmpresa : Form
    {
        DataEmpresa dEmpresa = new DataEmpresa();
        int codigo;
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            cargarEmpresaAll();

        }

        public void cargarEmpresaAll()
        {

            dEmpresa.ListarEmpresasAll(dgvEmpresa);
            cargarComboboxSectores();
            cargarComboboxProvincias();
        }

        public void cargarComboboxSectores()
        {
            cbbSector.DataSource = dEmpresa.CargarComboboxSectores();
            cbbSector.DisplayMember = "nombreSector";
            cbbSector.ValueMember = "codigo";

        }

        public void cargarComboboxProvincias()
        {
            cbbProvincia.DataSource = dEmpresa.CargarComboboxProvincias();
            cbbProvincia.DisplayMember = "nombreProvincia";
            cbbProvincia.ValueMember = "codigo";

        }

        public void desabilitar_textbox()
        {

            txtNombreEmpresa.Enabled = false;
            txtRNC.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            cbbSector.Enabled = false;
            cbbProvincia.Enabled = false;

        }
        public void habilitar_textbox()
        {
            txtNombreEmpresa.Enabled = true;
            txtRNC.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            cbbSector.Enabled = true;
            cbbProvincia.Enabled = true;

        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtNombreEmpresa.Text = "";
            txtRNC.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            cbbSector.Text = "";
            cbbProvincia.Text = "";
            
        }

        public void ValidarVacios()
        {
            if (txtRNC.Text == "")
            {
                txtRNC.Text = "Ninguno";
            }
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
            if (txtNombreEmpresa.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                EmpresaModel empresaModel = new EmpresaModel
                {
                    NombreEmpresa = txtNombreEmpresa.Text,
                    RNC = txtRNC.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    Sector = cbbSector.Text,
                    Provincia = cbbProvincia.Text

                };

                if (dEmpresa.GuardarEmpresa(empresaModel) == true)
                {
                    cargarEmpresaAll();

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
                EmpresaModel empresaModel = new EmpresaModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    NombreEmpresa = txtNombreEmpresa.Text,
                    RNC = txtRNC.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    Sector = cbbSector.Text,
                    Provincia = cbbProvincia.Text

                };
                
                if (dEmpresa.EditarEmpresa(empresaModel) == true)
                {
                    cargarEmpresaAll();

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

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgvEmpresa.Rows[e.RowIndex].Cells[0].Value;
            txtCodigo.Text = dgvEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombreEmpresa.Text = dgvEmpresa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRNC.Text = dgvEmpresa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefono.Text = dgvEmpresa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCorreo.Text = dgvEmpresa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDireccion.Text = dgvEmpresa.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbbSector.Text = dgvEmpresa.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbbProvincia.Text = dgvEmpresa.Rows[e.RowIndex].Cells[7].Value.ToString();

            habilitar_textbox();
            btnGuardar.Visible = false;
            btnnuevo.Visible = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btbcancelar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar esta Empresa?", "Eliminar Empresa", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dEmpresa.EliminarEmpresa(codigo) == true)
                {
                    cargarEmpresaAll();

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
                    MessageBox.Show("Error Eliminando El Empresa");
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

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            cargarEmpresaAll();
        }
    }
}
