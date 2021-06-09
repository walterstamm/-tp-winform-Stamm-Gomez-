using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;


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
            if (!IsPostBack)
            {

                if (Request.QueryString["Id"] != null)
                {

                    if (carrito.Find(x => x.Id.ToString() == Request.QueryString["Id"]) == null)
                    {
                        List<Articulo> listaOriginal = (List<Articulo>)Session["listaSeleccionado"];
                        carrito.Add(listaOriginal.Find(x => x.Id.ToString() == Request.QueryString["Id"]));
                    }


                }

                repetidor.DataSource = carrito;
                repetidor.DataBind();

            }
            Session.Add("listaCarrito", carrito);
        }

        protected void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulo> carrito = (List<Articulo>)Session["listaCarrito"];
            Articulo elim = carrito.Find(x => x.Id.ToString() == argument);
            carrito.Remove(elim);
            Session.Add("listaCarrito", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = carrito;
            repetidor.DataBind();
        }
    }
}