using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cochinitoDeDulce.Models;


// importo las vistas y modelos
using cochinitoDeDulce.Views;

namespace cochinitoDeDulce.Presenters
{
    public class IngresosPresenter
    {
        private IIngresosView iViewIngresos;
        private IIngresosDatabase databaIngresos;

        public IngresosPresenter(IIngresosView iViewIngresos, IIngresosDatabase databaIngresos)
        {
            this.iViewIngresos = iViewIngresos;
            this.databaIngresos = databaIngresos;
            iViewIngresos.Show();
        }
    }
}
