using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface IGastosView
    {
        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // ------ [Del modelo ] ----- //
        int IdGasto { get; set; }
        string Nombre { get; set; }
        float Precio { get; set; }
        float Descuento { get; set; }
        float Cantidad { get; set; }
        string Unidad { get; set; }
        string Fecha { get; set; }
        string Comentario { get; set; }
        string Categoria { get; set; }
        string Lugar { get; set; }
        string Marca { get; set; }
        string Tipo { get; set; }
        // ------ [De la vista] ----- //
        string TxtBuscarGasto { get; set; }
        string TxtAgregarEditar { get; set; }
        string TxtPrecio { get; set; }
        string TxtCantidad {  get; set; }
        string TxtDescuento { get; set; }
        string TxtComentario { get; set; }
        string CbUnidad { get; set; }
        string CbCategoria {  get; set; }
        string CbMarca { get; set; }
        string CbLugar { get; set; }
        string CbTipo {  get; set; }

        // ------ [Solo en codigo] ----- //
        bool EstoyEditando { get; set; }
        bool FueExitoso { get; set; }
        string Mensaje { get; set; }
        bool Suscrito {  get; set; }
        // /////// //
        // EVENTOS //
        // /////// //

        // ------ [Ventana "Buscar Gasto"] ----- //
        event EventHandler BuscarGasto_Event;
        // ------ [Ventana "Agregar Gasto"] ----- //
        event EventHandler AgregarNuevoGasto_Event;
        event EventHandler IrVentanaAgregarNuevoGasto_Event;
        event EventHandler RegresarVentanaAgregarNuevoGasto_Event;
        // ------ [Ventana "Editar Gasto"] ----- //
        event EventHandler EditarGasto_Event;
        event EventHandler IrVentanaEditarGasto_Event;
        // ------ [Ventana "Eliminar Gasto"] ----- //
        event EventHandler EliminarGasto_Event;

        // /////// //
        // METODOS //
        // /////// //

        // Para el data grid
        void EstablecerValoresBindingSource(BindingSource gastosLista);
        // Para cada combo box que se muestra en la ventana de agregar/editar
        void EstablecerCategoriasComboBox(IEnumerable<CategoriasModel> categoriasDisponibles);
        void EstablecerLugaresComboBox(IEnumerable<LugaresModel> lugaresDisponibles);
        void EstablecerMarcasComboBox(IEnumerable<MarcasModel> marcasDisponibles);
        void EstablecerTiposComboBox(IEnumerable<TiposModel> tiposDisponibles);
        void EstablecerUnidadesComboBox(List<string> listaUnidades);
        void Show();

    }
}
