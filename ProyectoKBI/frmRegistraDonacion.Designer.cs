namespace ProyectoKBI
{
    partial class frmRegistraDonacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistraDonacion));
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtDonador = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtComentarios = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMonto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::ProyectoKBI.Properties.Resources.Banner;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(435, 80);
            this.panel.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::ProyectoKBI.Properties.Resources.close1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(398, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtDonador
            // 
            this.txtDonador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDonador.ForeColor = System.Drawing.Color.Khaki;
            this.txtDonador.HintForeColor = System.Drawing.Color.Khaki;
            this.txtDonador.HintText = "Donador";
            this.txtDonador.isPassword = false;
            this.txtDonador.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtDonador.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.txtDonador.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtDonador.LineThickness = 3;
            this.txtDonador.Location = new System.Drawing.Point(29, 119);
            this.txtDonador.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonador.Name = "txtDonador";
            this.txtDonador.Size = new System.Drawing.Size(370, 44);
            this.txtDonador.TabIndex = 19;
            this.txtDonador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComentarios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtComentarios.ForeColor = System.Drawing.Color.Khaki;
            this.txtComentarios.HintForeColor = System.Drawing.Color.Khaki;
            this.txtComentarios.HintText = "Comentarios";
            this.txtComentarios.isPassword = false;
            this.txtComentarios.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtComentarios.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.txtComentarios.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtComentarios.LineThickness = 3;
            this.txtComentarios.Location = new System.Drawing.Point(29, 199);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(370, 44);
            this.txtComentarios.TabIndex = 20;
            this.txtComentarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMonto
            // 
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMonto.ForeColor = System.Drawing.Color.Khaki;
            this.txtMonto.HintForeColor = System.Drawing.Color.Khaki;
            this.txtMonto.HintText = "Monto";
            this.txtMonto.isPassword = false;
            this.txtMonto.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtMonto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.txtMonto.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtMonto.LineThickness = 3;
            this.txtMonto.Location = new System.Drawing.Point(29, 282);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(370, 44);
            this.txtMonto.TabIndex = 21;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.Khaki;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Khaki;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 1;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.Khaki;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.Khaki;
            this.btnRegistrar.Location = new System.Drawing.Point(103, 435);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(225, 58);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.dtpFecha.BorderRadius = 0;
            this.dtpFecha.ForeColor = System.Drawing.Color.Khaki;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.FormatCustom = null;
            this.dtpFecha.Location = new System.Drawing.Point(29, 365);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(370, 51);
            this.dtpFecha.TabIndex = 24;
            this.dtpFecha.Value = new System.DateTime(2021, 1, 27, 19, 39, 17, 441);
            // 
            // frmRegistraDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(435, 507);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtDonador);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistraDonacion";
            this.Text = "frmRegistraDonacion";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDonador;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtComentarios;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMonto;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFecha;
    }
}