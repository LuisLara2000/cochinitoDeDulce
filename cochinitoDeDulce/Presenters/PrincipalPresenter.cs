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
            this.principalView.MostrarGastos_Evento += MostrarGastos;
            this.principalView.MostrarIngresos_Evento += MostrarIngresos;
            this.principalView.MostrarInicio_Evento += MostrarInicio;
        }

        private void MostrarInicio(object? sender, EventArgs e)
        {
            IInicioView vista = InicioView.ObtenerLaVentanaInicio((PrincipalView)principalView);
            IInicioDatabase database = new InicioDatabase(sqlCadenaConexion);
            new inicioPresenter(vista, database);
        }

        private void MostrarIngresos(object? sender, EventArgs e)
        {
            IIngresosView vista = IngresosView.ObtenerLaVentanaIngresos((PrincipalView)principalView);
            IIngresosDatabase database = new IngresosDatabase(sqlCadenaConexion);
            new IngresosPresenter(vista, database);
        }

        private void MostrarGastos(object? sender, EventArgs e)
        {
            IGastosView vista = GastosView.ObtenerLaVentanaGastos((PrincipalView)principalView);
            IGastosDatabase database = new GastosDatabase(sqlCadenaConexion);
            new GastosPresenter(vista, database);

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
            IMarcasDataBase database = new MarcasDatabase(sqlCadenaConexion);
            new MarcaPresenter(vista, database);
        }

        private void MostrarLugares(object? sender, EventArgs e)
        {
            ILugaresView vista = LugaresView.ObtenerLaVentanaLugares((PrincipalView)principalView);
            ILugaresDatabase database = new LugaresDatabase(sqlCadenaConexion);
            new LugaresPresenter(vista, database);
        }
        private void MostrarTipos(object? sender, EventArgs e)
        {
            ITiposView vista = TiposView.ObtenerLaVentanaTipos((PrincipalView)principalView);
            ITiposDatabase database = new TiposDatabase(sqlCadenaConexion);
            new TiposPresenter(vista, database);
        }



    }
}
