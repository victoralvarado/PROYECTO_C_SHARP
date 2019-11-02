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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReportesEmple = new System.Windows.Forms.Label();
            this.pnlReportesPrestamos = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReportePersonal = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lbltexto1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtEmpleao = new System.Windows.Forms.TextBox();
            this.btnReportePP = new System.Windows.Forms.Button();
            this.pnlReportesPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonal)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
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
            // pnlReportesPrestamos
            // 
            this.pnlReportesPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.pnlReportesPrestamos.Controls.Add(this.btnReportePP);
            this.pnlReportesPrestamos.Controls.Add(this.txtEmpleao);
            this.pnlReportesPrestamos.Controls.Add(this.txtBuscar);
            this.pnlReportesPrestamos.Controls.Add(this.label1);
            this.pnlReportesPrestamos.Controls.Add(this.dgvReportePersonal);
            this.pnlReportesPrestamos.Controls.Add(this.pnlTitulo);
            this.pnlReportesPrestamos.Controls.Add(this.lbltexto1);
            this.pnlReportesPrestamos.Location = new System.Drawing.Point(22, 37);
            this.pnlReportesPrestamos.Name = "pnlReportesPrestamos";
            this.pnlReportesPrestamos.Size = new System.Drawing.Size(522, 288);
            this.pnlReportesPrestamos.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(96, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(316, 29);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "BUSCAR:";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportePersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReportePersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvReportePersonal.EnableHeadersVisualStyles = false;
            this.dgvReportePersonal.Location = new System.Drawing.Point(21, 111);
            this.dgvReportePersonal.MultiSelect = false;
            this.dgvReportePersonal.Name = "dgvReportePersonal";
            this.dgvReportePersonal.ReadOnly = true;
            this.dgvReportePersonal.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReportePersonal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReportePersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportePersonal.Size = new System.Drawing.Size(482, 126);
            this.dgvReportePersonal.TabIndex = 17;
            this.dgvReportePersonal.Click += new System.EventHandler(this.dgvReportePersonal_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.pnlTitulo.Controls.Add(this.lblReportesEmple);
            this.pnlTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(516, 37);
            this.pnlTitulo.TabIndex = 2;
            // 
            // lbltexto1
            // 
            this.lbltexto1.AutoSize = true;
            this.lbltexto1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto1.ForeColor = System.Drawing.Color.White;
            this.lbltexto1.Location = new System.Drawing.Point(140, 43);
            this.lbltexto1.Name = "lbltexto1";
            this.lbltexto1.Size = new System.Drawing.Size(227, 17);
            this.lbltexto1.TabIndex = 1;
            this.lbltexto1.Text = "Seleccione un Nombre de Empleado";
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
            // txtEmpleao
            // 
            this.txtEmpleao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpleao.Enabled = false;
            this.txtEmpleao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleao.Location = new System.Drawing.Point(21, 243);
            this.txtEmpleao.Name = "txtEmpleao";
            this.txtEmpleao.Size = new System.Drawing.Size(366, 29);
            this.txtEmpleao.TabIndex = 33;
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
            this.btnReportePP.Location = new System.Drawing.Point(406, 243);
            this.btnReportePP.Name = "btnReportePP";
            this.btnReportePP.Size = new System.Drawing.Size(97, 29);
            this.btnReportePP.TabIndex = 34;
            this.btnReportePP.Text = "REPORTE";
            this.btnReportePP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePP.UseVisualStyleBackColor = false;
            this.btnReportePP.Click += new System.EventHandler(this.btnReportePP_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1026, 524);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlReportesPrestamos);
            this.Name = "FrmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
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
        private System.Windows.Forms.Panel pnlReportesPrestamos;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lbltexto1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvReportePersonal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportePP;
        private System.Windows.Forms.TextBox txtEmpleao;
    }
}