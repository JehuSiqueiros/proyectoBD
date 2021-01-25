using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoKBI
{
    class clsBitacora
    {
        string path = @"server = DESKTOP-UFCCLJO\SQLEXTDB; database = ProyectoKBI; uid = sa; pwd = 123";

        public void Registrar(string fecha, string hora, int CantHombres, int CantMujeres, int CantNinos, int CantNinas, int RegistradoPor)
        {
            SqlConnection conexion = new SqlConnection(path);
            string registro = "INSERT INTO Bitacora(Fecha, Hora,CantHombres,CantMujeres,CantNinos,CantNinas,RegistradoPor) VALUES('"+fecha+"','"+hora+"',"+CantHombres+","+CantMujeres+","+CantNinos+","+CantNinas+","+RegistradoPor+");";
            SqlCommand query = new SqlCommand(registro, conexion);
            conexion.Open();
            SqlDataReader reader = query.ExecuteReader();
            conexion.Close();
            reader.Close();
        }


    }
}
