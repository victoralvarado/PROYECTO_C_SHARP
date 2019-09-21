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
        private ClsCategoria C = new ClsCategoria();
        public frmCategoria()
        {
            InitializeComponent();
        }
        private void ListarElementos()
        {
            dgvCategoria.ClearSelection();
            DataTable dt = new DataTable();
            dt = C.Listar();
            try
            {
                dgvCategoria.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCategoria.Rows.Add(dt.Rows[i][0]);
                    dgvCategoria.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvCategoria.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            ListarElementos();
        }
    }
}
