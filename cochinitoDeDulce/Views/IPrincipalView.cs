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
        bool QuieresSalirDeLaAplicacion { get; set; }
        /*
        event EventHandler MostrarCategorias_Evento;
        event EventHandler MostrarMarcas_Evento;
        event EventHandler MostrarLugares_Evento;
        event EventHandler MostrarTipos_Evento;
        */
        event EventHandler MostrarGastos_Evento;
        event EventHandler MostrarIngresos_Evento;
        event EventHandler MostrarInicio_Evento;
        event EventHandler MostrarParametros_Evento;
        event EventHandler CerrarAplicacion_Evento;

    }
}
