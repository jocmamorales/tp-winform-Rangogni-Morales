using AccesoDataBase;
using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
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
        public List<Marca> Marcas()
        {
            var list = new List<Marca>();
            NuevaConexion();
            string sql = "SELECT [Id],[Descripcion] FROM MARCAS";
            try
            {
                SqlDataReader dataReader = conexion.EjecutarConsultaDataReader(sql);
                while (dataReader.Read())
                {
                    Marca marca = new Marca
                    {
                        Id = int.Parse(dataReader["Id"].ToString()),
                        Descripcion = dataReader["Descripcion"].ToString()
                    };
                    list.Add(marca);
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
        public bool Alta(Marca marca)
        {
            bool alta;
            try
            {
                NuevaConexion();
                string sql = "INSERT INTO MARCAS ([Descripcion]) VALUES (@DESCRIPCION)";
                var command = conexion.NewSqlCommand;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                var param = conexion.NewSqlParameter;
                param.ParameterName = "@DESCRIPCION";
                param.Value = marca.Descripcion;
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

        public bool Modifica(Marca marca)
        {
            bool modificaion;
            try
            {
                NuevaConexion();
                string sql = "UPDATE MARCAS SET [Descripcion] = @DESCRIPCION WHERE [Id] = @ID";
                var command = conexion.NewSqlCommand;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                var param = conexion.NewSqlParameter;
                param.ParameterName = "@DESCRIPCION";
                param.Value = marca.Descripcion;
                command.Parameters.Add(param);
                var param2 = conexion.NewSqlParameter;
                param2.ParameterName = "@ID";
                param2.Value = marca.Id;
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
