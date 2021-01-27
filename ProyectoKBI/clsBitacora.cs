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
        decimal porcentajeMujeres, porcentajeHombres, porcentajeNiños, porcentajeNiñas;
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

    }
}
