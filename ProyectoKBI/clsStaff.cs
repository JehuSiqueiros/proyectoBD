using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProyectoKBI
{
    class clsStaff: Conexion
    {
        public struct dato
        {
            public int IdMiembroEquipo;
            public string Nombre;
            public string ApellidoPaterno;
            public string ApellidoMaterno;
            public string Puesto;
        }

        public dato datos;
        public int idmiembroEquipo
        {
            get { return datos.IdMiembroEquipo; }
            set { datos.IdMiembroEquipo = value; }
        }
        public string nombre
        {
            get { return datos.Nombre; }
            set { datos.Nombre = value; }
        }
        public string apellidoPaterno
        {
            get { return datos.ApellidoPaterno; }
            set { datos.ApellidoPaterno = value; }
        }
        public string apellidoMaterno
        {
            get { return datos.ApellidoMaterno; }
            set { datos.ApellidoMaterno = value; }
        }
        public string puesto
        {
            get { return datos.Puesto; }
            set { datos.Puesto = value; }
        }

        ArrayList lista = new ArrayList();

        public ArrayList ConsultarStaff()
        {
            AbrirConexion();
            comando.CommandText = $"SELECT IdMiembroEquipo,Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno as Nombre, Puesto FROM Staff ORDER BY Nombre ASC;";
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                //Nombre, Staff
                nombre = objLectura["Nombre"].ToString();
                puesto = objLectura["Puesto"].ToString();

                lista.Add(datos);
            }
            conexion.Close();
            return lista;
        }
    }
}
