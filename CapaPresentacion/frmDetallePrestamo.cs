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
/*
 * @Nombre de Clase: frmDetallePrestamo.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class frmDetallePrestamo : Form
    {
        public frmDetallePrestamo()
        {
            InitializeComponent();
        }

        private DetallePrestamo DP = new DetallePrestamo();
        private Devolucion D = new Devolucion();
        private string idPrestamo = null;
        private string idHerramienta = null;
        private string idPersonal = null;
        private string recibidapor = null;
        private string uso = null;
        private string estado = null;
        private bool ValidarF = false;
        private ErrorProvider ep = new ErrorProvider();

        public void ListarDetallePrestamo()
        {
            DetallePrestamo LDP = new DetallePrestamo();
            dgvDetalleprestamo.DataSource = LDP.ListarDetallePrestamo();
        }

        public void LlenarEstado()
        {
            cmbEstado.Items.Add("SELECCIONAR");
            //cmbEstado.Items.Add("NUEVA");
            cmbEstado.Items.Add("NORMAL");
            cmbEstado.Items.Add("DEFECTUOSA");
            cmbEstado.SelectedIndex = 0;
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
        }

        public void ListarHerramientas()
        {
            Herramienta LH = new Herramienta();
            dgvHerramienta.DataSource = LH.ListarHerramientasPPrestamo();
        }

        private void frmDetallePrestamo_Load(object sender, EventArgs e)
        {
            ListarDetallePrestamo();
            ListarHerramientas();
            LlenarEstado();
        }

        private void LimpiarControles()
        {
            cmbEstado.SelectedIndex = 0;
            txtHerramienta.Clear();
        }

        private void dgvDetalleprestamo_Click(object sender, EventArgs e)
        {
            if (dgvDetalleprestamo.RowCount > 0)
            {
                idPrestamo = dgvDetalleprestamo.Rows[dgvDetalleprestamo.CurrentRow.Index].Cells["CODIGO PRESTAMO"].Value.ToString();
                txtHerramienta.Text= dgvDetalleprestamo.Rows[dgvDetalleprestamo.CurrentRow.Index].Cells["HERRAMIENTA"].Value.ToString();
                idHerramienta = dgvDetalleprestamo.Rows[dgvDetalleprestamo.CurrentRow.Index].Cells["CODIGO HERRAMIENTA"].Value.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ep.Clear();
            ValidarF = true;
            if (txtHerramienta.Text.Trim().Length == 0)
            {
                ValidarF = false;
                ep.SetError(txtHerramienta, "Debe seleccionar una herramienta de la tabla detalle prestamo");
            }
            if (cmbEstado.SelectedIndex==0)
            {
                ValidarF = false;
                ep.SetError(cmbEstado, "Debe seleccionar un estado valido");
            }

            if (ValidarF == true)
            {
                recibidapor = "Administrador";//VARIABLE DE QUIEN ESTE LOGUEADO
                uso = "NO";
                
                DP.ModificarUso(uso, cmbEstado.Text, idHerramienta);
                D.EliminarPrestamo(idPrestamo);
                MessageBox.Show("Herramienta entregada correctamente", "Entregando",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ListarDetallePrestamo();
                ListarHerramientas();
                LimpiarControles();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbEstado.SelectedIndex > 0 || txtHerramienta.Text.Length > 0)
            {
                if (MessageBox.Show("Esta seguro que desea cancelar la operacion", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarControles();
                }
            }
        }

        private void dgvHerramienta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            }
        }
    }
}
