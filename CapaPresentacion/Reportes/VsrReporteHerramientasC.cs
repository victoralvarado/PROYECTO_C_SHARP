using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHerramientasC : Form
    {
        public VsrReporteHerramientasC(string prmUsuario)
        {
            InitializeComponent();
            RptHerramientasC1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
