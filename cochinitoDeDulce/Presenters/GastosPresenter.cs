using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            iViewGastos= iViewG;
            databaseGastos = databaseG;
            // suscribimos los eventos
            SuscribirEventosGastos();
            // inicializamos el binding source
            iViewG.EstablecerValoresBindingSource(gastosBindingSource);
            // cargos los gastos
            CargarGastos();
            // muestro la pantalla
            iViewG.Show();


        }

        private void CargarGastos()
        {
            
            gastosList = databaseGastos.BuscarGastos("");
            gastosBindingSource.DataSource = gastosList;
        }

        public void SuscribirEventosGastos()
        {

        }
    }
}
