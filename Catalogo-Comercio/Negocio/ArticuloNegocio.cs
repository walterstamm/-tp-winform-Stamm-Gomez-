using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> lista()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            

            try
            {
                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select isnull(C.Descripcion, 0) as Categoria, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, A.Precio, A.ImagenUrl from ARTICULOS A full join MARCAS M on A.IdMarca = M.Id full join CATEGORIAS C on A.IdCategoria = C.Id where A.Id is not null";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    
                    
                    aux.Categoria = new Categorias((string)lector["Categoria"]);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //aux.Precio = (int)lector["Precio"];
                    aux.Marca = new Marcas((string)lector["Marca"]);
                    aux.ImagenUrl = (string)lector["ImagenUrl"];


                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values ('" + nuevo.Codigo + "' , '" + nuevo.Nombre + " ', '" + nuevo.Descripcion + " ', "+ nuevo.Marca.Id +", " +nuevo.Categoria.Id+ ", '" +nuevo.ImagenUrl+ " ', 0.00)";
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + valores);

                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
