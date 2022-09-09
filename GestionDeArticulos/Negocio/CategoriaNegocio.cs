using AccesoDataBase;
using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Negocio
{

    public class CategoriaNegocio
    {
        private ConexionSQL conexion = null;

        private void NuevaConexion()
        {
            conexion = new ConexionSQL(ConfigurationManager.ConnectionStrings["Arts"].ToString());
        }
        private void TerminarConexion()
        {            
            conexion.CerrarConexion();
        }
        public List<Categoria> Categorias()
        {
            var list = new List<Categoria>();
            NuevaConexion();
            string sql = "SELECT [Id],[Descripcion] FROM CATEGORIAS";
            try
            {
                SqlDataReader dataReader = conexion.EjecutarConsultaDataReader(sql);
                while (dataReader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = int.Parse(dataReader["Id"].ToString());
                    categoria.Descripcion = dataReader["Descripcion"].ToString();
                    list.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                TerminarConexion();
                throw ex;
            }
            TerminarConexion();
            return list;
        }
        public bool Alta(Categoria categoria)
        {
            bool alta;
            try
            {
                NuevaConexion();
                string sql = "INSERT INTO CATEGORIAS ([Descripcion]) VALUES (@DESCRIPCION)";
                var command = conexion.NewSqlCommand;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                var param = conexion.NewSqlParameter;
                param.ParameterName = "@DESCRIPCION";
                param.Value = categoria.Descripcion;
                command.Parameters.Add(param);
                int num = conexion.EjecutarQueryCommand(command);
                alta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return alta;
        }

        public bool Modifica(Categoria categoria)
        {
            bool modificaion;
            try
            {
                NuevaConexion();
                string sql = "UPDATE CATEGORIAS SET [Descripcion] = @DESCRIPCION WHERE [Id] = @ID";
                var command = conexion.NewSqlCommand;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                var param = conexion.NewSqlParameter;
                param.ParameterName = "@DESCRIPCION";
                param.Value = categoria.Descripcion;
                command.Parameters.Add(param);
                var param2 = conexion.NewSqlParameter;
                param2.ParameterName = "@ID";
                param2.Value = categoria.Id;
                command.Parameters.Add(param2);
                int num = conexion.EjecutarQueryCommand(command);
                modificaion = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return modificaion;
        }
    }
}
