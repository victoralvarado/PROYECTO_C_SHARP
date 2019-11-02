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
 * @Nombre de Clase: FrmReportes.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private string idPersonal = null;
        private ErrorProvider ep = new ErrorProvider();
        public void listarPP()
        {
            DetallePrestamo DP = new DetallePrestamo();
            dgvReportePersonal.DataSource = DP.ListarPP();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            listarPP();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DetallePrestamo FDP = new DetallePrestamo();
            string buscar = txtBuscar.Text;
            dgvReportePersonal.DataSource = FDP.filtrarPP(buscar);
        }

        private void dgvReportePersonal_Click(object sender, EventArgs e)
        {
            if (dgvReportePersonal.RowCount > 0)
            {
                idPersonal = dgvReportePersonal.Rows[dgvReportePersonal.CurrentRow.Index].Cells["CÓDIGO EMPLEADO"].Value.ToString();
                txtEmpleao.Text = dgvReportePersonal.Rows[dgvReportePersonal.CurrentRow.Index].Cells["NOMBRE COMPLETO"].Value.ToString();
            }
        }

        private void btnReportePP_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtEmpleao.Text.Trim().Length == 0)
            {
                ep.SetError(txtEmpleao, "Debe seleccionar un empleado de la tabla");
            }
            else
            {
                //PARAMETROS PARA REPORTE
            }
        }
    }
}
