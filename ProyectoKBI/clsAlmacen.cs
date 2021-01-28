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
        articulo datosArticulo;

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
                            " LEFT JOIN Almacen t3 ON t1.idArticulos = t3.idArticulos";
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
    }
}
