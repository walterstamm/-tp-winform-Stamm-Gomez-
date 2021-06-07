using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace AplicacionWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<Articulo> Carrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Carrito = (List<Articulo>)Session["listaCarrito"];
                if (Carrito == null)
                    Carrito = new List<Articulo>();

                List<Articulo> listas = (List<Articulo>)Session["listaSeleccionado"];

                int id = int.Parse(Request.QueryString["id"]);

                Articulo seleccionado = listas.Find(x => x.Id == id);
                                
                lblSeleccionado.Text = seleccionado.Nombre;
                lblUrlImagen.Text = seleccionado.ImagenUrl;
                lblPrecio.Text = "$ " + seleccionado.Precio.ToString("0.00");
                lblStock.Text = "Disponible";

                Carrito.Add(listas.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                Session.Add("listaSeleccionado", Carrito);

            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }   
        }

        protected void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx");
        }
    }
}