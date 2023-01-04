using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int IdCategoriaArt { get; set; }
        public string DescripcionCategoria { get; set; }

        public override string ToString()
        {
            return DescripcionCategoria.ToString();
        }

        private List<Categoria> listaCategorias;
        public List<Categoria> ListarCategoria
        {
            get { return listaCategorias; }
            set { listaCategorias = value; }
        }
    }
}
