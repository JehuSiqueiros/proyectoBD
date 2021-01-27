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
    public partial class frmBitacoraConsultar : Form
    {
        public frmBitacoraConsultar()
        {
            InitializeComponent();
            dgvDatos.ColumnHeadersVisible = false;
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

        private void dtpFecha_CloseUp(object sender, EventArgs e)
        {
            //Consulta por día específico cuando el usuario cierra el dateTimepicker
            dgvDatos.Rows.Clear();
            dgvDatos.ColumnHeadersVisible = true;
            clsBitacora objBitacora = new clsBitacora();
            string fecha = dtpFecha.Value.ToShortDateString().Substring(6, 4) + "-" + dtpFecha.Value.ToShortDateString().Substring(3, 2) + "-" + dtpFecha.Value.ToShortDateString().Substring(0, 2);
            
            ArrayList lista = objBitacora.ConsultarBitacora(fecha);
            foreach (clsBitacora.dato dato in lista)
            {
                dgvDatos.Rows.Add(dato.Fecha,dato.Hora, dato.CantHombres, dato.CantMujeres, dato.CantNinos, dato.CantNinas,dato.Nombres);
            }
            
        }

        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Consulta por mes 
            dgvDatos.Rows.Clear();
            dgvDatos.ColumnHeadersVisible = true;
            clsBitacora objBitacora = new clsBitacora();
            int mes = 0;
            switch (cbMes.SelectedItem.ToString())
            {
                case "Enero":
                    mes = 1;
                    break;
                case "Febrero":
                    mes = 2;
                    break;
                case "Marzo":
                    mes = 3;
                    break;
                case "Abril":
                    mes = 4;
                    break;
                case "Mayo":
                    mes = 5;
                    break;
                case "Junio":
                    mes = 6;
                    break;
                case "Julio":
                    mes = 7;
                    break;
                case "Agosto":
                    mes = 8;
                    break;
                case "Septiembre":
                    mes = 9;
                    break;
                case "Octubre":
                    mes = 10;
                    break;
                case "Noviembre":
                    mes = 11;
                    break;
                case "Diciembre":
                    mes = 12;
                    break;
                default:
                    break;
            }

            ArrayList lista = objBitacora.ConsultarBitacoraMes(mes);
            foreach (clsBitacora.dato dato in lista)
            {
                dgvDatos.Rows.Add(dato.Fecha, dato.Hora, dato.CantHombres, dato.CantMujeres, dato.CantNinos, dato.CantNinas, dato.Nombres);
            }


        }
    }
}
