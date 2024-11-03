using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cochinitoDeDulce._DataBase;

// importo las vistas y modelos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;

namespace cochinitoDeDulce.Presenters
{
    public class TiposPresenter
    {

        private ITiposView iViewTipo;
        private ITiposDatabase databaseTipo;
        private BindingSource tiposBindingsSource;
        private IEnumerable<TiposModel> tiposList;
        private List<TiposModel> listComboBox;

        public TiposPresenter(ITiposView viewT, ITiposDatabase databaseT)
        {
            this.tiposBindingsSource = new BindingSource();
            this.listComboBox = new List<TiposModel>();
            iViewTipo = viewT;
            databaseTipo = databaseT;
            // suscribimos los eventos
            SuscribirEventosTipos();
            // inicializamos el binding source y el combobox
            viewT.EstablecerValoresBindingSource(tiposBindingsSource);
            // cargo las marcas
            CargarTipos();
            // muestro en pantalla 
            viewT.Show();
        }
        // subscripcion de eventos //
        public void SuscribirEventosTipos()
        {
            // Ventana "Agregar"
            iViewTipo.AgregarNuevoTipo_Event += AgregarNuevoTipo;
            iViewTipo.IrVentanaAgregarNuevoTipo_Event += IrVentanaAgregarNuevoTipo;
            iViewTipo.RegresarVentanaAgregarNuevoTipo_Event += RegresarVentanaAgregarNuevoTipo;
            // Ventana "Eliminar"
            iViewTipo.IrVentanaEliminarTipo_Event += IrVentanaEliminarTipo;
            iViewTipo.EliminarTipo_Event += EliminarTipo;
            iViewTipo.RegresarVentanaEliminarTipo_Event += RegresarVentanaEliminarTipo;
            // Ventana "Editar"
            iViewTipo.IrVentanaEditarTipo_Event += IrVentanaEditarTipo;
            iViewTipo.EditarTipo_Event += EditarTipo;
            iViewTipo.RegresarVentanaEditarTipo_Event += RegresarVentanaEditarTipo;
            // Ventana "Buscar"
            iViewTipo.BuscarTipo_Event += BuscarTipo;

        }

        // metodos //

        // agregar //
        private void AgregarNuevoTipo(object? sender, EventArgs e)
        {
            // creo un modelo
            var modeloTipo = new TiposModel();
            // le asigno el valor al modelo
            modeloTipo.NombreTipo = iViewTipo.TxtAgregarEditar;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloTipo);
                // valido que no este repetido
                if (databaseTipo.ValidarNoRepetido(modeloTipo.NombreTipo) == 0)
                {
                    // agrego la marca
                    databaseTipo.AgregarTipo(modeloTipo);
                    CargarTipos();
                    iViewTipo.FueExitoso = true;
                    iViewTipo.Mensaje = "El tipo fue creado exitosamente";
                }
                else
                {
                    iViewTipo.FueExitoso = false;
                    iViewTipo.Mensaje = "El tipo ya existe";
                }

            }
            catch (Exception ex)
            {
                iViewTipo.FueExitoso = false;
                iViewTipo.Mensaje = ex.Message;
            }


        }
        private void IrVentanaAgregarNuevoTipo(object? sender, EventArgs e)
        {
            iViewTipo.EstoyEditando = false;
        }
        private void RegresarVentanaAgregarNuevoTipo(object? sender, EventArgs e)
        {
            iViewTipo.TxtAgregarEditar = "";
        }
        // buscar //
        private void BuscarTipo(object? sender, EventArgs e)
        {
            tiposList = databaseTipo.BuscarTipos(iViewTipo.TxtBuscarTipo);
            tiposBindingsSource.DataSource = tiposList;
        }
        void CargarTipos()
        {
            tiposList = databaseTipo.BuscarTipos("");
            tiposBindingsSource.DataSource = tiposList;

        }
        // editar // 
        private void IrVentanaEditarTipo(object? sender, EventArgs e)
        {
            var tipoActual = (TiposModel)tiposBindingsSource.Current;
            iViewTipo.LblAgregarEditar = "El tipo '" + tipoActual.NombreTipo + "' sera editada a:";
            iViewTipo.EstoyEditando = true;
        }
        private void EditarTipo(object? sender, EventArgs e)
        {
            var nombreActual = (TiposModel)tiposBindingsSource.Current;
            var nombreNuevo = new TiposModel();
            nombreNuevo.NombreTipo = iViewTipo.TxtAgregarEditar;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(nombreNuevo);
                // valido que no este repetido
                if (databaseTipo.ValidarNoRepetido(nombreNuevo.NombreTipo) == 0)
                {
                    databaseTipo.EditarTipo(nombreActual.NombreTipo, nombreNuevo.NombreTipo);
                    CargarTipos();
                    iViewTipo.FueExitoso = true;
                    iViewTipo.Mensaje = "El tipo fue editado exitosamente";

                }
                else
                {
                    iViewTipo.FueExitoso = false;
                    iViewTipo.Mensaje = "El tipo ya existe";
                }

            }
            catch (Exception ex)
            {
                iViewTipo.FueExitoso = false;
                iViewTipo.Mensaje = ex.Message;
            }

        }
        // no se esta usando esta funcion 
        private void RegresarVentanaEditarTipo(object? sender, EventArgs e)
        {
            iViewTipo.TxtAgregarEditar = "";
        }
        // eliminar //
        private void EliminarTipo(object? sender, EventArgs e)
        {

            // obtengo la categoria a eliminar
            var tipoActual = (TiposModel)tiposBindingsSource.Current;
            // creo un modelo
            var modeloTipo = new TiposModel();

            modeloTipo.NombreTipo = iViewTipo.CbEliminar;

            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloTipo);
                // elimino la categoria                                          le paso la categoria a reemplazar
                databaseTipo.EliminarTipo(tipoActual.IdTipo, iViewTipo.CbEliminar);
                // cargo las categorias para actualizar la tabla
                CargarTipos();
                iViewTipo.FueExitoso = true;
                iViewTipo.Mensaje = "El tipo '" + tipoActual.NombreTipo + "' fue eliminado exitosamente";


            }
            catch (Exception ex)
            {
                iViewTipo.FueExitoso = false;
                iViewTipo.Mensaje = ex.Message;
            }
        }
        private void IrVentanaEliminarTipo(object? sender, EventArgs e)
        {
            // mostrar mensaje de cual categoria vas a eliminar
            var tipoElimnar = (TiposModel)tiposBindingsSource.Current;
            iViewTipo.LblElimnarTipo = "Para eliminar el tipo '" + tipoElimnar.NombreTipo + "' es necesario reemplazarla por:";
            // obtener de la base de datos la lista de todos las categorias creadas,
            // exepto del id de la categoria eliminar

            // reutilizo el codigo que tengo de buscar categoria
            tiposList = databaseTipo.BuscarTipoExepto(tipoElimnar.IdTipo);

            // se las mando al combo box que esta en la ventana eliminar
            CargarTiposComboBox();
            iViewTipo.PuedoEliminar = true;
            if (tiposList.Count() == 0)
            {
                iViewTipo.PuedoEliminar = false;
                iViewTipo.Mensaje = "¡NO PUEDES QUEDARTE SIN TIPOS!";
            }

        }
        private void RegresarVentanaEliminarTipo(object? sender, EventArgs e)
        {
            iViewTipo.CbEliminar = "";
        }
        void CargarTiposComboBox()
        {
            iViewTipo.EstablecerValoresComboBox(tiposList);
        }

        
    }
}
