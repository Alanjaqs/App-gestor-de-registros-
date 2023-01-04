using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Service;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        // Atributo
        Articulos seleccionado = new Articulos();
        List<Articulos> listaArticulos;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            CargarForm();
        }
           

        public void CargarForm()
        {
            Articulos articulos = new Articulos();
            ArticulosService serviceArt = new ArticulosService();
            Categoria categ = new Categoria();
            CategoriasService serviceCateg = new CategoriasService();
            Marca marcas = new Marca();
            MarcasService serviceMarcas = new MarcasService();

            // Articulos DataGridView
            articulos.ListarArticulos = serviceArt.Listar();
            listaArticulos = serviceArt.Listar();
            dgvArticulos.DataSource = articulos.ListarArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;
            //dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["CategoriaArt"].Visible = false;
            dgvArticulos.Columns["IdArt"].Visible = false;
            // Categorias ComboBox
            categ.ListarCategoria = serviceCateg.ListarCategorias();
            cmbCategorias.DataSource = categ.ListarCategoria;
            cmbCategorias.SelectedIndex = 0;
            // Marcas ComboBox
            marcas.ListarMarcas = serviceMarcas.ListarMarcas();
            cmbMarcas.DataSource = marcas.ListarMarcas;
            cmbMarcas.SelectedIndex = 0;
            
            
            
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FormDetalles detalles = new FormDetalles(seleccionado.Nombre, seleccionado.Descripcion, seleccionado.Imagen, seleccionado.Precio, seleccionado.MarcaArt);
            detalles.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            // Marcas
            // Entiendo que si agregara más marcas y categorias esto no es escalable pero no se me ocurre cómo hacerlo
            if(seleccionado.MarcaArt.DescripcionMarca == "Samsung")
            {
                seleccionado.MarcaArt.IdMarcaClase = 1;
            }
            if (seleccionado.MarcaArt.DescripcionMarca == "Apple")
            {
                seleccionado.MarcaArt.IdMarcaClase = 2;
            }
            if (seleccionado.MarcaArt.DescripcionMarca == "Sony")
            {
                seleccionado.MarcaArt.IdMarcaClase = 3;
            }
            if (seleccionado.MarcaArt.DescripcionMarca == "Huawei")
            {
                seleccionado.MarcaArt.IdMarcaClase = 4;
            }
            if (seleccionado.MarcaArt.DescripcionMarca == "Motorola")
            {
                seleccionado.MarcaArt.IdMarcaClase = 5;
            }
            // Categorias
            if(seleccionado.CategoriaArt.DescripcionCategoria == "Celulares")
            {
                seleccionado.CategoriaArt.IdCategoriaArt = 1;
            }
            if (seleccionado.CategoriaArt.DescripcionCategoria == "Televisores")
            {
                seleccionado.CategoriaArt.IdCategoriaArt = 2;
            }
            if (seleccionado.CategoriaArt.DescripcionCategoria == "Media")
            {
                seleccionado.CategoriaArt.IdCategoriaArt = 3;
            }
            if (seleccionado.CategoriaArt.DescripcionCategoria == "Audio")
            {
                seleccionado.CategoriaArt.IdCategoriaArt = 4;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar ventana = new FormAgregar();
            ventana.ShowDialog();
            CargarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estás eliminando " + seleccionado.Nombre + " ¿Estás seguro/a?", "Eliminando..", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                ArticulosService service = new ArticulosService();
                service.EliminarArticulo("delete from articulos where Id = " + seleccionado.IdArt);
                CargarForm();
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormAgregar ventana = new FormAgregar(seleccionado.Codigo, seleccionado.Nombre, seleccionado.Descripcion, seleccionado.MarcaArt.IdMarcaClase, seleccionado.CategoriaArt.IdCategoriaArt, seleccionado.Imagen, seleccionado.Precio, "Modificar Artículo", seleccionado);
            ventana.ShowDialog();
            CargarForm();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtroCategoria = cmbCategorias.SelectedItem.ToString();
            string filtroMarcas = cmbMarcas.SelectedItem.ToString();
            listaFiltrada = listaArticulos.FindAll(x => x.CategoriaArt.DescripcionCategoria.ToUpper().Contains(filtroCategoria.ToUpper()));
            listaFiltrada = listaFiltrada.FindAll(x => x.MarcaArt.DescripcionMarca.ToUpper().Contains(filtroMarcas.ToUpper()));
            dgvArticulos.DataSource = listaFiltrada;
        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = listaArticulos;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            List<Articulos> listaFiltrada;
            if (filtro != "" && filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                dgvArticulos.DataSource = listaFiltrada;
            }
            else
            {
                dgvArticulos.DataSource = listaArticulos;
            }
        }
    }
}
