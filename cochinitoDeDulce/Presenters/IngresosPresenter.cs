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
    public class IngresosPresenter
    {
        private IIngresosView iViewIngresos;
        private IIngresosDatabase databaIngresos;
        private IEnumerable<IngresosModel> listaIngresos;
        private BindingSource ingresosBindingSource;
        public IngresosPresenter(IIngresosView iViewI, IIngresosDatabase databaseI)
        {
            this.ingresosBindingSource = new BindingSource();
            this.iViewIngresos = iViewI;
            this.databaIngresos = databaseI;
            suscribirEventos();
            iViewIngresos.EstablecerBindingSource(ingresosBindingSource);
            CargarIngresos();
            iViewI.Show();
        }

        public void suscribirEventos()
        {
            iViewIngresos.BuscarIngreso_Event += BuscarIngreso;
            iViewIngresos.IrVentanaAgregarNuevoIngreso_Event += IrVentanaAgregarNuevoIngreso;
            iViewIngresos.AgregarNuevoIngreso_Event += AgregarNuevoIngreso;
            iViewIngresos.IrVentanaEditarIngreso_Event += IrVentanaEditarIngreso;
            iViewIngresos.EditarIngreso_Event += EditarIngreso;
            iViewIngresos.RegresarVentanaAgregarNuevoIngreso_Event += RegresarVentanaAgregarNuevoIngreso;
            iViewIngresos.EliminarIngreso_Event += EliminarIngreso;
        }

        private void EliminarIngreso(object? sender, EventArgs e)
        {
            var seleccionadoIngreso = (IngresosModel)ingresosBindingSource.Current;
            try
            {
                databaIngresos.EliminarIngeso(seleccionadoIngreso.IdIngreso);
                CargarIngresos();
                iViewIngresos.Exitoso = true;
                iViewIngresos.Mensaje = "Ingreso eliminado exitosamente";
            }
            catch (Exception ex)
            {
                iViewIngresos.Exitoso = false;
                iViewIngresos.Mensaje = ex.Message;
            }

        }

        private void RegresarVentanaAgregarNuevoIngreso(object? sender, EventArgs e)
        {
            //nada
        }

        private void EditarIngreso(object? sender, EventArgs e)
        {
            var seleccionadoIngreso = (IngresosModel)ingresosBindingSource.Current;
            var editadoIngreso = new IngresosModel();
            try
            {
                editadoIngreso.IdIngreso = seleccionadoIngreso.IdIngreso;
                editadoIngreso.Monto = float.Parse(iViewIngresos.TxtAgregarMonto);
                editadoIngreso.Origen = iViewIngresos.TxtAgregarOrigen;
                databaIngresos.EditarIngreso(editadoIngreso);
                CargarIngresos();
                iViewIngresos.Exitoso = true;
                iViewIngresos.Mensaje = "Ingreso editado exitosamente";
            }
            catch (Exception ex)
            {
                iViewIngresos.Exitoso = false;
                iViewIngresos.Mensaje = ex.Message;
            }
        }

        private void IrVentanaEditarIngreso(object? sender, EventArgs e)
        {
            iViewIngresos.Editando = true;
            var seleccionadoIngreso = (IngresosModel)ingresosBindingSource.Current;
            iViewIngresos.TxtAgregarMonto = seleccionadoIngreso.Monto.ToString();
            iViewIngresos.TxtAgregarOrigen = seleccionadoIngreso.Origen;
        }

        private void AgregarNuevoIngreso(object? sender, EventArgs e)
        {

            var vIngreso = new IngresosModel();
            try
            {
                vIngreso.Monto = float.Parse(iViewIngresos.TxtAgregarMonto);
                vIngreso.Origen = iViewIngresos.TxtAgregarOrigen;
                databaIngresos.AgregarIngreso(vIngreso);
                CargarIngresos();
                iViewIngresos.Exitoso = true;
                iViewIngresos.Mensaje = "Ingreso agregado exitosamente";
            }
            catch (Exception ex)
            {
                iViewIngresos.Exitoso = false;
                iViewIngresos.Mensaje = ex.Message;
            }

        }

        private void IrVentanaAgregarNuevoIngreso(object? sender, EventArgs e)
        {
            iViewIngresos.Editando = false;
            iViewIngresos.LblAgregarEditar = "Ingrese el nuevo ingreso";
        }

        private void BuscarIngreso(object? sender, EventArgs e)
        {
            listaIngresos = databaIngresos.BuscarIngreso(iViewIngresos.TxtBuscarIngreso);
            ingresosBindingSource.DataSource = listaIngresos;
        }

        void CargarIngresos()
        {
            listaIngresos = databaIngresos.BuscarIngreso("");
            ingresosBindingSource.DataSource = listaIngresos;
        }
    }
}
