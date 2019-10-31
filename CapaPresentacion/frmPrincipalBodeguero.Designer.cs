namespace CapaPresentacion
{
    partial class frmPrincipalBodeguero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation15 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalBodeguero));
            BunifuAnimatorNS.Animation animation16 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarMenu = new System.Windows.Forms.PictureBox();
            this.btnAbrirMenu = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tblpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPrestamo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPersonal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHerramientas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGestionar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevoPre = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblBodeguero = new System.Windows.Forms.Label();
            this.lblPanel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrirMenu)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblpPrincipal.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFormularios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 58);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.6042296F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.909366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.966767F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.62537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.12085F));
            this.tableLayoutPanel1.Controls.Add(this.pnlUsuario, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMenu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.AnimacionSidebarBack.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1324, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsuario.Controls.Add(this.btnLogout);
            this.AnimacionSidebarBack.SetDecoration(this.pnlUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlUsuario, BunifuAnimatorNS.DecorationType.None);
            this.pnlUsuario.Location = new System.Drawing.Point(1190, 3);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(131, 52);
            this.pnlUsuario.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.lblUserName, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblUserName, BunifuAnimatorNS.DecorationType.None);
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(943, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            this.lblUserName.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.Image = global::CapaPresentacion.Properties.Resources.Logout;
            this.btnLogout.Location = new System.Drawing.Point(47, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(37, 36);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.lblMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblMenu, BunifuAnimatorNS.DecorationType.None);
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(74, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(72, 58);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCerrarMenu);
            this.pnlMenu.Controls.Add(this.btnAbrirMenu);
            this.AnimacionSidebarBack.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Location = new System.Drawing.Point(10, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(58, 52);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnCerrarMenu
            // 
            this.btnCerrarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnCerrarMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnCerrarMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarMenu.Image = global::CapaPresentacion.Properties.Resources.arrowleft;
            this.btnCerrarMenu.Location = new System.Drawing.Point(4, 0);
            this.btnCerrarMenu.Name = "btnCerrarMenu";
            this.btnCerrarMenu.Size = new System.Drawing.Size(51, 49);
            this.btnCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarMenu.TabIndex = 2;
            this.btnCerrarMenu.TabStop = false;
            this.btnCerrarMenu.Click += new System.EventHandler(this.btnCerrarMenu_Click);
            // 
            // btnAbrirMenu
            // 
            this.btnAbrirMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnAbrirMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnAbrirMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnAbrirMenu.Image = global::CapaPresentacion.Properties.Resources.arrowright;
            this.btnAbrirMenu.Location = new System.Drawing.Point(4, 0);
            this.btnAbrirMenu.Name = "btnAbrirMenu";
            this.btnAbrirMenu.Size = new System.Drawing.Size(51, 49);
            this.btnAbrirMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbrirMenu.TabIndex = 1;
            this.btnAbrirMenu.TabStop = false;
            this.btnAbrirMenu.Visible = false;
            this.btnAbrirMenu.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.pnlFooter.Controls.Add(this.tableLayoutPanel2);
            this.AnimacionSidebarBack.SetDecoration(this.pnlFooter, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlFooter, BunifuAnimatorNS.DecorationType.None);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 627);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1324, 25);
            this.pnlFooter.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblFooter, 0, 0);
            this.AnimacionSidebarBack.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1324, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.lblFooter, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblFooter, BunifuAnimatorNS.DecorationType.None);
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(3, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1318, 25);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "footer";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation15.AnimateOnlyDifferences = true;
            animation15.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.BlindCoeff")));
            animation15.LeafCoeff = 0F;
            animation15.MaxTime = 1F;
            animation15.MinTime = 0F;
            animation15.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicCoeff")));
            animation15.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicShift")));
            animation15.MosaicSize = 1;
            animation15.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation15.RotateCoeff = 0F;
            animation15.RotateLimit = 0F;
            animation15.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.ScaleCoeff")));
            animation15.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.SlideCoeff")));
            animation15.TimeCoeff = 2F;
            animation15.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation15;
            this.AnimacionSidebar.TimeStep = 0.08F;
            // 
            // tblpPrincipal
            // 
            this.tblpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tblpPrincipal.ColumnCount = 2;
            this.tblpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpPrincipal.Controls.Add(this.Sidebar, 0, 0);
            this.tblpPrincipal.Controls.Add(this.pnlFormularios, 1, 0);
            this.AnimacionSidebarBack.SetDecoration(this.tblpPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.tblpPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.tblpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpPrincipal.Location = new System.Drawing.Point(0, 58);
            this.tblpPrincipal.Name = "tblpPrincipal";
            this.tblpPrincipal.RowCount = 1;
            this.tblpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpPrincipal.Size = new System.Drawing.Size(1324, 569);
            this.tblpPrincipal.TabIndex = 4;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnPrestamo);
            this.Sidebar.Controls.Add(this.btnCategoria);
            this.Sidebar.Controls.Add(this.btnPersonal);
            this.Sidebar.Controls.Add(this.btnHerramientas);
            this.Sidebar.Controls.Add(this.pictureBox2);
            this.Sidebar.Controls.Add(this.btnGestionar);
            this.Sidebar.Controls.Add(this.btnReportes);
            this.Sidebar.Controls.Add(this.btnNuevoPre);
            this.Sidebar.Controls.Add(this.btnInicio);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(3, 3);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 563);
            this.Sidebar.TabIndex = 1;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrestamo.BorderRadius = 0;
            this.btnPrestamo.ButtonText = "      Detalle Préstamo";
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnPrestamo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnPrestamo, BunifuAnimatorNS.DecorationType.None);
            this.btnPrestamo.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrestamo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrestamo.Iconimage = global::CapaPresentacion.Properties.Resources._011_codificacion;
            this.btnPrestamo.Iconimage_right = null;
            this.btnPrestamo.Iconimage_right_Selected = null;
            this.btnPrestamo.Iconimage_Selected = null;
            this.btnPrestamo.IconMarginLeft = 0;
            this.btnPrestamo.IconMarginRight = 0;
            this.btnPrestamo.IconRightVisible = true;
            this.btnPrestamo.IconRightZoom = 0D;
            this.btnPrestamo.IconVisible = true;
            this.btnPrestamo.IconZoom = 50D;
            this.btnPrestamo.IsTab = false;
            this.btnPrestamo.Location = new System.Drawing.Point(15, 377);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrestamo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.btnPrestamo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrestamo.selected = false;
            this.btnPrestamo.Size = new System.Drawing.Size(252, 37);
            this.btnPrestamo.TabIndex = 20;
            this.btnPrestamo.Text = "      Detalle Préstamo";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.Textcolor = System.Drawing.Color.LightGray;
            this.btnPrestamo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Activecolor = System.Drawing.Color.Transparent;
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategoria.BorderRadius = 0;
            this.btnCategoria.ButtonText = "       Categorías";
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnCategoria, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnCategoria, BunifuAnimatorNS.DecorationType.None);
            this.btnCategoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategoria.Iconimage = global::CapaPresentacion.Properties.Resources._011_codificacion;
            this.btnCategoria.Iconimage_right = null;
            this.btnCategoria.Iconimage_right_Selected = null;
            this.btnCategoria.Iconimage_Selected = null;
            this.btnCategoria.IconMarginLeft = 0;
            this.btnCategoria.IconMarginRight = 0;
            this.btnCategoria.IconRightVisible = true;
            this.btnCategoria.IconRightZoom = 0D;
            this.btnCategoria.IconVisible = true;
            this.btnCategoria.IconZoom = 50D;
            this.btnCategoria.IsTab = false;
            this.btnCategoria.Location = new System.Drawing.Point(15, 339);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.btnCategoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCategoria.selected = false;
            this.btnCategoria.Size = new System.Drawing.Size(252, 32);
            this.btnCategoria.TabIndex = 18;
            this.btnCategoria.Text = "       Categorías";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Textcolor = System.Drawing.Color.LightGray;
            this.btnCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Activecolor = System.Drawing.Color.Transparent;
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonal.BorderRadius = 0;
            this.btnPersonal.ButtonText = "      Personal";
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnPersonal, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnPersonal, BunifuAnimatorNS.DecorationType.None);
            this.btnPersonal.DisabledColor = System.Drawing.Color.Gray;
            this.btnPersonal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPersonal.Iconimage = global::CapaPresentacion.Properties.Resources._009_constructor;
            this.btnPersonal.Iconimage_right = null;
            this.btnPersonal.Iconimage_right_Selected = null;
            this.btnPersonal.Iconimage_Selected = null;
            this.btnPersonal.IconMarginLeft = 0;
            this.btnPersonal.IconMarginRight = 0;
            this.btnPersonal.IconRightVisible = true;
            this.btnPersonal.IconRightZoom = 0D;
            this.btnPersonal.IconVisible = true;
            this.btnPersonal.IconZoom = 50D;
            this.btnPersonal.IsTab = false;
            this.btnPersonal.Location = new System.Drawing.Point(15, 302);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPersonal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.btnPersonal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPersonal.selected = false;
            this.btnPersonal.Size = new System.Drawing.Size(252, 32);
            this.btnPersonal.TabIndex = 17;
            this.btnPersonal.Text = "      Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Textcolor = System.Drawing.Color.LightGray;
            this.btnPersonal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Activecolor = System.Drawing.Color.Transparent;
            this.btnHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.btnHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHerramientas.BorderRadius = 0;
            this.btnHerramientas.ButtonText = "      Herramientas";
            this.btnHerramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnHerramientas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnHerramientas, BunifuAnimatorNS.DecorationType.None);
            this.btnHerramientas.DisabledColor = System.Drawing.Color.Gray;
            this.btnHerramientas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHerramientas.Iconimage = global::CapaPresentacion.Properties.Resources._008_caja_de_herramientas;
            this.btnHerramientas.Iconimage_right = null;
            this.btnHerramientas.Iconimage_right_Selected = null;
            this.btnHerramientas.Iconimage_Selected = null;
            this.btnHerramientas.IconMarginLeft = 0;
            this.btnHerramientas.IconMarginRight = 0;
            this.btnHerramientas.IconRightVisible = true;
            this.btnHerramientas.IconRightZoom = 0D;
            this.btnHerramientas.IconVisible = true;
            this.btnHerramientas.IconZoom = 50D;
            this.btnHerramientas.IsTab = false;
            this.btnHerramientas.Location = new System.Drawing.Point(15, 265);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHerramientas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.btnHerramientas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHerramientas.selected = false;
            this.btnHerramientas.Size = new System.Drawing.Size(252, 32);
            this.btnHerramientas.TabIndex = 16;
            this.btnHerramientas.Text = "      Herramientas";
            this.btnHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHerramientas.Textcolor = System.Drawing.Color.LightGray;
            this.btnHerramientas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHerramientas.Click += new System.EventHandler(this.BtnHerramientas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Recurso_1;
            this.pictureBox2.Location = new System.Drawing.Point(62, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnGestionar
            // 
            this.btnGestionar.Activecolor = System.Drawing.Color.Transparent;
            this.btnGestionar.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGestionar.BorderRadius = 0;
            this.btnGestionar.ButtonText = "      GESTIONAR                     ◀            ";
            this.btnGestionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnGestionar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnGestionar, BunifuAnimatorNS.DecorationType.None);
            this.btnGestionar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGestionar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGestionar.Iconimage = global::CapaPresentacion.Properties.Resources._006_gestion_de_data;
            this.btnGestionar.Iconimage_right = null;
            this.btnGestionar.Iconimage_right_Selected = null;
            this.btnGestionar.Iconimage_Selected = null;
            this.btnGestionar.IconMarginLeft = 0;
            this.btnGestionar.IconMarginRight = 0;
            this.btnGestionar.IconRightVisible = true;
            this.btnGestionar.IconRightZoom = 0D;
            this.btnGestionar.IconVisible = true;
            this.btnGestionar.IconZoom = 50D;
            this.btnGestionar.IsTab = false;
            this.btnGestionar.Location = new System.Drawing.Point(13, 223);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGestionar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGestionar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGestionar.selected = false;
            this.btnGestionar.Size = new System.Drawing.Size(252, 40);
            this.btnGestionar.TabIndex = 13;
            this.btnGestionar.Text = "      GESTIONAR                     ◀            ";
            this.btnGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionar.Textcolor = System.Drawing.Color.LightGray;
            this.btnGestionar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGestionar.Click += new System.EventHandler(this.BtnGestionar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.Transparent;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "     REPORTES";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = global::CapaPresentacion.Properties.Resources._003_reporte;
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 50D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(13, 176);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(252, 40);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "     REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Textcolor = System.Drawing.Color.LightGray;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnNuevoPre
            // 
            this.btnNuevoPre.Activecolor = System.Drawing.Color.Transparent;
            this.btnNuevoPre.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoPre.BorderRadius = 0;
            this.btnNuevoPre.ButtonText = "     NUEVO PRÉSTAMO";
            this.btnNuevoPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnNuevoPre, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnNuevoPre, BunifuAnimatorNS.DecorationType.None);
            this.btnNuevoPre.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoPre.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoPre.Iconimage = global::CapaPresentacion.Properties.Resources._001_mas;
            this.btnNuevoPre.Iconimage_right = null;
            this.btnNuevoPre.Iconimage_right_Selected = null;
            this.btnNuevoPre.Iconimage_Selected = null;
            this.btnNuevoPre.IconMarginLeft = 0;
            this.btnNuevoPre.IconMarginRight = 0;
            this.btnNuevoPre.IconRightVisible = true;
            this.btnNuevoPre.IconRightZoom = 0D;
            this.btnNuevoPre.IconVisible = true;
            this.btnNuevoPre.IconZoom = 50D;
            this.btnNuevoPre.IsTab = false;
            this.btnNuevoPre.Location = new System.Drawing.Point(13, 125);
            this.btnNuevoPre.Name = "btnNuevoPre";
            this.btnNuevoPre.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNuevoPre.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevoPre.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoPre.selected = false;
            this.btnNuevoPre.Size = new System.Drawing.Size(252, 40);
            this.btnNuevoPre.TabIndex = 9;
            this.btnNuevoPre.Text = "     NUEVO PRÉSTAMO";
            this.btnNuevoPre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPre.Textcolor = System.Drawing.Color.LightGray;
            this.btnNuevoPre.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevoPre.Click += new System.EventHandler(this.btnNuevoPre_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "     INICIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::CapaPresentacion.Properties.Resources._002_casa;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 50D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(13, 75);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(252, 40);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "     INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.LightGray;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.iconoToolSoft;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.AutoSize = true;
            this.pnlFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.pnlFormularios.Controls.Add(this.lblUserName);
            this.AnimacionSidebarBack.SetDecoration(this.pnlFormularios, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlFormularios, BunifuAnimatorNS.DecorationType.None);
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(279, 3);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(1042, 563);
            this.pnlFormularios.TabIndex = 2;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation16.AnimateOnlyDifferences = true;
            animation16.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.BlindCoeff")));
            animation16.LeafCoeff = 0F;
            animation16.MaxTime = 1F;
            animation16.MinTime = 0F;
            animation16.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.MosaicCoeff")));
            animation16.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation16.MosaicShift")));
            animation16.MosaicSize = 0;
            animation16.Padding = new System.Windows.Forms.Padding(0);
            animation16.RotateCoeff = 0F;
            animation16.RotateLimit = 0F;
            animation16.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.ScaleCoeff")));
            animation16.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.SlideCoeff")));
            animation16.TimeCoeff = 0F;
            animation16.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation16;
            this.AnimacionSidebarBack.TimeStep = 0.08F;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = null;
            this.MoverDashboard.Vertical = true;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // lblBodeguero
            // 
            this.lblBodeguero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBodeguero.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.lblBodeguero, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblBodeguero, BunifuAnimatorNS.DecorationType.None);
            this.lblBodeguero.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodeguero.ForeColor = System.Drawing.Color.White;
            this.lblBodeguero.Location = new System.Drawing.Point(511, 15);
            this.lblBodeguero.Name = "lblBodeguero";
            this.lblBodeguero.Size = new System.Drawing.Size(115, 25);
            this.lblBodeguero.TabIndex = 3;
            this.lblBodeguero.Text = "Bodeguero";
            // 
            // lblPanel
            // 
            this.lblPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPanel.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.lblPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblPanel, BunifuAnimatorNS.DecorationType.None);
            this.lblPanel.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.ForeColor = System.Drawing.Color.White;
            this.lblPanel.Location = new System.Drawing.Point(448, 15);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(64, 25);
            this.lblPanel.TabIndex = 2;
            this.lblPanel.Text = "Panel";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(123)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.lblBodeguero);
            this.panel2.Controls.Add(this.lblPanel);
            this.AnimacionSidebarBack.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(152, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 52);
            this.panel2.TabIndex = 4;
            // 
            // frmPrincipalBodeguero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 652);
            this.Controls.Add(this.tblpPrincipal);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.panel1);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1340, 691);
            this.Name = "frmPrincipalBodeguero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TOOLSOFT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipalEditor_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipalEditor_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrirMenu)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblpPrincipal.ResumeLayout(false);
            this.tblpPrincipal.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFormularios.ResumeLayout(false);
            this.pnlFormularios.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlFooter;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGestionar;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoPre;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tblpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlFormularios;
        private Bunifu.Framework.UI.BunifuFlatButton btnHerramientas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnPersonal;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrestamo;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox btnAbrirMenu;
        private System.Windows.Forms.PictureBox btnCerrarMenu;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label lblBodeguero;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Panel panel2;
    }
}

