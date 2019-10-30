﻿using CapaLogicaNegocio;
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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
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
            txtNombres.Clear();
            txtApellidos.Clear();
            nudEdad.Value = 0;
            DesactivarControles();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            ListarPersonal();
            DesactivarControles();
            Botones();
          
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Personal DPEP = new Personal();
            string buscar = txtBuscar.Text;
            dgvPersonal.DataSource = DPEP.FiltrarPersonal2(buscar);
        }

        private void dgvPersonal_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount > 0)
            {
                idPersonal = dgvPersonal.Rows[dgvPersonal.CurrentRow.Index].Cells["ID PERSONAL"].Value.ToString();
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
                    dgvPersonal.Enabled = false;
                    ActivarBotones();
                    ActivarControles();
                    Editando = true;
                    Agregando = false;
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

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    idPersonal = dgvPersonal.CurrentRow.Cells["ID PERSONAL"].Value.ToString();
                    Botones();
                    ListarPersonal();
                    MessageBox.Show("Registro eliminado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación ?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
                ep.Clear();
                Agregando = false;
                Editando = false;
                Botones();
                dgvPersonal.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();
            if (txtNombres.Text.Trim().Length == 0)
            {
                ep.SetError(txtNombres, "Campo requerido!");
                ValidarF = false;
            }
            if (txtApellidos.Text.Trim().Length == 0) 
            {
                ep.SetError(txtApellidos, "Campo requerido");
                ValidarF = false;
            
            }

            if (nudEdad.Value == 0 || nudEdad.Value <= 18) 
            {
                ep.SetError(nudEdad, "Campo requerido");
                ValidarF = false;
            
            }
            if (ValidarF == true)
            {
                if (Agregando == true && Editando == false)
                {

                    P.RegistrarPersonal(txtNombres.Text, txtApellidos.Text, nudEdad.ToString());
                    MessageBox.Show("Datos agregados correctamente", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarPersonal();
                    LimpiarControles();
                    dgvPersonal.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Datos modificados correctamente", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarPersonal();
                    LimpiarControles();
                    dgvPersonal.Enabled = true;
                }

            }
        }
    }
}
