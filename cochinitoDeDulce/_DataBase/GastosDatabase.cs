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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void EliminarGasto(int idGastoEliminar)
        {
            throw new NotImplementedException();
        }
    }
}
