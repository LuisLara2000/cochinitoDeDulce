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
            this.principalView.MostrarCategorias += MostrarCategorias;
        }

        private void MostrarCategorias(object sender, EventArgs e)
        {
            ICategoriasView vista = CategoriasView.ObtenerInstancia((PrincipalView)principalView);
            ICategoriasDataBase database = new CategoriasDatabase(sqlCadenaConexion);
            new CategoriaPresenter(vista,database);
        }

    }
}
