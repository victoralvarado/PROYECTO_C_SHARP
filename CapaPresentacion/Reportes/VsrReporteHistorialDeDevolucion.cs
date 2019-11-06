using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHistorialDeDevolucion : Form
    {
        public VsrReporteHistorialDeDevolucion(string prmUsuario)
        {
            InitializeComponent();
            RptHistorialDeDevolucion1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
