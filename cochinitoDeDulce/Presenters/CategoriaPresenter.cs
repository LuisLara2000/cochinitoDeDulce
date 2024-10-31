using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agrego las referencias de los modelos y las vistas
// en la carpeta de modelos tambien esta la referencias a la base de datos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;

namespace cochinitoDeDulce.Presenters
{
    internal class CategoriaPresenter
    {
        // campos
        private ICategoriasView viewCategoria;// la interfaz de la vista
        private ICategoriasDataBase databaseCategoria; // la interfaz de la base de datos
        private BindingSource categoriasBindingSource; // mostrar los datos
        private IEnumerable<CategoriasModel> categoriaList;// lista de categorias
        private ComboBox cb;
        private List<string> xdd= new List<string>();
        // creamos el constructor (importante)
        public CategoriaPresenter(ICategoriasView viewC,ICategoriasDataBase databaseC)
        {
            this.categoriasBindingSource = new BindingSource();// asignammos el binding source de la vista categoria
            this.cb = new ComboBox();
            viewCategoria = viewC;
            databaseCategoria = databaseC;
            // suscribimos los eventos que se ejecutan en la vista
            suscribirEventos();
            // set categorias binding source
            viewCategoria.SetPetListBindingSource(categoriasBindingSource);
            viewCategoria.SetComboBoxCategoriasEliminar(cb);
            // cargo todas las categorias
            CargarCategorias();
            
            // muestro la pantalla
            viewC.Show();
        }

        public void suscribirEventos()
        {
            // Ventana "Agregar Categoria"
            viewCategoria.AgregarNuevaCategoria_Event += AgregarNuevaCategoria;
            viewCategoria.IrVentanaAgregarNuevaCategoria_Event += IrVentanaAgregarNuevaCategoria;
            viewCategoria.RegresarVentanaAgregarNuevaCategoria_Event += RegresarVentanaAgregarNuevaCategoria;
            // Ventana "Eliminar Categoria"
            viewCategoria.EliminarCategoria_Event += EliminarCategoria;
            viewCategoria.IrVentanaEliminarCategoria_Event += IrVentanaEliminarCategoria;
            viewCategoria.RegresarVentanaEliminarCategoria_Event += RegresarVentanaEliminarCategoria;
            // Ventana "Editar Categoria"
            viewCategoria.EditarCategoria_Event += EditarCategoria;
            viewCategoria.IrVentanaEditarCategoria_Event += IrVentanaEditarCategoria;
            viewCategoria.RegresarVentanaEditarCategoria_Event += RegresarVentanaEditarCategoria;
            // Ventana "Buscar Categoria"
            viewCategoria.BuscarCategorias_Event += BuscarCategoria;
        }

        // Ventana "Agregar Categoria"
        private void AgregarNuevaCategoria(object sender, EventArgs e)
        {
            var modeloCategorias = new CategoriasModel();
            modeloCategorias.NombreCategoria = viewCategoria.NombreCategorias;
            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloCategorias);
                // valido que no este repetido
                if (databaseCategoria.ValidarNoRepetido(modeloCategorias.NombreCategoria) == 0)
                {
                   
                    databaseCategoria.AgregarCategoria(modeloCategorias);
                    viewCategoria.Exitoso = true;
                    CargarCategorias();
                    viewCategoria.Mensaje = "La categoria '"+ modeloCategorias.NombreCategoria + "' fue creada exitosamente";
                }  
                else
                {
                    viewCategoria.Exitoso = false;
                    viewCategoria.Mensaje = "La categoria ya existe";      
                }
                   
            }
            catch (Exception ex)
            {
                viewCategoria.Exitoso = false;
                viewCategoria.Mensaje = ex.Message;
            }

        }
        private void IrVentanaAgregarNuevaCategoria(object? sender, EventArgs e)
        {
            viewCategoria.EditarAgregarLbl = "Ingrese el nombre de la nueva categoria";
            viewCategoria.Editando = false;
        }
        private void RegresarVentanaAgregarNuevaCategoria(object? sender, EventArgs e)
        {
            viewCategoria.NombreCategorias = "";
        }

        // Ventana "Eliminar Categoria"
        private void EliminarCategoria(object? sender, EventArgs e)
        {
            // obtengo la categoria a eliminar
            var categoriaActual = (CategoriasModel)categoriasBindingSource.Current;
            // creo un modelo
            var modeloCategoria = new CategoriasModel();

            modeloCategoria.NombreCategoria = viewCategoria.CatagoriaEliminarCb;

            try
            {
                // valido el modelo
                new General.ModelDataValidation().Validar(modeloCategoria);
                // elimino la categoria                                          le paso la categoria a reemplazar
                databaseCategoria.EliminarCategoria(categoriaActual.IdCategoria, viewCategoria.CatagoriaEliminarCb);
                // cargo las categorias para actualizar la tabla
                CargarCategorias();
                viewCategoria.Exitoso = true;
                viewCategoria.Mensaje = "La categoria '" + categoriaActual.NombreCategoria + "' fue eliminada exitosamente";


            }
            catch (Exception ex)
            {
                viewCategoria.Exitoso = false;
                viewCategoria.Mensaje = ex.Message;
            }


        }

        private void IrVentanaEliminarCategoria(object? sender, EventArgs e)
        {
            // mostrar mensaje de cual categoria vas a eliminar
            var categoriaActual = (CategoriasModel)categoriasBindingSource.Current;
            viewCategoria.ElimnarLbl = "Para eliminar '" + categoriaActual.NombreCategoria + "' es necesario reemplazarla por: ";
            // obtener de la base de datos la lista de todos las categorias creadas,
            // exepto del id de la categoria eliminar

            // reutilizo el codigo que tengo de buscar categoria
            categoriaList = databaseCategoria.BuscarCategoriaExepto(categoriaActual.IdCategoria);
            // limpio los registros 
            cb.Items.Clear();
            // las agrego al combo box
            foreach (var cat in categoriaList)
            {
                cb.Items.Add(cat.NombreCategoria);
            }
            // se las mando al combo box que esta en la ventana eliminar
            viewCategoria.SetComboBoxCategoriasEliminar(cb);
            viewCategoria.PuedoEliminar = true;
            if (cb.Items.Count == 0)
            {
                viewCategoria.PuedoEliminar = false;
                viewCategoria.Mensaje = "¡NO PUEDES TENER 0 CATEGORIAS!";
            }

        }

        // no se usa
        private void RegresarVentanaEliminarCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        // Ventana "Editar Categoria"
        private void EditarCategoria(object? sender, EventArgs e)
        {
            // creo un modelo, el asignare el nuevo nombre con el que quiere sustiruirlo
            var modeloCategoriaSusutituto = new CategoriasModel();
            // le paso el parametro al modelo
            modeloCategoriaSusutituto.NombreCategoria = viewCategoria.NombreCategorias;
            // obtengo la categoria a editar
            var categoriaActual = (CategoriasModel)categoriasBindingSource.Current;
           
            try
            {
                // valido el modelo nuevo
                new General.ModelDataValidation().Validar(modeloCategoriaSusutituto);
                // valido que no este repetido
                if (databaseCategoria.ValidarNoRepetido(viewCategoria.NombreCategorias) == 0)
                {
                    databaseCategoria.EditarCategoria(categoriaActual.NombreCategoria, viewCategoria.NombreCategorias);
                    // cargo las categorias para actualizar la tabla
                    CargarCategorias();
                    viewCategoria.Exitoso = true;
                    viewCategoria.Mensaje = "La categoria '" + categoriaActual.NombreCategoria + "' a sido editada correctamente";

                }
                else
                {
                    viewCategoria.Exitoso = false;
                    viewCategoria.Mensaje = "La categoria ya existe";
                }
            }
            catch (Exception ex)
            {
                viewCategoria.Exitoso = false;
                viewCategoria.Mensaje = ex.Message;
            }


            
        }
        private void IrVentanaEditarCategoria(object sender, EventArgs e)
        {
            var categoriaActual = (CategoriasModel)categoriasBindingSource.Current;
            viewCategoria.EditarAgregarLbl = "La categoria '" + categoriaActual.NombreCategoria + "' sera editada por: ";
            viewCategoria.Editando = true;
        }
        private void RegresarVentanaEditarCategoria(object? sender, EventArgs e)
        {
            viewCategoria.Editando = false;
        }

        // Ventana "Buscar Categoria"
        private void BuscarCategoria(object sender, EventArgs e)
        {
            categoriaList = databaseCategoria.BuscarCategorias(viewCategoria.BuscarCategoriaTxt);
            categoriasBindingSource.DataSource = categoriaList;
        }

        private void CargarCategorias()
        {
            categoriaList = databaseCategoria.BuscarCategorias("");
            categoriasBindingSource.DataSource = categoriaList; 
        }

  
    }
}
