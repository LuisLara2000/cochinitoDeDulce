using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public interface IMarcasDataBase
    {
        // para ingresar una categoria necesito un objeto de tipo categoria
        // en este caso siempre usare el modelo marca, en lugar de solo el nombre
        // solo el nombre lo extraere de el modelo marcas
        void AgregarMarca(MarcasModel marcasModel);
        void EditarMarca(string nombreActualMarca, string nombreNuevoMarca);
        void EliminarMarca(int IdMarcaEliminar, string nombreMarcaReemplazar);
        int ValidarNoRepetido(string nombreMarca);
        // para ver las categorias
        IEnumerable<MarcasModel> BuscarMarcas(string marcasNombre);
        // para ver la categoria exepto una
        IEnumerable<MarcasModel> BuscarMarcaExepto(int IdModel);
    }
}
