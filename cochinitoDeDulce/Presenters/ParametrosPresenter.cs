using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// importo las vistas 
using cochinitoDeDulce.Views;
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Presenters;
using cochinitoDeDulce._DataBase;

namespace cochinitoDeDulce.Presenters
{
    public class ParametrosPresenter
    {
        private IParametrosView parametrosView;
        private IPrincipalView principalView;
        private readonly string sqlCadenaConexion;
        public ParametrosPresenter(IParametrosView viewP,IPrincipalView ventanaPadre,string cadenaConexion, bool suscrito)
        {
            principalView = ventanaPadre;
            parametrosView = viewP;
            sqlCadenaConexion = cadenaConexion;
            // suscribimos los eventos
            if (!suscrito)
            {
                SuscribirEventos();
                viewP.Suscrito = true;
            }

            // muestro en pantalla 
            viewP.Show();
        }

        void SuscribirEventos()
        {
            parametrosView.MostrarCategorias_Event += MostrarCategorias;
            parametrosView.MostrarMarcas_Event += MostrarMarcas;
            parametrosView.MostrarLugares_Event += MostrarLugares;
            parametrosView.MostrarTipos_Event += MostrarTipos;
        }

        private void MostrarTipos(object? sender, EventArgs e)
        {
            ITiposView vista = TiposView.ObtenerLaVentanaTipos((PrincipalView)principalView);
            ITiposDatabase database = new TiposDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new TiposPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new TiposPresenter(vista, database, true);
        }

        private void MostrarLugares(object? sender, EventArgs e)
        {
            ILugaresView vista = LugaresView.ObtenerLaVentanaLugares((PrincipalView)principalView);
            ILugaresDatabase database = new LugaresDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new LugaresPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new LugaresPresenter(vista, database, true);
        }

        private void MostrarMarcas(object? sender, EventArgs e)
        {
            IMarcasView vista = MarcasView.ObtenerLaVentanaMarcas((PrincipalView)principalView);
            IMarcasDataBase database = new MarcasDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new MarcaPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new MarcaPresenter(vista, database, true);
        }

        private void MostrarCategorias(object? sender, EventArgs e)
        {

            ICategoriasView vista = CategoriasView.ObtenerInstancia((PrincipalView)principalView);
            ICategoriasDataBase database = new CategoriasDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)
                new CategoriaPresenter(vista, database, false);
            else
                new CategoriaPresenter(vista, database, true);
        }
    }
}
