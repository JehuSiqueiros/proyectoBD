namespace ProyectoKBI
{
    partial class frmBitacoraFunciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitacoraFunciones));
            this.label1 = new System.Windows.Forms.Label();
            this.pbMujeres = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pbNiñas = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Panel();
            this.btnGenerar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbNiños = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pbHombres = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtpInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mes";
            // 
            // pbMujeres
            // 
            this.pbMujeres.animated = false;
            this.pbMujeres.animationIterval = 5;
            this.pbMujeres.animationSpeed = 300;
            this.pbMujeres.BackColor = System.Drawing.Color.Transparent;
            this.pbMujeres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMujeres.BackgroundImage")));
            this.pbMujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pbMujeres.ForeColor = System.Drawing.Color.Khaki;
            this.pbMujeres.LabelVisible = true;
            this.pbMujeres.LineProgressThickness = 8;
            this.pbMujeres.LineThickness = 5;
            this.pbMujeres.Location = new System.Drawing.Point(27, 196);
            this.pbMujeres.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pbMujeres.MaxValue = 100;
            this.pbMujeres.Name = "pbMujeres";
            this.pbMujeres.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.pbMujeres.ProgressColor = System.Drawing.Color.Gold;
            this.pbMujeres.Size = new System.Drawing.Size(281, 281);
            this.pbMujeres.TabIndex = 4;
            this.pbMujeres.Value = 0;
            // 
            // pbNiñas
            // 
            this.pbNiñas.animated = false;
            this.pbNiñas.animationIterval = 5;
            this.pbNiñas.animationSpeed = 300;
            this.pbNiñas.BackColor = System.Drawing.Color.Transparent;
            this.pbNiñas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNiñas.BackgroundImage")));
            this.pbNiñas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pbNiñas.ForeColor = System.Drawing.Color.Khaki;
            this.pbNiñas.LabelVisible = true;
            this.pbNiñas.LineProgressThickness = 8;
            this.pbNiñas.LineThickness = 5;
            this.pbNiñas.Location = new System.Drawing.Point(471, 175);
            this.pbNiñas.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pbNiñas.MaxValue = 100;
            this.pbNiñas.Name = "pbNiñas";
            this.pbNiñas.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.pbNiñas.ProgressColor = System.Drawing.Color.DeepPink;
            this.pbNiñas.Size = new System.Drawing.Size(133, 133);
            this.pbNiñas.TabIndex = 5;
            this.pbNiñas.Value = 0;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::ProyectoKBI.Properties.Resources.Banner;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(616, 80);
            this.panel.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::ProyectoKBI.Properties.Resources.close1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(579, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.BorderRadius = 0;
            this.btnGenerar.ButtonText = "Generar Estadísticas";
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Iconimage")));
            this.btnGenerar.Iconimage_right = null;
            this.btnGenerar.Iconimage_right_Selected = null;
            this.btnGenerar.Iconimage_Selected = null;
            this.btnGenerar.IconMarginLeft = 0;
            this.btnGenerar.IconMarginRight = 0;
            this.btnGenerar.IconRightVisible = true;
            this.btnGenerar.IconRightZoom = 0D;
            this.btnGenerar.IconVisible = true;
            this.btnGenerar.IconZoom = 90D;
            this.btnGenerar.IsTab = false;
            this.btnGenerar.Location = new System.Drawing.Point(323, 100);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.btnGenerar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btnGenerar.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnGenerar.selected = false;
            this.btnGenerar.Size = new System.Drawing.Size(281, 78);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "Generar Estadísticas";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Textcolor = System.Drawing.Color.Khaki;
            this.btnGenerar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pbNiños
            // 
            this.pbNiños.animated = false;
            this.pbNiños.animationIterval = 5;
            this.pbNiños.animationSpeed = 300;
            this.pbNiños.BackColor = System.Drawing.Color.Transparent;
            this.pbNiños.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNiños.BackgroundImage")));
            this.pbNiños.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pbNiños.ForeColor = System.Drawing.Color.Khaki;
            this.pbNiños.LabelVisible = true;
            this.pbNiños.LineProgressThickness = 8;
            this.pbNiños.LineThickness = 5;
            this.pbNiños.Location = new System.Drawing.Point(318, 175);
            this.pbNiños.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pbNiños.MaxValue = 100;
            this.pbNiños.Name = "pbNiños";
            this.pbNiños.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.pbNiños.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.pbNiños.Size = new System.Drawing.Size(133, 133);
            this.pbNiños.TabIndex = 20;
            this.pbNiños.Value = 0;
            // 
            // pbHombres
            // 
            this.pbHombres.animated = false;
            this.pbHombres.animationIterval = 5;
            this.pbHombres.animationSpeed = 300;
            this.pbHombres.BackColor = System.Drawing.Color.Transparent;
            this.pbHombres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHombres.BackgroundImage")));
            this.pbHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pbHombres.ForeColor = System.Drawing.Color.Khaki;
            this.pbHombres.LabelVisible = true;
            this.pbHombres.LineProgressThickness = 8;
            this.pbHombres.LineThickness = 5;
            this.pbHombres.Location = new System.Drawing.Point(361, 301);
            this.pbHombres.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pbHombres.MaxValue = 100;
            this.pbHombres.Name = "pbHombres";
            this.pbHombres.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.pbHombres.ProgressColor = System.Drawing.Color.Red;
            this.pbHombres.Size = new System.Drawing.Size(196, 196);
            this.pbHombres.TabIndex = 21;
            this.pbHombres.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mujeres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Niños";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Niñas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hombres";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.dtpInicio.BorderRadius = 0;
            this.dtpInicio.ForeColor = System.Drawing.Color.Khaki;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpInicio.FormatCustom = null;
            this.dtpInicio.Location = new System.Drawing.Point(27, 100);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(281, 36);
            this.dtpInicio.TabIndex = 26;
            this.dtpInicio.Value = new System.DateTime(2021, 1, 26, 18, 26, 58, 402);
            // 
            // dtpFin
            // 
            this.dtpFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.dtpFin.BorderRadius = 0;
            this.dtpFin.ForeColor = System.Drawing.Color.Khaki;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.FormatCustom = null;
            this.dtpFin.Location = new System.Drawing.Point(27, 142);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(281, 36);
            this.dtpFin.TabIndex = 27;
            this.dtpFin.Value = new System.DateTime(2021, 1, 26, 18, 26, 58, 402);
            // 
            // frmBitacoraFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(616, 495);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pbNiñas);
            this.Controls.Add(this.pbMujeres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNiños);
            this.Controls.Add(this.pbHombres);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBitacoraFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBitacoraFunciones";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbMujeres;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbNiñas;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbNiños;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbHombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDatepicker dtpInicio;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFin;
    }
}