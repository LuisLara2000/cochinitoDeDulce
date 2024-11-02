using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace cochinitoDeDulce.Views
{
    public interface IMarcasView
    {
        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // Del modelo 
        string IdMarca { get; set; }
        string NombreMarca { get; set; }

        // De la vista
        string TxtBuscarMarca {  get; set; }
        string TxtAgregarEditar { get; set; }
        string LblAgregarEditar { get; set; }
        string LblElimnarMarca {  get; set; }
        string CbEliminar {  get; set; }
        // Solo en codigo
        bool EstoyEditando { get; set; }
        bool FueExitoso { get; set; }
        bool PuedoEliminar { get; set; }
        string Mensaje {  get; set; }

        // /////// //
        // EVENTOS //
        // /////// //

        // ----------------------- //
        // Ventana "Agregar Marca" //
        // ----------------------- //
        event EventHandler AgregarNuevaMarca_Event;
        event EventHandler IrVentanaAgregarNuevaMarca_Event;
        event EventHandler RegresarVentanaAgregarNuevaMarca_Event;
        // ------------------------ //
        // Ventana "Eliminar Marca" //
        // ------------------------ //
        event EventHandler EliminarMarca_Event;
        event EventHandler IrVentanaEliminarMarca_Event;
        event EventHandler RegresarVentanaEliminarMarca_Event;
        // ---------------------- //
        // Ventana "Editar Marca" //
        // ---------------------- //
        event EventHandler EditarMarca_Event;
        event EventHandler IrVentanaEditarMarca_Event;
        event EventHandler RegresarVentanaEditarMarca_Event;
        // -------------------------------------------------------------------------------------------------------- //
        // Ventana "Buscar Marca" (Esta es la ventana que se muestra al presionar "Marcas" en la ventana principal) //
        // -------------------------------------------------------------------------------------------------------- //
        event EventHandler BuscarMarca_Event;

        // /////// //
        // METODOS //
        // /////// //

        // Aqui se muestran las marcas en una tabla al ver la primera pantalla
        void EstablecerValoresBindingSource(BindingSource marcasLista);
        // Aqui se muestran las marcas en una lista para que escojas cual reemplazara a la que quieres eliminar
        void EstablecerValoresComboBox(IEnumerable<MarcasModel> marcasListaMenosLaQueVasAEliminar);
        void Show();
    }
}
