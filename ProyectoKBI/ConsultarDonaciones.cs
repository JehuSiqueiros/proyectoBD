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
    public partial class ConsultarDonaciones : Form
    {
        Donaciones query = new Donaciones();
        public ConsultarDonaciones()
        {
            InitializeComponent();
        }

        private void cbDonacion_onItemSelected(object sender, EventArgs e)
        {
            var datos = query.consultarDonacion(cbDonacion.selectedIndex);
            lblComentarios.Text = datos.comentarios;
            lblDonador.Text = datos.donador;
            lblFecha.Text = datos.fecha;
            lblMonto.Text = $"${datos.monto} MXN";
        }

        private void ConsultarDonaciones_Load(object sender, EventArgs e)
        {
            var arreglo = query.obtenerDonaciones();
            foreach (var donacion in arreglo)
            {
                cbDonacion.AddItem($"{donacion.fecha} - {donacion.donador}");
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
