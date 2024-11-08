using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface ITiposView
    {
        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // Del Tipo 
        string IdTipo { get; set; }
        string NombreTipo { get; set; }

        // De la vista
        string TxtBuscarTipo { get; set; }
        string TxtAgregarEditar { get; set; }
        string LblAgregarEditar { get; set; }
        string LblElimnarTipo { get; set; }
        string CbEliminar { get; set; }
        // Solo en codigo
        bool EstoyEditando { get; set; }
        bool FueExitoso { get; set; }
        bool PuedoEliminar { get; set; }
        string Mensaje { get; set; }
        bool Suscrito { get; set; }
        // /////// //
        // EVENTOS //
        // /////// //

        // ----------------------- //
        // Ventana "Agregar Marca" //
        // ----------------------- //
        event EventHandler AgregarNuevoTipo_Event;
        event EventHandler IrVentanaAgregarNuevoTipo_Event;
        event EventHandler RegresarVentanaAgregarNuevoTipo_Event;
        // ------------------------ //
        // Ventana "Eliminar Marca" //
        // ------------------------ //
        event EventHandler EliminarTipo_Event;
        event EventHandler IrVentanaEliminarTipo_Event;
        event EventHandler RegresarVentanaEliminarTipo_Event;
        // ---------------------- //
        // Ventana "Editar Marca" //
        // ---------------------- //
        event EventHandler EditarTipo_Event;
        event EventHandler IrVentanaEditarTipo_Event;
        event EventHandler RegresarVentanaEditarTipo_Event;
        // -------------------------------------------------------------------------------------------------------- //
        // Ventana "Buscar Marca" (Esta es la ventana que se muestra al presionar "Marcas" en la ventana principal) //
        // -------------------------------------------------------------------------------------------------------- //
        event EventHandler BuscarTipo_Event;

        // /////// //
        // METODOS //
        // /////// //

        // Aqui se muestran las marcas en una tabla al ver la primera pantalla
        void EstablecerValoresBindingSource(BindingSource tiposLista);
        // Aqui se muestran las marcas en una lista para que escojas cual reemplazara a la que quieres eliminar
        void EstablecerValoresComboBox(IEnumerable<TiposModel> tiposListaMenosLaQueVasAEliminar);
        void Show();
    }
}
