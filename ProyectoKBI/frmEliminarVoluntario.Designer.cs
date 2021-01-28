namespace ProyectoKBI
{
    partial class frmEliminarVoluntario
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbIDvoluntarios = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvVoluntarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // cbIDvoluntarios
            // 
            this.cbIDvoluntarios.FormattingEnabled = true;
            this.cbIDvoluntarios.Location = new System.Drawing.Point(40, 24);
            this.cbIDvoluntarios.Name = "cbIDvoluntarios";
            this.cbIDvoluntarios.Size = new System.Drawing.Size(121, 21);
            this.cbIDvoluntarios.TabIndex = 1;
            this.cbIDvoluntarios.SelectionChangeCommitted += new System.EventHandler(this.cbIDvoluntarios_SelectionChangeCommitted);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(530, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvVoluntarios
            // 
            this.dgvVoluntarios.AllowUserToAddRows = false;
            this.dgvVoluntarios.AllowUserToDeleteRows = false;
            this.dgvVoluntarios.AllowUserToResizeColumns = false;
            this.dgvVoluntarios.AllowUserToResizeRows = false;
            this.dgvVoluntarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVoluntarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoluntarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvVoluntarios.Location = new System.Drawing.Point(12, 104);
            this.dgvVoluntarios.Name = "dgvVoluntarios";
            this.dgvVoluntarios.ReadOnly = true;
            this.dgvVoluntarios.RowHeadersVisible = false;
            this.dgvVoluntarios.Size = new System.Drawing.Size(640, 93);
            this.dgvVoluntarios.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombres";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido Paterno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellido Materno";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "idHorario";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 85);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(38, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Datos:";
            // 
            // frmEliminarVoluntario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 219);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvVoluntarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbIDvoluntarios);
            this.Controls.Add(this.label1);
            this.Name = "frmEliminarVoluntario";
            this.Text = "frmEliminarVoluntario";
            this.Load += new System.EventHandler(this.frmEliminarVoluntario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIDvoluntarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvVoluntarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblResult;
    }
}