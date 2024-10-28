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
        void EditarCategoria(CategoriasModel categoriasModel);
        void EliminarCategoria(CategoriasModel categoriasModel);
        // para ver las categorias
        IEnumerable<CategoriasModel> BuscarCategorias(string categoriaNombre);
    }
}
