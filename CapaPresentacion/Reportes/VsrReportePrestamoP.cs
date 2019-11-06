using System;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReportePrestamoP : Form
    {
        public VsrReportePrestamoP(string prmCodigoEmp, string prmUsuario)
        {
            InitializeComponent();
            RptPrestamoP1.SetParameterValue("prmCodigoEmp", Convert.ToInt32(prmCodigoEmp));
            RptPrestamoP1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
