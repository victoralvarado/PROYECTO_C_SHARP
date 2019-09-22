using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        private Usuario U = new Usuario();
        private string idUsuario = null;
        private bool Modificar = false;

        public frmUsuario()
        {
            InitializeComponent();
        }


        public void CargarTipoUsuario()
        {
            cmbTipo.Items.Add("- Seleccionar -");
            cmbTipo.Items.Add("Administrador");
            cmbTipo.Items.Add("Editor");
            cmbTipo.SelectedIndex = 0;
        }
        private void ListarUsuarios()
        {
            Usuario LU = new Usuario();
            dgvUsuario.DataSource = LU.ListarUsuario();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarTipoUsuario();
            ListarUsuarios();
           dgvUsuario.Columns["password"].Visible = false;
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            if (Modificar == false)
            {
                try
                {
                    U.RegistrarUsuario(txtUserName.Text,txtPassword.Text,cmbTipo.Text);
                    MessageBox.Show("se registro correctamente");
                    ListarUsuarios();
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo registrar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Modificar == true)
            {

                try
                {
                    U.ModificarUsuario(idUsuario,txtUserName.Text,txtPassword.Text, cmbTipo.Text);
                    MessageBox.Show("se modifico correctamente");
                    ListarUsuarios();
                    LimpiarFormulario();
                    Modificar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo modificar los datos por: " + ex);
                }
            }
        }

        public void LimpiarFormulario()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cmbTipo.SelectedIndex = 0;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                Modificar = true;
                txtUserName.Text = dgvUsuario.CurrentRow.Cells["NOMBRE DE USUARIO"].Value.ToString();
                txtPassword.Text = dgvUsuario.CurrentRow.Cells["password"].Value.ToString();
                
                cmbTipo.Text = dgvUsuario.CurrentRow.Cells["TIPO"].Value.ToString();
                idUsuario = dgvUsuario.CurrentRow.Cells["ID USUARIO"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BtnElimnar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                idUsuario = dgvUsuario.CurrentRow.Cells["ID USUARIO"].Value.ToString();
                U.EliminarUsuario(idUsuario);
                MessageBox.Show("Eliminado correctamente");
                ListarUsuarios();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
