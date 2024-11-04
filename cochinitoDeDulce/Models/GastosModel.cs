using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class GastosModel
    {
        private int idGasto;
        private string nombre;
        private float precio;
        private float descuento;
        private float cantidad;
        private string unidad;
        private string fecha;
        private string comentario;
        private string categoria;
        private string lugar;
        private string marca;
        private string tipo;

        [DisplayName("ID")]
        public int IdGasto { get => idGasto; set => idGasto = value; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Es necesario asignar un Nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [DisplayName("Precio")]
        [Required(ErrorMessage = "Es necesario asignar el Precio")]
        public float Precio { get => precio; set => precio = value; }
        [DisplayName("Descuento")]
        public float Descuento { get => descuento; set => descuento = value; }
        [DisplayName("Cantidad")]
        public float Cantidad { get => cantidad; set => cantidad = value; }
        [DisplayName("Unidad")]
        public string Unidad { get => unidad; set => unidad = value; }
        [DisplayName("Fecha")]
        [Required(ErrorMessage = "Es necesario asignar una Fecha")]
        public string Fecha { get => fecha; set => fecha = value; }
        [DisplayName("Comentario")]
        public string Comentario { get => comentario; set => comentario = value; }
        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Es necesario asignar una Categoria")]
        public string Categoria { get => categoria; set => categoria = value; }
        [DisplayName("Lugar")]
        [Required(ErrorMessage = "Es necesario asignar un Lugar")]
        public string Lugar { get => lugar; set => lugar = value; }
        [DisplayName("Marca")]
        [Required(ErrorMessage = "Es necesario asignar una Marca")]
        public string Marca { get => marca; set => marca = value; }
        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Es necesario asignar un Tipo")]
        public string Tipo { get => tipo; set => tipo = value; }

       


    }
}
