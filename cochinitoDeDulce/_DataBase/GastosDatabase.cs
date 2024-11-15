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
    internal class GastosDatabase : Conexion, IGastosDatabase
    {
        // constructor
        public GastosDatabase(string cadenaConexion)
        {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }
        public void AgregarGasto(GastosModel gastoModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta para ingresar "detalles"
                string consulta = "insert into detalles (nombre,precio,cantidad, unidad,descuento,fecha,comentario) values (@detalleNombre,@detallePrecio, @detalleCantidad, @detalleUnidad, @detalleDescuento, @detalleFecha, @detalleComentario)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@detalleNombre", gastoModel.Nombre));
                comando.Parameters.Add(new SQLiteParameter("@detallePrecio", gastoModel.Precio));
                comando.Parameters.Add(new SQLiteParameter("@detalleCantidad", gastoModel.Cantidad));
                comando.Parameters.Add(new SQLiteParameter("@detalleUnidad", gastoModel.Unidad));
                comando.Parameters.Add(new SQLiteParameter("@detalleDescuento", gastoModel.Descuento));
                comando.Parameters.Add(new SQLiteParameter("@detalleFecha", gastoModel.Fecha));
                comando.Parameters.Add(new SQLiteParameter("@detalleComentario", gastoModel.Comentario));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

                // creo una consulta para ingresar el "gasto"
                consulta = "insert into gastos (idCategoria,idLugar,idMarca,idImagenGasto,idDetalle,idTipo) values ((select idCategorias from categorias where nombreCategoria=@categoriaNombre),(select idLugar from lugares where nombreLugar=@lugarNombre),(select idMarca from marcas where nombreMarca=@marcaNombre),1,(select idDetalle from detalles order by idDetalle desc LIMIT 1),(select idTipo from tipos where nombreTipo=@tipoNombre))";
                comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@categoriaNombre", gastoModel.Categoria));
                comando.Parameters.Add(new SQLiteParameter("@lugarNombre", gastoModel.Lugar));
                comando.Parameters.Add(new SQLiteParameter("@marcaNombre", gastoModel.Marca));
                comando.Parameters.Add(new SQLiteParameter("@tipoNombre", gastoModel.Tipo));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
            /*
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
            */
        }
        public IEnumerable<GastosModel> BuscarGastos(string gastoNombre)//sqlite
        {
            // creo una lista de categoriaModels
            List<GastosModel> lGastos = new List<GastosModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select gastos.idGasto,detalles.nombre,detalles.precio, detalles.descuento,detalles.cantidad, detalles.unidad,detalles.fecha, detalles.comentario,categorias.nombreCategoria,lugares.nombreLugar,marcas.nombreMarca,tipos.nombreTipo from (((((gastos join detalles on gastos.idDetalle=detalles.idDetalle)join categorias on gastos.idCategoria=categorias.idCategorias)join lugares on gastos.idLugar=lugares.idLugar)join marcas on gastos.idMarca=marcas.idMarca)join tipos on gastos.idTipo=tipos.idTipo)where detalles.nombre like '%' || @nombreBuscar || '%'";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreBuscar", gastoNombre));

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
                        var vGasto = new GastosModel();
                        // leemos los datos que regresa la consulta
                        vGasto.IdGasto = Convert.ToInt32(lector[0]);
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
            }
            // retorno la lista
            return lGastos;
            /*
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
            }*/

        }
        public void EditarGasto(int idGastoActual, GastosModel gastoEditado)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta para ingresar "detalles"
                string consulta = "update detalles set nombre=@detalleNombre,precio=@detallePrecio,cantidad=@detalleCantidad,unidad=@detalleUnidad,descuento=@detalleDescuento,fecha=@detalleFecha,comentario=@detalleComentario where idDetalle=(select idDetalle from gastos where idGasto=@idGasto)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@detalleNombre", gastoEditado.Nombre));
                comando.Parameters.Add(new SQLiteParameter("@detallePrecio", gastoEditado.Precio));
                comando.Parameters.Add(new SQLiteParameter("@detalleCantidad", gastoEditado.Cantidad));
                comando.Parameters.Add(new SQLiteParameter("@detalleUnidad", gastoEditado.Unidad));
                comando.Parameters.Add(new SQLiteParameter("@detalleDescuento", gastoEditado.Descuento));
                comando.Parameters.Add(new SQLiteParameter("@detalleFecha", gastoEditado.Fecha));
                comando.Parameters.Add(new SQLiteParameter("@detalleComentario", gastoEditado.Comentario));
                comando.Parameters.Add(new SQLiteParameter("@idGasto", gastoEditado.IdGasto));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

                // creo una consulta para ingresar el "gasto"
                consulta = "update gastos set idCategoria=(select idCategorias from categorias where nombreCategoria=@categoriaNombre),idLugar=(select idLugar from lugares where nombreLugar=@lugarNombre),idMarca=(select idMarca from marcas where nombreMarca=@marcaNombre),idImagenGasto=1,idDetalle=idDetalle,idTipo=(select idTipo from tipos where nombreTipo=@tipoNombre)where idGasto=@idGasto";
                comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@categoriaNombre", gastoEditado.Categoria));
                comando.Parameters.Add(new SQLiteParameter("@lugarNombre", gastoEditado.Lugar));
                comando.Parameters.Add(new SQLiteParameter("@marcaNombre", gastoEditado.Marca));
                comando.Parameters.Add(new SQLiteParameter("@tipoNombre", gastoEditado.Tipo));
                comando.Parameters.Add(new SQLiteParameter("@idGasto", gastoEditado.IdGasto));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
        public void EliminarGasto(int idGastoEliminar)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta UPDATE
                string consulta = "delete from gastos where idGasto=@idGastoEliminar";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@idGastoEliminar", idGastoEliminar));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
        public IEnumerable<CategoriasModel> ObtenerCategorias()//sqlite
        {
            // creo una lista de categoriaModels
            List<CategoriasModel> lCategorias = new List<CategoriasModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select nombreCategoria from categorias";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
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
                        vCategoria.NombreCategoria = lector[0].ToString();
                        // los agregamos a la lista de categorias
                        lCategorias.Add(vCategoria);
                    }

                }
            }
            return lCategorias;
        }
        public IEnumerable<LugaresModel> ObtenerLugares()//sqlite
        {
            // creo una lista de categoriaModels
            List<LugaresModel> lLugares = new List<LugaresModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select nombreLugar from lugares;";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

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
                        vLugar.NombreLugar = lector[0].ToString();
                        // los agregamos a la lista de lugares
                        lLugares.Add(vLugar);
                    }

                }
            }
            // retorno la lista
            return lLugares;
        }
        public IEnumerable<MarcasModel> ObtenerMarcas()//sqlite
        {
            // creo una lista de categoriaModels
            List<MarcasModel> lMarcas = new List<MarcasModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select nombreMarca from marcas;";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

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
                        vMarca.NombreMarca = lector[0].ToString();
                        // los agregamos a la lista de marcas
                        lMarcas.Add(vMarca);
                    }

                }
            }
            // retorno la lista
            return lMarcas;
        }
        public IEnumerable<TiposModel> ObtenerTipos()//sqlite
        {
            // creo una lista de categoriaModels
            List<TiposModel> lTipos = new List<TiposModel>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select nombreTipo from tipos";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

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
                        vTipo.NombreTipo = lector[0].ToString();
                        // los agregamos a la lista de categorias
                        lTipos.Add(vTipo);
                    }

                }
            }
            return lTipos;
        }
    }
}
