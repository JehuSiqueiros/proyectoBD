namespace ProyectoKBI
{
    partial class frmBitacoraRegistrar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHombres = new System.Windows.Forms.NumericUpDown();
            this.nudMujeres = new System.Windows.Forms.NumericUpDown();
            this.nudNinos = new System.Windows.Forms.NumericUpDown();
            this.nudNinas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMujeres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNinas)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(33, 92);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "07:00",
            "15:00"});
            this.cmbHora.Location = new System.Drawing.Point(326, 89);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(220, 21);
            this.cmbHora.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(287, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nudHombres
            // 
            this.nudHombres.Location = new System.Drawing.Point(349, 116);
            this.nudHombres.Name = "nudHombres";
            this.nudHombres.Size = new System.Drawing.Size(197, 20);
            this.nudHombres.TabIndex = 4;
            // 
            // nudMujeres
            // 
            this.nudMujeres.Location = new System.Drawing.Point(349, 147);
            this.nudMujeres.Name = "nudMujeres";
            this.nudMujeres.Size = new System.Drawing.Size(197, 20);
            this.nudMujeres.TabIndex = 5;
            // 
            // nudNinos
            // 
            this.nudNinos.Location = new System.Drawing.Point(349, 176);
            this.nudNinos.Name = "nudNinos";
            this.nudNinos.Size = new System.Drawing.Size(197, 20);
            this.nudNinos.TabIndex = 6;
            // 
            // nudNinas
            // 
            this.nudNinas.Location = new System.Drawing.Point(349, 207);
            this.nudNinas.Name = "nudNinas";
            this.nudNinas.Size = new System.Drawing.Size(197, 20);
            this.nudNinas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(287, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hombres:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(287, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mujeres:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(287, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Niños:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(287, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Niñas:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(33, 271);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(513, 69);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(372, 233);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(174, 21);
            this.cmbID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(287, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Registrado por:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::ProyectoKBI.Properties.Resources.Banner;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(585, 80);
            this.panel.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::ProyectoKBI.Properties.Resources.close1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(548, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // frmBitacoraRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(585, 358);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNinas);
            this.Controls.Add(this.nudNinos);
            this.Controls.Add(this.nudMujeres);
            this.Controls.Add(this.nudHombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(599, 398);
            this.Name = "frmBitacoraRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitácora";
            ((System.ComponentModel.ISupportInitialize)(this.nudHombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMujeres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNinas)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHombres;
        private System.Windows.Forms.NumericUpDown nudMujeres;
        private System.Windows.Forms.NumericUpDown nudNinos;
        private System.Windows.Forms.NumericUpDown nudNinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel btnClose;
    }
}