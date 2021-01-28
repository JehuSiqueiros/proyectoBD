﻿using System;
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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            try
            {
                clsStaff objStaff = new clsStaff();
                ArrayList lista = objStaff.ConsultarStaff();

                foreach (clsStaff.dato dato in lista)
                {
                    dgvStaff.Rows.Add(dato.Nombre, dato.Puesto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
