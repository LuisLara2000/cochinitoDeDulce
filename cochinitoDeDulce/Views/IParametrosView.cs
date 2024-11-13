using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface IParametrosView
    {
        bool Suscrito { get; set; }
        // /////// //
        // EVENTOS //
        // /////// //

        event EventHandler MostrarCategorias_Event;
        event EventHandler MostrarLugares_Event;
        event EventHandler MostrarTipos_Event;
        event EventHandler MostrarMarcas_Event;

        void Show();

    }
}
