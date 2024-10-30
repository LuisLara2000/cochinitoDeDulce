using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public interface ICategoriasDataBase
    {
        // comportamiento para el acceso a datos

        // para ingresar una categoria necesito un objeto de tipo categoria
        void AgregarCategoria(CategoriasModel categoriasModel);
        void EditarCategoria(string nombreActualCategoria, string nombreNuevoCategoria);
        void EliminarCategoria(int IdCategoriaEliminar, string NombreCategoriaReemplazar);
        int ValidarNoRepetido(string nombreCategoria);
        // para ver las categorias
        IEnumerable<CategoriasModel> BuscarCategorias(string categoriaNombre);
        // para ver la categoria exepto una
        IEnumerable<CategoriasModel> BuscarCategoriaExepto(int categoriaId);
    }
}
