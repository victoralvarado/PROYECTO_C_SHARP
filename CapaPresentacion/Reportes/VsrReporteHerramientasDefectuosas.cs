using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHerramientasDefectuosas : Form
    {
        public VsrReporteHerramientasDefectuosas(string prmUsuario)
        {
            InitializeComponent();
            RptHerramientasDefectuosas1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
