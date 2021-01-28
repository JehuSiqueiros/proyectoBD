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
                    dgvVoluntarios.Rows.Clear();
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
            dgvVoluntarios.Rows.Clear();
            clsVoluntarios objVoluntarios = new clsVoluntarios();
            ArrayList lista = objVoluntarios.ConsultarPorID(Convert.ToInt32(cbIDvoluntarios.SelectedItem.ToString()));
            foreach (clsVoluntarios.dato dato in lista)
            {
                dgvVoluntarios.Rows.Add(dato.idVoluntario, dato.Nombres, dato.ApellidoP, dato.ApellidoM,dato.idHorario, dato.Telefono);
            }
        }
    }
}
