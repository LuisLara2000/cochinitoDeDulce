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
            this.principalView.CerrarAplicacion_Evento += CerrarAplicacion;
        }

        private void CerrarAplicacion(object? sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Quieres salir de la aplicacion?","Cerrar",MessageBoxButtons.OKCancel);
            if (respuesta == DialogResult.OK)
            {
                principalView.QuieresSalirDeLaAplicacion = true;
            }
            else
            {
                principalView.QuieresSalirDeLaAplicacion = false;
            }
            
        }

        private void MostrarInicio(object? sender, EventArgs e)
        {
            IInicioView vista = InicioView.ObtenerLaVentanaInicio((PrincipalView)principalView);
            IInicioDatabase database = new InicioDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new InicioPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new InicioPresenter(vista, database, true);
        }

        private void MostrarIngresos(object? sender, EventArgs e)
        {
            IIngresosView vista = IngresosView.ObtenerLaVentanaIngresos((PrincipalView)principalView);
            IIngresosDatabase database = new IngresosDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new IngresosPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new IngresosPresenter(vista, database, true);
        }

        private void MostrarGastos(object? sender, EventArgs e)
        {
            IGastosView vista = GastosView.ObtenerLaVentanaGastos((PrincipalView)principalView);
            IGastosDatabase database = new GastosDatabase(sqlCadenaConexion);
            if(!vista.Suscrito)// me suscribo a los eventos
                new GastosPresenter(vista, database,false);
            else// ya no me suscribo a los eventos
                new GastosPresenter(vista, database,true);

        }

        private void MostrarCategorias(object sender, EventArgs e)
        {
            ICategoriasView vista = CategoriasView.ObtenerInstancia((PrincipalView)principalView);
            ICategoriasDataBase database = new CategoriasDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new CategoriaPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new CategoriaPresenter(vista, database, true);
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

        private void MostrarLugares(object? sender, EventArgs e)
        {
            ILugaresView vista = LugaresView.ObtenerLaVentanaLugares((PrincipalView)principalView);
            ILugaresDatabase database = new LugaresDatabase(sqlCadenaConexion);
            if (!vista.Suscrito)// me suscribo a los eventos
                new LugaresPresenter(vista, database, false);
            else// ya no me suscribo a los eventos
                new LugaresPresenter(vista, database, true);
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



    }
}
