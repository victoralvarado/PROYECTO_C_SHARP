namespace CapaPresentacion
{
    partial class FrmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTotalDP = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CapaLogicaNegocio.GradientPanel();
            this.cmbReporteH = new System.Windows.Forms.ComboBox();
            this.btnReporteH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlReportesPrestamos = new CapaLogicaNegocio.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportePP = new System.Windows.Forms.Button();
            this.dgvReportePersonal = new System.Windows.Forms.DataGridView();
            this.txtEmpleao = new System.Windows.Forms.TextBox();
            this.lbltexto1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblReportesEmple = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlReportesPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonal)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(436, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "REPORTES";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(550, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 13);
            this.lblTipo.TabIndex = 41;
            this.lblTipo.Text = "lblTipo";
            this.lblTipo.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(550, 2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 13);
            this.lblUserName.TabIndex = 40;
            this.lblUserName.Text = "lblUserName";
            this.lblUserName.Visible = false;
            // 
            // lblTotalDP
            // 
            this.lblTotalDP.AutoSize = true;
            this.lblTotalDP.Location = new System.Drawing.Point(607, 21);
            this.lblTotalDP.Name = "lblTotalDP";
            this.lblTotalDP.Size = new System.Drawing.Size(42, 13);
            this.lblTotalDP.TabIndex = 42;
            this.lblTotalDP.Text = "totalDP";
            this.lblTotalDP.Visible = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(83)))), ((int)(((byte)(69)))));
            this.gradientPanel1.Controls.Add(this.cmbReporteH);
            this.gradientPanel1.Controls.Add(this.btnReporteH);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Location = new System.Drawing.Point(583, 37);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(431, 279);
            this.gradientPanel1.TabIndex = 35;
            // 
            // cmbReporteH
            // 
            this.cmbReporteH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporteH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporteH.FormattingEnabled = true;
            this.cmbReporteH.Location = new System.Drawing.Point(27, 136);
            this.cmbReporteH.Name = "cmbReporteH";
            this.cmbReporteH.Size = new System.Drawing.Size(374, 29);
            this.cmbReporteH.TabIndex = 35;
            // 
            // btnReporteH
            // 
            this.btnReporteH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReporteH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteH.FlatAppearance.BorderSize = 0;
            this.btnReporteH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReporteH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteH.Image = global::CapaPresentacion.Properties.Resources.printer;
            this.btnReporteH.Location = new System.Drawing.Point(176, 239);
            this.btnReporteH.Name = "btnReporteH";
            this.btnReporteH.Size = new System.Drawing.Size(97, 29);
            this.btnReporteH.TabIndex = 34;
            this.btnReporteH.Text = "REPORTE";
            this.btnReporteH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteH.UseVisualStyleBackColor = false;
            this.btnReporteH.Click += new System.EventHandler(this.btnReporteH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Generar reporte por";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 37);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reporte de herramientas";
            // 
            // pnlReportesPrestamos
            // 
            this.pnlReportesPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlReportesPrestamos.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.pnlReportesPrestamos.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(83)))), ((int)(((byte)(69)))));
            this.pnlReportesPrestamos.Controls.Add(this.label1);
            this.pnlReportesPrestamos.Controls.Add(this.btnReportePP);
            this.pnlReportesPrestamos.Controls.Add(this.dgvReportePersonal);
            this.pnlReportesPrestamos.Controls.Add(this.txtEmpleao);
            this.pnlReportesPrestamos.Controls.Add(this.lbltexto1);
            this.pnlReportesPrestamos.Controls.Add(this.txtBuscar);
            this.pnlReportesPrestamos.Controls.Add(this.pnlTitulo);
            this.pnlReportesPrestamos.Location = new System.Drawing.Point(12, 37);
            this.pnlReportesPrestamos.Name = "pnlReportesPrestamos";
            this.pnlReportesPrestamos.Size = new System.Drawing.Size(544, 279);
            this.pnlReportesPrestamos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "BUSCAR:";
            // 
            // btnReportePP
            // 
            this.btnReportePP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReportePP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportePP.FlatAppearance.BorderSize = 0;
            this.btnReportePP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReportePP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePP.Image = global::CapaPresentacion.Properties.Resources.printer;
            this.btnReportePP.Location = new System.Drawing.Point(432, 239);
            this.btnReportePP.Name = "btnReportePP";
            this.btnReportePP.Size = new System.Drawing.Size(97, 29);
            this.btnReportePP.TabIndex = 34;
            this.btnReportePP.Text = "REPORTE";
            this.btnReportePP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePP.UseVisualStyleBackColor = false;
            this.btnReportePP.Click += new System.EventHandler(this.btnReportePP_Click);
            // 
            // dgvReportePersonal
            // 
            this.dgvReportePersonal.AllowUserToAddRows = false;
            this.dgvReportePersonal.AllowUserToDeleteRows = false;
            this.dgvReportePersonal.AllowUserToResizeColumns = false;
            this.dgvReportePersonal.AllowUserToResizeRows = false;
            this.dgvReportePersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportePersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportePersonal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportePersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportePersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvReportePersonal.EnableHeadersVisualStyles = false;
            this.dgvReportePersonal.Location = new System.Drawing.Point(13, 107);
            this.dgvReportePersonal.MultiSelect = false;
            this.dgvReportePersonal.Name = "dgvReportePersonal";
            this.dgvReportePersonal.ReadOnly = true;
            this.dgvReportePersonal.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReportePersonal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportePersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportePersonal.Size = new System.Drawing.Size(516, 126);
            this.dgvReportePersonal.TabIndex = 17;
            this.dgvReportePersonal.Click += new System.EventHandler(this.dgvReportePersonal_Click);
            // 
            // txtEmpleao
            // 
            this.txtEmpleao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpleao.Enabled = false;
            this.txtEmpleao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleao.Location = new System.Drawing.Point(13, 239);
            this.txtEmpleao.Name = "txtEmpleao";
            this.txtEmpleao.Size = new System.Drawing.Size(387, 29);
            this.txtEmpleao.TabIndex = 33;
            // 
            // lbltexto1
            // 
            this.lbltexto1.AutoSize = true;
            this.lbltexto1.BackColor = System.Drawing.Color.Transparent;
            this.lbltexto1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto1.ForeColor = System.Drawing.Color.White;
            this.lbltexto1.Location = new System.Drawing.Point(150, 47);
            this.lbltexto1.Name = "lbltexto1";
            this.lbltexto1.Size = new System.Drawing.Size(227, 17);
            this.lbltexto1.TabIndex = 1;
            this.lbltexto1.Text = "Seleccione un Nombre de Empleado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(88, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(272, 29);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.pnlTitulo.Controls.Add(this.lblReportesEmple);
            this.pnlTitulo.Location = new System.Drawing.Point(13, 7);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(516, 37);
            this.pnlTitulo.TabIndex = 2;
            // 
            // lblReportesEmple
            // 
            this.lblReportesEmple.AutoSize = true;
            this.lblReportesEmple.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportesEmple.ForeColor = System.Drawing.Color.White;
            this.lblReportesEmple.Location = new System.Drawing.Point(67, 6);
            this.lblReportesEmple.Name = "lblReportesEmple";
            this.lblReportesEmple.Size = new System.Drawing.Size(386, 21);
            this.lblReportesEmple.TabIndex = 0;
            this.lblReportesEmple.Text = "Reporte de herramientas prestadas por empleado";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1026, 524);
            this.Controls.Add(this.lblTotalDP);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlReportesPrestamos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlReportesPrestamos.ResumeLayout(false);
            this.pnlReportesPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonal)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportesEmple;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lbltexto1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvReportePersonal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportePP;
        private System.Windows.Forms.TextBox txtEmpleao;
        private CapaLogicaNegocio.GradientPanel pnlReportesPrestamos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUserName;
        private CapaLogicaNegocio.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnReporteH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbReporteH;
        private System.Windows.Forms.Label lblTotalDP;
    }
}