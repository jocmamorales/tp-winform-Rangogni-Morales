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

        private void NuevaConexion()
        {
            conexion = new ConexionSQL(ConfigurationManager.ConnectionStrings["Arts"].ToString());
        }

        public List<Articulo> ListarArticulos()
        {
            var list = new List<Articulo>();
            NuevaConexion();
            string sql = "SELECT [Id],[Codigo],[Nombre],[Descripcion],[IdCategoria],[IdMarca],[Precio],[ImagenUrl] FROM ARTICULOS";
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
                    articulo.IdMarca = int.Parse(dataReader["IdMarca"].ToString());
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

        public List<Articulo> ListarArticulos(string filtro)
        {
            var list = new List<Articulo>();
            NuevaConexion();
            string sql = "SELECT [Id],[Codigo],[Nombre],[Descripcion],[IdCategoria],[IdMarca],[Precio],[ImagenUrl] FROM ARTICULOS WHERE " + filtro;
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
                    articulo.IdMarca = int.Parse(dataReader["IdMarca"].ToString());
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
              try
            {
                NuevaConexion();
                string sql = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl,Precio)values(" + nuevo.Codigo + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.IdMarca + "', '" + nuevo.IdCategoria + "', '" + nuevo.ImagenUrl + "','" + nuevo.Precio + "')";
                conexion.EjecutarQuery(sql);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void modificar(Articulo nuevo)
        {  
            try
            {
                NuevaConexion();
                string sql = "UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl,Precio = @Precio WHERE Id=@id";
                SqlCommand sql1 = new SqlCommand();
                sql1.CommandText = sql;
                
                sql1.CommandType = System.Data.CommandType.Text;
                sql1.Parameters.AddWithValue("@Codigo", nuevo.Codigo);
                sql1.Parameters.AddWithValue("@Nombre", nuevo.Nombre); 
                sql1.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                sql1.Parameters.AddWithValue("@idMarca", nuevo.IdMarca);
                sql1.Parameters.AddWithValue("@idCategoria", nuevo.IdCategoria);
                sql1.Parameters.AddWithValue("@imagenUrl", nuevo.ImagenUrl);
                sql1.Parameters.AddWithValue("@precio", nuevo.Precio);
                sql1.Parameters.AddWithValue("@id", nuevo.Id);
                conexion.EjecutarQueryCommand(sql1);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            
        
        }

    }


}
