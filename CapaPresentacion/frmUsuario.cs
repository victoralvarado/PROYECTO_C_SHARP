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
            cmbTipo.DataSource = U.ListarTUsuario();
            cmbTipo.DisplayMember = "tipoUsuario";
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
            dgvUsuario.Columns["idUsuario"].Visible = false;
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
                
                cmbTipo.Text = dgvUsuario.CurrentRow.Cells["TIPO DE USUARIO"].Value.ToString();
                idUsuario = dgvUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
                if (idUsuario.Equals("1"))
                {
                    cmbTipo.Enabled = false;
                }
                else
                {
                    cmbTipo.Enabled = true;
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BtnElimnar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                idUsuario = dgvUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
                if (idUsuario.Equals("1"))
                {
                    MessageBox.Show("El administrador principal no puede ser eliminado");
                }
                else
                {
                    
                    U.EliminarUsuario(idUsuario);
                    MessageBox.Show("Eliminado correctamente");
                    ListarUsuarios();
                }
                
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void DgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvUsuario.Columns[e.ColumnIndex].Name== "TIPO DE USUARIO")
            {
                if (Convert.ToString(e.Value)=="Administrador")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.ForestGreen;
                }
            }
        }
    }
}
