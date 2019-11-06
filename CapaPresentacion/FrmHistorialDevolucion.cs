using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
 * @Nombre de Clase: FrmHistorialDevolucion.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class FrmHistorialDevolucion : Form
    {
        public FrmHistorialDevolucion()
        {
            InitializeComponent();
        }

        public void ListarDevolucion()
        {
            Devolucion LD = new Devolucion();
            dgvHistorialDevolucion.DataSource = LD.ListarDevolucion();
        }

        public void LlenarCampo()
        {
            //Metodo para llenar los campos para filtar(Buscar) en la tabla por un campo especifico
            List<Items> lista = new List<Items>();
            //                     NAME                  VALUE
            lista.Add(new Items("SELECCIONAR", ""));
            lista.Add(new Items("CÓDIGO DEVOLUCIÓN", "de.idDevolucion"));
            lista.Add(new Items("CÓDIGO EMPLEADO", "p.id"));
            lista.Add(new Items("NOMBRES", "p.nombre"));
            lista.Add(new Items("APELLIDOS", "p.apellido"));
            lista.Add(new Items("CÓDIGO HERRAMIENTA", "hi.idherramienta"));
            lista.Add(new Items("HERRAMIENTA", "h.nombreHerramienta"));
            lista.Add(new Items("ESTADO DE ENTREGA", "de.estadoEntre"));
            lista.Add(new Items("ASIGNADA POR", "de.prespor"));
            lista.Add(new Items("RECIBIDA POR", "de.recibidaPor"));
            lista.Add(new Items("FECHA-HORA", "de.fechaHora"));
            //Se mostrara el Name y tomara el value del combobox
            cmbCampo.DisplayMember = "Name";
            cmbCampo.ValueMember = "Value";
            cmbCampo.DataSource = lista;
            cmbCampo.SelectedIndex = 0;
        }

        private void FrmHistorialDevolucion_Load(object sender, EventArgs e)
        {
            ListarDevolucion();
            LlenarCampo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex == 0)
            {
                //buscar por todos los campos de la tabla
                Devolucion D = new Devolucion();
                string buscar = txtBuscar.Text;
                string value = Convert.ToString(cmbCampo.SelectedValue);
                dgvHistorialDevolucion.DataSource = D.FiltrarDevolucionTC(buscar);
            }
            else
            {
                try
                {
                    //buscar por un campo especifico de la tabla
                    Devolucion D = new Devolucion();
                    string buscar = txtBuscar.Text;
                    string value = Convert.ToString(cmbCampo.SelectedValue);
                    dgvHistorialDevolucion.DataSource = D.FiltrarDevolucion(value, buscar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error : " + ex + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
