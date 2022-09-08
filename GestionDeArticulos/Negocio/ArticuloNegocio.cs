using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDataBase;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public Articulo articulo { get; set; }
               
        public List <Articulo> ListarArticulos()
        {
            ConexionSQL conexion = new ConexionSQL("");

            return new List<Articulo> { articulo };
        }

    }
    
}
