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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulo> listas;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listas = negocio.lista();// trae lo de la base de dato y lo carga ahi



                Session.Add("listaSeleccionado", listas);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());

                Response.Redirect("Error.aspx");

            }

        }
    }
}