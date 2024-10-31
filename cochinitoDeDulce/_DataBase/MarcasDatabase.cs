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
        public void AgregarMarca(MarcasModel marcasModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriasModel> BuscarMarcaExepto(MarcasModel marcasModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriasModel> BuscarMarcas(MarcasModel marcasModel)
        {
            throw new NotImplementedException();
        }

        public void EditarMarca(MarcasModel marcasModel, string nombreNuevoCategoria)
        {
            throw new NotImplementedException();
        }

        public void EliminarMarca(MarcasModel marcasModel, string NombreCategoriaReemplazar)
        {
            throw new NotImplementedException();
        }

        public int ValidarNoRepetido(MarcasModel marcasModel)
        {
            throw new NotImplementedException();
        }
    }
}
