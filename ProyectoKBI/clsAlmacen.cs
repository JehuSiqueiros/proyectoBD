using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKBI
{
    class clsAlmacen : Conexion
    {
        public struct articulo
        {
            public int idArticulo;
            public string nombre;
            public string tipo;
            public int cantEnAlmacen;
        }
        public articulo datosArticulo;

        public int IdArticulos
        {
            get { return datosArticulo.idArticulo; }
            set { datosArticulo.idArticulo = value; }
        }
        public int CantEnAlmacen
        {
            get { return datosArticulo.cantEnAlmacen; }
            set { datosArticulo.cantEnAlmacen = value; }
        }
        public string Nombre
        {
            get { return datosArticulo.nombre; }
            set { datosArticulo.nombre = value; }
        }
        public string Tipo
        {
            get { return datosArticulo.tipo; }
            set { datosArticulo.tipo = value; }
        }
        public List<articulo> inventario = new List<articulo>();
        public List<articulo> consultarInventario()
        {
            inventario.Clear();
            string query = "SELECT t1.idArticulos AS Id, Nombre, t2.Descrip AS Tipo, Unidades " +
                            "FROM Articulos t1 LEFT JOIN Tipos t2 ON t1.idTipo = t2.idTipo" +
                            " LEFT JOIN Almacen t3 ON t1.idArticulos = t3.idArticulos ORDER BY Nombre";
            AbrirConexion();
            comando.CommandText = query;
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                IdArticulos = Convert.ToInt32(lector["Id"]);
                Nombre = lector["Nombre"].ToString();
                Tipo = lector["Tipo"].ToString();
                CantEnAlmacen = Convert.ToInt32(lector["Unidades"]);
                inventario.Add(datosArticulo);
            }
            CerrarConexion();
            return inventario;
        }
        public List<string> consultarTipos()
        {
            List<string> lstTipos = new List<string>();
            AbrirConexion();
            comando.CommandText = "SELECT Descrip FROM Tipos";
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lstTipos.Add(lector["Descrip"].ToString());
            }
            return lstTipos;
        }
        public void modificarArticulo(int id, string nombre, string tipo, int inventario)
        {
            string query = $"SELECT idTipo FROM Tipos WHERE Descrip = '{tipo}'";
            AbrirConexion();
            comando.CommandText = query;
            SqlDataReader lector = comando.ExecuteReader();
            lector.Read();
            int idTipo = int.Parse(lector["idTipo"].ToString());
            lector.Close();
            query = $"UPDATE Articulos SET Nombre = '{nombre}', idTipo = {idTipo} WHERE idArticulos = {id}";
            comando.CommandText = query;
            comando.ExecuteNonQuery();
            query = $"UPDATE Almacen SET Unidades = {inventario} WHERE idArticulos = {id}";
            comando.CommandText = query;
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}
