using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProyectoKBI
{
    class clsBitacora : Conexion
    {

        public struct dato
        {
            public int idBitacora;
            public string Fecha;
            public string Hora;
            public int CantHombres;
            public int CantMujeres;
            public int CantNinos;
            public int CantNinas;
            public int RegistradoPor;
            public string Nombres;

        }

        public dato datos;

        decimal porcentajeMujeres, porcentajeHombres, porcentajeNiños, porcentajeNiñas;

        public int IdBitacora
        {
            get { return datos.idBitacora; }
            set { datos.idBitacora = value; }
        }
        public string fecha
        {
            get { return datos.Fecha; }
            set { datos.Fecha = value; }
        }
        public string hora
        {
            get { return datos.Hora; }
            set { datos.Hora = value; }
        }
        public int cantHombres
        {
            get { return datos.CantHombres; }
            set { datos.CantHombres = value; }
        }
        public int cantMujeres
        {
            get { return datos.CantMujeres; }
            set { datos.CantMujeres = value; }
        }
        public int cantNinos
        {
            get { return datos.CantNinos; }
            set { datos.CantNinos = value; }
        }
        public int cantNinas
        {
            get { return datos.CantNinas; }
            set { datos.CantNinas = value; }
        }
        //Id del voluntario que registro
        public int registradoPor
        {
            get { return datos.RegistradoPor; }
            set { datos.RegistradoPor = value; }
        }

        //Nombre del Voluntario que registro
        public string nombres
        {
            get { return datos.Nombres; }
            set { datos.Nombres = value; }
        }
        public decimal PorcentajeMujeres
        {
            get { return porcentajeMujeres; }
            set { porcentajeMujeres = value; }
        }
        public decimal PorcentajeHombres
        {
            get { return porcentajeHombres; }
            set { porcentajeHombres = value; }
        }
        public decimal PorcentajeNiños
        {
            get { return porcentajeNiños; }
            set { porcentajeNiños = value; }
        }
        public decimal PorcentajeNiñas
        {
            get { return porcentajeNiñas; }
            set { porcentajeNiñas = value; }
        }



        public void Registrar(string fecha, string hora, int CantHombres, int CantMujeres, int CantNinos, int CantNinas, int RegistradoPor)
        {
            string registro = $"INSERT INTO Bitacora(Fecha, Hora,CantHombres,CantMujeres,CantNinos,CantNinas,RegistradoPor) VALUES('{fecha}','{hora}',{CantHombres},{CantMujeres},{CantNinos},{CantNinas},{RegistradoPor});";

            AbrirConexion();
            comando.CommandText = registro;
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
        public void ConsultarEstadisticas(string fechaInicio, string fechaFin)
        {
            string query = $"SELECT dbo.fnHombresPrc('{fechaInicio}', '{fechaFin}') as hombres," +
                                  $"dbo.fnMujeresPrc('{fechaInicio}', '{fechaFin}') as mujeres," +
                                  $"dbo.fnNinasPrc(  '{fechaInicio}', '{fechaFin}') as niñas," +
                                  $"dbo.fnNinosPrc(  '{fechaInicio}', '{fechaFin}') as niños";

            AbrirConexion();
            comando.CommandText = query;
            SqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            this.PorcentajeHombres = Convert.ToDecimal(lector["hombres"]);
            this.PorcentajeMujeres = Convert.ToDecimal(lector["mujeres"]);
            this.PorcentajeNiñas = Convert.ToDecimal(lector["niñas"]);
            this.PorcentajeNiños = Convert.ToDecimal(lector["niños"]);
            CerrarConexion();
        }


        ArrayList lista = new ArrayList();

        public ArrayList ConsultarBitacora(string date)
        {
            AbrirConexion();          
            comando.CommandText = $"SELECT Fecha, Hora, CantHombres, CantMujeres, CantNinos, CantNinas,Nombres as Voluntario FROM Bitacora INNER JOIN Voluntarios ON Bitacora.RegistradoPor = Voluntarios.idVoluntario WHERE Fecha = '" + date + "'";
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                //IdBitacora = Convert.ToInt32(objLectura["idBitacora"]);
                fecha = objLectura["Fecha"].ToString();
                hora = objLectura["Hora"].ToString();
                cantHombres = Convert.ToInt32(objLectura["CantHombres"]);
                cantMujeres = Convert.ToInt32(objLectura["CantMujeres"]);
                cantNinos = Convert.ToInt32(objLectura["CantNinos"]);
                cantNinas = Convert.ToInt32(objLectura["CantNinas"]);
                //registradoPor = Convert.ToInt32(objLectura["RegistradoPor"]);
                nombres = objLectura["Voluntario"].ToString();

                lista.Add(datos);

            }
            conexion.Close();
            return lista;
        }

        public ArrayList ConsultarBitacoraMes(int mes)
        {
            AbrirConexion();
            comando.CommandText = $"SELECT Fecha, Hora, CantHombres, CantMujeres, CantNinos, CantNinas,Nombres as Voluntario FROM Bitacora INNER JOIN Voluntarios ON Bitacora.RegistradoPor = Voluntarios.idVoluntario WHERE MONTH(Fecha) = " + mes;
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                //IdBitacora = Convert.ToInt32(objLectura["idBitacora"]);
                fecha = objLectura["Fecha"].ToString();
                hora = objLectura["Hora"].ToString();
                cantHombres = Convert.ToInt32(objLectura["CantHombres"]);
                cantMujeres = Convert.ToInt32(objLectura["CantMujeres"]);
                cantNinos = Convert.ToInt32(objLectura["CantNinos"]);
                cantNinas = Convert.ToInt32(objLectura["CantNinas"]);
                //registradoPor = Convert.ToInt32(objLectura["RegistradoPor"]);
                nombres = objLectura["Voluntario"].ToString();

                lista.Add(datos);

            }
            conexion.Close();
            return lista;
        }



    }
}
