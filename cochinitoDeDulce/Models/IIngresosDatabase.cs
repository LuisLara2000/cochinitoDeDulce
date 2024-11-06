using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public interface IIngresosDatabase
    {
        void AgregarIngreso(IngresosModel ingresoModel);
        void EditarIngreso(IngresosModel ingresoModel);
        void EliminarIngeso(int idIngreso);
        IEnumerable<IngresosModel> BuscarIngreso(string origen);
    }
}
