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
    public partial class FormDetalles : Form
    {
        public FormDetalles(string nombre, string descripcion, string imagen, decimal precio, Marca marca)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblDescripcion.Text = descripcion;
            pboxImagen.ImageLocation = imagen;
            lblPrecio.Text = "Precio: " + precio.ToString();
            lblMarca.Text = marca.DescripcionMarca;
        }

   
    }
}
