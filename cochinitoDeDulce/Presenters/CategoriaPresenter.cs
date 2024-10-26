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

        // creamos el constructor (importante)
        public CategoriaPresenter(ICategoriasView viewC,ICategoriasDataBase databaseC)
        {
            viewCategoria = viewC;
            databaseCategoria = databaseC;
            // suscribimos los eventos que se ejecutan en la vista
            viewCategoria.AgregarNuevaCategoria_Event += AgregarNuevaCategoria;
            viewC.Show();
        }

        private void AgregarNuevaCategoria(object sender, EventArgs e)
        {
            var modeloCategorias = new CategoriasModel();
            modeloCategorias.NombreCategoria = viewCategoria.NombreCategorias;

        }
    }
}
