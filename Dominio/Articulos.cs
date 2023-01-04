using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        // Properties
        public int IdArt { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca MarcaArt { get; set; }
        public Categoria CategoriaArt { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }

        private List<Articulos> listaArticulos;
        public List<Articulos> ListarArticulos
        {
            get { return listaArticulos; }
            set { listaArticulos = value; }
        }
    }
}
