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
    public partial class frmConsejo : Form
    {
        public frmConsejo()
        {
            InitializeComponent();
        }

        private void frmConsejo_Load(object sender, EventArgs e)
        {
            try
            {
                clsConsejo objConsejo = new clsConsejo();
                ArrayList lista = objConsejo.ConsultarConsejo();

                foreach (clsConsejo.dato dato in lista)
                {
                    dgvConsejo.Rows.Add(dato.Nombre, dato.Posicion, dato.Ocupacion, dato.Residencia);
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
