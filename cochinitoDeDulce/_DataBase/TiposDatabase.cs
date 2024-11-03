using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias para conectarse a SQL
using System.Data.SqlClient;
using System.Data;
using cochinitoDeDulce.Models;
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
        public IEnumerable<TiposModel> BuscarTipos(string tiposNombre)
        {
            // creo una lista de categoriaModels
            List<TiposModel> lTipos = new List<TiposModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spBuscarTipos"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreBuscar", SqlDbType.VarChar).Value = tiposNombre;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vTipo = new TiposModel();
                        // leemos los datos que regresa la consulta
                        vTipo.IdTipo = (int)lector[0];
                        vTipo.NombreTipo = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lTipos.Add(vTipo);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lTipos;
        }
        // Agregar //
        public void AgregarTipo(TiposModel tiposModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spAgregarTipo"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreTipo", SqlDbType.NVarChar).Value = tiposModel.NombreTipo;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }
        }

        // Editar //
        public void EditarTipo(string nombreActualTipo, string nombreNuevoTipo)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEditarTipo"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreActualTipo", SqlDbType.VarChar).Value = nombreActualTipo;
                command.Parameters.Add("@nombreTipoNuevo", SqlDbType.VarChar).Value = nombreNuevoTipo;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        // Agregar y Editar
        public int ValidarNoRepetido(string nombreTipo)
        {
            int resultado = 2;
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spValidarNoRepetidoTipo"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreTipo", SqlDbType.VarChar).Value = nombreTipo;
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
            }
            return resultado;
        }

        // Eliminar //
        public void EliminarTipo(int IdTipoEliminar, string nombreTipoReemplazar)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEliminarTipo"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idTipoEliminar", SqlDbType.Int).Value = IdTipoEliminar;
                command.Parameters.Add("@idTipoReemplazar", SqlDbType.VarChar).Value = nombreTipoReemplazar;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }
        public IEnumerable<TiposModel> BuscarTipoExepto(int IdTipo)
        {
            // creo una lista de categoriaModels
            List<TiposModel> lTipos = new List<TiposModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spMostrarTipoExepto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idTipoExepcion", SqlDbType.Int).Value = IdTipo;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vTipo = new TiposModel();
                        // leemos los datos que regresa la consulta
                        vTipo.IdTipo = (int)lector[0];
                        vTipo.NombreTipo = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lTipos.Add(vTipo);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lTipos;
        }


    }
}
