using cochinitoDeDulce._DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public interface IGastosDatabase
    {
        void AgregarGasto(GastosModel gastoModel);
        void EditarGasto(int idGastoActual, GastosModel gastoEditado);
        void EliminarGasto(int idGastoEliminar);
        IEnumerable<CategoriasModel> ObtenerCategorias();
        IEnumerable<MarcasModel> ObtenerMarcas();
        IEnumerable<LugaresModel> ObtenerLugares();
        IEnumerable<TiposModel> ObtenerTipos();
        IEnumerable<GastosModel> BuscarGastos(string gastoNombre);

    }
}
