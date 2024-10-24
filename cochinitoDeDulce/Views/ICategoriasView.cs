using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface ICategoriasView
    {
        // propiedades GETTERS
        string IdCategoria { get; set; }
        string NombreCategorias { get; set; }

        // eventos
        event EventHandler AgregarNuevaCategoria_Event;

    }
}
