using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHerramientasEnUso : Form
    {
        public VsrReporteHerramientasEnUso(string prmUsuario)
        {
            InitializeComponent();
            RptHerramientasEnUso1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
