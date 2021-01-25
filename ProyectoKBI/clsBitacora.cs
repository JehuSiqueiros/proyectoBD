using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoKBI
{
    class clsBitacora : Conexion
    {

        public void Registrar(string fecha, string hora, int CantHombres, int CantMujeres, int CantNinos, int CantNinas, int RegistradoPor)
        {
            string registro = $"INSERT INTO Bitacora(Fecha, Hora,CantHombres,CantMujeres,CantNinos,CantNinas,RegistradoPor) VALUES('{fecha}','{hora}',{CantHombres},{CantMujeres},{CantNinos},{CantNinas},{RegistradoPor});";

            comando.CommandText = registro;
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();



        }

    }
}
