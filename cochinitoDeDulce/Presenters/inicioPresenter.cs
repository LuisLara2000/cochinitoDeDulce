using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Presenters
{
    public class InicioPresenter
    {
        private IInicioView iViewInicio;
        private IInicioDatabase databaseInicio;
        public InicioPresenter(IInicioView iViewI,IInicioDatabase databaseI, bool suscrito)
        {
            iViewInicio = iViewI;
            databaseInicio = databaseI;
            iViewInicio.Show();
        }

    }
}
