using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoKBI
{
    public partial class frmBitacoraRegistrar : Form
    {
        public frmBitacoraRegistrar()
        {
            InitializeComponent();

            //ComboBox cmbID muestra los id de los voluntarios
            SqlConnection conexion = new SqlConnection(@"server = DESKTOP-UFCCLJO\SQLEXTDB; database = ProyectoKBI; uid = sa; pwd = 123");
            SqlCommand query = new SqlCommand("SELECT idVoluntario FROM Voluntarios", conexion);
            conexion.Open();
            SqlDataReader reader = query.ExecuteReader();

            while (reader.Read() == true)
            {
                cmbID.Items.Add(reader["idVoluntario".ToString()]);
            }
            conexion.Close();
            reader.Close();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                clsBitacora objBitacora = new clsBitacora();
                objBitacora.Registrar(monthCalendar1.SelectionRange.Start.ToShortDateString(), cmbHora.SelectedItem.ToString(), Convert.ToInt32(nudHombres.Value), Convert.ToInt32(nudMujeres.Value), Convert.ToInt32(nudNinos.Value), Convert.ToInt32(nudNinas.Value), Convert.ToInt32(cmbID.SelectedItem.ToString()));
                MessageBox.Show("Registrado");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
    }
}
