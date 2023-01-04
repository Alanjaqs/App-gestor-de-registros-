using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Windows.Forms;

namespace Service
{
    public class CategoriasService
    {

        public List<Categoria> ListarCategorias()
        {

            List<Categoria> listaCat = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Descripcion from categorias");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria categ = new Categoria();
                    categ.DescripcionCategoria = (string)datos.Lector["Descripcion"];

                    listaCat.Add(categ);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
            return listaCat;
        }

    }
}
