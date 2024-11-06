using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cochinitoDeDulce.Models;

namespace cochinitoDeDulce._DataBase
{
    public class IngresosDatabase:Conexion, IIngresosDatabase
    {
        public IngresosDatabase(string cadenaConexion) 
        {
            this.cadenaConexion = cadenaConexion;
        }

        public void AgregarIngreso(IngresosModel ingresoModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spAgregarIngreso"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@monto", SqlDbType.Float).Value = ingresoModel.Monto;
                command.Parameters.Add("@origen", SqlDbType.NVarChar).Value = ingresoModel.Origen;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }
        }

        public IEnumerable<IngresosModel> BuscarIngreso(string origen)
        {
            // creo una lista de categoriaModels
            List<IngresosModel> lIngresos= new List<IngresosModel>();
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spBuscarIngreso"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@origen", SqlDbType.VarChar).Value = origen;
                // ejecutar comando
                command.ExecuteNonQuery();
                // creo un lector
                using (var lector = command.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        // creamos un nuevo modelo categoria
                        var vIngreso = new IngresosModel();
                        // leemos los datos que regresa la consulta
                        vIngreso.IdIngreso = (int)lector[0];
                        vIngreso.Monto = float.Parse(lector[1].ToString());
                        vIngreso.Origen = lector[2].ToString();
                        // los agregamos a la lista de categorias
                        lIngresos.Add(vIngreso);
                    }
                }
                // como uso using la conexion se cierra automaticamente
            }
            // retorno la lista
            return lIngresos;
        }

        public void EditarIngreso(IngresosModel ingresoModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEditarIngreso"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@id", SqlDbType.Int).Value = ingresoModel.IdIngreso;
                command.Parameters.Add("@monto", SqlDbType.Float).Value = ingresoModel.Monto;
                command.Parameters.Add("@origen", SqlDbType.VarChar).Value = ingresoModel.Origen;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }

        public void EliminarIngeso(int idIngreso)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))
            // creo un objeto comando para poder ejecutar los comandos
            using (var command = new SqlCommand("spEliminarIngreso"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@id", SqlDbType.Int).Value = idIngreso;
                // ejecutar comando
                command.ExecuteNonQuery();

                // como uso using la conexion se cierra automaticamente
            }
        }
    }
}
