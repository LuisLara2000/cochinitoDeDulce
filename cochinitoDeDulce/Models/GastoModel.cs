using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Models
{
    public class GastoModel
    {
        private int idGasto;
        private int idCategoria;
        private int idLugar;
        private int idMarca;
        private int idImagenGasto;
        private int idDetalle;
        private int idTipo;

        public int IdGasto { get => idGasto; set => idGasto = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdLugar { get => idLugar; set => idLugar = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public int IdImagenGasto { get => idImagenGasto; set => idImagenGasto = value; }
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
