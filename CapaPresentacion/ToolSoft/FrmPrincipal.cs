﻿using System;
using System.Drawing;
using System.Windows.Forms;
/*
 * @Nombre de Clase: FrmPrincipal.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(string userName)
        {
            InitializeComponent();
            lblUserName.Text = userName;
        }

        ToolTip ttL = new ToolTip();
        ToolTip tt = new ToolTip();

        public void Footer()
        {
            string year;
            year = DateTime.Now.ToString("yyyy");
            lblFooter.Text = "Copyright © " + year + " ToolSoft. Todos los derechos reservados";
        }

        public void SideBar()
        {

            if (pnlConteMenu.Width == 270)
            {
                pnlConteMenu.Width = 62;
                btnCerrarMenu.Visible = false;
                btnAbrirMenu.Visible = true;
            }
            else
            {
                pnlConteMenu.Width = 270;
                btnAbrirMenu.Visible = false;
                btnCerrarMenu.Visible = true;
            }
        }

        public void sidebarContraer()
        {
            tt.Active = true;
            tt.IsBalloon = true;
            tt.SetToolTip(this.btnInicio, "Inicio");
            tt.SetToolTip(this.btnNuevoPre, "Nuevo Préstamo");
            tt.SetToolTip(this.btnReportes, "Reportes");
            tt.SetToolTip(this.btnHistorialDe, "Historial de Devolución");
            tt.SetToolTip(this.btnHPrestamo, "Historial de Préstamos");
            tt.SetToolTip(this.btnGestionar, "Gestionar");
            tt.SetToolTip(this.btnUsuarios, "Gestionar Usuarios");
            tt.SetToolTip(this.btnHerramientas, "Gestionar Herramientas");
            tt.SetToolTip(this.btnPersonal, "Gestionar Personal");
            tt.SetToolTip(this.btnCategoria, "Gestionar Categorías");
            tt.SetToolTip(this.btnPrestamo, "Devolución");
            tt.SetToolTip(this.btnUserName, "Usuario: " + lblUserName.Text + "");
        }

        public void comproSidebar()
        {
            if (pnlConteMenu.Width == 270)
            {
                if (btnPersonal.Visible == false)
                {
                    MostratBotones();
                    btnGestionar.Text = "      GESTIONAR                     ▼";
                }
                if (btnPersonal.Visible == true)
                {
                    OcultarBotones();
                    btnGestionar.Text = "      GESTIONAR                     ◀";
                }
            }
            if (pnlConteMenu.Width == 62)
            {
                if (btnPersonal.Visible == false)
                {
                    MostratBotones();
                    btnGestionar.Text = " ▼";
                }
                if (btnPersonal.Visible == true)
                {
                    OcultarBotones();
                    btnGestionar.Text = " ◀";
                }
            }
        }

        //Metodo para abrir un formulario a la vez
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
            btnUsuarios.Visible = true;
            btnHerramientas.Visible = true;
            btnPersonal.Visible = true;
            btnCategoria.Visible = true;
        }

        public void OcultarBotones()
        {
            btnUsuarios.Visible = false;
            btnHerramientas.Visible = false;
            btnPersonal.Visible = false;
            btnCategoria.Visible = false;

        }

        public void ActivBoton()
        {
            btnInicio.BackColor = Color.Transparent;
            btnNuevoPre.BackColor = Color.Transparent;
            btnReportes.BackColor = Color.Transparent;
            btnHistorialDe.BackColor = Color.Transparent;
            btnHPrestamo.BackColor = Color.Transparent;
            btnGestionar.BackColor = Color.Transparent;
            btnUsuarios.BackColor = Color.Transparent;
            btnHerramientas.BackColor = Color.Transparent;
            btnPersonal.BackColor = Color.Transparent;
            btnCategoria.BackColor = Color.Transparent;
            btnPrestamo.BackColor = Color.Transparent;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ttL.SetToolTip(btnLogout, "Cerrar sesión");
            ttL.SetToolTip(btnAbrirMenu, "Expandir Menú");
            ttL.SetToolTip(btnCerrarMenu, "Contraer Menú");
            AbrirformInpanel(new FrmInicio());
            ActivBoton();
            btnInicio.BackColor = Color.FromArgb(22, 36, 49);
            Footer();
            OcultarBotones();
            btnUserName.Text = "      " + lblUserName.Text;
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            SideBar();
            comproSidebar();
            sidebarContraer();
        }

        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            SideBar();
            comproSidebar();
            tt.Active = false;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin L = new FrmLogin();
                this.Hide();
                L.Show();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmInicio());
            ActivBoton();
            btnInicio.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnNuevoPre_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmPrestamo(lblUserName.Text, lblAdministrador.Text));
            ActivBoton();
            btnNuevoPre.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmReportes(lblUserName.Text, lblAdministrador.Text));
            ActivBoton();
            btnReportes.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnHistorialDe_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmHistorialDevolucion());
            ActivBoton();
            btnHistorialDe.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnHPrestamo_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmHistorialPrestamo());
            ActivBoton();
            btnHPrestamo.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            if (pnlConteMenu.Width == 270)
            {
                if (btnPersonal.Visible == false)
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
            if (pnlConteMenu.Width == 62)
            {
                if (btnPersonal.Visible == false)
                {
                    MostratBotones();
                    btnGestionar.Text = " ▼";
                }
                else
                {
                    OcultarBotones();
                    btnGestionar.Text = " ◀";
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmUsuario());
            ActivBoton();
            btnUsuarios.BackColor = Color.FromArgb(49, 62, 74);
            btnGestionar.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmHerramienta(lblAdministrador.Text));
            ActivBoton();
            btnHerramientas.BackColor = Color.FromArgb(49, 62, 74);
            btnGestionar.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmPersonal(lblAdministrador.Text));
            ActivBoton();
            btnPersonal.BackColor = Color.FromArgb(49, 62, 74);
            btnGestionar.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmCategoria(lblAdministrador.Text));
            ActivBoton();
            btnCategoria.BackColor = Color.FromArgb(49, 62, 74);
            btnGestionar.BackColor = Color.FromArgb(22, 36, 49);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            AbrirformInpanel(new FrmDevolucion(lblUserName.Text));
            ActivBoton();
            btnPrestamo.BackColor = Color.FromArgb(22, 36, 49);
        }
    }
}
