using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface ICategoriasView
    {
        // propiedades GETTERS
        // MODELO
        string IdCategoria { get; set; }
        string NombreCategorias { get; set; }
        // VISTA
        string BuscarCategoriaTxt { get; set; }
        string EditarAgregarLbl { get; set; }
        string ElimnarLbl { get; set; }
        string CatagoriaEliminarCb {  get;  }
        // variables que no tienen viculacion con objetos de la vista
        bool Editando {get; set; }
        bool Exitoso { get; set; }
        string Mensaje {  get; set; }
        bool PuedoEliminar { get; set; }
        bool Suscrito { get; set; }
        // eventos
        /// <summary>
        /// todos los eventos van aqui, por ejemplo 
        /// evento presionar agregar y que te lleve a la ventana agregar(te muestra la ventana puedes ingresar los valores de agregar)
        /// es diferente al
        /// evento presionar agregar en la ventana agregar (se guarda la info)
        /// </summary>

        // Ventana "Agregar Categoria"
        event EventHandler AgregarNuevaCategoria_Event;
        event EventHandler IrVentanaAgregarNuevaCategoria_Event;
        event EventHandler RegresarVentanaAgregarNuevaCategoria_Event;
        // Ventana "Eliminar Categoria"
        event EventHandler EliminarCategoria_Event;
        event EventHandler IrVentanaEliminarCategoria_Event;
        event EventHandler RegresarVentanaEliminarCategoria_Event;
        // Ventana "Editar Categoria"
        event EventHandler EditarCategoria_Event;
        event EventHandler IrVentanaEditarCategoria_Event;
        event EventHandler RegresarVentanaEditarCategoria_Event;
        // Ventana "Buscar Categoria" (Esta es la ventana que se muestra al presionar "Categorias" en la ventana principal)
        event EventHandler BuscarCategorias_Event;
        // este eevento sera sustituido
        event EventHandler Regresar_Event;

        // metodos
        void SetPetListBindingSource(BindingSource categoriasLista);
        void SetComboBoxCategoriasEliminar(ComboBox cbCategorias);

        void Show();
    }
}
