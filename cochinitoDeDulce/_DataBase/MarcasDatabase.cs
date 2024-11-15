using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias para conectarse a SQL
using System.Data.SqlClient;
using System.Data;
using cochinitoDeDulce.Models;
using System.Data.SQLite;

namespace cochinitoDeDulce._DataBase
{
    public class MarcasDatabase : Conexion, IMarcasDataBase
    {
        // constructor
        public MarcasDatabase(string cadenaConexion) {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }

        // Buscar //
        public IEnumerable<MarcasModel> BuscarMarcas(string marcasNombre)//sqlite
        {
            // creo una lista de categoriaModels
            List<MarcasModel> lMarcas = new List<MarcasModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from marcas where nombreMarca like '%' || @nombreBuscar || '%'";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreBuscar", marcasNombre));

                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                // creo un lector
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    // leo el contenido de la consulta 
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo marcas
                        var vMarca = new MarcasModel();
                        // leemos los datos que regresa la consulta
                        vMarca.IdMarca = Convert.ToInt32(lector[0]);
                        vMarca.NombreMarca = lector[1].ToString();
                        // los agregamos a la lista de marcas
                        lMarcas.Add(vMarca);
                    }

                }
            }
            // retorno la lista
            return lMarcas;         
        }
        // Agregar //
        public void AgregarMarca(MarcasModel marcasModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "insert into marcas (nombreMarca) values (@nombreMarca)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreMarca", marcasModel.NombreMarca));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }       
        }
        public int ValidarNoRepetido(string nombreMarca)//sqlite
        {
            int resultado = 2;
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select COUNT(*) from marcas where nombreMarca=@nombreMarca";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreMarca", nombreMarca));
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
        // Editar //
        public void EditarMarca(string nombreActualMarca, string nombreNuevoMarca)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "update marcas set nombreMarca=@nombreMarcaNuevo where idMarca=(select idMarca from marcas where nombreMarca=@nombreActualMarca)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreMarcaNuevo", nombreNuevoMarca));
                comando.Parameters.Add(new SQLiteParameter("@nombreActualMarca", nombreActualMarca));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
        }
          
        // Eliminar //
        public void EliminarMarca(int IdMarcaEliminar, string nombreMarcaReemplazar)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta UPDATE
                string consulta = "update gastos set idMarca=(select idMarca from marcas where nombreMarca = @idMarcaReemplazar) where idMarca=@idMarcaEliminar";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idMarcaReemplazar", nombreMarcaReemplazar));
                comando.Parameters.Add(new SQLiteParameter("@idMarcaEliminar", IdMarcaEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

                // creo consulta DELETE
                consulta = "delete from marcas where idMarca = @idMarcaEliminar";
                // actualizo los parametros
                comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idMarcaEliminar", IdMarcaEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
        public IEnumerable<MarcasModel> BuscarMarcaExepto(int IdModel)//sqlite
        {
            // creo una lista de categoriaModels
            List<MarcasModel> lMarcas = new List<MarcasModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from marcas where idMarca != @idMarcaExepcion";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idMarcaExepcion", IdModel));

                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                // creo un lector
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    // leo el contenido de la consulta 
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo marcas
                        var vMarca = new MarcasModel();
                        // leemos los datos que regresa la consulta
                        vMarca.IdMarca = Convert.ToInt32(lector[0]);
                        vMarca.NombreMarca = lector[1].ToString();
                        // los agregamos a la lista de marcas
                        lMarcas.Add(vMarca);
                    }

                }
            }
            // retorno la lista
            return lMarcas;
        }


    }
}
