﻿using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
/*
* @Nombre de Clase: FrmHerramienta.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaPresentacion
{
    public partial class FrmHerramienta : Form
    {

        public FrmHerramienta()
        {
            InitializeComponent();
        }

        public FrmHerramienta(string tipo)
        {
            InitializeComponent();
            lblTipoUsuario.Text = tipo;
        }

        private Herramienta H = new Herramienta();
        private string idHerramienta = null;
        ErrorProvider ep = new ErrorProvider();
        bool Editando = false;
        bool Agregando = false;
        bool ValidarF = false;
        bool Seleccionado = false;

        public void CargarCat()
        {
            cmbCategoria.DataSource = H.ListarCategoriaCombo();
            cmbCategoria.DisplayMember = "CATEGORÍA";
            cmbCategoria.ValueMember = "CÓDIGO CATEGORÍA";
            cmbCategoria.SelectedIndex = 0;
        }

        public void LlenarUso()
        {
            cmbUso.Items.Add("SELECCIONAR");
            cmbUso.Items.Add("SI");
            cmbUso.Items.Add("NO");
            cmbUso.SelectedIndex = 2;
            cmbUso.Enabled = false;
        }

        public void LlenarEstado()
        {
            cmbEstado.Items.Add("SELECCIONAR");
            cmbEstado.Items.Add("NUEVA");
            cmbEstado.Items.Add("NORMAL");
            cmbEstado.Items.Add("DEFECTUOSA");
            cmbEstado.SelectedIndex = 0;
        }

        public void LlenarCampo()
        {
            //Metodo para llenar los campos para filtar(Buscar) en la tabla por un campo especifico
            List<Items> lista = new List<Items>();
            //                     NAME                  VALUE
            lista.Add(new Items("SELECCIONAR", ""));
            lista.Add(new Items("CÓDIGO HERRAMIENTA", "h.idHerramienta"));
            lista.Add(new Items("HERRAMIENTA", " h.nombreHerramienta"));
            lista.Add(new Items("CÓDIGO CATEGORÍA", "h.idCategoria"));
            lista.Add(new Items("USO", "h.uso"));
            lista.Add(new Items("ESTADO", "h.estado"));
            lista.Add(new Items("CATEGORÍA", "c.nombreCategoria"));
            //Se mostrara el Name y tomara el value del combobox
            cmbCampo.DisplayMember = "Name";
            cmbCampo.ValueMember = "Value";
            cmbCampo.DataSource = lista;
            cmbCampo.SelectedIndex = 0;
        }

        public void ListarHerramientas()
        {

            Herramienta LH = new Herramienta();
            dgvHerramienta.DataSource = LH.ListarHerramienta();
        }

        public void DesactivarControles()
        {
            txtNombre.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbEstado.Enabled = false;
            cmbUso.Enabled = false;
        }

        public void ActivarControles()
        {
            txtNombre.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbEstado.Enabled = true;
            cmbUso.Enabled = false;
        }

        public void Botones()
        {
            if (dgvHerramienta.RowCount > 0)
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
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbUso.SelectedIndex = 2;
            DesactivarControles();
        }

        public void validarTipoUsuario()
        {
            if (dgvHerramienta.RowCount > 0)
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

        private void FrmHerramienta_Load(object sender, EventArgs e)
        {
            CargarCat();
            LlenarUso();
            LlenarEstado();
            ListarHerramientas();
            LlenarCampo();
            DesactivarControles();
            Botones();
            validarTipoUsuario();
        }

        private void DgvHerramienta_Click(object sender, EventArgs e)
        {
            if (dgvHerramienta.RowCount > 0)
            {
                //Si la herramienta SI esta en uso no se puede seleccionar y no se mostrara en las cajas de texto
                if (dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["USO"].Value.ToString() == "SI")
                {
                    MessageBox.Show("No puede editar ni eliminar herramientas en uso", "Herramientas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControles();
                }
                //Si la herramienta NO esta en uso si se podra seleccionar
                else
                {
                    idHerramienta = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["CÓDIGO HERRAMIENTA"].Value.ToString();
                    txtNombre.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["NOMBRE HERRAMIENTA"].Value.ToString();
                    cmbCategoria.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["CATEGORÍA"].Value.ToString();
                    cmbEstado.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
                    cmbUso.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["USO"].Value.ToString();
                }
            }
        }

        private void DgvHerramienta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvHerramienta.Columns[e.ColumnIndex].Name == "ESTADO")
            {
                //Cambiar color de celda dependiendo del estado de la herramienta
                if (Convert.ToString(e.Value) == "NUEVA")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(217, 237, 247);
                }
                if (Convert.ToString(e.Value) == "NORMAL")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.White;
                }
                if (Convert.ToString(e.Value) == "DEFECTUOSA")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(249, 53, 76);
                }
            }
            if (this.dgvHerramienta.Columns[e.ColumnIndex].Name == "USO")
            {
                if (Convert.ToString(e.Value) == "NO")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(65, 179, 20);
                }
                if (Convert.ToString(e.Value) == "SI")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(228, 203, 16);
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex == 0)
            {
                //buscar por todos los campos de la tabla
                Herramienta LH = new Herramienta();
                string buscar = '%' + txtBuscar.Text + '%';
                dgvHerramienta.DataSource = LH.FiltrarHerramientaTC(buscar);
            }
            else
            {
                try
                {
                    //buscar por un campo especifico de la tabla
                    Herramienta LH = new Herramienta();
                    string buscar = '%' + txtBuscar.Text + '%';
                    string value = cmbCampo.SelectedValue.ToString();
                    dgvHerramienta.DataSource = LH.FiltrarHerramienta(value, buscar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error : " + ex + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();

            if (txtNombre.Text.Trim().Length == 0)
            {
                ep.SetError(txtNombre, "¡Campo requerido!");
                ValidarF = false;
            }
            if (cmbCategoria.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoria, "¡Seleccione una categoria!");
                ValidarF = false;
            }
            if (cmbEstado.SelectedIndex == 0)
            {
                ep.SetError(cmbEstado, "¡Seleccione estado!");
                ValidarF = false;
            }
            if (cmbUso.SelectedIndex == 0)
            {
                ep.SetError(cmbUso, "¡Seleccione uso!");
                ValidarF = false;
            }
            if (ValidarF == true)
            {
                if (Agregando == true && Editando == false)
                {
                    string idCategoria = Convert.ToString(cmbCategoria.SelectedValue);
                    H.RegistrarHerramienta(txtNombre.Text, idCategoria, cmbUso.Text, cmbEstado.Text);
                    MessageBox.Show("Datos agregados correctamente", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarHerramientas();
                    LimpiarControles();
                    validarTipoUsuario();
                    dgvHerramienta.Enabled = true;
                }
                else
                {
                    string idCategoria = Convert.ToString(cmbCategoria.SelectedValue);
                    H.ModificarHerramienta(txtNombre.Text, idCategoria, cmbUso.Text, cmbEstado.Text, idHerramienta);
                    MessageBox.Show("Datos modificados correctamente", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarHerramientas();
                    LimpiarControles();
                    validarTipoUsuario();
                    dgvHerramienta.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvHerramienta.RowCount > 0)
            {
                Seleccionado = false;
                if (txtNombre.Text.Length > 0)
                {
                    Seleccionado = true;
                }

                if (Seleccionado == true)
                {
                    dgvHerramienta.Enabled = false;
                    ActivarControles();
                    ActivarBotones();
                    Editando = true;
                    Agregando = false;
                }
                else
                {
                    MessageBox.Show("Debe dar clic sobre la fila a editar", "Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Si cancela la operacion limpiara cajas de texto y bloquera botones y controles
            if (MessageBox.Show("¿Desea cancelar la operación?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
                ep.Clear();
                Agregando = false;
                Editando = false;
                Botones();
                validarTipoUsuario();
                dgvHerramienta.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHerramienta.RowCount > 0)
            {
                //Si la herramienta SI está en uso no podra ser eliminada
                if (dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["USO"].Value.ToString() == "SI")
                {
                    MessageBox.Show("No puede editar ni eliminar herramientas en uso", "Herramientas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControles();
                }
                //Si la herramienta NO está en uso si podra ser eliminada
                else
                {
                    if (MessageBox.Show("¿Desea eliminar la herramienta?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        idHerramienta = dgvHerramienta.CurrentRow.Cells["CÓDIGO HERRAMIENTA"].Value.ToString();
                        H.EliminarHerramienta(idHerramienta);
                        Botones();
                        ListarHerramientas();
                        MessageBox.Show("Registro eliminado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvHerramienta.Enabled = false;
            LimpiarControles();
            ActivarControles();
            ActivarBotones();
            Editando = false;
            Agregando = true;
            txtNombre.Focus();
        }
    }
}
