namespace CapaPresentacion
{
    partial class FrmInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chrGraficoEstado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblDefectuosa = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblNUMCAT = new System.Windows.Forms.Label();
            this.lblPRESTA = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNUMEMP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNUMH = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficoEstado)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(475, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "INICIO";
            // 
            // chrGraficoEstado
            // 
            this.chrGraficoEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chrGraficoEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(146)))), ((int)(((byte)(170)))));
            this.chrGraficoEstado.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chrGraficoEstado.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chrGraficoEstado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrGraficoEstado.Legends.Add(legend1);
            this.chrGraficoEstado.Location = new System.Drawing.Point(162, 200);
            this.chrGraficoEstado.Name = "chrGraficoEstado";
            this.chrGraficoEstado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            series1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "NUEVA";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "NORMAL";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "DEFECTUOSA";
            this.chrGraficoEstado.Series.Add(series1);
            this.chrGraficoEstado.Series.Add(series2);
            this.chrGraficoEstado.Series.Add(series3);
            this.chrGraficoEstado.Size = new System.Drawing.Size(707, 277);
            this.chrGraficoEstado.TabIndex = 0;
            this.chrGraficoEstado.Text = "GraficoEstado";
            title1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "ESTADO DE HERRAMIENTAS";
            this.chrGraficoEstado.Titles.Add(title1);
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Location = new System.Drawing.Point(12, 449);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(35, 13);
            this.lblNueva.TabIndex = 40;
            this.lblNueva.Text = "label1";
            this.lblNueva.Visible = false;
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Location = new System.Drawing.Point(12, 477);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(35, 13);
            this.lblNormal.TabIndex = 41;
            this.lblNormal.Text = "label2";
            this.lblNormal.Visible = false;
            // 
            // lblDefectuosa
            // 
            this.lblDefectuosa.AutoSize = true;
            this.lblDefectuosa.Location = new System.Drawing.Point(12, 502);
            this.lblDefectuosa.Name = "lblDefectuosa";
            this.lblDefectuosa.Size = new System.Drawing.Size(35, 13);
            this.lblDefectuosa.TabIndex = 42;
            this.lblDefectuosa.Text = "label3";
            this.lblDefectuosa.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(29, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(972, 123);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblCat);
            this.panel2.Controls.Add(this.lblNUMCAT);
            this.panel2.Controls.Add(this.lblPRESTA);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(672, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 82);
            this.panel2.TabIndex = 2;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(122, 23);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(73, 17);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Categorias";
            // 
            // lblNUMCAT
            // 
            this.lblNUMCAT.AutoSize = true;
            this.lblNUMCAT.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUMCAT.ForeColor = System.Drawing.Color.White;
            this.lblNUMCAT.Location = new System.Drawing.Point(147, 49);
            this.lblNUMCAT.Name = "lblNUMCAT";
            this.lblNUMCAT.Size = new System.Drawing.Size(23, 21);
            this.lblNUMCAT.TabIndex = 2;
            this.lblNUMCAT.Text = "N";
            // 
            // lblPRESTA
            // 
            this.lblPRESTA.AutoSize = true;
            this.lblPRESTA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRESTA.ForeColor = System.Drawing.Color.White;
            this.lblPRESTA.Location = new System.Drawing.Point(90, 23);
            this.lblPRESTA.Name = "lblPRESTA";
            this.lblPRESTA.Size = new System.Drawing.Size(0, 17);
            this.lblPRESTA.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.IMGCategoria;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lblNUMEMP);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblEM);
            this.panel3.Location = new System.Drawing.Point(369, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 82);
            this.panel3.TabIndex = 1;
            // 
            // lblNUMEMP
            // 
            this.lblNUMEMP.AutoSize = true;
            this.lblNUMEMP.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUMEMP.ForeColor = System.Drawing.Color.White;
            this.lblNUMEMP.Location = new System.Drawing.Point(144, 49);
            this.lblNUMEMP.Name = "lblNUMEMP";
            this.lblNUMEMP.Size = new System.Drawing.Size(23, 21);
            this.lblNUMEMP.TabIndex = 1;
            this.lblNUMEMP.Text = "N";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.IMGPersonal;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblEM
            // 
            this.lblEM.AutoSize = true;
            this.lblEM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEM.ForeColor = System.Drawing.Color.White;
            this.lblEM.Location = new System.Drawing.Point(125, 23);
            this.lblEM.Name = "lblEM";
            this.lblEM.Size = new System.Drawing.Size(61, 17);
            this.lblEM.TabIndex = 0;
            this.lblEM.Text = "Personal";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblNUMH);
            this.panel1.Controls.Add(this.lblH);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(67, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblNUMH
            // 
            this.lblNUMH.AutoSize = true;
            this.lblNUMH.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUMH.ForeColor = System.Drawing.Color.White;
            this.lblNUMH.Location = new System.Drawing.Point(143, 49);
            this.lblNUMH.Name = "lblNUMH";
            this.lblNUMH.Size = new System.Drawing.Size(23, 21);
            this.lblNUMH.TabIndex = 1;
            this.lblNUMH.Text = "N";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(109, 23);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(91, 17);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Herramientas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.IMGHerramienta;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1026, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDefectuosa);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.chrGraficoEstado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGraficoEstado)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraficoEstado;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblDefectuosa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblNUMCAT;
        private System.Windows.Forms.Label lblPRESTA;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNUMEMP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNUMH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}