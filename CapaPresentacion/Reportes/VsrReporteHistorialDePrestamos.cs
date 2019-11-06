using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class VsrReporteHistorialDePrestamos : Form
    {
        public VsrReporteHistorialDePrestamos(string prmUsuario)
        {
            InitializeComponent();

            RptHistorialDePrestamos1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
