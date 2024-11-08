using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{

    public interface IIngresosView
    {
        // propiedades GETTERS
        // MODELO
        int IdIngreso { get; set; }
        float Monto {  get; set; }
        string Origen {  get; set; }

        // VISTA
        string TxtBuscarIngreso { get; set; }
        string TxtAgregarMonto {  get; set; }
        string TxtAgregarOrigen{ get; set; }
        string LblAgregarEditar { get; set; }


        // variables que no tienen viculacion con objetos de la vista
        bool Editando { get; set; }
        bool Exitoso { get; set; }
        string Mensaje { get; set; }
        bool Suscrito { get; set; }
        // eventos
        // Ventana "Agregar"
        event EventHandler AgregarNuevoIngreso_Event;
        event EventHandler IrVentanaAgregarNuevoIngreso_Event;
        event EventHandler RegresarVentanaAgregarNuevoIngreso_Event;
        // Ventana "Editar"
        event EventHandler EditarIngreso_Event;
        event EventHandler IrVentanaEditarIngreso_Event;
        // Ventana "Eliminar"
        event EventHandler EliminarIngreso_Event;
        // Ventana "Buscar"
        event EventHandler BuscarIngreso_Event;

        // metodos
        void EstablecerBindingSource(BindingSource ingresosLista);
        void Show();
    }
}
