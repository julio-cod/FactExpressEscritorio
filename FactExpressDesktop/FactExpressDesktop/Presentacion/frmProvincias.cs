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
    public partial class frmProvincias : Form
    {
        DataProvincia dProvincia = new DataProvincia();
        int codigo;
        public frmProvincias()
        {
            InitializeComponent();
        }

        private void frmProvincias_Load(object sender, EventArgs e)
        {
            cargarProvinciasAll();
        }

        public void cargarProvinciasAll()
        {

            dProvincia.listarProvinciasAll(dgvProvincias);

        }

        public void desabilitar_textbox()
        {

            txtNombreProvincia.Enabled = false;

        }
        public void habilitar_textbox()
        {

            txtNombreProvincia.Enabled = true;

        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            txtNombreProvincia.Text = "";

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
            if (txtNombreProvincia.Text == "" )
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                ProvinciaModel provinciaModel = new ProvinciaModel
                {
                    NombreProvincia = txtNombreProvincia.Text

                };

                if (dProvincia.ValidarProvinciaExiste(provinciaModel.NombreProvincia) == false)
                {
                    if (dProvincia.guardarProvincia(provinciaModel) == true)
                    {
                        cargarProvinciasAll();

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
                else
                {
                    MessageBox.Show("El nombre de Provincia ya existe");
                }



            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombreProvincia.Text == "" || txtCodigo.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                ProvinciaModel provinciaModel = new ProvinciaModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    NombreProvincia = txtNombreProvincia.Text

                };

                if (dProvincia.ValidarProvinciaExiste(provinciaModel.NombreProvincia) == false)
                {
                    if (dProvincia.EditarProvincia(provinciaModel) == true)
                    {
                        cargarProvinciasAll();

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
                else
                {
                    MessageBox.Show("Erro! - El nombre de Provincia ya existe");
                }



            }
        }

        private void dgvProvincias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgvProvincias.Rows[e.RowIndex].Cells[0].Value;
            txtCodigo.Text = dgvProvincias.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombreProvincia.Text = dgvProvincias.Rows[e.RowIndex].Cells[1].Value.ToString();

            habilitar_textbox();
            btnGuardar.Visible = false;
            btnnuevo.Visible = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btbcancelar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar esta Provincia?", "Eliminar Provincia", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dProvincia.EliminarProvincia(codigo) == true)
                {
                    cargarProvinciasAll();

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
                    MessageBox.Show("error Eliminando La Provincia");
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
            if (txtBuscar.Text != "")
            {
                dProvincia.Buscar = txtBuscar.Text;
                dProvincia.BuscarProvinciaPorNombre(dgvProvincias);
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                btnBuscar.Enabled = true;
                dProvincia.Buscar = txtBuscar.Text;
                dProvincia.BuscarProvinciaPorNombre(dgvProvincias);
            }
            else
            {
                btnBuscar.Enabled = false;
                cargarProvinciasAll();
            }
        }
    }
}
