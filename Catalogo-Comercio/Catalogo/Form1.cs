using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        private List<Articulo> ListaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaArticulo();

        }
        private void CargaArticulo()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = articuloNegocio.lista();
                dgvArticulo.DataSource = ListaArticulos;
                //oculto columnas que no quiero
                //Puedo poner e indice de la columna o el nombre de la propiedad
                dgvArticulo.Columns["Id"].Visible = true;
                dgvArticulo.Columns["Codigo"].Visible = true;
                dgvArticulo.Columns["Nombre"].Visible = true;
                dgvArticulo.Columns["Descripcion"].Visible = true;
                dgvArticulo.Columns["Precio"].Visible = true;
                dgvArticulo.Columns["ImagenUrl"].Visible = true;

                
                //RecargarImg(ListaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RecargarImg(string ing)
        {
            // ACA VA EL PRINT BOX DE LA IMAGEN
        }
    }
}
