using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class MarcasModel
    {
        private int idMarca;
        private string nombreMarca;

        [DisplayName("ID")]
        public int IdMarca { 
            get { return idMarca; }
            set { idMarca = value; }
        }

        [DisplayName("Marca")]
        [Required(ErrorMessage = "Los espacios en blanco no son validos")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe contener entre minimo 2 carecteres y maximo 100 caracteres")]

        public string NombreMarca { 
            get { return nombreMarca; }
            set { nombreMarca = value; }
        }
    }
}
