using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class MarcasModel
    {
        private int idMarca;
        private string nombreMarca;

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }
    }
}
