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
    public class TiposDatabase: Conexion, ITiposDatabase
    {
        // constructor
        public TiposDatabase(string cadenaConexion)
        {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }

        // Buscar //
        public IEnumerable<TiposModel> BuscarTipos(string tiposNombre)//sqlite
        {
            // creo una lista de categoriaModels
            List<TiposModel> lTipos = new List<TiposModel>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from Tipos where nombreTipo like '%' || @nombreBuscar || '%'";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreBuscar", tiposNombre));

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
                        var vTipo = new TiposModel();
                        // leemos los datos que regresa la consulta
                        vTipo.IdTipo = Convert.ToInt32(lector[0]);
                        vTipo.NombreTipo = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lTipos.Add(vTipo);
                    }

                }
            }
            return lTipos;
        }
        // Agregar //
        public void AgregarTipo(TiposModel tiposModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "insert into Tipos (nombreTipo) values (@nombreTipo)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreTipo", tiposModel.NombreTipo));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
        }
        public int ValidarNoRepetido(string nombreTipo)//sqlite
        {
            int resultado = 2;
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select COUNT(*) from Tipos where nombreTipo=@nombreTipo";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreTipo", nombreTipo));
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
        public void EditarTipo(string nombreActualTipo, string nombreNuevoTipo)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "update Tipos set nombreTipo=@nombreTipoNuevo where idTipo=(select idTipo from Tipos where nombreTipo=@nombreActualTipo)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreTipoNuevo", nombreNuevoTipo));
                comando.Parameters.Add(new SQLiteParameter("@nombreActualTipo", nombreActualTipo));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
        // Eliminar //
        public void EliminarTipo(int IdTipoEliminar, string nombreTipoReemplazar)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta UPDATE
                string consulta = "update gastos set idTipo=(select idTipo from Tipos where nombreTipo = @idTipoReemplazar) where idTipo=@idTipoEliminar";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idTipoReemplazar", nombreTipoReemplazar));
                comando.Parameters.Add(new SQLiteParameter("@idTipoEliminar", IdTipoEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

                // creo consulta DELETE
                consulta = "delete from Tipos where idTipo = @idTipoEliminar";
                // actualizo los parametros
                comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idTipoEliminar", IdTipoEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
        public IEnumerable<TiposModel> BuscarTipoExepto(int IdTipo)//sqlite
        {
            // creo una lista de categoriaModels
            List<TiposModel> lTipos = new List<TiposModel>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from Tipos where idTipo != @idTipoExepcion";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idTipoExepcion", IdTipo));

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
                        var vTipo = new TiposModel();
                        // leemos los datos que regresa la consulta
                        vTipo.IdTipo = Convert.ToInt32(lector[0]);
                        vTipo.NombreTipo = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lTipos.Add(vTipo);
                    }

                }
            }
            return lTipos;
        }


    }
}
