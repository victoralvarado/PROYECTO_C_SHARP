namespace CapaPresentacion
{
    partial class FrmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.dgvHerramientaUS = new System.Windows.Forms.DataGridView();
            this.dgvHerramientaUN = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientaUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientaUN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(447, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CATEGORÍAS";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(381, 77);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(266, 29);
            this.txtCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(427, 53);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(174, 21);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Nombre de Categoría";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCategoria.EnableHeadersVisualStyles = false;
            this.dgvCategoria.Location = new System.Drawing.Point(77, 229);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategoria.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(874, 233);
            this.dgvCategoria.TabIndex = 16;
            this.dgvCategoria.Click += new System.EventHandler(this.DgvCategoria_Click);
            // 
            // dgvHerramientaUS
            // 
            this.dgvHerramientaUS.AllowUserToAddRows = false;
            this.dgvHerramientaUS.AllowUserToDeleteRows = false;
            this.dgvHerramientaUS.AllowUserToResizeColumns = false;
            this.dgvHerramientaUS.AllowUserToResizeRows = false;
            this.dgvHerramientaUS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHerramientaUS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHerramientaUS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvHerramientaUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerramientaUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHerramientaUS.EnableHeadersVisualStyles = false;
            this.dgvHerramientaUS.Location = new System.Drawing.Point(198, 467);
            this.dgvHerramientaUS.MultiSelect = false;
            this.dgvHerramientaUS.Name = "dgvHerramientaUS";
            this.dgvHerramientaUS.ReadOnly = true;
            this.dgvHerramientaUS.RowHeadersVisible = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHerramientaUS.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvHerramientaUS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHerramientaUS.Size = new System.Drawing.Size(621, 16);
            this.dgvHerramientaUS.TabIndex = 17;
            // 
            // dgvHerramientaUN
            // 
            this.dgvHerramientaUN.AllowUserToAddRows = false;
            this.dgvHerramientaUN.AllowUserToDeleteRows = false;
            this.dgvHerramientaUN.AllowUserToResizeColumns = false;
            this.dgvHerramientaUN.AllowUserToResizeRows = false;
            this.dgvHerramientaUN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHerramientaUN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHerramientaUN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvHerramientaUN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerramientaUN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHerramientaUN.EnableHeadersVisualStyles = false;
            this.dgvHerramientaUN.Location = new System.Drawing.Point(198, 489);
            this.dgvHerramientaUN.MultiSelect = false;
            this.dgvHerramientaUN.Name = "dgvHerramientaUN";
            this.dgvHerramientaUN.ReadOnly = true;
            this.dgvHerramientaUN.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHerramientaUN.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvHerramientaUN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHerramientaUN.Size = new System.Drawing.Size(621, 14);
            this.dgvHerramientaUN.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(210)))), ((int)(((byte)(77)))));
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(210)))), ((int)(((byte)(77)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 4;
            this.btnAgregar.ButtonText = "AGREGAR";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Silver;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::CapaPresentacion.Properties.Resources._new;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 50D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(130, 134);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(210)))), ((int)(((byte)(77)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(150, 38);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnAgregar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 4;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Silver;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = global::CapaPresentacion.Properties.Resources.edit;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 50D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(288, 134);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(197)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(150, 38);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.Black;
            this.btnEditar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 4;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Silver;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::CapaPresentacion.Properties.Resources.delete;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 50D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(446, 134);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(150, 38);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnEliminar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 4;
            this.btnCancelar.ButtonText = "CANCELAR";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = global::CapaPresentacion.Properties.Resources.cancel;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(604, 134);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(150, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.Black;
            this.btnCancelar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 4;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Silver;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = global::CapaPresentacion.Properties.Resources.save;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 50D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(762, 134);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(150, 38);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.Black;
            this.btnGuardar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(149, 194);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(316, 29);
            this.txtBuscar.TabIndex = 30;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "BUSCAR:";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1026, 524);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvHerramientaUN);
            this.Controls.Add(this.dgvHerramientaUS);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientaUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientaUN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.DataGridView dgvHerramientaUS;
        private System.Windows.Forms.DataGridView dgvHerramientaUN;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
    }
}