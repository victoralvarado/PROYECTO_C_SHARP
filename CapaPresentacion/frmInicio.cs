using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private Herramienta H = new Herramienta();
        private Personal P = new Personal();
        private Categoria C = new Categoria();
        public void ListarTotalH()
        {
            H.ListarTotalH(lblNUMH);
        }

        public void ListarTotalP()
        {
            P.ListarTotalP(lblNUMEMP);
        }

        public void ListarTotalC()
        {
            C.ListarTotalC(lblNUMCAT);
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            ListarTotalH();
            ListarTotalP();
            ListarTotalC();
        }
    }
}
