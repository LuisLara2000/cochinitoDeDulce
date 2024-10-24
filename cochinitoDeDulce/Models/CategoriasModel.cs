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
        [DisplayName("Categoria ID")]
        public int IdCategoria {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Asignarle un nombre a la categoria es necesario")]
        [StringLength(100,MinimumLength =1,ErrorMessage ="El nombre de la categoria no debe ser un espacio en blanco")]
        public string NombreCategoria {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

    }
}
