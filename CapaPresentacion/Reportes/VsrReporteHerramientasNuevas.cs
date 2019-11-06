using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHerramientasNuevas : Form
    {
        public VsrReporteHerramientasNuevas(string prmUsuario)
        {
            InitializeComponent();
            RptHerramientasNuevas1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
