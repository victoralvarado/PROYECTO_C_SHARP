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
        private string idHerramienta = null;
        ErrorProvider ep = new ErrorProvider();
        bool Editando = false;
        bool Agregando = false;
        bool ValidarF = false;
        bool Seleccionado = false;

        public void ListarHerramientas()
        {
            Herramienta LH = new Herramienta();
            dgvHerramienta.DataSource = LH.ListarHerramientasPPrestamo();
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
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            tmrFechaHora.Enabled = true;
            ListarPersonal();
            ListarHerramientas();
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(DateTime.Now);
        }

        private void dgvHerramienta_Click(object sender, EventArgs e)
        {

            if (dgvHerramienta.RowCount > 0)
            {
                idHerramienta = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["ID HERRAMIENTA"].Value.ToString();
                txtHerramienta.Text = dgvHerramienta.Rows[dgvHerramienta.CurrentRow.Index].Cells["NOMBRE HERRAMIENTA"].Value.ToString();

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
    }
}
