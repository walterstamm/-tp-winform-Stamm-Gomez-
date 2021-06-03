using Dominio;
using Negocio;
using System;
using System.Windows.Forms;
namespace Catalogo
{
    public partial class FmrModificar : Form
    {
        private Articulo ArtAuxiliar;
<<<<<<< Updated upstream
        private bool Detalle = false;
=======
>>>>>>> Stashed changes
       
        public FmrModificar(Articulo articulo)
        {
            InitializeComponent();
            this.ArtAuxiliar = articulo;
            Text = "Modificar Articulo";

        }


        public FmrModificar(Articulo articulo,bool detalle)
        {
            InitializeComponent();
            this.ArtAuxiliar = articulo;
            Text = "Detalle del Articulo";
            this.Detalle=detalle;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RecargarImg(string img)
        {
            try
            {
                pbxArticulo.Load(img);
            }
            catch (Exception )
            {

                MessageBox.Show("URL Invalida");
            }
        }

        private void FmrModificar_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            MarcasNegocio marcas = new MarcasNegocio();

            try
            {

                cbCategoria.DataSource = categoriasNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                cbMarca.DataSource = marcas.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                txtCodigo.Text = ArtAuxiliar.Codigo;
                txtNombre.Text = ArtAuxiliar.Nombre;
                txtDescripcion.Text = ArtAuxiliar.Descripcion;
                txtprecio.Text = (string)ArtAuxiliar.Precio.ToString();
                txtUrlImagen.Text = ArtAuxiliar.ImagenUrl;
                cbCategoria.SelectedValue = ArtAuxiliar.Categoria.Id;
                cbMarca.SelectedValue = ArtAuxiliar.Marca.Id;
                RecargarImg(ArtAuxiliar.ImagenUrl);
                ActivarDesactivar();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                ArtAuxiliar.Codigo = txtCodigo.Text;
                ArtAuxiliar.Nombre = txtNombre.Text;
                ArtAuxiliar.Descripcion = txtDescripcion.Text;
                ArtAuxiliar.Precio = Decimal.Parse(txtprecio.Text);
                ArtAuxiliar.Marca = (Marcas)cbMarca.SelectedItem;
                ArtAuxiliar.Categoria = (Categorias)cbCategoria.SelectedItem;
                ArtAuxiliar.ImagenUrl = txtUrlImagen.Text;
              
                articuloNegocio.ModificarArticulo(ArtAuxiliar);
                MessageBox.Show("Modificado");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            RecargarImg(txtUrlImagen.Text);
        }

        private void ActivarDesactivar()
        {
            btnAceptar.Visible = !Detalle;
            btnCancelar.Visible = !Detalle;
            gbDetalle.Enabled = !Detalle;
        }
    }
}

