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

        public FrmReportes(string userName, string tipo)
        {
            InitializeComponent();
            lblUserName.Text = userName;
            lblTipo.Text = tipo;
        }

        DetallePrestamo DP = new DetallePrestamo();
        public void ListarTotalDP()
        {
            DP.listarTotalDP(lblTotalDP);
        }

        public void itemsCMB()
        {
            cmbReporteH.Items.Add("---------------- Seleccionar ----------------");
            cmbReporteH.Items.Add("Herramientas por Categoria");
            cmbReporteH.Items.Add("Herramientas Nuevas");
            cmbReporteH.Items.Add("Herramientas Disponibles");
            cmbReporteH.Items.Add("Herramientas en Uso");
            cmbReporteH.Items.Add("Herramientas Prestadas, ordenadas por Empleado");
            cmbReporteH.Items.Add("Herramientas Defectuosas");
            cmbReporteH.SelectedIndex = 0;
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
            ListarTotalDP();
            listarPP();
            itemsCMB();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DetallePrestamo FDP = new DetallePrestamo();
            string buscar = txtBuscar.Text;
            dgvReportePersonal.DataSource = FDP.filtrarPP(buscar);
        }

        private void dgvReportePersonal_Click(object sender, EventArgs e)
        {
            ep.Clear();
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
                Reportes.VsrReportePrestamoP rpt = new Reportes.VsrReportePrestamoP(idPersonal, lblUserName.Text);
                rpt.Show();
            }
        }

        private void btnReporteH_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbReporteH.SelectedIndex == 0)
            {
                ep.SetError(cmbReporteH, "Debe seleccionar una opcion");
            }
            if (cmbReporteH.SelectedIndex == 1)
            {
                //Herramientas por Categoria
                Reportes.VsrReporteHerramientasC rpt = new Reportes.VsrReporteHerramientasC(lblUserName.Text);
                rpt.Show();
            }
            if (cmbReporteH.SelectedIndex == 2)
            {
                //Herramientas NuevasHerramientas Disponibles
            }
            if (cmbReporteH.SelectedIndex == 3)
            {
                //Herramientas Disponibles
            }
            if (cmbReporteH.SelectedIndex == 4)
            {
                //Herramientas en Uso
            }
            if (cmbReporteH.SelectedIndex == 5)
            {
                //Herramientas Prestadas, ordenadas por Empleado
            }
            if (cmbReporteH.SelectedIndex == 6)
            {
                //Herramientas Defectuosas
            }
        }
    }
}
