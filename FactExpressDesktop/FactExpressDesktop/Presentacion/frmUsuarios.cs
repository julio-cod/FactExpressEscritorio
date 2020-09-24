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
    public partial class frmUsuarios : Form
    {
        DataUsuario dUsuario = new DataUsuario();
        int codigo;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuariosAll();
        }
        public void cargarUsuariosAll()
        {

            dUsuario.listarUsuariosAll(dgvUsuario);

        }

        public void desabilitar_textbox()
        {

            cbbTipo.Enabled = false;
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            cbbEstado.Enabled = false;

        }
        public void habilitar_textbox()
        {

            cbbTipo.Enabled = true;
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            cbbEstado.Enabled = true;

        }

        public void limpiar()
        {

            txtCodigo.Text = "";
            cbbTipo.Text = "";
            txtusuario.Text = "";
            txtclave.Text = "";
            cbbEstado.Text = "";


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
            txtCodigo.Clear();
            txtusuario.Clear();
            txtclave.Clear();
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


            if (txtusuario.Text == "" || txtclave.Text == "" || cbbTipo.Text == "" || cbbEstado.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                UsuarioModel usuarioModel = new UsuarioModel
                {
                    Usuario = txtusuario.Text,
                    Clave = txtclave.Text,
                    Tipo = cbbTipo.Text,
                    Estado = cbbEstado.Text

                };

                ;

                if (dUsuario.ValidarNombreExiste(usuarioModel.Usuario) == false)
                {
                    if (dUsuario.guardarUsuario(usuarioModel) == true)
                    {
                        cargarUsuariosAll();

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
                    MessageBox.Show("Erro! - El nombre de usuario ya existe");
                }

                

            }
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtclave.Text == "" || cbbTipo.Text == "" || cbbEstado.Text == "")
            {
                MessageBox.Show("faltan datos");
                return;
            }
            else
            {
                UsuarioModel usuarioModel = new UsuarioModel
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    Usuario = txtusuario.Text,
                    Clave = txtclave.Text,
                    Tipo = cbbTipo.Text,
                    Estado = cbbEstado.Text

                };

                if (dUsuario.ValidarNombreExiste(usuarioModel.Usuario) == false)
                {
                    if (dUsuario.EditarUsuario(usuarioModel) == true)
                    {
                        cargarUsuariosAll();

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
                    MessageBox.Show("Erro! - El nombre de usuario ya existe");
                }

                    

            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = (int)dgvUsuario.Rows[e.RowIndex].Cells[0].Value;
                txtCodigo.Text = dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtusuario.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtclave.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbTipo.Text = dgvUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbEstado.Text = dgvUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();

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
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dUsuario.EliminarUsuario(codigo) == true)
                {
                    cargarUsuariosAll();


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
                    MessageBox.Show("error Eliminando usuario");
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

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            if (cbbBuscarPorEstado.Text == "Todos")
            {
                cargarUsuariosAll();
            }
            else if (cbbBuscarPorEstado.Text == "Activos")
            {
                dUsuario.listarUsuariosActivos(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "Inactivos")
            {
                dUsuario.listarUsuariosInactivos(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "Pendientes")
            {
                dUsuario.listarUsuariosPendientes(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "Bloqueados")
            {
                dUsuario.listarUsuariosBloqueados(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "")
            {
                cbbBuscarPorEstado.Text = "Todos";
                cargarUsuariosAll();

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dUsuario.Buscar = txtBuscar.Text;
                dUsuario.BuscarUsuariosPorNombre(dgvUsuario);
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
                dUsuario.Buscar = txtBuscar.Text;
                dUsuario.BuscarUsuariosPorNombre(dgvUsuario);
            }
            else
            {
                btnBuscar.Enabled = false;
                cargarUsuariosAll();
            }
        }

        private void cbbBuscarPorEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBuscarPorEstado.Text == "Todos")
            {
                cargarUsuariosAll();
            }
            else if (cbbBuscarPorEstado.Text == "Activos")
            {
                dUsuario.listarUsuariosActivos(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "Inactivos")
            {
                dUsuario.listarUsuariosInactivos(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "Pendientes")
            {
                dUsuario.listarUsuariosPendientes(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "Bloqueados")
            {
                dUsuario.listarUsuariosBloqueados(dgvUsuario);
            }
            else if (cbbBuscarPorEstado.Text == "")
            {
                cbbBuscarPorEstado.Text = "Todos";
                cargarUsuariosAll();

            }
        }
    }
}
