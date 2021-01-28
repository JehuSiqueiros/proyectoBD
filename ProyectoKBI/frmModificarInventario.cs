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
    public partial class frmModificarInventario : Form
    {
        clsAlmacen query = new clsAlmacen();
        List<clsAlmacen.articulo> inventario;
        public frmModificarInventario()
        {
            InitializeComponent();
        }

        private void frmModificarInventario_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            foreach (var articulo in query.consultarInventario())
            {
                cbArticulo.AddItem($"{articulo.nombre}");
            }
            cbTipo.DataSource = query.consultarTipos();
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string tipo = cbTipo.SelectedItem.ToString();
                int inventario = int.Parse(txtInventario.Text);
                query.modificarArticulo(query.inventario[cbArticulo.selectedIndex].idArticulo, nombre, tipo, inventario);
                MessageBox.Show("Articulo modificado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", $"Error:\n{ex.Message}");
            }
        }

        private void cbArticulo_onItemSelected(object sender, EventArgs e)
        {
            int index = cbArticulo.selectedIndex;
            txtNombre.Text = query.inventario[index].nombre;
            txtInventario.Text = query.inventario[index].cantEnAlmacen.ToString();
            cbTipo.SelectedIndex = cbTipo.Items.IndexOf(query.inventario[index].tipo);
        }

        private void txtInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}
