using CapaLogicaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/*
 * @Nombre de Clase: frmLogin.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        bool validarL = true;
        Usuario U = new Usuario();
        public void Login()
        {
            validarL = true;
            if (txtPassword.Text == "password" || txtPassword.Text.Trim().Length == 0 || txtUserName.Text == "username" || txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe completar sus credenciales","Validar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                validarL = false;
            }
            if (validarL == true)
            {
                string tipo = "";
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                tipo = U.Login(userName, password);
                if (tipo == "Administrador")
                {
                    frmPrincipal FP = new frmPrincipal(userName);
                    FP.Show();
                    this.Hide();
                }
                if (tipo == "Bodeguero")
                {
                    frmPrincipalBodeguero FPE = new frmPrincipalBodeguero(userName);
                    FPE.Show();
                    this.Hide();
                }
                if (tipo == "")
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ObtenerFechaActual();
            ToolTip();
        }

        public void ObtenerFechaActual()
        {
            DateTime Hoy = DateTime.Today;
            string fechaActual = string.Format("{0:D}", Hoy);
            lblFecha.Text = fechaActual;
        }

        public void ToolTip()
        {
            ToolTip t = new ToolTip();
            t.ShowAlways = true;
            t.SetToolTip(btnCerrar, "Cerrar");
            t.SetToolTip(btnLogIn, "Acceder");
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "username";
                txtUserName.ForeColor = Color.DimGray;
            }
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
