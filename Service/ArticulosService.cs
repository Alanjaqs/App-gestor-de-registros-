using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Windows.Forms;


namespace Service
{
    public class ArticulosService
    {
       
        public void AgregarModificarArticulo(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void EliminarArticulo(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulos> Listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, a.ImagenUrl, a.Precio from ARTICULOS a, CATEGORIAS c, MARCAS m where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.EjecutarLectura();
                while(datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.IdArt = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.MarcaArt = new Marca();
                    aux.MarcaArt.DescripcionMarca = (string)datos.Lector["Marca"];
                    aux.CategoriaArt = new Categoria();
                    aux.CategoriaArt.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
            return lista;
        }
    }
}
