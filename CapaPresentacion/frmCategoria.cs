using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;

using System.Windows.Forms;
using CapaLogicaNegocio;
/*
* @Nombre de Clase: frmCategoria.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea, Diego
*/
namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        
        frmHerramienta FH = new frmHerramienta();
        private Herramienta H = new Herramienta();
        private string categoria = null;
        private Categoria C = new Categoria();
        private string idCategoria = null;
        ErrorProvider ep = new ErrorProvider();
        bool Editando = false;
        bool Agregando = false;
        bool ValidarF = false;
        bool Seleccionado = false;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void ListarCategorias()
        {
            Categoria LC = new Categoria();
            dgvCategoria.DataSource = LC.ListarCategoria();
        }

        public void DesactivarControles()
        {
            txtCategoria.Enabled = false;
        }

        public void ActivarControles()
        {
            txtCategoria.Enabled = true;
        }

        public void Botones()
        {
            if (dgvCategoria.RowCount > 0)
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
            txtCategoria.Clear();
            DesactivarControles();
        }



        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            DesactivarControles();
            Botones();
            dgvHerramientaUS.Visible = false;
            dgvHerramientaUN.Visible = false;

        }

        private void DgvCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.RowCount > 0)
            {
                idCategoria = dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells["CÓDIGO CATEGORÍA"].Value.ToString();
                txtCategoria.Text = dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells["CATEGORÍA"].Value.ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgvCategoria.Enabled = false;
            LimpiarControles();
            ActivarControles();
            ActivarBotones();
            Editando = false;
            Agregando = true;
            txtCategoria.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.RowCount > 0)
            {
                Seleccionado = false;
                if (txtCategoria.Text.Length > 0)
                {
                    Seleccionado = true;
                }

                if (Seleccionado == true)
                {
                    dgvCategoria.Enabled = false;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.RowCount > 0)
            {
                categoria = dgvCategoria.CurrentRow.Cells["CATEGORÍA"].Value.ToString();

                string usoS = null;
                string usoN = null;

                Herramienta LH = new Herramienta();

                dgvHerramientaUS.DataSource = LH.ListarHerramientaCUS(categoria);

                dgvHerramientaUN.DataSource = LH.ListarHerramientaCUN(categoria);

                if (dgvHerramientaUS.RowCount > 0)
                {
                    usoS = "SI";

                }
                else
                {
                    usoS = "";
                }

                if (dgvHerramientaUN.RowCount > 0)
                {
                    usoN = "NO";

                }
                else
                {
                    usoN = "";
                }



                if (usoS == "SI")
                {
                    MessageBox.Show("No puede eliminar la categoría '" + categoria + "', porque hay herramientas en uso que pertenecen a esa categoría, desocupen las herramientas que pertenecen a '" + categoria + "' para poder eliminarla", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (usoN == "NO" && usoS == "")
                {
                    if (MessageBox.Show("Todas las herramientas que pertenecen a la categoría '" + categoria + "' serán eliminadas.\n¿Está seguro que desea eliminarla?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        C.EliminarCategoria(idCategoria);
                        Botones();
                        ListarCategorias();
                        MessageBox.Show("Registro eliminado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                }

                if (usoS == "" && usoN == "")
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar la categoría '" + categoria + "'?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        C.EliminarCategoria(idCategoria);
                        Botones();
                        ListarCategorias();
                        MessageBox.Show("Registro eliminado correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                }
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();
                ep.Clear();
                Agregando = false;
                Editando = false;
                Botones();
                dgvCategoria.Enabled = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();
            if (txtCategoria.Text.Trim().Length == 0)
            {
                ep.SetError(txtCategoria, "¡Campo requerido!");
                ValidarF = false;
            }
            if (ValidarF == true)
            {
                if (Agregando == true && Editando == false)
                {
                    C.RegistrarCategoria(txtCategoria.Text);
                    MessageBox.Show("Datos agregados correctamente", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarCategorias();
                    LimpiarControles();
                    dgvCategoria.Enabled = true;
                }
                else
                {
                    C.ModificarCategoria(idCategoria, txtCategoria.Text);
                    MessageBox.Show("Datos modificados correctamente", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones();
                    ListarCategorias();
                    LimpiarControles();
                    dgvCategoria.Enabled = true;
                }
                
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Categoria FC = new Categoria();
            string buscar = txtBuscar.Text;
            dgvCategoria.DataSource = FC.FiltrarCat(buscar);
        }
    }
}
