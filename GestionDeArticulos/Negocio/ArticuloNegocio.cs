using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio;
using AccesoDataBase;
using System.Configuration;

namespace Negocio
{
    public class ArticuloNegocio
    {
        ConexionSQL conexion = null;
        public Articulo articulo { get; set; }

        public List<Articulo> ListarArticulos()
        {
            var list = new List<Articulo>();
            conexion = new ConexionSQL(ConfigurationManager.ConnectionStrings["Arts"].ToString());
            string sql = "SELECT [Id],[Codigo],[Nombre],[Descripcion],[IdCategoria],[Precio],[ImagenUrl] FROM ARTICULOS";
            try
            {
                SqlDataReader dataReader = conexion.EjecutarConsultaDataReader(sql);
                while (dataReader.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = int.Parse(dataReader["Id"].ToString());
                    articulo.Codigo = dataReader["Codigo"].ToString();
                    articulo.Nombre = dataReader["Nombre"].ToString();
                    articulo.Descripcion = dataReader["Descripcion"].ToString();
                    articulo.IdCategoria = int.Parse(dataReader["IdCategoria"].ToString());
                    articulo.Precio = decimal.Parse(dataReader["Precio"].ToString());
                    articulo.ImagenUrl = dataReader["ImagenUrl"].ToString();
                    list.Add(articulo);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            conexion.CerrarConexion();
            return list;
        }
        public void agregar(Articulo nuevo)
            { 
        
            }



}

}
