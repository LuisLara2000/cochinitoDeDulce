using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Estilos
{
    internal class TamañosPosiciones
    {
        
        public static void CargarPosiciones(Form Ventana)
        {
            int anchoMenuLateral = 150;
        // estabablecemos el tamaño del tab page que contiene el formulario
            Ventana.Width = Screen.PrimaryScreen.Bounds.Width-anchoMenuLateral;
            Ventana.Height = Screen.PrimaryScreen.Bounds.Height;// para que no se vea el borde infeiror
        }
    }
}
