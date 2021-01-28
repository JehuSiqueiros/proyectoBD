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
    }
}
