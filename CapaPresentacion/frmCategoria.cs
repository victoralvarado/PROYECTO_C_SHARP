using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;

using System.Windows.Forms;
using CapaLogicaNegocio;
/*
 * @Nombre de Clase: Categoria.
 * @Version: 1.0.
 * @CopyRight: SISTEMA DE REGISTRO Y CONTROL DE HERRAMIENTAS PARA BODEGA DE LA EMPRESA VAAD.
 * @Author: Victor, Adrian, Andrea y Diego.
 */
namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        private Categoria C = new Categoria();
        private string idCategoria = null;
        private bool Modificar = false;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void ListarCategorias()
        {
            Categoria LC = new Categoria();
            dgvCategoria.DataSource = LC.ListarCategoria();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Modificar == false)
            {
                try
                {
                    C.RegistrarCategoria(txtCategoria.Text);
                    MessageBox.Show("se registro correctamente");
                    ListarCategorias();
                    limpiarForm();
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
                    C.ModificarCategoria(idCategoria , txtCategoria.Text);
                    MessageBox.Show("se modifico correctamente");
                    ListarCategorias();
                    limpiarForm();
                    Modificar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo modificar los datos por: " + ex);
                }
            }
        }
        private void limpiarForm()
        {
            txtCategoria.Clear();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                Modificar = true;
                txtCategoria.Text = dgvCategoria.CurrentRow.Cells["nombreCategoria"].Value.ToString();
                idCategoria = dgvCategoria.CurrentRow.Cells["idCategoria"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                idCategoria = dgvCategoria.CurrentRow.Cells["idCategoria"].Value.ToString();
                C.EliminarCategoria(idCategoria);
                MessageBox.Show("Eliminado correctamente");
                ListarCategorias();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                dgvCategoria.CurrentCell = null;
                foreach (DataGridViewRow d in dgvCategoria.Rows)
                {
                    d.Visible = false;
                }
                foreach (DataGridViewRow d in dgvCategoria.Rows)
                {
                    foreach (DataGridViewCell da in d.Cells)
                    {
                        if ((da.Value.ToString().ToUpper()).IndexOf(txtFiltro.Text.ToUpper()) == 0)
                        {
                            d.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                ListarCategorias();
            }
        }
    }
}
