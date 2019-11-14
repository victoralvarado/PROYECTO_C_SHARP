using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
* @Nombre de Clase: FrmHistorialPrestamo.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaPresentacion
{
    public partial class FrmHistorialPrestamo : Form
    {
        public FrmHistorialPrestamo()
        {
            InitializeComponent();
        }

        public void ListarHistorial()
        {
            Historial LH = new Historial();
            dgvHistorialPrestamo.DataSource = LH.ListarHistorial();
        }

        public void LlenarCampo()
        {
            //Metodo para llenar los campos para filtar(Buscar) en la tabla por un campo especifico
            List<Items> lista = new List<Items>();
            //                     NAME                  VALUE
            lista.Add(new Items("SELECCIONAR", ""));
            lista.Add(new Items("CÓDIGO EMPLEADO", "p.id"));
            lista.Add(new Items("NOMBRES", "p.nombre"));
            lista.Add(new Items("APELLIDOS", "p.apellido"));
            lista.Add(new Items("CÓDIGO HISTORIAL", "hi.idPrestamoH"));
            lista.Add(new Items("CÓDIGO HERRAMIENTA", "hi.idherramienta"));
            lista.Add(new Items("HERRAMIENTA", "h.nombreHerramienta"));
            lista.Add(new Items("FECHA-HORA", "hi.fechaHora"));
            lista.Add(new Items("ASIGNADA POR", "hi.prespor"));
            //Se mostrara el Name y tomara el value del combobox
            cmbCampo.DisplayMember = "Name";
            cmbCampo.ValueMember = "Value";
            cmbCampo.DataSource = lista;
            cmbCampo.SelectedIndex = 0;
        }

        private void FrmHistorialPrestamo_Load(object sender, EventArgs e)
        {
            ListarHistorial();
            LlenarCampo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex == 0)
            {
                //buscar por todos los campos de la tabla
                Historial LH = new Historial();
                string buscar = '%' + txtBuscar.Text + '%';
                dgvHistorialPrestamo.DataSource = LH.FiltrarHistorialTC(buscar);
            }
            else
            {
                try
                {
                    //buscar por un campo especifico de la tabla
                    Historial LH = new Historial();
                    string buscar = '%' + txtBuscar.Text + '%';
                    string value = cmbCampo.SelectedValue.ToString();
                    dgvHistorialPrestamo.DataSource = LH.FiltrarHistorial(value, buscar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error : " + ex + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
