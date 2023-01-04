using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Windows.Forms;

namespace Service
{
    public class MarcasService
    {

        public List<Marca> ListarMarcas()
        {

            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Descripcion from marcas");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.DescripcionMarca = (string)datos.Lector["Descripcion"];

                    listaMarcas.Add(marca);
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
            return listaMarcas;
        }
    }
}
