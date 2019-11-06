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
    public partial class VsrReporteHerramientasNuevas : Form
    {
        public VsrReporteHerramientasNuevas(string prmUsuario)
        {
            InitializeComponent();
            RptHerramientasNuevas1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
