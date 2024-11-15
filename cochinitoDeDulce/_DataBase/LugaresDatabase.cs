using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace cochinitoDeDulce._DataBase
{
    public class LugaresDatabase: Conexion,ILugaresDatabase
    {
        // constructor
        public LugaresDatabase(string cadenaConexion)
        {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }

        // Buscar //
        public IEnumerable<LugaresModel> BuscarLugares(string lugaresNombre)//sqlite
        {
            // creo una lista de categoriaModels
            List<LugaresModel> lLugares = new List<LugaresModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from Lugares where nombreLugar like '%' || @nombreBuscar || '%'";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreBuscar", lugaresNombre));

                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                // creo un lector
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    // leo el contenido de la consulta 
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo lugar
                        var vLugar = new LugaresModel();
                        // leemos los datos que regresa la consulta
                        vLugar.IdLugar = Convert.ToInt32(lector[0]);
                        vLugar.NombreLugar = lector[1].ToString();
                        // los agregamos a la lista de lugares
                        lLugares.Add(vLugar);
                    }

                }
            }
            // retorno la lista
            return lLugares;
        }
        // Agregar //
        public void AgregarLugar(LugaresModel lugaresModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "insert into Lugares (nombreLugar) values (@nombreLugar)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreLugar", lugaresModel.NombreLugar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
      
        }
        public int ValidarNoRepetido(string nombreLugar)//sqlite
        {
            int resultado = 2;
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select COUNT(*) from Lugares where nombreLugar=@nombreLugar";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreLugar", nombreLugar));
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
            /*
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spValidarNoRepetidoLugar"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreLugar", SqlDbType.VarChar).Value = nombreLugar;
                // ejecutar comando
                command.ExecuteNonQuery();
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        resultado = (int)lector[0];
                    }

                }
                // como uso using la conexion se cierra automaticamente
            }*/

        }
        // Editar //
        public void EditarLugar(string nombreActualLugar, string nombreNuevoLugar)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "update Lugares set nombreLugar=@nombreLugarNuevo where idLugar=(select idLugar from Lugares where nombreLugar=@nombreActualLugar)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreLugarNuevo", nombreNuevoLugar));
                comando.Parameters.Add(new SQLiteParameter("@nombreActualLugar", nombreActualLugar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
          
        }
        // Eliminar //
        public void EliminarLugar(int IdLugarEliminar, string nombreLugarReemplazar)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta UPDATE
                string consulta = "update gastos set idLugar=(select idLugar from Lugares where nombreLugar = @idLugarReemplazar) where idLugar=@idLugarEliminar";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idLugarReemplazar", nombreLugarReemplazar));
                comando.Parameters.Add(new SQLiteParameter("@idLugarEliminar", IdLugarEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

                // creo consulta DELETE
                consulta = "delete from Lugares where idLugar = @idLugarEliminar";
                // actualizo los parametros
                comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idLugarEliminar", IdLugarEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
    
        }
        public IEnumerable<LugaresModel> BuscarLugarExepto(int IdModel)//sqlite
        {
            // creo una lista de categoriaModels
            List<LugaresModel> lLugares = new List<LugaresModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from Lugares where idLugar != @idLugarExepcion";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idLugarExepcion", IdModel));

                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
                // creo un lector
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    // leo el contenido de la consulta 
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo lugar
                        var vLugar = new LugaresModel();
                        // leemos los datos que regresa la consulta
                        vLugar.IdLugar = Convert.ToInt32(lector[0]);
                        vLugar.NombreLugar = lector[1].ToString();
                        // los agregamos a la lista de lugares
                        lLugares.Add(vLugar);
                    }

                }
            }
            // retorno la lista
            return lLugares;
        }

    }
}
