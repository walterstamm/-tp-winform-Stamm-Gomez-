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
            Text = "Gestion de Articulos";
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
                //oculto columnas que no quiero = false
                //Puedo poner e indice de la columna o el nombre de la propiedad

                dgvArticulo.Columns["Id"].Visible = false;
                dgvArticulo.Columns["Codigo"].Visible = false;
                dgvArticulo.Columns["Nombre"].Visible = true;
                dgvArticulo.Columns["Descripcion"].Visible = true;
                dgvArticulo.Columns["Precio"].Visible = true;
                dgvArticulo.Columns["Marca"].Visible = true;
                dgvArticulo.Columns["Categoria"].Visible = true;
                dgvArticulo.Columns["ImagenUrl"].Visible = false;

                RecargarImg(ListaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CargaArticulo(List <Articulo> lista)
        {
            try
            {
                dgvArticulo.DataSource = lista;
                //oculto columnas que no quiero = false
                //Puedo poner e indice de la columna o el nombre de la propiedad

                dgvArticulo.Columns["Id"].Visible = false;
                dgvArticulo.Columns["Codigo"].Visible = false;
                dgvArticulo.Columns["Nombre"].Visible = true;
                dgvArticulo.Columns["Descripcion"].Visible = true;
                dgvArticulo.Columns["Precio"].Visible = true;
                dgvArticulo.Columns["Marca"].Visible = true;
                dgvArticulo.Columns["Categoria"].Visible = true;
                dgvArticulo.Columns["ImagenUrl"].Visible = false;

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void RecargarImg(string img)
        {
            try
            {
                PbxImagen.Load(img);
            }
            catch (Exception )
            {
                MessageBox.Show("URL invalida");
            
            } 
        }

        private void dgvArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.ImagenUrl);
        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevo agregar = new FrmAgregarNuevo();
            agregar.ShowDialog();
            CargaArticulo();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo auxiliar = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            FmrModificar Modificar = new FmrModificar(auxiliar);
            Modificar.ShowDialog();
            CargaArticulo();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo aux = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(MessageBox.Show("Seguro que quiere eliminar el Articulo","Eliminar" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    negocio.Eliminar(aux.Id);
                    MessageBox.Show("Eliminado Correctamente");
                    CargaArticulo();
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length >= 3)
            {
                List<Articulo> listaFiltrada = ListaArticulos.FindAll(X => X.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.Codigo.ToUpper().Contains(txtFiltro.Text.ToUpper()));

                CargaArticulo(listaFiltrada);
            }
            else
            {
                CargaArticulo();

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFiltro.Text.Length >= 3)
            {
                List<Articulo> listaFiltrada = ListaArticulos.FindAll(X => X.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.Codigo.ToUpper().Contains(txtFiltro.Text.ToUpper()));
               
                CargaArticulo(listaFiltrada);
            }
            else
            {
                CargaArticulo();
               
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo auxiliar = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            FmrModificar Modificar = new FmrModificar(auxiliar, true);
            Modificar.ShowDialog();
            CargaArticulo();

        }
    }
}
