using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProyectoKBI
{
    class clsConsejo: Conexion
    {
        public struct dato
        {
            public int IdMiembroConsejo;
            public string Nombre;
            public string Apellido;
            public string Posicion;
            public string Ocupacion;
            public string Ciudad;
            public string Estado;
            public string País;

            public string Residencia;
        }

        public dato datos;
        public int idmiembroConsejo
        {
            get { return datos.IdMiembroConsejo; }
            set { datos.IdMiembroConsejo = value; }
        }
        public string nombre
        {
            get { return datos.Nombre; }
            set { datos.Nombre = value; }
        }
        public string apellido
        {
            get { return datos.Apellido; }
            set { datos.Apellido = value; }
        }
        public string posicion
        {
            get { return datos.Posicion; }
            set { datos.Posicion = value; }
        }
        public string ocupacion
        {
            get { return datos.Ocupacion; }
            set { datos.Ocupacion = value; }
        }
        public string ciudad
        {
            get { return datos.Ciudad; }
            set { datos.Ciudad = value; }
        }
        public string estado
        {
            get { return datos.Estado; }
            set { datos.Estado = value; }
        }
        public string pais
        {
            get { return datos.País; }
            set { datos.País = value; }
        }
        public string residencia
        {
            get { return datos.Residencia; }
            set { datos.Residencia = value; }
        }

    
        ArrayList lista = new ArrayList();

        public ArrayList ConsultarConsejo()
        {
            AbrirConexion();
            comando.CommandText = $"select Nombre +' '+  Apellido as Nombre, Posición, Ocupación, Ciudad + ', '+ Estado+', '+ País as Residencia from Consejo ORDER BY Nombre ASC";
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                //Nombre, Posición, Ocupación, Residencia
                nombre = objLectura["Nombre"].ToString();
                posicion = objLectura["Posición"].ToString();
                ocupacion = objLectura["Ocupación"].ToString();
                residencia = objLectura["Residencia"].ToString();

                lista.Add(datos);
            }
            conexion.Close();
            return lista;
        }

    }
}
