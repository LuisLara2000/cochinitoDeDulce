using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface IPrincipalView
    {
        event EventHandler MostrarCategorias_Evento;
        event EventHandler MostrarMarcas_Evento;
        event EventHandler MostrarLugares_Evento;
        event EventHandler MostrarTipos_Evento;
        event EventHandler MostrarGastos_Evento;
        event EventHandler MostrarIngresos_Evento;
        event EventHandler MostrarInicio_Evento;
    }
}
