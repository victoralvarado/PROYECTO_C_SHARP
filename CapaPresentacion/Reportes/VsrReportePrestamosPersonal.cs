using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReportePrestamosPersonal : Form
    {
        public VsrReportePrestamosPersonal(string prmUsuario)
        {
            InitializeComponent();
            RptPrestamoPersonal1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
