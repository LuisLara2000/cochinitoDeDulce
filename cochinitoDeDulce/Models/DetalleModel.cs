using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// librerias para hacer las validaciones
using System.ComponentModel;// librerias para hacer las validaciones

namespace cochinitoDeDulce.Models
{
    public class DetalleModel
    {
        // campos
        private int idDetalle;
        private string nombre;
        private float precio;
        private float cantidad;
        private string unidad;
        private float descuento;
        private DateTime fecha;
        private string comentario;

        // propiedades y validaciones

        [DisplayName("Detalle ID")]
        public int IdDetalle { 
            get => idDetalle; 
            set => idDetalle = value; 
        }

        [DisplayName("Nombre")]
        public string Nombre { 
            get => nombre; 
            set => nombre = value; 
        }

        [DisplayName("Precio")]
        public float Precio { 
            get => precio; 
            set => precio = value; 
        }

        [DisplayName("Cantidad")]
        public float Cantidad { 
            get => cantidad; 
            set => cantidad = value; 
        }

        [DisplayName("Unidad")]
        public string Unidad { 
            get => unidad; 
            set => unidad = value; 
        }

        [DisplayName("Descuento")]
        public float Descuento { 
            get => descuento; 
            set => descuento = value; 
        }

        [DisplayName("Fecha")]
        public DateTime Fecha { 
            get => fecha; 
            set => fecha = value; 
        }

        [DisplayName("Comentario")]
        public string Comentario { 
            get => comentario; 
            set => comentario = value; 
        }
    }
}
