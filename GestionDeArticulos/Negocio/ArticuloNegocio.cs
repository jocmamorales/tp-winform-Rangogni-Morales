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
        public void agregar(Articulo nuevo)
        {
           // NuevaConexion();
            


            try
            {
                //NuevaConexion datos = new NuevaConexion();
                //ConexionSQL datos = new ConexionSQL();
                /*
                datos.setearConsulta ("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl,Precio)values(" + nuevo.Codigo + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.IdMarca + "', '" + nuevo.IdCategoria + "', '" + nuevo.ImagenUrl + "','" + nuevo.Precio + "')");
                               
                datos.setearParametro("@Codigo",nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.IdMarca);
                datos.setearParametro("@idCategoria", nuevo.IdCategoria);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@precio", nuevo.Precio);

                conexion.EjecutarQueryCommand(datos);
                */
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
        {  /* 
            NuevaConexion();



            try
            {
                

                datos.setearConsulta = ("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl,Precio = @Precio WHERE Id=@id";

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.IdMarca);
                datos.setearParametro("@idCategoria", nuevo.IdCategoria);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@id", nuevo.Id);
                conexion.EjecutarQueryCommand(datos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            
        */
        }

    }


}
