using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHerramientasDisponibles : Form
    {
        public VsrReporteHerramientasDisponibles(string prmUsuario)
        {
            InitializeComponent();

            RptHerramientasDisponibles1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
