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
                comando.CommandText = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion as Marca,M.Id IdMarca,C.Id IdCategoria, isnull(C.Descripcion, 0) as Categoria, A.ImagenUrl  from ARTICULOS A full join MARCAS M on A.IdMarca = M.Id full join CATEGORIAS C on A.IdCategoria = C.Id where A.Id is not null";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (Decimal)lector["Precio"];
                    aux.Marca = new Marcas((string)lector["Marca"]);
                    aux.Categoria = new Categorias((string)lector["Categoria"]);
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Categoria.Id = (int)lector["IdCategoria"];

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
                string valores = "values ('" + nuevo.Codigo + "' , '" + nuevo.Nombre + " ', '" + nuevo.Descripcion + " ', "+ nuevo.Marca.Id +", " +nuevo.Categoria.Id+ ", '" +nuevo.ImagenUrl+ " ', " +nuevo.Precio + ")";
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + valores);

                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar (int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS where Id= " + ID);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex; 
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }


        public void ModificarArticulo(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,IdMarca=@idMarca,IdCategoria=@idCategoria,ImagenUrl=@urlImagen,Precio=@precio where Id=@id");
                datos.setearParametro("@id",modificar.Id);
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre",modificar.Nombre);
                datos.setearParametro("@descripcion",modificar.Descripcion);
                datos.setearParametro("@idMarca",modificar.Marca.Id);
                datos.setearParametro("@idCategoria",modificar.Categoria.Id);
                datos.setearParametro("@urlImagen",modificar.ImagenUrl);
                datos.setearParametro("@precio",modificar.Precio);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
