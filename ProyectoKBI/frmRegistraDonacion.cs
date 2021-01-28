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
    public partial class frmRegistraDonacion : Form
    {
        Donaciones query = new Donaciones();
        public frmRegistraDonacion()
        {
            InitializeComponent();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string donador, fecha, comentarios;
            decimal monto;
            try
            {
                donador = txtDonador.Text.Trim();
                fecha = $"{dtpFecha.Value.Month}/{dtpFecha.Value.Day}/{dtpFecha.Value.Year}";
                comentarios = txtComentarios.Text.Trim();
                monto = Convert.ToDecimal(txtMonto.Text.Trim());
                query.registrarDonacion(donador, monto, fecha, comentarios);
                MessageBox.Show("Donación registrada", "La donación se ha registrado con éxito.");
                txtComentarios.Text = txtDonador.Text = txtMonto.Text = "";
                dtpFecha.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Un error ha ocurrido tratando de registrar la donación\nError: " + ex.Message);
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar) || Convert.ToChar(e.KeyChar) == '.')))
                e.Handled = true;

            if (txtMonto.Text.IndexOf('.') != -1 && Convert.ToChar(e.KeyChar) == '.')
                e.Handled = true;
        }
    }
}
