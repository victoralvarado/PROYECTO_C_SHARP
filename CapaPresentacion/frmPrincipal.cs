using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
/*
 * @Nombre de Clase: frmPrincipal.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Footer()
        {
            string year;
            year = DateTime.Now.ToString("yyyy");
            lblFooter.Text = "Copyright © " + year + " ToolSoft. Todos los derechos reservados";
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 62;
                LineaSidebar.Width = 50;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Footer();
            OcultarBotones();
            btnGestionar.Text = "      GESTIONAR                     ◀";
        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            if (btnUsuarios.Visible == false)
            {
                MostratBotones();
                btnGestionar.Text = "      GESTIONAR                     ▼";
            }
            else
            {
                OcultarBotones();
                btnGestionar.Text = "      GESTIONAR                     ◀";
            }

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
                //formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.AutoScaleMode = AutoScaleMode.Font;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmUsuario"] == null)
                btnUsuarios.Normalcolor = Color.Transparent;
            btnGestionar.Normalcolor = Color.Transparent;
            if (Application.OpenForms["frmHerramienta"] == null)
                btnHerramientas.Normalcolor = Color.Transparent;
            btnGestionar.Normalcolor = Color.Transparent;
            if (Application.OpenForms["frmCategoria"] == null)
                btnCategoria.Normalcolor = Color.Transparent;
            btnGestionar.Normalcolor = Color.Transparent;
        }

        public void MostratBotones()
        {
            btnUsuarios.Visible = true;
            btnHerramientas.Visible = true;
            btnPersonal.Visible = true;
            btnCategoria.Visible = true;
            btnPrestamo.Visible = true;

        }

        public void OcultarBotones()
        {
            btnUsuarios.Visible = false;
            btnHerramientas.Visible = false;
            btnPersonal.Visible = false;
            btnCategoria.Visible = false;
            btnPrestamo.Visible = false;

        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuario>();
            btnUsuarios.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);

        }

        private void BtnHerramientas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHerramienta>();
            btnHerramientas.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCategoria>();
            btnCategoria.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);
        }
    }
}
