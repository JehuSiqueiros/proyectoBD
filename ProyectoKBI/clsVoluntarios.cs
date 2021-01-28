using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;


namespace ProyectoKBI
{
    class clsVoluntarios: Conexion
    {
        public struct dato
        {
            public int idVoluntario;
            public string Nombres;
            public string ApellidoP;
            public string ApellidoM;
            public int idHorario;
            public string Telefono;
            public string NombreCompleto;
            public string Horario;
        }

        public dato datos;

        public int IdVoluntario
        {
            get { return datos.idVoluntario; }
            set { datos.idVoluntario = value; }
        }
        public string nombres
        {
            get { return datos.Nombres; }
            set { datos.Nombres = value; }
        }
        public string apellidoP
        {
            get { return datos.ApellidoP; }
            set { datos.ApellidoP = value; }
        }
        public string apellidoM
        {
            get { return datos.ApellidoM; }
            set { datos.ApellidoM = value; }
        }
        public int IdHorario
        {
            get { return datos.idHorario; }
            set { datos.idHorario = value; }
        }
        public string telefono
        {
            get { return datos.Telefono; }
            set { datos.Telefono = value; }
        }
        public string nombreCompleto
        {
            get { return datos.NombreCompleto; }
            set { datos.NombreCompleto = value; }
        }
        public string horario
        {
            get { return datos.Horario; }
            set { datos.Horario = value; }
        }

        ArrayList lista = new ArrayList();

        public ArrayList ConsultarVoluntarios()
        {
            AbrirConexion();
            comando.CommandText = $"SELECT idVoluntario, Nombres + ' ' + ApellidoP + ' ' + ApellidoM as 'Nombre Completo', Dia + ', '+HoraEntrada+'-'+HoraSalida as Horario, Telefono  FROM Voluntarios INNER JOIN Horario ON Voluntarios.idHorario = Horario.idHorario";
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                //ID, NombreCompleto, Horario, Telefono
                IdVoluntario = Convert.ToInt32(objLectura["idVoluntario"].ToString());
                //nombres = objLectura["Nombres"].ToString();
                //apellidoP = objLectura["ApellidoP"].ToString();
                //apellidoM = objLectura["ApellidoM"].ToString();
                nombreCompleto = objLectura["Nombre Completo"].ToString();
                horario = objLectura["Horario"].ToString();
                //IdHorario = Convert.ToInt32(objLectura["Horario"].ToString());
                telefono = objLectura["Telefono"].ToString();
                lista.Add(datos);
            }
            conexion.Close();
            return lista;
        }

        public ArrayList ConsultarInicial(string inicial)
        {
            AbrirConexion();
            comando.CommandText = $"SELECT idVoluntario, Nombres + ' ' + ApellidoP + ' ' + ApellidoM as 'Nombre Completo', Dia + ', '+HoraEntrada+'-'+HoraSalida as Horario, Telefono  FROM Voluntarios INNER JOIN Horario ON Voluntarios.idHorario = Horario.idHorario WHERE Nombres LIKE '"+inicial+"%'";
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                //ID, NombreCompleto, Horario, Telefono
                IdVoluntario = Convert.ToInt32(objLectura["idVoluntario"].ToString());
                //nombres = objLectura["Nombres"].ToString();
                //apellidoP = objLectura["ApellidoP"].ToString();
                //apellidoM = objLectura["ApellidoM"].ToString();
                nombreCompleto = objLectura["Nombre Completo"].ToString();
                horario = objLectura["Horario"].ToString();
                //IdHorario = Convert.ToInt32(objLectura["Horario"].ToString());
                telefono = objLectura["Telefono"].ToString();
                lista.Add(datos);
            }
            conexion.Close();
            return lista;
        }


        //public void Registrar(string fecha, string hora, int CantHombres, int CantMujeres, int CantNinos, int CantNinas, int RegistradoPor)
        //{
        //    string registro = $"INSERT INTO Bitacora(Fecha, Hora,CantHombres,CantMujeres,CantNinos,CantNinas,RegistradoPor) VALUES('{fecha}','{hora}',{CantHombres},{CantMujeres},{CantNinos},{CantNinas},{RegistradoPor});";

        //    AbrirConexion();
        //    comando.CommandText = registro;
        //    comando.ExecuteNonQuery();
        //    CerrarConexion();
        //}

        public void Registrar(string nombre, string apeP, string apeM, int idHora, string numTelefono)
        {
            string registro = $"INSERT INTO Voluntarios(Nombres,ApellidoP,ApellidoM,idHorario,Telefono) VALUES('{nombre}','{apeP}','{apeM}',{idHora},'{numTelefono}')";
            AbrirConexion();
            comando.CommandText = registro;
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public void Eliminar(int id)
        {
            string registro = $"DELETE FROM Voluntarios WHERE idVoluntario = " + id;
            AbrirConexion();
            comando.CommandText = registro;
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public ArrayList ConsultarVoluntariosTODO()
        {
            AbrirConexion();
            comando.CommandText = $"SELECT * FROM Voluntarios";
            SqlDataReader objLectura = comando.ExecuteReader();

            while (objLectura.Read())
            {
                IdVoluntario = Convert.ToInt32(objLectura["idVoluntario"].ToString());
                nombres = objLectura["Nombres"].ToString();
                apellidoP = objLectura["ApellidoP"].ToString();
                apellidoM = objLectura["ApellidoM"].ToString();
                IdHorario = Convert.ToInt32(objLectura["Horario"].ToString());
                telefono = objLectura["Telefono"].ToString();
                lista.Add(datos);
            }
            conexion.Close();
            return lista;
        }




    }
}
