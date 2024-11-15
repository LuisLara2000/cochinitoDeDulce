using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias para conectarse a SQL
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

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
        public IEnumerable<CategoriasModel> BuscarCategorias(string categoriaNombre)//sqlite
        {
            // creo una lista de categoriaModels
            List<CategoriasModel> lCategorias = new List<CategoriasModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from categorias where nombreCategoria like '%' || @nombreBuscar || '%'";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreBuscar", categoriaNombre));

                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                // creo un lector
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    // leo el contenido de la consulta 
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vCategoria = new CategoriasModel();
                        // leemos los datos que regresa la consulta
                        vCategoria.IdCategoria = Convert.ToInt32(lector[0]);
                        vCategoria.NombreCategoria = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lCategorias.Add(vCategoria);
                    }

                }
            }
            return lCategorias;
        }
        public void AgregarCategoria(CategoriasModel categoriasModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "insert into categorias(nombreCategoria) values (@nombreCategoria)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreCategoria", categoriasModel.NombreCategoria));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
              
            }
        }
        public int ValidarNoRepetido(string nombreCategoria)//sqlite
        {
            int resultado = 2;
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select COUNT(*) from categorias where nombreCategoria=@nombreCategoria";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreCategoria", nombreCategoria));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        resultado = Convert.ToInt32(lector[0]);
                    }

                }
                return resultado;
            }          
        }    
        public void EditarCategoria(string nombreActualCategoria, string nombreNuevoCategoria)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "update categorias set nombreCategoria=@nombreCategoriaNuevo where idCategorias=(select idCategorias from categorias where nombreCategoria=@nombreActualCategoria)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreCategoriaNuevo", nombreNuevoCategoria));
                comando.Parameters.Add(new SQLiteParameter("@nombreActualCategoria", nombreActualCategoria));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
        }
        public void EliminarCategoria(int IdCategoriaEliminar,string NombreCategoriaReemplazar)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta UPDATE
                string consulta = "update gastos set idCategoria=(select idCategorias from categorias where nombrecategoria = @idCategoriaReemplazar) where idCategoria=@idCategoriaEliminar";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idCategoriaReemplazar", NombreCategoriaReemplazar));
                comando.Parameters.Add(new SQLiteParameter("@idCategoriaEliminar", IdCategoriaEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

                // creo consulta DELETE
                consulta = "delete from categorias where idCategorias = @idCategoriaEliminar ";
                // actualizo los parametros
                comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idCategoriaEliminar", IdCategoriaEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
  
        }    
        public IEnumerable<CategoriasModel> BuscarCategoriaExepto(int categoriaId)//sqlite
        {
            // creo una lista de categoriaModels
            List<CategoriasModel> lCategorias = new List<CategoriasModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from categorias where idcategorias != @idCategoriaExepcion";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idCategoriaExepcion", categoriaId));

                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                // creo un lector
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    // leo el contenido de la consulta 
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vCategoria = new CategoriasModel();
                        // leemos los datos que regresa la consulta
                        vCategoria.IdCategoria = Convert.ToInt32(lector[0]);
                        vCategoria.NombreCategoria = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lCategorias.Add(vCategoria);
                    }

                }
            }
            return lCategorias;
          
        }
       

    }
}
