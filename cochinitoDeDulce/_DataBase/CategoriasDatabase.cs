﻿using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias para conectarse a SQL
using System.Data.SqlClient;
using System.Data;
namespace cochinitoDeDulce._DataBase
{
    public class CategoriasDatabase : Conexion, ICategoriasDataBase
    {
        // contructor
        public CategoriasDatabase(string cadenaConexion)
        {
            // obtengo la cadena de conexion
            this.cadenaConexion = cadenaConexion;
        }

        public void AgregarCategoria(CategoriasModel categoriasModel)
        {
            // crear la conexion
            using (var conexion = new SqlConnection(cadenaConexion))

            // creo un objeto comando para poder ejecutar los comandos
            using( var command = new SqlCommand("spAgregaraCategoria"))
            {
                // abrir la conexion
                conexion.Open();
                // establecemos la conexion al objeto comando
                command.Connection = conexion;
                // determino el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                // pasar parametros
                command.Parameters.Add("@nombreCategoria", SqlDbType.NVarChar).Value = categoriasModel.NombreCategoria;
                // ejecutar comando
                command.ExecuteNonQuery();
                // como uso using la conexion se cierra automaticamente
            }


        }

        public void EditarCategoria(CategoriasModel categoriasModel)
        {
            throw new NotImplementedException();
        }

        public void EliminarCategoria(CategoriasModel categoriasModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriasModel> VerTodasCategoras()
        {
            throw new NotImplementedException();
        }
    }
}
