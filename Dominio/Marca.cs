using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int IdMarcaClase { get; set; }
        public string DescripcionMarca { get; set; }

        public override string ToString()
        {
            return DescripcionMarca.ToString();
        }

        private List<Marca> listaMarcas;
        public List<Marca> ListarMarcas
        {
            get { return listaMarcas; }
            set { listaMarcas = value; }
        }
    }
}
