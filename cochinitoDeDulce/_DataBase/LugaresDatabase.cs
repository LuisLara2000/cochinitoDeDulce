using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IEnumerable<LugaresModel> BuscarLugares(string lugaresNombre)
        {
            // creo una lista de categoriaModels
            List<LugaresModel> lLugares = new List<LugaresModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spBuscarLugares"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreBuscar", SqlDbType.VarChar).Value = lugaresNombre;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vLugar = new LugaresModel();
                        // leemos los datos que regresa la consulta
                        vLugar.IdLugar = (int)lector[0];
                        vLugar.NombreLugar = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lLugares.Add(vLugar);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lLugares;
        }
        // Agregar //
        public void AgregarLugar(LugaresModel lugaresModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spAgregarLugar"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreLugar", SqlDbType.NVarChar).Value = lugaresModel.NombreLugar;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }
        }

        // Editar //
        public void EditarLugar(string nombreActualLugar, string nombreNuevoLugar)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEditarLugar"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreActualLugar", SqlDbType.VarChar).Value = nombreActualLugar;
                command.Parameters.Add("@nombreLugarNuevo", SqlDbType.VarChar).Value = nombreNuevoLugar;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        // Agregar y Editar
        public int ValidarNoRepetido(string nombreLugar)
        {
            int resultado = 2;
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
            }
            return resultado;
        }

        // Eliminar //
        public void EliminarLugar(int IdLugarEliminar, string nombreLugarReemplazar)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEliminarLugar"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idLugarEliminar", SqlDbType.Int).Value = IdLugarEliminar;
                command.Parameters.Add("@idLugarReemplazar", SqlDbType.VarChar).Value = nombreLugarReemplazar;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }
        public IEnumerable<LugaresModel> BuscarLugarExepto(int IdModel)
        {
            // creo una lista de categoriaModels
            List<LugaresModel> lLugares = new List<LugaresModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spMostrarLugarExepto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idLugarExepcion", SqlDbType.Int).Value = IdModel;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vLugar = new LugaresModel();
                        // leemos los datos que regresa la consulta
                        vLugar.IdLugar = (int)lector[0];
                        vLugar.NombreLugar = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lLugares.Add(vLugar);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lLugares;
        }

    }
}
