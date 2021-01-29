using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ProyectoKBI
{
    public partial class frmEliminarVoluntario : Form
    {
        
        public frmEliminarVoluntario()
        {
            InitializeComponent();
            clsVoluntarios objVoluntarios = new clsVoluntarios();
            ArrayList lista = objVoluntarios.listaIDs();
            foreach (clsVoluntarios.dato dato in lista)
            {
                cbIDvoluntarios.Items.Add(dato.idVoluntario.ToString());
            }

        }

        private void frmEliminarVoluntario_Load(object sender, EventArgs e)
        {


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de querer guardar los datos anteriores?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {

                }
                else
                {
                    clsVoluntarios objVoluntarios = new clsVoluntarios();
                    objVoluntarios.Eliminar(Convert.ToInt32(cbIDvoluntarios.SelectedItem.ToString()));
                    lblApellidoM.Text = lblApellidoP.Text = lblHorario.Text = lblNombre.Text = lblTel.Text = string.Empty;
                    lblResult.Text += " Eliminados";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbIDvoluntarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clsVoluntarios objVoluntarios = new clsVoluntarios();
            var voluntario = objVoluntarios.ConsultarPorID(Convert.ToInt32(cbIDvoluntarios.SelectedItem.ToString()));

            lblApellidoM.Text = voluntario.ApellidoM;
            lblApellidoP.Text = voluntario.ApellidoP;
            lblHorario.Text = voluntario.Horario;
            lblTel.Text = voluntario.Telefono;
            lblNombre.Text = voluntario.Nombres;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnClose.BackgroundImage = Properties.Resources.closeHover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnClose.BackgroundImage = Properties.Resources.close1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
