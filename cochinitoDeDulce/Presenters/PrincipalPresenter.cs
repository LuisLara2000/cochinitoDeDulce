using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agregamos las referenias de los modelos, vistas y base de datos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;
using cochinitoDeDulce.Presenters;
using cochinitoDeDulce._DataBase;

namespace cochinitoDeDulce.Presenters
{
  
    public class PrincipalPresenter
    {
        private IPrincipalView principalView;// interfaz de la vista principal
        // para la conexion
        private readonly string sqlCadenaConexion;

        public PrincipalPresenter(IPrincipalView principalView, string sqlCadenaConexion)
        {
            this.principalView = principalView;
            this.sqlCadenaConexion = sqlCadenaConexion;
            this.principalView.MostrarCategorias_Evento += MostrarCategorias;
            this.principalView.MostrarMarcas_Evento += MostrarMarcas;
            this.principalView.MostrarLugares_Evento += MostrarLugares;
            this.principalView.MostrarTipos_Evento += MostrarTipos;
        }


        private void MostrarCategorias(object sender, EventArgs e)
        {
            ICategoriasView vista = CategoriasView.ObtenerInstancia((PrincipalView)principalView);
            ICategoriasDataBase database = new CategoriasDatabase(sqlCadenaConexion);
            new CategoriaPresenter(vista,database);
        }

        private void MostrarMarcas(object? sender, EventArgs e)
        {
            IMarcasView vista = MarcasView.ObtenerLaVentanaMarcas((PrincipalView)principalView);
            // falta la conexion a la base de datos, va en esta linea xd
            new 
        }

        private void MostrarLugares(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void MostrarTipos(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



    }
}
