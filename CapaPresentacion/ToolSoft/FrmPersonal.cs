﻿using CapaLogicaNegocio;
using System;
using System.Windows.Forms;
/*
 * @Nombre de Clase: FrmPersonal.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        public FrmPersonal(string tipo)
        {
            InitializeComponent();
            lblTipoUsuario.Text = tipo;
        }

        private Personal P = new Personal();
        private string idPersonal = null;
        ErrorProvider ep = new ErrorProvider();
        bool Editando = false;
        bool Agregando = false;
        bool ValidarF = false;
        bool Seleccionado = false;


        public void ListarPersonal()
        {
            Personal LP = new Personal();
            dgvPersonal.DataSource = LP.ListarPersonal();
        }
        public void DesactivarControles()
        {
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            nudEdad.Enabled = false;
        }

        public void ActivarControles()
        {
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            nudEdad.Enabled = true;
        }
        public void Botones()
        {
            if (dgvPersonal.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregar.Cursor = Cursors.Hand;

                btnEditar.Enabled = true;
                btnEditar.Cursor = Cursors.Hand;

                btnEliminar.Enabled = true;
                btnEliminar.Cursor = Cursors.Hand;

                btnCancelar.Enabled = false;

                btnGuardar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnAgregar.Cursor = Cursors.Hand;

                btnEditar.Enabled = false;

                btnEliminar.Enabled = false;

                btnCancelar.Enabled = false;

                btnGuardar.Enabled = false;
            }
        }

        public void ActivarBotones()
        {
            btnAgregar.Enabled = false;

            btnEditar.Enabled = false;

            btnEliminar.Enabled = false;

            btnCancelar.Enabled = true;
            btnCancelar.Cursor = Cursors.Hand;

            btnGuardar.Enabled = true;
            btnGuardar.Cursor = Cursors.Hand;
        }

        public void LimpiarControles()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            nudEdad.Value = 0;
            DesactivarControles();
        }

        public void validarTipoUsuario()
        {
            if (dgvPersonal.RowCount > 0)
            {
                if (lblTipoUsuario.Text == "Bodeguero")
                {
                    btnEliminar.Enabled = false;
                }
                if (lblTipoUsuario.Text == "Administrador")
                {
                    btnEliminar.Enabled = true;
                }
            }
            else
            {
                if (lblTipoUsuario.Text == "Bodeguero")
                {
                    btnEliminar.Enabled = false;
                }
                if (lblTipoUsuario.Text == "Administrador")
                {
                    btnEliminar.Enabled = false;
                }
            }
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            ListarPersonal();
            DesactivarControles();
            Botones();
            validarTipoUsuario();
        }

        private void dgvPersonal_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount > 0)
            {
                idPersonal = dgvPersonal.Rows[dgvPersonal.CurrentRow.Index].Cells["CÓDIGO EMPLEADO"].Value.ToString();
                txtNombres.Text = dgvPersonal.Rows[dgvPersonal.CurrentRow.Index].Cells["NOMBRES"].Value.ToString();
                txtApellidos.Text = dgvPersonal.Rows[dgvPersonal.CurrentRow.Index].Cells["APELLIDOS"].Value.ToString();
                nudEdad.Value = Convert.ToInt32(dgvPersonal.Rows[dgvPersonal.CurrentRow.Index].Cells["EDAD"].Value.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvPersonal.Enabled = false;
            LimpiarControles();
            ActivarControles();
            ActivarBotones();
            Editando = false;
            Agregando = true;
            txtNombres.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount > 0)
            {
                Seleccionado = false;
                if (txtNombres.Text.Length > 0)
                {
                    Seleccionado = true;
                }
                if (Seleccionado == true)
                {
                    Personal LPP = new Personal();
                    dgvDetalleprestamo.DataSource = LPP.BuscarIDEMP(idPersonal);
                    if (dgvDetalleprestamo.RowCount > 0)
                    {
                        MessageBox.Show("No puede editar el empleado porque ha prestado herramientas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarControles();
                    }
                    else
                    {
                        dgvPersonal.Enabled = false;
                        ActivarBotones();
                        ActivarControles();
                        Editando = true;
                        Agregando = false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe dar clic sobre la fila a editar", "Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount > 0)
            {
                Personal LPP = new Personal();
                idPersonal = dgvPersonal.CurrentRow.Cells["CÓDIGO EMPLEADO"].Value.ToString();

                dgvDetalleprestamo.DataSource = LPP.BuscarIDEMP(idPersonal);

                if (dgvDetalleprestamo.RowCount > 0)
                {
                    MessageBox.Show("No puede eliminar el empleado porque ha prestado herramientas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        P.EliminarPersonal(idPersonal);
                        Botones();
                        ListarPersonal();
                        MessageBox.Show("Registro eliminado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
                ep.Clear();
                Agregando = false;
                Editando = false;
                Botones();
                validarTipoUsuario();
                dgvPersonal.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();
            if (txtNombres.Text.Trim().Length == 0)
            {
                ep.SetError(txtNombres, "¡Campo requerido!");
                ValidarF = false;
            }
            if (txtApellidos.Text.Trim().Length == 0)
            {
                ep.SetError(txtApellidos, "¡Campo requerido!");
                ValidarF = false;

            }

            if (nudEdad.Value < 18)
            {
                ep.SetError(nudEdad, "¡Debe ser mayor de 17 años!");
                ValidarF = false;
            }
            if (ValidarF == true)
            {
                if (Agregando == true && Editando == false)
                {

                    P.RegistrarPersonal(txtNombres.Text, txtApellidos.Text, nudEdad.Value.ToString());
                    MessageBox.Show("Datos agregados correctamente", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarPersonal();
                    LimpiarControles();
                    validarTipoUsuario();
                    dgvPersonal.Enabled = true;
                }
                if (Agregando == false && Editando == true)
                {
                    P.ModificarPersonal(txtNombres.Text, txtApellidos.Text, nudEdad.Value.ToString(), idPersonal);
                    MessageBox.Show("Datos modificados correctamente", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarPersonal();
                    LimpiarControles();
                    validarTipoUsuario();
                    dgvPersonal.Enabled = true;
                }
            }
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            Personal DPEP = new Personal();
            string buscar = '%' +  txtBuscarEmpleado.Text + '%';
            dgvPersonal.DataSource = DPEP.FiltrarPersonal2(buscar);
        }
    }
}
