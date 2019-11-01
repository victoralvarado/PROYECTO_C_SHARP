using CapaLogicaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;
/*
 * @Nombre de Clase: FrmUsuario.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class FrmUsuario : Form
    {
        private Usuario U = new Usuario();
        private string idUsuario = null;
        ErrorProvider ep = new ErrorProvider();
        bool Editando = false;
        bool Agregando = false;
        bool ValidarF = false;
        bool Seleccionado = false;

        public FrmUsuario()
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
            dgvUsuario.Columns["password"].Visible = false;
        }
        public void DesactivarControles()
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            cmbTipo.Enabled = false;
        }

        public void ActivarControles()
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
        }

        public void Botones()
        {
            if (dgvUsuario.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregar.Cursor = Cursors.Hand;

                btnEditar.Enabled = true;
                btnEditar.Cursor = Cursors.Hand;

                btnEliminar.Enabled = true;
                btnEliminar.Cursor = Cursors.Hand;

                btnCancelar.Enabled = false;
                btnCancelar.Cursor = Cursors.No;

                btnGuardar.Enabled = false;
                btnGuardar.Cursor = Cursors.No;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnAgregar.Cursor = Cursors.Hand;

                btnEditar.Enabled = false;
                btnEditar.Cursor = Cursors.No;

                btnEliminar.Enabled = false;
                btnEliminar.Cursor = Cursors.No;

                btnCancelar.Enabled = false;
                btnCancelar.Cursor = Cursors.No;

                btnGuardar.Enabled = false;
                btnGuardar.Cursor = Cursors.No;
            }
        }

        public void ActivarBotones()
        {
            btnAgregar.Enabled = false;
            btnAgregar.Cursor = Cursors.No;

            btnEditar.Enabled = false;
            btnEditar.Cursor = Cursors.No;

            btnEliminar.Enabled = false;
            btnEliminar.Cursor = Cursors.No;

            btnCancelar.Enabled = true;
            btnCancelar.Cursor = Cursors.Hand;

            btnGuardar.Enabled = true;
            btnGuardar.Cursor = Cursors.Hand;
        }

        public void LimpiarControles()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cmbTipo.SelectedIndex = 0;
            DesactivarControles();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarTipoUsuario();
            ListarUsuarios();
            DesactivarControles();
            Botones();
        }


        private void DgvUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                idUsuario = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["ID USUARIO"].Value.ToString();
                txtUserName.Text = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["NOMBRE DE USUARIO"].Value.ToString();
                txtPassword.Text = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["password"].Value.ToString();
                cmbTipo.Text = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["TIPO DE USUARIO"].Value.ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgvUsuario.Enabled = false;
            LimpiarControles();
            ActivarControles();
            cmbTipo.Enabled = true;
            ActivarBotones();
            Editando = false;
            Agregando = true;
            txtUserName.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                Seleccionado = false;
                if (txtUserName.Text.Length > 0)
                {
                    Seleccionado = true;
                }

                if (Seleccionado == true)
                {
                    if (idUsuario == "1")
                    {
                        cmbTipo.Enabled = false;
                        dgvUsuario.Enabled = false;
                        ActivarBotones();
                        ActivarControles();
                        Editando = true;
                        Agregando = false;
                    }
                    else
                    {
                        cmbTipo.Enabled = false;
                        dgvUsuario.Enabled = false;
                        ActivarBotones();
                        ActivarControles();
                        Editando = true;
                        Agregando = false;
                        cmbTipo.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe dar clic sobre la fila a editar", "Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación ?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
                ep.Clear();
                Agregando = false;
                Editando = false;
                Botones();
                dgvUsuario.Enabled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                idUsuario = dgvUsuario.CurrentRow.Cells["ID USUARIO"].Value.ToString();
                if (idUsuario == "1")
                {
                    MessageBox.Show("El administrador principal no puede ser eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("Desea eliminar?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        U.EliminarUsuario(idUsuario);
                        Botones();
                        ListarUsuarios();
                        MessageBox.Show("Registro eliminado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();
            if (txtUserName.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserName, "Campo requerido!");
                ValidarF = false;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "Campo requerido!");
                ValidarF = false;
            }
            if (cmbTipo.SelectedIndex == 0)
            {
                ep.SetError(cmbTipo, "Seleccione tipo de usuario!");
                ValidarF = false;
            }
            if (ValidarF == true)
            {
                if (Agregando == true && Editando == false)
                {

                    U.RegistrarUsuario(txtUserName.Text, txtPassword.Text, cmbTipo.Text);
                    MessageBox.Show("Datos agregados correctamente", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarUsuarios();
                    LimpiarControles();
                    dgvUsuario.Enabled = true;
                }
                else
                {
                    U.ModificarUsuario(idUsuario, txtUserName.Text, txtPassword.Text, cmbTipo.Text);
                    MessageBox.Show("Datos modificados correctamente", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarUsuarios();
                    LimpiarControles();
                    dgvUsuario.Enabled = true;
                }
            }
        }

        private void DgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvUsuario.Columns[e.ColumnIndex].Name == "TIPO DE USUARIO")
            {
                if (Convert.ToString(e.Value) == "Administrador")
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

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Usuario LU = new Usuario();
                string buscar = txtBuscar.Text;
                dgvUsuario.DataSource = LU.FiltrarUsuario(buscar.Replace("'", ""));
                dgvUsuario.Columns["password"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
