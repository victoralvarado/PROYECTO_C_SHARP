using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
