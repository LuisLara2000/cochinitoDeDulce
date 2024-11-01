﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importo las vistas y modelos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;
namespace cochinitoDeDulce.Presenters
{
    public class MarcaPresenter
    {
        private IMarcasView iViewMarca;
        private IMarcasDataBase dataBaseMarca;
        private BindingSource marcasBindingsSource;
        private IEnumerable<MarcasModel> marcasList;
        private List<MarcasModel> listComboBox;

        public MarcaPresenter(IMarcasView viewM, IMarcasDataBase databaseM)
        {
            this.marcasBindingsSource = new BindingSource();
            this.listComboBox = new List<MarcasModel>();
            iViewMarca = viewM;
            dataBaseMarca = databaseM;
            // suscribimos los eventos
            SuscribirEventosMarcas();
            // inicializamos el binding source y el combobox
            viewM.EstablecerValoresBindingSource(marcasBindingsSource);
            // cargo las marcas
            CargarMarcas();
            // muestro en pantalla 
            viewM.Show();
        }
        // subscripcion de eventos //
        public void SuscribirEventosMarcas()
        {
            // Ventana "Agregar"
            iViewMarca.AgregarNuevaMarca_Event += AgregarNuevaMarca;
            iViewMarca.IrVentanaAgregarNuevaMarca_Event += IrVentanaAgregarNuevaMarca;
            iViewMarca.RegresarVentanaAgregarNuevaMarca_Event += RegresarVentanaAgregarNuevaMarca;
            // Ventana "Eliminar"
            // Ventana "Editar"
            iViewMarca.IrVentanaEditarMarca_Event += IrVentanaEditarMarca;
            iViewMarca.EditarMarca_Event += EditarMarca;
            iViewMarca.RegresarVentanaEditarMarca_Event += RegresarVentanaEditarMarca;
            // Ventana "Buscar"
            iViewMarca.BuscarMarca_Event += BuscarMarca;
            
        }














        // metodos //

        // agregar //
        private void AgregarNuevaMarca(object? sender, EventArgs e)
        {
            // creo un modelo
            var modeloMarca = new MarcasModel();
            // le asigno el valor al modelo
            modeloMarca.NombreMarca = iViewMarca.TxtAgregarEditar;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloMarca);
                // valido que no este repetido
                if (dataBaseMarca.ValidarNoRepetido(modeloMarca.NombreMarca)==0)
                {
                    // agrego la marca
                    dataBaseMarca.AgregarMarca(modeloMarca);
                    CargarMarcas();
                    iViewMarca.FueExitoso = true;
                    iViewMarca.Mensaje = "La marca fue creada exitosamente";
                }
                else
                {
                    iViewMarca.FueExitoso = false;
                    iViewMarca.Mensaje = "La marca ya existe";
                }

            }
            catch (Exception ex)
            {
                iViewMarca.FueExitoso = false;
                iViewMarca.Mensaje = ex.Message;
            }


        }
        private void IrVentanaAgregarNuevaMarca(object? sender, EventArgs e)
        {
            iViewMarca.EstoyEditando = false;
        }
        private void RegresarVentanaAgregarNuevaMarca(object? sender, EventArgs e)
        {
            iViewMarca.TxtAgregarEditar = "";
        }
        // buscar //
        private void BuscarMarca(object? sender, EventArgs e)
        {
            marcasList = dataBaseMarca.BuscarMarcas(iViewMarca.TxtBuscarMarca);
            marcasBindingsSource.DataSource = marcasList;
        }
        void CargarMarcas()
        {
            marcasList = dataBaseMarca.BuscarMarcas("");
            marcasBindingsSource.DataSource = marcasList;

        }
        // editar // 

        private void IrVentanaEditarMarca(object? sender, EventArgs e)
        {
            var marcaActual = (MarcasModel)marcasBindingsSource.Current;
            iViewMarca.LblAgregarEditar = "La marca '" + marcaActual.NombreMarca + "' sera editada a:";
            iViewMarca.EstoyEditando = true;
        }
        private void EditarMarca(object? sender, EventArgs e)
        {
            var nombreActual = (MarcasModel)marcasBindingsSource.Current;
            var nombreNuevo = new MarcasModel();
            nombreNuevo.NombreMarca= iViewMarca.TxtAgregarEditar;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(nombreNuevo);
                // valido que no este repetido
                if (dataBaseMarca.ValidarNoRepetido(nombreNuevo.NombreMarca) == 0)
                {
                    dataBaseMarca.EditarMarca(nombreActual.NombreMarca, nombreNuevo.NombreMarca);
                    CargarMarcas();
                    iViewMarca.FueExitoso = true;
                    iViewMarca.Mensaje = "La marca fue editada exitosamente";
                   
                }
                else
                {
                    iViewMarca.FueExitoso = false;
                    iViewMarca.Mensaje = "La marca ya existe";
                }
               
            }
            catch (Exception ex)
            {
                iViewMarca.FueExitoso = false;
                iViewMarca.Mensaje = ex.Message;
            }
            
        }
        // no en uso
        private void RegresarVentanaEditarMarca(object? sender, EventArgs e)
        {
            iViewMarca.TxtAgregarEditar = "";
        }
        // eliminar //



    }
}