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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private Personal P = new Personal();
        private string idPersonal = null;
        ErrorProvider ep = new ErrorProvider();
        bool Editando = false;
        bool Agregando = false;
        bool ValidarF = false;
        bool Seleccionado = false;

        public void LlenarCampo()
        {
            //Metodo para llenar los campos para filtar(Buscar) en la tabla por un campo especifico
            List<Items> lista = new List<Items>();
            //                     NAME                  VALUE
            lista.Add(new Items("SELECCIONAR", ""));
            lista.Add(new Items("ID PERSONAL", "id"));
            lista.Add(new Items("NOMBRES", "nombre"));
            lista.Add(new Items("APELLIDOS", "apellido"));
            lista.Add(new Items("EDAD", "edad"));
            //Se mostrara el Name y tomara el value del combobox
            cmbCampo.DisplayMember = "Name";
            cmbCampo.ValueMember = "Value";
            cmbCampo.DataSource = lista;
            cmbCampo.SelectedIndex = 0;
        }
        public void ListarPersonal()
        {
            Personal LP = new Personal();
            dgvPersonal.DataSource = LP.ListarPersonal();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            ListarPersonal();
            LlenarCampo();
        }
    }
}
