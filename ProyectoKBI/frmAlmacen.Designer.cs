namespace ProyectoKBI
{
    partial class frmAlmacen
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
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.AllowUserToAddRows = false;
            this.dgvAlmacen.AllowUserToDeleteRows = false;
            this.dgvAlmacen.AllowUserToOrderColumns = true;
            this.dgvAlmacen.AllowUserToResizeRows = false;
            this.dgvAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmacen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.dgvAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlmacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlmacen.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlmacen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.dgvAlmacen.Location = new System.Drawing.Point(0, 109);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.ReadOnly = true;
            this.dgvAlmacen.RowHeadersVisible = false;
            this.dgvAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacen.Size = new System.Drawing.Size(800, 382);
            this.dgvAlmacen.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::ProyectoKBI.Properties.Resources.Banner;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 109);
            this.panel.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::ProyectoKBI.Properties.Resources.close1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(763, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvAlmacen);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlmacen";
            this.Text = "frmAlmacen";
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel btnClose;
    }
}