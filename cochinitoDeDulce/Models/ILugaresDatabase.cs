using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public interface ILugaresDatabase
    {
        void AgregarLugar(LugaresModel lugaresModel);
        void EditarLugar(string nombreActualLugar, string nombreNuevoLugar);
        void EliminarLugar(int IdLugarEliminar, string nombreLugarReemplazar);
        int ValidarNoRepetido(string nombreLugar);
        // para ver las categorias
        IEnumerable<LugaresModel> BuscarLugares(string lugaresNombre);
        // para ver la categoria exepto una
        IEnumerable<LugaresModel> BuscarLugarExepto(int IdLugar);
    }
}
