using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Presenters
{
    public class inicioPresenter
    {
        private IInicioView iViewInicio;
        private IInicioDatabase databaseInicio;
        public inicioPresenter(IInicioView iViewI,IInicioDatabase databaseI)
        {
            iViewInicio = iViewI;
            databaseInicio = databaseI;
            iViewInicio.Show();
        }

    }
}
