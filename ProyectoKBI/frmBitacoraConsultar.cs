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
    public partial class frmBitacoraConsultar : Form
    {
        public frmBitacoraConsultar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            ((Panel)sender).BackgroundImage = Properties.Resources.closeHover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            ((Panel)sender).BackgroundImage = Properties.Resources.close1;
        }

        private void btnClose_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
