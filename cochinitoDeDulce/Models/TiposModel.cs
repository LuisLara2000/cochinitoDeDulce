using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class TiposModel
    {
        private int idTipo;
        private string nombreTipo;

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}
