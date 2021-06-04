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
        public List<Articulo> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                lista = negocio.lista();

            }
            catch (Exception ex)
            {

                Response.Redirect("Error.aspx");

            }

        }
    }
}