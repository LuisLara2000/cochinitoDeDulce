using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cochinitoDeDulce._DataBase;

// importo las vistas y modelos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;

namespace cochinitoDeDulce.Presenters
{
    public class GastosPresenter
    {
        private IGastosView iViewGastos;
        private IGastosDatabase databaseGastos;
        private BindingSource gastosBindingSource;
        private IEnumerable<GastosModel> gastosList;

        public GastosPresenter(IGastosView iViewG, IGastosDatabase databaseG)
        {
            gastosBindingSource = new BindingSource();
            iViewGastos = iViewG;
            databaseGastos = databaseG;
            // suscribimos los eventos
            SuscribirEventosGastos();
            // inicializamos el binding source
            iViewG.EstablecerValoresBindingSource(gastosBindingSource);
            // cargos los gastos
            CargarGastos();
            // oculto la pantlla
            //iViewG.
            // muestro la pantalla
            iViewG.Show();


        }


        public void SuscribirEventosGastos()
        {
            iViewGastos.IrVentanaAgregarNuevoGasto_Event += IrVentanaAgregarNuevoGasto;
            iViewGastos.RegresarVentanaAgregarNuevoGasto_Event += RegresarVentanaAgregarNuevoGasto;
        }

        private void RegresarVentanaAgregarNuevoGasto(object? sender, EventArgs e)
        {
            
        }

        private void IrVentanaAgregarNuevoGasto(object? sender, EventArgs e)
        {
            CargarUnidades();
            CargarCategorias();
            CargarLugares();
            CargarMarcas();
            CargarTipos();
        }

        private void CargarGastos()
        {

            gastosList = databaseGastos.BuscarGastos("");
            gastosBindingSource.DataSource = gastosList;
        }

        private void CargarUnidades()
        {
            List<string> lUnidades = new List<string>();
            lUnidades.Add("kilogramos");
            lUnidades.Add("litro");
            lUnidades.Add("gramo");
            lUnidades.Add("mililitro");
            lUnidades.Add("pieza");
            iViewGastos.EstablecerUnidadesComboBox(lUnidades);
        }

        private void CargarCategorias()
        { 
            IEnumerable<CategoriasModel> lCategorias;
            lCategorias = databaseGastos.ObtenerCategorias();
            iViewGastos.EstablecerCategoriasComboBox(lCategorias);
        }
        private void CargarMarcas()
        {
            IEnumerable<MarcasModel> lMarcas;
            lMarcas = databaseGastos.ObtenerMarcas();
            iViewGastos.EstablecerMarcasComboBox(lMarcas);
        }
        private void CargarLugares()
        {
            IEnumerable<LugaresModel> lLugares;
            lLugares = databaseGastos.ObtenerLugares();
            iViewGastos.EstablecerLugaresComboBox(lLugares);
        }
        private void CargarTipos()
        {
            IEnumerable<TiposModel> lTipos;
            lTipos = databaseGastos.ObtenerTipos();
            iViewGastos.EstablecerTiposComboBox(lTipos);
        }

    }
}
