using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias para conectarse a SQL
using System.Data.SqlClient;
using System.Data;
namespace cochinitoDeDulce._DataBase
{
    public class CategoriasDatabase : Conexion, ICategoriasDataBase
    {
        // contructor
        public CategoriasDatabase(string cadenaConexion)
        {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }
        public int ValidarNoRepetido(string nombreCategoria)
        {
            int resultado = 2;
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spValidarNoRepetidoCategoria"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreCategoria", SqlDbType.VarChar).Value = nombreCategoria;
                 // ejecutar comando
                command.ExecuteNonQuery();
                using (var lector = command.ExecuteReader())
                {
                    while(lector.Read())
                    {
                        resultado = (int)lector[0];
                    }
                    
                }
                // como uso using la conexion se cierra automaticamente
            }
            return resultado;
        }
        public void AgregarCategoria(CategoriasModel categoriasModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using( var command = new SqlCommand("spAgregaraCategoria"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreCategoria", SqlDbType.NVarChar).Value = categoriasModel.NombreCategoria;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }


        }

        public void EditarCategoria(string nombreActualCategoria, string nombreNuevoCategoria)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEditarCategoria"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreActualCategoria", SqlDbType.VarChar).Value = nombreActualCategoria;
                command.Parameters.Add("@nombreCategoriaNuevo", SqlDbType.VarChar).Value = nombreNuevoCategoria;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        public void EliminarCategoria(int IdCategoriaEliminar,string NombreCategoriaReemplazar)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEliminarCategoria"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idCategoriaEliminar", SqlDbType.Int).Value = IdCategoriaEliminar;
                command.Parameters.Add("@idCategoriaReemplazar", SqlDbType.VarChar).Value = NombreCategoriaReemplazar;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        public IEnumerable<CategoriasModel> BuscarCategorias(string categoriaNombre)
        {
            // creo una lista de categoriaModels
            List<CategoriasModel> lCategorias = new List<CategoriasModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spBuscarCategorias"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreBuscar", SqlDbType.VarChar).Value = categoriaNombre.ToString();
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vCategoria = new CategoriasModel();
                        // leemos los datos que regresa la consulta
                        vCategoria.IdCategoria = (int)lector[0];
                        vCategoria.NombreCategoria = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lCategorias.Add(vCategoria);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lCategorias;

        }

        public IEnumerable<CategoriasModel> VerTodasCategoras()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriasModel> BuscarCategoriaExepto(int categoriaId)
        {
            // creo una lista de categoriaModels
            List<CategoriasModel> lCategorias = new List<CategoriasModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spMostrarCategoriaExepto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idCategoriaExepcion", SqlDbType.Int).Value = categoriaId;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vCategoria = new CategoriasModel();
                        // leemos los datos que regresa la consulta
                        vCategoria.IdCategoria = (int)lector[0];
                        vCategoria.NombreCategoria = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lCategorias.Add(vCategoria);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lCategorias;
        }


    }
}
