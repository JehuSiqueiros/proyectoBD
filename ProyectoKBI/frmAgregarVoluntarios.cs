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
    public partial class frmAgregarVoluntarios : Form
    {
        public frmAgregarVoluntarios()
        {
            InitializeComponent();
        }

        public int idHora=1;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            dgvVoluntarios.Rows.Clear();

            try
            {
                if (MessageBox.Show("¿Está seguro de querer guardar los datos anteriores?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {

                }
                else
                {
                    clsVoluntarios objVoluntarios = new clsVoluntarios();
                    objVoluntarios.Registrar(txtNombre.Text, txtPaterno.Text, txtMaterno.Text, idHora, txtTelefono.Text);
                    ArrayList lista = objVoluntarios.ConsultarVoluntariosTODO(txtPaterno.Text, txtMaterno.Text);
                    foreach (clsVoluntarios.dato dato in lista)
                    {
                        dgvVoluntarios.Rows.Add(dato.idVoluntario, dato.Nombres, dato.ApellidoP, dato.ApellidoM, dato.idHorario, dato.Telefono);
                    }
                    lblResult.Text = "Registrado correctamente";

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                throw;
            }

        }

        private void cbHorario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            switch (cbHorario.SelectedIndex)
            {
                case 0:
                    idHora = 1;
                    break;
                case 1:
                    idHora = 2;
                    break;
                case 2:
                    idHora = 3;
                    break;
                case 3:
                    idHora = 4;
                    break;
                case 4:
                    idHora = 5;
                    break;
                case 5:
                    idHora = 6;
                    break;
                case 6:
                    idHora = 7;
                    break;
                case 7:
                    idHora = 8;
                    break;
                case 8:
                    idHora = 9;
                    break;
                case 9:
                    idHora = 10;
                    break;
                case 10:
                    idHora = 11;
                    break;
                case 11:
                    idHora = 12;
                    break;
                case 12:
                    idHora = 13;
                    break;
                case 13:
                    idHora = 14;
                    break;
                default:
                    break;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox de telefono validado solo para números
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;               
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
