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
    public partial class frmAlmacen : Form
    {
        clsAlmacen query = new clsAlmacen();
        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            mostrarAlmacen();
        }

        private void mostrarAlmacen()
        {
            DataTable tabla = new DataTable("Almacen");
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Cantidad en inventario", typeof(int));
            foreach (var articulo in query.consultarInventario())
            {
                tabla.Rows.Add(articulo.nombre, articulo.tipo, articulo.cantEnAlmacen);
            }
            dgvAlmacen.DataSource = tabla;
        }
    }
}
