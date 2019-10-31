﻿using System;
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
    public partial class frmPrincipalBodeguero : Form
    {
        public frmPrincipalBodeguero()
        {
            InitializeComponent();
        }

        public frmPrincipalBodeguero(string userName)
        {
            InitializeComponent();
            lblUserName.Text =  userName;
        }

        ToolTip tt = new ToolTip();
        public void Footer()
        {
            string year;
            year = DateTime.Now.ToString("yyyy");
            lblFooter.Text = "Copyright © " + year + " ToolSoft. Todos los derechos reservados";
        }
        public void SideBar()
        {

            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 62;
                LineaSidebar.Width = 50;
                AnimacionSidebar.Show(Sidebar);
                btnCerrarMenu.Visible = false;
                btnAbrirMenu.Visible = true;
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
                btnAbrirMenu.Visible = false;
                btnCerrarMenu.Visible = true;
            }
        }

        public void sidebarContraer()
        {
            tt.SetToolTip(this.btnInicio, "Inicio");
            tt.SetToolTip(this.btnNuevoPre, "Nuevo Prestamo");
            tt.SetToolTip(this.btnReportes, "Reportes");
            tt.SetToolTip(this.btnGestionar, "Gestionar");
            tt.SetToolTip(this.btnHerramientas, "Gestionar Herramientas");
            tt.SetToolTip(this.btnPersonal, "Gestionar Personal");
            tt.SetToolTip(this.btnCategoria, "Gestionar Categorias");
            tt.SetToolTip(this.btnPrestamo, "Gestionar Detalle Prestamo");
        }

        private void FrmPrincipalEditor_Load(object sender, EventArgs e)
        {
            tt.SetToolTip(btnLogout, "Cerrar sesión");
            sidebarContraer();
            tt.SetToolTip(btnAbrirMenu, "Expandir Menu");
            tt.SetToolTip(btnCerrarMenu, "Contraer Menu");
            AbrirformInpanel(new frmInicio());
            ActivBoton();
            btnInicio.Normalcolor = Color.FromArgb(22, 36, 49);
            Footer();
            OcultarBotones();
            btnGestionar.Text = "      GESTIONAR                     ◀";
        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            if (btnHerramientas.Visible == false)
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

        public void AbrirformInpanel(Form formhijo)
        {
            if (this.pnlFormularios.Controls.Count > 0)
                this.pnlFormularios.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlFormularios.Controls.Add(fh);
            this.pnlFormularios.Tag = fh;
            fh.Show(); 
        }

        public void MostratBotones()
        {
            btnHerramientas.Visible = true;
            btnPersonal.Visible = true;
            btnCategoria.Visible = true;
            btnPrestamo.Visible = true;

        }

        public void OcultarBotones()
        {
            btnHerramientas.Visible = false;
            btnPersonal.Visible = false;
            btnCategoria.Visible = false;
            btnPrestamo.Visible = false;

        }

        public void ActivBoton()
        {
            
            btnInicio.Normalcolor = Color.Transparent;
            btnNuevoPre.Normalcolor = Color.Transparent;
            btnReportes.Normalcolor = Color.Transparent;
            btnGestionar.Normalcolor = Color.Transparent;
            btnHerramientas.Normalcolor = Color.Transparent;
            btnPersonal.Normalcolor = Color.Transparent;
            btnCategoria.Normalcolor = Color.Transparent;
            btnPrestamo.Normalcolor = Color.Transparent;
        }


        private void BtnHerramientas_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new frmHerramienta());
            ActivBoton();
            btnHerramientas.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new frmCategoria());
            ActivBoton();
            btnCategoria.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);
            

        }

        private void btnNuevoPre_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new frmPrestamo(lblUserName.Text, lblBodeguero.Text));
            ActivBoton();
            btnNuevoPre.Normalcolor = Color.FromArgb(22, 36, 49);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new frmDetallePrestamo());
            ActivBoton();
            btnPrestamo.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new frmInicio());
            ActivBoton();
            btnInicio.Normalcolor = Color.FromArgb(22, 36, 49);
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            SideBar();
        }

        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            SideBar();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new frmPersonal());
            ActivBoton();
            btnPersonal.Normalcolor = Color.FromArgb(49, 62, 74);
            btnGestionar.Normalcolor = Color.FromArgb(22, 36, 49);
        }

        private void frmPrincipalEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin L = new frmLogin();
                this.Hide();
                L.Show();
            }
        }
    }
}