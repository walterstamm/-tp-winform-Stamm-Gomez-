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
        public List<Articulo> carrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (List<Articulo>)Session["listaCarrito"];
            if (carrito == null)//Si carrito es null creo la lista, sino voy a trabajar con la lista de la session
                carrito = new List<Articulo>();

            List<Articulo> listaOriginal = (List<Articulo>)Session["listaSeleccionado"];

            carrito.Add(listaOriginal.Find(x => x.Id.ToString() == Request.QueryString["id"]));
            Session.Add("listaCarrito", carrito);

        }

        protected void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx");
        }
    }
}