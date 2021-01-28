using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKBI
{
    class Donaciones : Conexion
    {
        public struct datosDonacion
        {
            public int id;
            public decimal monto;
            public string fecha;
            public string donador;
            public string comentarios;
        }
        datosDonacion datos;
        
        public string Donador
        {
            get { return datos.donador; }
            set { datos.donador = value; }
        }
        public string Comentarios
        {
            get { return datos.comentarios; }
            set { datos.comentarios = value; }
        }
        public string Fecha
        {
            get { return datos.fecha; }
            set { datos.fecha = value; }
        }
        public decimal Monto
        {
            get { return datos.monto; }
            set { datos.monto = value; }
        }
        int idDonacion
        {
            get { return datos.id; }
            set { datos.id = value; }
        }

        public List<datosDonacion> donaciones = new List<datosDonacion>();

        public List<datosDonacion> obtenerDonaciones()
        {
            donaciones.Clear();
            AbrirConexion();
            comando.CommandText = "SELECT * FROM Donaciones ORDER BY Fecha ASC";
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                idDonacion = Convert.ToInt32(lector["IdDonacion"]);
                Monto = Convert.ToDecimal(lector["Monto"]);
                Fecha = lector["Fecha"].ToString();
                Comentarios = lector["Razon"].ToString();
                Donador = lector["Donador"].ToString();
                donaciones.Add(datos);
            }
            CerrarConexion();
            return donaciones;
        }
        public datosDonacion consultarDonacion(int id)
        {
            return donaciones[id];
        }

        public void registrarDonacion(string donador, decimal monto, string fecha, string comentarios)
        {
            AbrirConexion();
            comando.CommandText = $"INSERT INTO Donaciones (Donador, Monto, Fecha, Razon) VALUES ('{donador}',{monto},'{fecha}','{comentarios}')";
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}
