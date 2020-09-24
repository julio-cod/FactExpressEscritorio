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
    public partial class frmProveedores : Form
    {
        DataProveedor dProveedor = new DataProveedor();
        int codigo;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargarProveedoresAll();
        }

        public void cargarProveedoresAll()
        {

            dProveedor.ListarProveedoresAll(dgvProveedores);
         
        }

        public void desabilitar_textbox()
        {

            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtCelular.Enabled = false;
            txtDireccion.Enabled = false;

        }
        public void habilitar_textbox()
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCelular.Enabled = true;
            txtDireccion.Enabled = true;

        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";

        }

        public void ValidarVacios()
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ninguno";
            }
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Ninguno";
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Ninguna";
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
                ProveedorModel proveedorModel = new ProveedorModel
                {
                    NombreProveedor = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Celular = txtCelular.Text,
                    Direccion = txtDireccion.Text

                };

                if (dProveedor.GuardarProveedor(proveedorModel) == true)
                {
                    cargarProveedoresAll();

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
                ProveedorModel proveedorModel = new ProveedorModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    NombreProveedor = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Celular = txtCelular.Text,
                    Direccion = txtDireccion.Text

                };
               

                if (dProveedor.EditarProveedor(proveedorModel) == true)
                {
                    cargarProveedoresAll();

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

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = (int)dgvProveedores.Rows[e.RowIndex].Cells[0].Value;
                txtCodigo.Text = dgvProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCelular.Text = dgvProveedores.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDireccion.Text = dgvProveedores.Rows[e.RowIndex].Cells[4].Value.ToString();

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
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar este Proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dProveedor.EliminarProveedor(codigo) == true)
                {
                    cargarProveedoresAll();

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
                    MessageBox.Show("Error Eliminando El Proveedor");
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
                    dProveedor.Buscar = txtBuscar.Text;
                    dProveedor.BuscarProveedorPorNombre(dgvProveedores);
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
                    dProveedor.Buscar = txtBuscar.Text;
                    dProveedor.BuscarProveedorPorCodigo(dgvProveedores);
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
                    dProveedor.Buscar = txtBuscar.Text;
                    dProveedor.BuscarProveedorPorNombre(dgvProveedores);
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
                    dProveedor.Buscar = txtBuscar.Text;
                    dProveedor.BuscarProveedorPorNombre(dgvProveedores);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProveedoresAll();
                }
            }
            else if (cbbBuscarPor.Text == "Codigo")
            {
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dProveedor.Buscar = txtBuscar.Text;
                    dProveedor.BuscarProveedorPorCodigo(dgvProveedores);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProveedoresAll();
                }

            }
            
            else
            {
                cbbBuscarPor.Text = "Nombre";
                if (txtBuscar.Text != "")
                {
                    btnBuscar.Enabled = true;
                    dProveedor.Buscar = txtBuscar.Text;
                    dProveedor.BuscarProveedorPorNombre(dgvProveedores);
                }
                else
                {
                    btnBuscar.Enabled = false;
                    cargarProveedoresAll();
                }
            }
        }
    }
}
