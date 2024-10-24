using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    internal class IngresosModel
    {
        private int idIngreso;
        private float monto;
        private string origen;

        public int IdIngreso { get => idIngreso; set => idIngreso = value; }
        public float Monto { get => monto; set => monto = value; }
        public string Origen { get => origen; set => origen = value; }
    }
}
