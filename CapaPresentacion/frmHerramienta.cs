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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace CapaPresentacion
{
    public partial class frmHerramienta : Form
    {
        public frmHerramienta()
        {
            InitializeComponent();
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
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "ID CATEGORIA";
            cmbCategoria.SelectedIndex = 0;
        }

        public void LlenarUso()
        {
            cmbUso.Items.Add("SELECCIONAR");
            cmbUso.Items.Add("SI");
            cmbUso.Items.Add("NO");
            cmbUso.SelectedIndex = 0;
        }

        public void LlenarEstado()
        {
            cmbEstado.Items.Add("SELECCIONAR");
            cmbEstado.Items.Add("NUEVA");
            cmbEstado.Items.Add("NORMAL");
            cmbEstado.Items.Add("DEFECTUOSA");
            cmbEstado.SelectedIndex = 0;
        }
        public class Item
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public Item(string name, string value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        public void LlenarCampo()
        {
            List<Item> lista = new List<Item>();

            lista.Add(new Item("SELECCIONAR", ""));
            lista.Add(new Item("ID HERRAMIENTA", "idHerramienta"));
            lista.Add(new Item("HERRAMIENTA", "nombreHerramienta"));
            lista.Add(new Item("ID CATEGORIA", "idCategoria"));
            lista.Add(new Item("USO", "uso"));
            lista.Add(new Item("ESTADO", "estado"));
            lista.Add(new Item("CATEGORIA", "nombreCategoria"));

            cmbCampo.DisplayMember = "Name";
            cmbCampo.ValueMember = "Value";
            cmbCampo.DataSource = lista;
            cmbCampo.SelectedIndex = 0;
        }

        private void ListarHerramientas()
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
            cmbUso.Enabled = true;
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
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbUso.SelectedIndex = 0;
            DesactivarControles();
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
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();

            if (txtNombre.Text.Trim().Length == 0)
            {
                ep.SetError(txtNombre, "Campo requerido!");
                ValidarF = false;
            }
            if (cmbCategoria.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoria, "Seleccione una categoria!");
                ValidarF = false;
            }
            if (cmbEstado.SelectedIndex == 0)
            {
                ep.SetError(cmbEstado, "Seleccione estado!");
                ValidarF = false;
            }
            if (cmbUso.SelectedIndex == 0)
            {
                ep.SetError(cmbUso, "Seleccione uso!");
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
                    dgvHerramienta.Enabled = true;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgvHerramienta  .Enabled = false;
            LimpiarControles();
            ActivarControles();
            ActivarBotones();
            Editando = false;
            Agregando = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Seleccionado = false;
            if (txtNombre.Text.Length > 0)
            {
                Seleccionado = true;
            }

            if (Seleccionado == true)
            {
                dgvHerramienta.Enabled = false;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHerramienta.RowCount > 0)
            {
                if (MessageBox.Show("Desea eliminar?", "Validación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    idHerramienta = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["ID HERRAMIENTA"].Value.ToString();
                    H.EliminarHerramienta(idHerramienta);
                    Botones();
                    ListarHerramientas();
                    MessageBox.Show("Registro eliminado correctamente", "Validación",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación ?", "Validacion", MessageBoxButtons.YesNo,
 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
                ep.Clear();
                Agregando = false;
                Editando = false;
                Botones();
                dgvHerramienta.Enabled = true;
            }
        }

        private void DgvHerramienta_Click(object sender, EventArgs e)
        {
            if (dgvHerramienta.RowCount > 0)
            {
                idHerramienta = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["ID HERRAMIENTA"].Value.ToString();
                txtNombre.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["NOMBRE HERRAMIENTA"].Value.ToString();
                cmbCategoria.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["CATEGORIA"].Value.ToString();
                cmbEstado.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
                cmbUso.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["USO"].Value.ToString();
            }
        }

        private void DgvHerramienta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvHerramienta.Columns[e.ColumnIndex].Name == "ESTADO")
            {
                if (Convert.ToString(e.Value) == "NUEVA")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.SkyBlue;
                }
                if (Convert.ToString(e.Value) == "NORMAL")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.White;
                }
                if (Convert.ToString(e.Value) == "DEFECTUOSA")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
            if (this.dgvHerramienta.Columns[e.ColumnIndex].Name == "USO")
            {
                if (Convert.ToString(e.Value) == "NO")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
                if (Convert.ToString(e.Value) == "SI")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex==0)
            {
                MessageBox.Show("Primero seleccione un campo","Campo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Herramienta LH = new Herramienta();
                string value = Convert.ToString(cmbCampo.SelectedValue);
                dgvHerramienta.DataSource = LH.FiltrarHerramienta(value, txtBuscar.Text);
            }
        }
    }
}
