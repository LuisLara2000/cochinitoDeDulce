using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class LugaresModel
    {
        private int idLugar;
        private string nombreLugar;

        [DisplayName("ID")]
        public int IdLugar { get => idLugar; set => idLugar = value; }
        [DisplayName("Lugar")]
        [Required(ErrorMessage = "Los espacios en blanco no son validos")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe contener entre minimo 2 carecteres y maximo 100 caracteres")]
        public string NombreLugar { get => nombreLugar; set => nombreLugar = value; }
    }
}
