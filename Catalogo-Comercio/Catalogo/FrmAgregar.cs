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
    public partial class FrmAgregarNuevo : Form
    {
        public FrmAgregarNuevo()
        {
            InitializeComponent();
        }

        private void FrmAgregarNuevo_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            try
            {
                CboMarcas.DataSource = marcasNegocio.listar();
                CboCategoria.DataSource = categoriasNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                nuevo.Codigo = TxbCodigo.Text;
                nuevo.Nombre = TxbNombre.Text;
                nuevo.Descripcion = TxbDescripcion.Text;
                nuevo.Precio = Decimal.Parse(TxbPrecio.Text);
                nuevo.Marca = (Marcas)CboMarcas.SelectedItem;
                nuevo.Categoria = (Categorias)CboCategoria.SelectedItem;
                nuevo.ImagenUrl = TxbImagenUrl.Text;

                articuloNegocio.agregar(nuevo);
                MessageBox.Show("Agregado..........");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
