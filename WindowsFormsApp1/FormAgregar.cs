using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Dominio;

namespace WindowsFormsApp1
{
    public partial class FormAgregar : Form
    {
        Articulos seleccionado = new Articulos();
        Categoria categ = new Categoria();
        CategoriasService serviceCateg = new CategoriasService();
        Marca marcas = new Marca();
        MarcasService serviceMarcas = new MarcasService();
        public FormAgregar()
        {
            InitializeComponent();
            categ.ListarCategoria = serviceCateg.ListarCategorias();
            cmbCategoriasAgregar.DataSource = categ.ListarCategoria;
            cmbCategoriasAgregar.SelectedIndex = 0;
            marcas.ListarMarcas = serviceMarcas.ListarMarcas();
            cmbMarcasAgregar.DataSource = marcas.ListarMarcas;
            cmbMarcasAgregar.SelectedIndex = 0;
        }

        public FormAgregar(string codigo, string nombre, string descripcion, int marca, int categoria, string imagen, decimal precio, string titulo, Articulos seleccionado)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            // Marcas 
            marcas.ListarMarcas = serviceMarcas.ListarMarcas();
            cmbMarcasAgregar.DataSource = marcas.ListarMarcas;
            if (marca == 1)
            {
                cmbMarcasAgregar.SelectedIndex = 0;
            }
            else if (marca == 2)
            {
                cmbMarcasAgregar.SelectedIndex = 1;
            }
            else if (marca == 3)
            {
                cmbMarcasAgregar.SelectedIndex = 2;
            }
            else if (marca == 4)
            {
                cmbMarcasAgregar.SelectedIndex = 3;
            }
            else if (marca == 5)
            {
                cmbMarcasAgregar.SelectedIndex = 4;
            }
            // Categorias
            categ.ListarCategoria = serviceCateg.ListarCategorias();
            cmbCategoriasAgregar.DataSource = categ.ListarCategoria;
            if (categoria == 1)
            {
                cmbCategoriasAgregar.SelectedIndex = 0;
            }
            else if (categoria == 2)
            {
                cmbCategoriasAgregar.SelectedIndex = 1;
            }
            else if (categoria == 3)
            {
                cmbCategoriasAgregar.SelectedIndex = 2;
            }
            else if (categoria == 4)
            {
                cmbCategoriasAgregar.SelectedIndex = 3;
            }
            txtImagen.Text = imagen;
            txtPrecio.Text = precio.ToString();
            Text = titulo;
            this.seleccionado = seleccionado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Text == "Agregar Artículo")
            {
                if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "" && txtImagen.Text != "" && txtPrecio.Text != "" && txtPrecio.Text.All(char.IsDigit))
                {
                    ArticulosService service = new ArticulosService();
                    Articulos articulo = new Articulos();

                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    // Marcas
                    articulo.MarcaArt = new Marca();
                    if (cmbMarcasAgregar.SelectedIndex == 0)
                    {
                        articulo.MarcaArt.IdMarcaClase = 1;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 1)
                    {
                        articulo.MarcaArt.IdMarcaClase = 2;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 2)
                    {
                        articulo.MarcaArt.IdMarcaClase = 3;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 3)
                    {
                        articulo.MarcaArt.IdMarcaClase = 4;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 4)
                    {
                        articulo.MarcaArt.IdMarcaClase = 5;
                    }
                    // Categorias
                    articulo.CategoriaArt = new Categoria();
                    if (cmbCategoriasAgregar.SelectedIndex == 0)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 1;
                    }
                    else if (cmbCategoriasAgregar.SelectedIndex == 1)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 2;
                    }
                    else if (cmbCategoriasAgregar.SelectedIndex == 2)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 3;
                    }
                    else if (cmbCategoriasAgregar.SelectedIndex == 3)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 4;
                    }
                    articulo.Imagen = txtImagen.Text;
                    articulo.Precio = Decimal.Parse(txtPrecio.Text);

                  
                    service.AgregarModificarArticulo("insert into articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.MarcaArt.IdMarcaClase + "," + articulo.CategoriaArt.IdCategoriaArt + ",'" + articulo.Imagen + "','" + articulo.Precio + "')");
                    MessageBox.Show("Agregado exitósamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falta completar algún campo o algún campo tiene información incorrecta");
                }
            }

            if(Text == "Modificar Artículo")
            {
                if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != ""  && txtImagen.Text != "" && txtPrecio.Text != "" && txtPrecio.Text.All(char.IsDigit))
                {
                    ArticulosService service = new ArticulosService();
                    Articulos articulo = new Articulos();

                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    // Marcas
                    articulo.MarcaArt = new Marca();
                    if (cmbMarcasAgregar.SelectedIndex == 0)
                    {
                        articulo.MarcaArt.IdMarcaClase = 1;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 1)
                    {
                        articulo.MarcaArt.IdMarcaClase = 2;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 2)
                    {
                        articulo.MarcaArt.IdMarcaClase = 3;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 3)
                    {
                        articulo.MarcaArt.IdMarcaClase = 4;
                    }
                    else if (cmbMarcasAgregar.SelectedIndex == 4)
                    {
                        articulo.MarcaArt.IdMarcaClase = 5;
                    }
                    // Categorias
                    articulo.CategoriaArt = new Categoria();
                    if (cmbCategoriasAgregar.SelectedIndex == 0)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 1;
                    }
                    else if (cmbCategoriasAgregar.SelectedIndex == 1)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 2;
                    }
                    else if (cmbCategoriasAgregar.SelectedIndex == 2)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 3;
                    }
                    else if (cmbCategoriasAgregar.SelectedIndex == 3)
                    {
                        articulo.CategoriaArt.IdCategoriaArt = 4;
                    }
                    articulo.Imagen = txtImagen.Text;
                    articulo.Precio = Decimal.Parse(txtPrecio.Text);

                    service.AgregarModificarArticulo("update articulos set Codigo = '" + articulo.Codigo + "',Nombre = '" + articulo.Nombre + "',Descripcion = '" + articulo.Descripcion + "',IdMarca = " + articulo.MarcaArt.IdMarcaClase + ",IdCategoria = " + articulo.CategoriaArt.IdCategoriaArt + ",ImagenUrl = '" + articulo.Imagen + "',Precio = '" + articulo.Precio + "' where Id = " + seleccionado.IdArt);
                    MessageBox.Show("Modificado exitósamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falta completar algún campo o algún campo tiene información incorrecta");
                }
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
