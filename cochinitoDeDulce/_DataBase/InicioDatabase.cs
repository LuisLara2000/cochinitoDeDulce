using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce._DataBase
{
    public class InicioDatabase:Conexion,IInicioDatabase
    {
        public InicioDatabase(string cadenaConexion) {
            this.cadenaConexion = cadenaConexion;
        }
    }
}
