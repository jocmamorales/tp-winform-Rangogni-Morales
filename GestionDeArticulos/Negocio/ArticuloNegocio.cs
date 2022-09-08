using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public Articulo articulo { get; set; }
               
        public List <Articulo> ListarArticulos()
        {
            return new List<Articulo> { articulo };
        }

    }
    
}
