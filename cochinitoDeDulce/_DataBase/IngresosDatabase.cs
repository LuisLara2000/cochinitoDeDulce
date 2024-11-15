using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cochinitoDeDulce.Models;
using System.Data.SQLite;

namespace cochinitoDeDulce._DataBase
{
    public class IngresosDatabase:Conexion, IIngresosDatabase
    {
        public IngresosDatabase(string cadenaConexion) 
        {
            this.cadenaConexion = cadenaConexion;
        }
        public IEnumerable<IngresosModel> BuscarIngreso(string origen)//sqlite
        {
            // creo una lista de categoriaModels
            List<IngresosModel> lIngresos = new List<IngresosModel>();
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "select * from ingresos where origen like '%' || @nombreBuscar || '%'";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@nombreBuscar", origen));

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
                        var vIngreso = new IngresosModel();
                        // leemos los datos que regresa la consulta
                        vIngreso.IdIngreso = Convert.ToInt32(lector[0]);
                        vIngreso.Monto = float.Parse(lector[1].ToString());
                        vIngreso.Origen = lector[2].ToString();
                        // los agregamos a la lista de categorias
                        lIngresos.Add(vIngreso);
                    }

                }
            }
            return lIngresos;
        }
        public void AgregarIngreso(IngresosModel ingresoModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "insert into ingresos (monto,origen) values (@monto,@origen)";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@monto", ingresoModel.Monto));
                comando.Parameters.Add(new SQLiteParameter("@origen", ingresoModel.Origen));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();

            }
        }
        public void EditarIngreso(IngresosModel ingresoModel)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta
                string consulta = "update ingresos set monto=@monto, origen=@origen where idIngreso=@id";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@id", ingresoModel.IdIngreso));
                comando.Parameters.Add(new SQLiteParameter("@monto", ingresoModel.Monto));
                comando.Parameters.Add(new SQLiteParameter("@origen", ingresoModel.Origen));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
        public void EliminarIngeso(int idIngreso)//sqlite
        {
            // crear la conexion
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                // abro la conexion
                conexion.Open();
                // creo la consulta UPDATE
                string consulta = "delete from ingresos where idIngreso=@id";
                // creo el objeto que ejecuta la consulta
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                // le paso los parametros
                comando.Parameters.Add(new SQLiteParameter("@id", idIngreso));
                // especifico el tipo de comando
                comando.CommandType = CommandType.Text;
                // ejecuto la consulta
                comando.ExecuteNonQuery();
            }
        }
    }
}
