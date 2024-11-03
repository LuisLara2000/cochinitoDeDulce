using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface ILugaresView
    {
        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // Del modelo 
        string IdLugar{ get; set; }
        string NombreLugar { get; set; }

        // De la vista
        string TxtBuscarLugar { get; set; }
        string TxtAgregarEditar { get; set; }
        string LblAgregarEditar { get; set; }
        string LblElimnarLugar { get; set; }
        string CbEliminar { get; set; }
        // Solo en codigo
        bool EstoyEditando { get; set; }
        bool FueExitoso { get; set; }
        bool PuedoEliminar { get; set; }
        string Mensaje { get; set; }

        // /////// //
        // EVENTOS //
        // /////// //

        // ----------------------- //
        // Ventana "Agregar Lugar" //
        // ----------------------- //
        event EventHandler AgregarNuevoLugar_Event;
        event EventHandler IrVentanaAgregarNuevoLugar_Event;
        event EventHandler RegresarVentanaAgregarNuevoLugar_Event;
        // ------------------------ //
        // Ventana "Eliminar Lugar" //
        // ------------------------ //
        event EventHandler EliminarLugar_Event;
        event EventHandler IrVentanaEliminarLugar_Event;
        event EventHandler RegresarVentanaEliminarLugar_Event;
        // ---------------------- //
        // Ventana "Editar Lugar" //
        // ---------------------- //
        event EventHandler EditarLugar_Event;
        event EventHandler IrVentanaEditarLugar_Event;
        event EventHandler RegresarVentanaEditarLugar_Event;
        // -------------------------------------------------------------------------------------------------------- //
        // Ventana "Buscar Lugar" (Esta es la ventana que se muestra al presionar "Lugar" en la ventana principal) //
        // -------------------------------------------------------------------------------------------------------- //
        event EventHandler BuscarLugar_Event;

        // /////// //
        // METODOS //
        // /////// //

        // Aqui se muestran las Lugares en una tabla al ver la primera pantalla
        void EstablecerValoresBindingSource(BindingSource lugaresLista);
        // Aqui se muestran los Lugares en una lista para que escojas cual reemplazara a la que quieres eliminar
        void EstablecerValoresComboBox(IEnumerable<LugaresModel> lugaresListaMenosLaQueVasAEliminar);
        void Show();
    }
}
