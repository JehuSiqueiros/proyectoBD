using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProyectoKBI
{
    public partial class frmConsultarVoluntarios : Form
    {
        public frmConsultarVoluntarios()
        {
            InitializeComponent();
        }

        private void frmConsultarVoluntarios_Load(object sender, EventArgs e)
        {
            try
            {
                clsVoluntarios objVoluntarios = new clsVoluntarios();
                var lista = objVoluntarios.ConsultarVoluntarios();
                foreach (clsVoluntarios.dato dato in lista)
                {
                    dgvVoluntarios.Rows.Add(dato.idVoluntario, dato.NombreCompleto, dato.Horario, dato.Telefono);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Vuelve a cargar la tabla completa
            try
            {
                dgvVoluntarios.Rows.Clear();
                clsVoluntarios objVoluntarios = new clsVoluntarios();
                var lista = objVoluntarios.ConsultarVoluntarios();
                foreach (clsVoluntarios.dato dato in lista)
                {
                    dgvVoluntarios.Rows.Add(dato.idVoluntario, dato.NombreCompleto, dato.Horario, dato.Telefono);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbAlfabeto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvVoluntarios.Rows.Clear();
            clsVoluntarios objVoluntarios = new clsVoluntarios();
            var lista = objVoluntarios.ConsultarInicial(cbAlfabeto.SelectedItem.ToString());
            foreach (clsVoluntarios.dato dato in lista)
            {
                dgvVoluntarios.Rows.Add(dato.idVoluntario, dato.NombreCompleto, dato.Horario, dato.Telefono);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnClose.BackgroundImage = Properties.Resources.close1;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnClose.BackgroundImage = Properties.Resources.closeHover;
        }

        private void btnClose_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
