﻿using System;
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
    public partial class VsrReporteHistorialDeDevolucion : Form
    {
        public VsrReporteHistorialDeDevolucion(string prmUsuario)
        {
            InitializeComponent();
            RptHistorialDeDevolucion1.SetParameterValue("prmUsuario", prmUsuario);
        }
    }
}
