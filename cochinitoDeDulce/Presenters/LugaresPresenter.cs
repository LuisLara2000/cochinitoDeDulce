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
    public class LugaresPresenter
    {
        private ILugaresView iViewLugar;
        private ILugaresDatabase dataBaseLugar;
        private BindingSource lugaresBindingsSource;
        private IEnumerable<LugaresModel> lugaresList;
        private List<LugaresModel> listComboBox;

        public LugaresPresenter(ILugaresView viewM, ILugaresDatabase databaseL)
        {
            this.lugaresBindingsSource = new BindingSource();
            this.listComboBox = new List<LugaresModel>();
            iViewLugar = viewM;
            dataBaseLugar = databaseL;
            // suscribimos los eventos
            SuscribirEventosLugares();
            // inicializamos el binding source y el combobox
            viewM.EstablecerValoresBindingSource(lugaresBindingsSource);
            // cargo las marcas
            CargarLugares();
            // muestro en pantalla 
            viewM.Show();
        }
        // subscripcion de eventos //
        public void SuscribirEventosLugares()
        {
            // Ventana "Agregar"
            iViewLugar.AgregarNuevoLugar_Event += AgregarNuevoLugar;
            iViewLugar.IrVentanaAgregarNuevoLugar_Event += IrVentanaAgregarNuevoLugar;
            iViewLugar.RegresarVentanaAgregarNuevoLugar_Event += RegresarVentanaAgregarNuevoLugar;
            // Ventana "Eliminar"
            iViewLugar.IrVentanaEliminarLugar_Event += IrVentanaEliminarLugar;
            iViewLugar.EliminarLugar_Event += EliminarLugar;
            iViewLugar.RegresarVentanaEliminarLugar_Event += RegresarVentanaEliminarLugar;
            // Ventana "Editar"
            iViewLugar.IrVentanaEditarLugar_Event += IrVentanaEditarLugar;
            iViewLugar.EditarLugar_Event += EditarLugar;
            iViewLugar.RegresarVentanaEditarLugar_Event += RegresarVentanaEditarLugar;
            // Ventana "Buscar"
            iViewLugar.BuscarLugar_Event += BuscarLugar;

        }









        // metodos //

        // agregar //
        private void AgregarNuevoLugar(object? sender, EventArgs e)
        {
            // creo un modelo
            var modeloLugar = new LugaresModel();
            // le asigno el valor al modelo
            modeloLugar.NombreLugar = iViewLugar.TxtAgregarEditar;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloLugar);
                // valido que no este repetido
                if (dataBaseLugar.ValidarNoRepetido(modeloLugar.NombreLugar) == 0)
                {
                    // agrego la marca
                    dataBaseLugar.AgregarLugar(modeloLugar);
                    CargarLugares();
                    iViewLugar.FueExitoso = true;
                    iViewLugar.Mensaje = "El lugar fue creado exitosamente";
                }
                else
                {
                    iViewLugar.FueExitoso = false;
                    iViewLugar.Mensaje = "El lugar ya existe";
                }

            }
            catch (Exception ex)
            {
                iViewLugar.FueExitoso = false;
                iViewLugar.Mensaje = ex.Message;
            }


        }
        private void IrVentanaAgregarNuevoLugar(object? sender, EventArgs e)
        {
            iViewLugar.EstoyEditando = false;
        }
        private void RegresarVentanaAgregarNuevoLugar(object? sender, EventArgs e)
        {
            iViewLugar.TxtAgregarEditar = "";
        }
        // buscar //
        private void BuscarLugar(object? sender, EventArgs e)
        {
            lugaresList = dataBaseLugar.BuscarLugares(iViewLugar.TxtBuscarLugar);
            lugaresBindingsSource.DataSource = lugaresList;
        }
        void CargarLugares()
        {
            lugaresList = dataBaseLugar.BuscarLugares("");
            lugaresBindingsSource.DataSource = lugaresList;

        }
        // editar // 
        private void IrVentanaEditarLugar(object? sender, EventArgs e)
        {
            var lugarActual = (LugaresModel)lugaresBindingsSource.Current;
            iViewLugar.LblAgregarEditar = "El Lugar '" + lugarActual.NombreLugar + "' sera editado a:";
            iViewLugar.EstoyEditando = true;
        }
        private void EditarLugar(object? sender, EventArgs e)
        {
            var nombreActual = (LugaresModel)lugaresBindingsSource.Current;
            var nombreNuevo = new LugaresModel();
            nombreNuevo.NombreLugar = iViewLugar.TxtAgregarEditar;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(nombreNuevo);
                // valido que no este repetido
                if (dataBaseLugar.ValidarNoRepetido(nombreNuevo.NombreLugar) == 0)
                {
                    dataBaseLugar.EditarLugar(nombreActual.NombreLugar, nombreNuevo.NombreLugar);
                    CargarLugares();
                    iViewLugar.FueExitoso = true;
                    iViewLugar.Mensaje = "El lugar fue editado exitosamente";

                }
                else
                {
                    iViewLugar.FueExitoso = false;
                    iViewLugar.Mensaje = "El lugar ya existe";
                }

            }
            catch (Exception ex)
            {
                iViewLugar.FueExitoso = false;
                iViewLugar.Mensaje = ex.Message;
            }

        }
        // no se esta usando esta funcion 
        private void RegresarVentanaEditarLugar(object? sender, EventArgs e)
        {
            iViewLugar.TxtAgregarEditar = "";
        }
        // eliminar //
        private void EliminarLugar(object? sender, EventArgs e)
        {

            // obtengo la categoria a eliminar
            var lugarActual = (LugaresModel)lugaresBindingsSource.Current;
            // creo un modelo
            var modeloLugar = new LugaresModel();

            modeloLugar.NombreLugar = iViewLugar.CbEliminar;

            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloLugar);
                // elimino la categoria                                          le paso la categoria a reemplazar
                dataBaseLugar.EliminarLugar(lugarActual.IdLugar, iViewLugar.CbEliminar);
                // cargo las categorias para actualizar la tabla
                CargarLugares();
                iViewLugar.FueExitoso = true;
                iViewLugar.Mensaje = "El lugar '" + lugarActual.NombreLugar + "' fue eliminado exitosamente";


            }
            catch (Exception ex)
            {
                iViewLugar.FueExitoso = false;
                iViewLugar.Mensaje = ex.Message;
            }
        }
        private void IrVentanaEliminarLugar(object? sender, EventArgs e)
        {
            // mostrar mensaje de cual categoria vas a eliminar
            var lugarEliminar = (LugaresModel)lugaresBindingsSource.Current;
            iViewLugar.LblElimnarLugar = "Para eliminar el lugar '" + lugarEliminar.NombreLugar + "' es necesario reemplazarlo por:";
            // obtener de la base de datos la lista de todos las categorias creadas,
            // exepto del id de la categoria eliminar

            // reutilizo el codigo que tengo de buscar categoria
            lugaresList = dataBaseLugar.BuscarLugarExepto(lugarEliminar.IdLugar);

            // se las mando al combo box que esta en la ventana eliminar
            CargarLugaresComboBox();
            iViewLugar.PuedoEliminar = true;
            if (lugaresList.Count() == 0)
            {
                iViewLugar.PuedoEliminar = false;
                iViewLugar.Mensaje = "¡NO PUEDES QUEDARTE SIN LUGARES!";
            }

        }
        private void RegresarVentanaEliminarLugar(object? sender, EventArgs e)
        {
            iViewLugar.CbEliminar = "";
        }
        void CargarLugaresComboBox()
        {
            iViewLugar.EstablecerValoresComboBox(lugaresList);
        }


    }
}
