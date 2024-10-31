using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// librerias para hacer las validaciones
using System.ComponentModel;// librerias para hacer las validaciones
namespace cochinitoDeDulce.Models
{
    public class CategoriasModel
    {
        // campos
        private int idCategoria;
        private string nombreCategoria;

        // propiedades y validaciones
        [DisplayName("ID")]
        public int IdCategoria {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Asignarle un nombre a la categoria es necesario")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="El nombre de la categoria debe contener minimo 2 caracteres y maximo 100 caracteres")]
        public string NombreCategoria {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

    }
}
