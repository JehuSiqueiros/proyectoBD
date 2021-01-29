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

namespace ProyectoKBI
{
    public partial class frmBitacoraRegistrar : Form
    {
        clsBitacora querys = new clsBitacora();
        clsVoluntarios voluntarios = new clsVoluntarios();
        clsVoluntarios.dato registradoPor;
        public frmBitacoraRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                clsBitacora objBitacora = new clsBitacora();
                objBitacora.Registrar(monthCalendar1.SelectionRange.Start.ToShortDateString(), cmbHora.SelectedItem.ToString(), Convert.ToInt32(nudHombres.Value), Convert.ToInt32(nudMujeres.Value), Convert.ToInt32(nudNinos.Value), Convert.ToInt32(nudNinas.Value), registradoPor.idVoluntario);

                MessageBox.Show("Registrado");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackgroundImage = Properties.Resources.closeHover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackgroundImage = Properties.Resources.close1;
        }

        private void frmBitacoraRegistrar_Load(object sender, EventArgs e)
        {
            foreach (var voluntario in voluntarios.ConsultarVoluntarios())
            {
                cmbID.Items.Add(voluntario.NombreCompleto);
            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            registradoPor = voluntarios.lista[cmbID.SelectedIndex];
        }
    }
}
