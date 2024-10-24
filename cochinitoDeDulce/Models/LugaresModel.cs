using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class LugaresModel
    {
        private int idLugar;
        private string nombreLugar;

        public int IdLugar { get => idLugar; set => idLugar = value; }
        public string NombreLugar { get => nombreLugar; set => nombreLugar = value; }
    }
}
