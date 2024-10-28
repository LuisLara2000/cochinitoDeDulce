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

        // creamos el constructor (importante)
        public CategoriaPresenter(ICategoriasView viewC,ICategoriasDataBase databaseC)
        {
            this.categoriasBindingSource = new BindingSource();// asignammos el binding source de la vista categoria
            viewCategoria = viewC;
            databaseCategoria = databaseC;
            // suscribimos los eventos que se ejecutan en la vista
          
            // set categorias binding source
            viewCategoria.SetPetListBindingSource(categoriasBindingSource);
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
            // Ventana "Editar Categoria"
            // Ventana "Buscar Categoria"
            viewCategoria.BuscarCategorias_Event += BuscarCategoria;
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
            throw new NotImplementedException();
        }
        private void RegresarVentanaAgregarNuevaCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Ventana "Eliminar Categoria"
        // Ventana "Editar Categoria"
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
