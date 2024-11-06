using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class IngresosModel
    {
        private int idIngreso;
        private float monto;
        private string origen;

        [DisplayName("ID")]
        [Required(ErrorMessage = "Es necesario asignar un Id")]
        public int IdIngreso { get => idIngreso; set => idIngreso = value; }
        [DisplayName("Monto")]
        [Required(ErrorMessage = "Es necesario asignar un monto")]
        public float Monto { get => monto; set => monto = value; }
        [DisplayName("Origen")]
        [Required(ErrorMessage = "Es necesario asignar un origen")]
        public string Origen { get => origen; set => origen = value; }
    }
}
