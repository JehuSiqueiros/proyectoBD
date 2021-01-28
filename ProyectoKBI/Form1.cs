using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKBI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir form para Registrar en Tabla Bitacora
            frmBitacoraRegistrar frmBitacora = new frmBitacoraRegistrar();
            frmBitacora.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Panel panel = (Panel)sender;
            if(panel.Name == "btnClose")
            {
                panel.BackgroundImage = Properties.Resources.closeHover;
            }
            else
            {
                panel.BackgroundImage = Properties.Resources.HideHover;
            }
        }

        private void btnMinimized_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            Panel panel = (Panel)sender;
            if (panel.Name == "btnClose")
            {
                panel.BackgroundImage = Properties.Resources.close1;
            }
            else
            {
                panel.BackgroundImage = Properties.Resources.Hide;
            }
        }

        private void btnConsultarBitacora_Click(object sender, EventArgs e)
        {
            frmBitacoraConsultar forma = new frmBitacoraConsultar();
            forma.ShowDialog();
        }

        private void obtenerEstadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacoraFunciones forma = new frmBitacoraFunciones();
            forma.ShowDialog();
        }

        private void registrarDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAlmacen forma = new frmAlmacen();
            forma.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarDonaciones forma = new ConsultarDonaciones();
            forma.ShowDialog();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistraDonacion forma = new frmRegistraDonacion();
            forma.ShowDialog();
        }

        private void consejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsejo forma = new frmConsejo();
            forma.ShowDialog();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff forma = new frmStaff();
            forma.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Consultar tabla de voluntarios
            frmConsultarVoluntarios forma = new frmConsultarVoluntarios();
            forma.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Agregar registro en tabla Voluntarios
            frmAgregarVoluntarios forma = new frmAgregarVoluntarios();
            forma.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Eliminar registro de la tabla voluntarios
            frmEliminarVoluntario forma = new frmEliminarVoluntario();
            forma.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarInventario forma = new frmModificarInventario();
            forma.ShowDialog();
        }
    }
}
