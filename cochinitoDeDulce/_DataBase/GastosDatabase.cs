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
    internal class GastosDatabase : Conexion, IGastosDatabase
    {
        // constructor
        public GastosDatabase(string cadenaConexion)
        {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }

        public void AgregarGasto(GastosModel gastoModel)
        {
            
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spAgregarGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@detalleNombre", SqlDbType.NVarChar).Value = gastoModel.Nombre;
                command.Parameters.Add("@detallePrecio", SqlDbType.Float).Value = gastoModel.Precio;
                command.Parameters.Add("@detalleCantidad", SqlDbType.Float).Value = gastoModel.Cantidad;
                command.Parameters.Add("@detalleUnidad", SqlDbType.NVarChar).Value = gastoModel.Unidad;
                command.Parameters.Add("@detalleDescuento", SqlDbType.Float).Value = gastoModel.Descuento;
                command.Parameters.Add("@detalleFecha", SqlDbType.Date).Value = gastoModel.Fecha;
                command.Parameters.Add("@detalleComentario", SqlDbType.NVarChar).Value = gastoModel.Comentario;
                command.Parameters.Add("@categoriaNombre", SqlDbType.NVarChar).Value = gastoModel.Categoria;
                command.Parameters.Add("@lugarNombre", SqlDbType.NVarChar).Value = gastoModel.Lugar;
                command.Parameters.Add("@marcaNombre", SqlDbType.NVarChar).Value = gastoModel.Marca;
                command.Parameters.Add("@imagenId", SqlDbType.Int).Value = 1;// valor fijo en 1 temporalmente, modificar el sp
                command.Parameters.Add("@tipoNombre", SqlDbType.NVarChar).Value = gastoModel.Tipo;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }
           
        }

        public IEnumerable<GastosModel> BuscarGastos(string gastoNombre)
        {
            // creo una lista de categoriaModels
            List<GastosModel> lGastos = new List<GastosModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spBuscarGastos"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreGasto", SqlDbType.VarChar).Value = gastoNombre;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vGasto = new GastosModel();
                        // leemos los datos que regresa la consulta
                        vGasto.IdGasto = (int)lector[0];
                        vGasto.Nombre = (string)lector[1];
                        vGasto.Precio = float.Parse(lector[2].ToString());
                        vGasto.Descuento = float.Parse(lector[3].ToString());
                        vGasto.Cantidad = float.Parse(lector[4].ToString());
                        vGasto.Unidad = (string)lector[5];
                        vGasto.Fecha = lector[6].ToString();
                        vGasto.Comentario = (string)lector[7];
                        vGasto.Categoria = (string)lector[8];
                        vGasto.Lugar = (string)lector[9];
                        vGasto.Marca = (string)lector[10];
                        vGasto.Tipo = (string)lector[11];
                        // los agregamos a la lista de categorias
                        lGastos.Add(vGasto);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lGastos;
        }

        public void EditarGasto(int idGastoActual, GastosModel gastoEditado)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEditarGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idGasto", SqlDbType.Int).Value = gastoEditado.IdGasto;
                command.Parameters.Add("@detalleNombre", SqlDbType.VarChar).Value = gastoEditado.Nombre;
                command.Parameters.Add("@detallePrecio", SqlDbType.Float).Value = gastoEditado.Precio;
                command.Parameters.Add("@detalleCantidad", SqlDbType.Float).Value = gastoEditado.Cantidad;
                command.Parameters.Add("@detalleUnidad", SqlDbType.VarChar).Value = gastoEditado.Unidad;
                command.Parameters.Add("@detalleDescuento", SqlDbType.Float).Value = gastoEditado.Descuento;
                command.Parameters.Add("@detalleFecha", SqlDbType.Date).Value = gastoEditado.Fecha;
                command.Parameters.Add("@detalleComentario", SqlDbType.VarChar).Value = gastoEditado.Comentario;
                command.Parameters.Add("@categoriaNombre", SqlDbType.VarChar).Value = gastoEditado.Categoria;
                command.Parameters.Add("@lugarNombre", SqlDbType.VarChar).Value = gastoEditado.Lugar;
                command.Parameters.Add("@marcaNombre", SqlDbType.VarChar).Value = gastoEditado.Marca;
                command.Parameters.Add("@imagenId", SqlDbType.VarChar).Value = 1;
                command.Parameters.Add("@tipoNombre", SqlDbType.VarChar).Value = gastoEditado.Tipo;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        public void EliminarGasto(int idGastoEliminar)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEliminarGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@idGastoEliminar", SqlDbType.Int).Value = idGastoEliminar;

                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        public IEnumerable<CategoriasModel> ObtenerCategorias()
        {
            // creo una lista de categoriaModels
            List<CategoriasModel> lCategorias = new List<CategoriasModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spCategoriasGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vCategoria = new CategoriasModel();
                        // solo quiero el nombre
                        vCategoria.NombreCategoria = lector[0].ToString();

                        // los agregamos a la lista de categorias
                        lCategorias.Add(vCategoria);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lCategorias;
        }

        public IEnumerable<LugaresModel> ObtenerLugares()
        {
            // creo una lista de categoriaModels
            List<LugaresModel> lLugares = new List<LugaresModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spLugaresGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vLugar = new LugaresModel();
                        // solo quiero el nombre
                        vLugar.NombreLugar = lector[0].ToString();

                        // los agregamos a la lista de categorias
                        lLugares.Add(vLugar);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lLugares;
        }

        public IEnumerable<MarcasModel> ObtenerMarcas()
        {
            // creo una lista de categoriaModels
            List<MarcasModel> lMarcas = new List<MarcasModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spMarcasGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vMarca= new MarcasModel();
                        // solo quiero el nombre
                        vMarca.NombreMarca = lector[0].ToString();

                        // los agregamos a la lista de categorias
                        lMarcas.Add(vMarca);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lMarcas;
        }

        public IEnumerable<TiposModel> ObtenerTipos()
        {
            // creo una lista de categoriaModels
            List<TiposModel> lTipos = new List<TiposModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spTiposGasto"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vTipo = new TiposModel();
                        // solo quiero el nombre
                        vTipo.NombreTipo = lector[0].ToString();

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
