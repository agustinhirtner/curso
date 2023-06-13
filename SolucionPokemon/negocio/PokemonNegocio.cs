using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero , Nombre , P.Descripcion,UrlImagen , E.Descripcion Tipo, D.Descripcion Debilidad,P.IdTipo,P.IdDebilidad,P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.id = P.idTipo and D.id = P.idDebilidad";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    if (!(lector["UrlImagen"] is DBNull))
                    aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public List <Pokemon> filtrar (string campo , string criterio , string filtro)
        {

        }

        public void agregar (Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into POKEMONS (Numero,Nombre,Descripcion,Activo,IdTipo,IdDebilidad,UrlImagen) values (" + nuevo.Numero + " , '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "' , 1 , @IdTipo , @IdDebilidad,@UrlImagen)");
                datos.setearParametro("@IdTipo", nuevo.Tipo.id);
                datos.setearParametro("@IdDebilidad", nuevo.Debilidad.id);
                datos.setearParametro("@UrlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
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
        public void modificar(Pokemon modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero , Nombre = @nombre , Descripcion = @des , UrlImagen = @img , IdTipo = @idtipo , IdDebilidad = @iddebilidad where id = @id");
                datos.setearParametro("@numero", modificar.Numero);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@des", modificar.Descripcion);
                datos.setearParametro("@img", modificar.UrlImagen);
                datos.setearParametro("idtipo", modificar.Tipo.id);
                datos.setearParametro("@iddebilidad", modificar.Debilidad.id);
                datos.setearParametro("@id", modificar.Id);
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
        public void eliminar (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from POKEMONS where id=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
    }
}
