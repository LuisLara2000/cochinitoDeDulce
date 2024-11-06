using System;
using System.Collections.Generic;
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

    }
}
