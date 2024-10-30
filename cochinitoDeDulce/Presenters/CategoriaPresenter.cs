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
            viewCategoria.IrVentanaEditarCategoria_Event += IrVentanaEditarCategoria;
            // Ventana "Buscar Categoria"
            viewCategoria.BuscarCategorias_Event += BuscarCategoria;
        }

        private void EliminarCategoria(object? sender, EventArgs e)
        {
            // obtengo la categoria a eliminar
            var categoriaActual = (CategoriasModel)categoriasBindingSource.Current;
            // elimino la categoria                                          le paso la categoria a reemplazar
            databaseCategoria.EliminarCategoria(categoriaActual.IdCategoria, viewCategoria.CatagoriaEliminarCb);
            // muestro mensaje de aviso
            MessageBox.Show("La categoria " + categoriaActual.NombreCategoria + " a sido eliminada correctamente");
            // cargo las categorias para actualizar la tabla
            CargarCategorias();
        }






        // Ventana "Agregar Categoria"
        private void AgregarNuevaCategoria(object sender, EventArgs e)
        {
            var modeloCategorias = new CategoriasModel();
            modeloCategorias.NombreCategoria = viewCategoria.NombreCategorias;
            databaseCategoria.AgregarCategoria(modeloCategorias);
        }
        private void IrVentanaAgregarNuevaCategoria(object? sender, EventArgs e)
        {

            viewCategoria.EditarAgregarLbl = "Ingrese el nombre de la nueva categoria";
        }
        private void RegresarVentanaAgregarNuevaCategoria(object? sender, EventArgs e)
        {
            viewCategoria.NombreCategorias = "";
        }

        // Ventana "Eliminar Categoria"
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
        }

        private void RegresarVentanaEliminarCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        // Ventana "Editar Categoria"
        private void IrVentanaEditarCategoria(object sender, EventArgs e)
        {
            var categoriaActual = (CategoriasModel)categoriasBindingSource.Current;
            // error aqui
            viewCategoria.EditarAgregarLbl = "La categoria '" + categoriaActual.NombreCategoria + "' sera editada por: ";
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

        private void mostrarCategoriasVentanaEliminar()
        {

        }

    }
}
