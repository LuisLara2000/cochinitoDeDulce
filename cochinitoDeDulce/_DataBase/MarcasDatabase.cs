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
    public class MarcasDatabase : Conexion, IMarcasDataBase
    {
        // constructor
        public MarcasDatabase(string cadenaConexion) {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }

        // Buscar //
        public IEnumerable<MarcasModel> BuscarMarcas(string marcasNombre)
        {
            // creo una lista de categoriaModels
            List<MarcasModel> lMarcas = new List<MarcasModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spBuscarMarcas"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreBuscar", SqlDbType.VarChar).Value = marcasNombre;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vMarca = new MarcasModel();
                        // leemos los datos que regresa la consulta
                        vMarca.IdMarca = (int)lector[0];
                        vMarca.NombreMarca = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lMarcas.Add(vMarca);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lMarcas;
        }
        // Agregar //
        public void AgregarMarca(MarcasModel marcasModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spAgregarMarca"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreMarca", SqlDbType.NVarChar).Value = marcasModel.NombreMarca;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }
        }

        // Editar //
        public void EditarMarca(string nombreActualMarca, string nombreNuevoMarca)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEditarMarca"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreActualMarca", SqlDbType.VarChar).Value = nombreActualMarca;
                command.Parameters.Add("@nombreMarcaNuevo", SqlDbType.VarChar).Value = nombreNuevoMarca;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        // Agregar y Editar
        public int ValidarNoRepetido(string nombreMarca)
        {
            int resultado = 2;
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spValidarNoRepetidoMarca"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreMarca", SqlDbType.VarChar).Value = nombreMarca;
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
        public void EliminarMarca(int IdMarcaEliminar, string nombreMarcaReemplazar)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEliminarMarca"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idMarcaEliminar", SqlDbType.Int).Value = IdMarcaEliminar;
                command.Parameters.Add("@idMarcaReemplazar", SqlDbType.VarChar).Value = nombreMarcaReemplazar;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }
        public IEnumerable<MarcasModel> BuscarMarcaExepto(int IdModel)
        {
            // creo una lista de categoriaModels
            List<MarcasModel> lMarcas = new List<MarcasModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spMostrarMarcaExepto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idMarcaExepcion", SqlDbType.Int).Value = IdModel;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vMarca = new MarcasModel();
                        // leemos los datos que regresa la consulta
                        vMarca.IdMarca = (int)lector[0];
                        vMarca.NombreMarca = lector[1].ToString();
                        // los agregamos a la lista de categorias
                        lMarcas.Add(vMarca);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lMarcas;
        }


    }
}
