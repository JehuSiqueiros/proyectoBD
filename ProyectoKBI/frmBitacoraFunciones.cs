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
    public partial class frmBitacoraFunciones : Form
    {
        clsBitacora querys = new clsBitacora();
        public frmBitacoraFunciones()
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fechaInicio = $"{dtpInicio.Value.Month}/{dtpInicio.Value.Day}/{dtpInicio.Value.Year}";
            string fechaFin = $"{dtpFin.Value.Month}/{dtpFin.Value.Day}/{dtpFin.Value.Year}";
            querys.ConsultarEstadisticas(fechaInicio, fechaFin);
            pbHombres.Value = (int)Math.Round(querys.PorcentajeHombres);
            pbMujeres.Value = (int)Math.Round(querys.PorcentajeMujeres);
            pbNiñas.Value = (int)Math.Round(querys.PorcentajeNiñas);
            pbNiños.Value = (int)Math.Round(querys.PorcentajeNiños);
        }
    }
}
