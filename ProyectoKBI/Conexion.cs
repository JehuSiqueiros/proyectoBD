using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKBI
{
    class Conexion
    {
        protected SqlConnection conexion;
        protected SqlCommand comando;
        public void AbrirConexion()
        {
            string dirBarbie = @"server = DESKTOP-UFCCLJO\SQLEXTDB; database = ProyectoKBI; uid = sa; pwd = 123;";
            string dirJehu = @"server = JEHUCITOPC\sqlexptbd; database = ProyectoKBI; uid=sa; pwd = 123;";
            conexion = new SqlConnection(dirJehu);
            conexion.Open();
            comando = conexion.CreateCommand();
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
