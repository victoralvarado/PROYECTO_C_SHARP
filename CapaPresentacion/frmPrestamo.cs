using CapaLogicaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private Herramienta H = new Herramienta();
        private Personal P = new Personal();
        private DetallePrestamo DP = new DetallePrestamo();
        private string idHerramienta = null;
        private string idPersonal = null;
        private string prestadapor = null;
        private string uso = null;
        private string estado = null;
        private ErrorProvider ep = new ErrorProvider();
        private bool ValidarF = false;

        public void ListarHerramientas()
        {
            Herramienta LH = new Herramienta();
            dgvHerramienta.DataSource = LH.ListarHerramientasPPrestamo();
        }

        public void ListarDetallePrestamo()
        {
            DetallePrestamo LDP = new DetallePrestamo();
            dgvDetalleprestamo.DataSource = LDP.ListarDetallePrestamo();
        }

        public void ListarPersonal()
        {
            Personal LP = new Personal();
            dgvEmpleado.DataSource = LP.ListarPersonal();
            dgvEmpleado.Columns[3].Visible = false;
        }

        public void LimpiarControles()
        {
            txtHerramienta.Clear();
            txtEmpleado.Clear();
            ep.Clear();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            ListarDetallePrestamo();
            ListarPersonal();
            ListarHerramientas();
        }

        private void dgvHerramienta_Click(object sender, EventArgs e)
        {

            if (dgvHerramienta.RowCount > 0)
            {
                idHerramienta = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["CÓDIGO HERRAMIENTA"].Value.ToString();
                txtHerramienta.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["NOMBRE HERRAMIENTA"].Value.ToString();
                estado = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //buscar por todos los campos de la tabla
            Herramienta LH = new Herramienta();
            string buscar = txtBuscar.Text;
            dgvHerramienta.DataSource = LH.FiltrarHerramientaTCPrestamo(buscar);
        }

        private void dgvEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.RowCount > 0)
            {
                idPersonal = dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells["CÓDIGO EMPLEADO"].Value.ToString();
                txtEmpleado.Text = dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells["NOMBRES"].Value.ToString() + " " + dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells["APELLIDOS"].Value.ToString();
            }
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            Personal LP = new Personal();
            string buscar = txtBuscarEmpleado.Text;
            dgvEmpleado.DataSource = LP.FiltrarPersonal(buscar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarF = true;
            ep.Clear();
            if (txtEmpleado.Text.Trim().Length==0)
            {
                ep.SetError(txtEmpleado, "¡Seleccione un Empleado de la tabla!");
                ValidarF = false;
            }
            if (txtHerramienta.Text.Trim().Length==0)
            {
                ep.SetError(txtHerramienta, "¡Selleccione una Herramienta de la tabla!");
                ValidarF = false;
            }

            if (ValidarF==true)
            {
                prestadapor = "Administrador";
                uso = "SI";
                DP.RegistrarDetallePrestamo(idPersonal,idHerramienta,txtFecha.Text,prestadapor);
                DP.ModificarUso(uso,estado,idHerramienta);
                MessageBox.Show("Herramienta prestada correctamente", "Prestando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarDetallePrestamo();
                ListarHerramientas();
                LimpiarControles();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtEmpleado.Text.Length > 0 || txtHerramienta.Text.Length > 0) 
            {
                if (MessageBox.Show("¿Está seguro que desea cancelar la operacion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    LimpiarControles();
                }
            }
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
        }
    }
}
