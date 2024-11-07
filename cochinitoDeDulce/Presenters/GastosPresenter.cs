using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cochinitoDeDulce._DataBase;

// importo las vistas y modelos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;

namespace cochinitoDeDulce.Presenters
{
    public class GastosPresenter
    {
        private IGastosView iViewGastos;
        private IGastosDatabase databaseGastos;
        private BindingSource gastosBindingSource;
        private IEnumerable<GastosModel> gastosList;
        // falta validar el modelo gastos!!!!!!!!!!!!!!!!!!!!!!
        // falta validar el modelo gastos!!!!!!!!!!!!!!!!!!!!!!
        // falta validar el modelo gastos!!!!!!!!!!!!!!!!!!!!!!
        // falta validar el modelo gastos!!!!!!!!!!!!!!!!!!!!!!
        // falta validar el modelo gastos!!!!!!!!!!!!!!!!!!!!!!
        // falta validar el modelo gastos!!!!!!!!!!!!!!!!!!!!!!
        public GastosPresenter(IGastosView iViewG, IGastosDatabase databaseG,bool suscrito)
        {
            gastosBindingSource = new BindingSource();
            iViewGastos = iViewG;
            databaseGastos = databaseG;

            // inicializamos el binding source
            iViewG.EstablecerValoresBindingSource(gastosBindingSource);
            // cargos los gastos
            CargarGastos();

            if (!suscrito)
            {
                SuscribirEventosGastos();
                iViewGastos.Suscrito = true;
            }
            // muestro la pantalla
            iViewG.Show();
        }
        public void SuscribirEventosGastos()
        {
            iViewGastos.IrVentanaAgregarNuevoGasto_Event += IrVentanaAgregarNuevoGasto;
            iViewGastos.RegresarVentanaAgregarNuevoGasto_Event += RegresarVentanaAgregarNuevoGasto;
            iViewGastos.AgregarNuevoGasto_Event += AgregarNuevoGasto;
            iViewGastos.IrVentanaEditarGasto_Event += IrVentanaEditarGasto;
            iViewGastos.EditarGasto_Event += EditarGasto;
            iViewGastos.EliminarGasto_Event += EliminarGasto;
            iViewGastos.BuscarGasto_Event += BuscarGasto;
        }
        private void BuscarGasto(object? sender, EventArgs e)
        {
            iViewGastos.EstablecerValoresBindingSource(gastosBindingSource);
            gastosList = databaseGastos.BuscarGastos(iViewGastos.TxtBuscarGasto);
            gastosBindingSource.DataSource = gastosList;
        }
        private void EliminarGasto(object? sender, EventArgs e)
        {
            var idGasto = (GastosModel)gastosBindingSource.Current;// para obetenr el id del gasto seleccionado
            try
            {
                databaseGastos.EliminarGasto(idGasto.IdGasto);
                iViewGastos.FueExitoso = true;
                iViewGastos.Mensaje = "Gasto eliminado";
                CargarGastos();
            }
            catch (Exception ex)
            {
                iViewGastos.FueExitoso =false;
                iViewGastos.Mensaje = ex.Message;
            }
        }
        private void EditarGasto(object? sender, EventArgs e)
        {
            var gastoModeloEditado = new GastosModel();// obetene todos los datos del gasto editado exepto el id
            var idGasto = (GastosModel)gastosBindingSource.Current;// para obetenr el id del gasto seleccionado

            try
            {
                gastoModeloEditado.IdGasto = idGasto.IdGasto;
                gastoModeloEditado.Nombre = iViewGastos.TxtAgregarEditar;
                gastoModeloEditado.Precio = float.Parse(iViewGastos.TxtPrecio);
                gastoModeloEditado.Cantidad = float.Parse(iViewGastos.TxtCantidad);
                gastoModeloEditado.Unidad = iViewGastos.CbUnidad;
                gastoModeloEditado.Descuento = float.Parse(iViewGastos.TxtDescuento);
                gastoModeloEditado.Fecha = idGasto.Fecha;// la fecha se modifica 
                gastoModeloEditado.Comentario = iViewGastos.TxtComentario;
                gastoModeloEditado.Categoria = iViewGastos.CbCategoria;
                gastoModeloEditado.Lugar = iViewGastos.CbLugar;
                gastoModeloEditado.Marca = iViewGastos.CbMarca;
                // id imagen
                gastoModeloEditado.Tipo = iViewGastos.CbTipo;
                databaseGastos.EditarGasto(idGasto.IdGasto, gastoModeloEditado);
                CargarGastos();
                iViewGastos.FueExitoso = true;
                iViewGastos.Mensaje = "Gasto "+ idGasto.IdGasto+ " editado correctamente";
            }
            catch(Exception ex)
            {
                iViewGastos.FueExitoso = false;
                iViewGastos.Mensaje = ex.Message;
            }

        }
        private void IrVentanaEditarGasto(object? sender, EventArgs e)
        {
            iViewGastos.EstoyEditando = true;
            CargarUnidades();
            CargarCategorias();
            CargarLugares();
            CargarMarcas();
            CargarTipos();
            // obtengo los valores seleccionados
            var gastoActual = (GastosModel)gastosBindingSource.Current;
            iViewGastos.TxtAgregarEditar = gastoActual.Nombre;
            iViewGastos.TxtPrecio = gastoActual.Precio.ToString();
            iViewGastos.TxtCantidad = gastoActual.Cantidad.ToString();
            iViewGastos.CbUnidad = gastoActual.Unidad;
            iViewGastos.TxtDescuento = gastoActual.Descuento.ToString();
            // falta el campo de fecha xd
            iViewGastos.TxtComentario = gastoActual.Comentario;
            iViewGastos.CbCategoria = gastoActual.Categoria;
            iViewGastos.CbMarca = gastoActual.Marca;
            iViewGastos.CbLugar = gastoActual.Lugar;
            iViewGastos.CbTipo = gastoActual.Tipo;

        }
        private void AgregarNuevoGasto(object? sender, EventArgs e)
        {
            var gastoModel = new GastosModel();
            try
            {
                gastoModel.Nombre = iViewGastos.TxtAgregarEditar;
                gastoModel.Precio = float.Parse(iViewGastos.TxtPrecio);
                gastoModel.Cantidad = float.Parse(iViewGastos.TxtCantidad);
                gastoModel.Unidad = iViewGastos.CbUnidad;
                gastoModel.Descuento = float.Parse(iViewGastos.TxtDescuento);
                gastoModel.Fecha = DateTime.Now.ToString("dd-MM-yyyy");
                gastoModel.Comentario = iViewGastos.TxtComentario;
                gastoModel.Categoria = iViewGastos.CbCategoria;
                gastoModel.Marca = iViewGastos.CbMarca;
                gastoModel.Lugar = iViewGastos.CbLugar;
                gastoModel.Tipo = iViewGastos.CbTipo;
              
                databaseGastos.AgregarGasto(gastoModel);
                CargarGastos();
                iViewGastos.FueExitoso = true;
                iViewGastos.Mensaje = "Gasto agregado con exito";
            }
            catch (Exception ex)
            {
                iViewGastos.FueExitoso = false;
                iViewGastos.Mensaje = ex.Message;
            }


        }
        private void RegresarVentanaAgregarNuevoGasto(object? sender, EventArgs e)
        {
            iViewGastos.TxtAgregarEditar = "";
            iViewGastos.TxtPrecio = "";
            iViewGastos.TxtCantidad = "";
            iViewGastos.CbUnidad = "";
            iViewGastos.TxtDescuento = "";
            // falta el campo de fecha xd
            iViewGastos.TxtComentario = "";
            iViewGastos.CbCategoria = "";
            iViewGastos.CbMarca = "";
            iViewGastos.CbLugar = "";
            iViewGastos.CbTipo = "";
        }
        private void IrVentanaAgregarNuevoGasto(object? sender, EventArgs e)
        {
            CargarUnidades();
            CargarCategorias();
            CargarLugares();
            CargarMarcas();
            CargarTipos();
            iViewGastos.EstoyEditando = false;
        }
        private void CargarGastos()
        {

            gastosList = databaseGastos.BuscarGastos("");
            gastosBindingSource.DataSource = gastosList;
        }
        private void CargarUnidades()
        {
            List<string> lUnidades = new List<string>();
            lUnidades.Add("kilogramos");
            lUnidades.Add("litro");
            lUnidades.Add("gramo");
            lUnidades.Add("mililitro");
            lUnidades.Add("pieza");
            iViewGastos.EstablecerUnidadesComboBox(lUnidades);
        }
        private void CargarCategorias()
        { 
            IEnumerable<CategoriasModel> lCategorias;
            lCategorias = databaseGastos.ObtenerCategorias();
            iViewGastos.EstablecerCategoriasComboBox(lCategorias);
        }
        private void CargarMarcas()
        {
            IEnumerable<MarcasModel> lMarcas;
            lMarcas = databaseGastos.ObtenerMarcas();
            iViewGastos.EstablecerMarcasComboBox(lMarcas);
        }
        private void CargarLugares()
        {
            IEnumerable<LugaresModel> lLugares;
            lLugares = databaseGastos.ObtenerLugares();
            iViewGastos.EstablecerLugaresComboBox(lLugares);
        }
        private void CargarTipos()
        {
            IEnumerable<TiposModel> lTipos;
            lTipos = databaseGastos.ObtenerTipos();
            iViewGastos.EstablecerTiposComboBox(lTipos);
        }
    }
}

//exec spEditarGasto 1,'',0.0,,0.0,'',0.0,getdate(),'','','','',1,''