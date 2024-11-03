using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public interface ITiposDatabase
    {
        // para ingresar una categoria necesito un objeto de tipo categoria
        // en este caso siempre usare el modelo marca, en lugar de solo el nombre
        // solo el nombre lo extraere de el modelo marcas
        void AgregarTipo(TiposModel tiposModel);
        void EditarTipo(string nombreActualTipo, string nombreNuevoTipo);
        void EliminarTipo(int IdTipoEliminar, string nombreTipoReemplazar);
        int ValidarNoRepetido(string nombreTipo);
        // para ver las categorias
        IEnumerable<TiposModel> BuscarTipos(string tiposNombre);
        // para ver la categoria exepto una
        IEnumerable<TiposModel> BuscarTipoExepto(int IdTipo);
    }
}
