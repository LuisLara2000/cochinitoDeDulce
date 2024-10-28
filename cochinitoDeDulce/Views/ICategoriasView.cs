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
        // 
        string BuscarCategoriaTxt { get; set; }

        // eventos
        event EventHandler AgregarNuevaCategoria_Event;
        event EventHandler BuscarCategorias_Event;
        event EventHandler Regresar_Event;

        // metodos
        void SetPetListBindingSource(BindingSource categoriasLista);
        void Show();
    }
}
