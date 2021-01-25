namespace ProyectoKBI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerEstadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDonacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voluntariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(561, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consejoToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.voluntariosToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDonacionesToolStripMenuItem,
            this.consultarAlmacenToolStripMenuItem});
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.almacenToolStripMenuItem.Text = "Almacen";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.obtenerEstadísticasToolStripMenuItem});
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.bitacoraToolStripMenuItem.Text = "Bitácora";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // obtenerEstadísticasToolStripMenuItem
            // 
            this.obtenerEstadísticasToolStripMenuItem.Name = "obtenerEstadísticasToolStripMenuItem";
            this.obtenerEstadísticasToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.obtenerEstadísticasToolStripMenuItem.Text = "Obtener estadísticas";
            // 
            // registrarDonacionesToolStripMenuItem
            // 
            this.registrarDonacionesToolStripMenuItem.Name = "registrarDonacionesToolStripMenuItem";
            this.registrarDonacionesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.registrarDonacionesToolStripMenuItem.Text = "Registrar donaciones";
            // 
            // consultarAlmacenToolStripMenuItem
            // 
            this.consultarAlmacenToolStripMenuItem.Name = "consultarAlmacenToolStripMenuItem";
            this.consultarAlmacenToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.consultarAlmacenToolStripMenuItem.Text = "Consultar Almacen";
            // 
            // consejoToolStripMenuItem
            // 
            this.consejoToolStripMenuItem.Name = "consejoToolStripMenuItem";
            this.consejoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.consejoToolStripMenuItem.Text = "Consejo";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // voluntariosToolStripMenuItem
            // 
            this.voluntariosToolStripMenuItem.Name = "voluntariosToolStripMenuItem";
            this.voluntariosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.voluntariosToolStripMenuItem.Text = "Voluntarios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 292);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "KBI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consejoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voluntariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDonacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerEstadísticasToolStripMenuItem;
    }
}

