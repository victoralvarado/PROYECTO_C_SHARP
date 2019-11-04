using CapaLogicaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;
/*
 * @Nombre de Clase: FrmInicio.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        private Herramienta H = new Herramienta();
        private Personal P = new Personal();
        private Categoria C = new Categoria();

        private string Nueva;
        private string Normal;
        private string Defectuosa;
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

        public void ListarTotalGrafico()
        {
            H.ListarTotalNU(lblNueva);
            H.ListarTotalNO(lblNormal);
            H.ListarTotalDE(lblDefectuosa);
            //string[] estado = { "NUEVA", "NORMAL", "DEFECTUOSA" };
            //int[] cantidad = {Convert.ToInt32(lblNueva.Text), Convert.ToInt32(lblNormal.Text), Convert.ToInt32(lblDefectuosa.Text)};
            chrGraficoEstado.Titles.Add("ESTADO DE HERRAMIENTAS");

            chrGraficoEstado.Series["NUEVA"].Points.Add(Convert.ToInt32(lblNueva.Text));
            chrGraficoEstado.Series["NUEVA"].Points[0].Color = Color.FromArgb(217, 237, 247);
            chrGraficoEstado.Series["NUEVA"].Points[0].AxisLabel = "NUEVA";
            chrGraficoEstado.Series["NUEVA"].Points[0].LegendText = "NUEVA";
            chrGraficoEstado.Series["NUEVA"].Points[0].Label = lblNueva.Text;

            chrGraficoEstado.Series["NUEVA"].Points.Add(Convert.ToInt32(lblNormal.Text));
            chrGraficoEstado.Series["NUEVA"].Points[1].Color = Color.White;
            chrGraficoEstado.Series["NUEVA"].Points[1].AxisLabel = "NORMAL";
            chrGraficoEstado.Series["NUEVA"].Points[1].LegendText = "NORMAL";
            chrGraficoEstado.Series["NUEVA"].Points[1].Label = lblNormal.Text;


            chrGraficoEstado.Series["NUEVA"].Points.Add(Convert.ToInt32(lblDefectuosa.Text));
            chrGraficoEstado.Series["NUEVA"].Points[2].Color = Color.Red;
            chrGraficoEstado.Series["NUEVA"].Points[2].AxisLabel = "DEFECTUOSA";
            chrGraficoEstado.Series["NUEVA"].Points[2].LegendText = "DEFECTUOSA";
            chrGraficoEstado.Series["NUEVA"].Points[2].Label = lblDefectuosa.Text;





            //for (int i = 0; i < estado.Length; i++)
            //{
            //    Series serie = chrGraficoEstado.Series.Add(estado[i]);
            //    serie.Label = cantidad[i].ToString();
            //    serie.Points.Add(cantidad[i]);
            //}
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ListarTotalGrafico();
            ListarTotalH();
            ListarTotalP();
            ListarTotalC();
        }
    }
}
