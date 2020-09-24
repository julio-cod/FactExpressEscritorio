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
    public partial class frmSectores : Form
    {
        DataSector dSector = new DataSector();
        int codigo;
        public frmSectores()
        {
            InitializeComponent();
        }

        private void frmSectores_Load(object sender, EventArgs e)
        {
            cargarProvinciasAll();
            cargarComboboxProvincias();
        }

        public void cargarProvinciasAll()
        {

            dSector.listarSectoresAll(dgvSectores);

        }

        public void cargarComboboxProvincias()
        {
            cbbProvincias.DataSource = dSector.CargarComboboxProvincias();
            cbbProvincias.DisplayMember = "nombreProvincia";
            cbbProvincias.ValueMember = "codigo";

        }

        public void desabilitar_textbox()
        {

            txtSector.Enabled = false;
            cbbProvincias.Enabled = false;

        }
        public void habilitar_textbox()
        {

            txtSector.Enabled = true;
            cbbProvincias.Enabled = true;
        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            txtSector.Text = "";
            cbbProvincias.Text = "";

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
            if (txtSector.Text == "" || cbbProvincias.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                SectorModel sectorModel = new SectorModel
                {
                    NombreSector = txtSector.Text,
                    Provincia = cbbProvincias.Text

                };

                if (dSector.guardarSector(sectorModel) == true)
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtSector.Text == "" || txtCodigo.Text == "" || cbbProvincias.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                SectorModel sectorModel = new SectorModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    NombreSector = txtSector.Text,
                    Provincia = cbbProvincias.Text

                };

                if (dSector.EditarSector(sectorModel) == true)
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

        }

        private void dgvSectores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = (int)dgvSectores.Rows[e.RowIndex].Cells[0].Value;
                txtCodigo.Text = dgvSectores.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSector.Text = dgvSectores.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbProvincias.Text = dgvSectores.Rows[e.RowIndex].Cells[2].Value.ToString();

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
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar este sector?", "Eliminar Sector", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dSector.EliminarSector(codigo) == true)
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
                    MessageBox.Show("error Eliminando El Sector");
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
                dSector.Buscar = txtBuscar.Text;
                dSector.BuscarSectorPorNombre(dgvSectores);
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
                dSector.Buscar = txtBuscar.Text;
                dSector.BuscarSectorPorNombre(dgvSectores);
            }
            else
            {
                btnBuscar.Enabled = false;
                cargarProvinciasAll();
            }
        }

        private void btnBuscformProvincias_Click(object sender, EventArgs e)
        {
            frmProvincias fp = new frmProvincias();
            fp.ShowDialog();
                
        }

        private void cbbProvincias_Click(object sender, EventArgs e)
        {
            string provincia = cbbProvincias.Text;
            cargarComboboxProvincias();
            cbbProvincias.Text = provincia;
        }

        private void cbbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
