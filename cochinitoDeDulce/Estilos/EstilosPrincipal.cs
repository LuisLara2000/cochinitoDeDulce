using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace cochinitoDeDulce.Estilos
{
    internal class EstilosPrincipal
    {
        public static void CargarEstilosPrincipal(Form actualForm)
        {
            // variables globales
            Color primary = Color.FromArgb(255,52,52,52);// gris
            Color secondary = Color.FromArgb(255,255,113,0);// naranja

            // el fondo en general
            //actualForm.FormBorderStyle = FormBorderStyle.FixedSingle;// para que no cubra la barra de tareas
            actualForm.WindowState = FormWindowState.Maximized;
            actualForm.BackColor = primary;
            //MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Location.ToString());
            //MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Size.ToString());
            //MessageBox.Show(Screen.PrimaryScreen.Bounds.ToString());

            // para cada componente en la forma
            foreach (Control control in actualForm.Controls)
            {

                if (control is MdiClient)
                {
                    ((MdiClient)control).ForeColor = primary;
                }
                // los compenentes que estan dentro del panel
                else if(control is Panel)
                {
                    foreach(Control c in control.Controls)
                    {
                        if(c is Button)
                        {
                            ((Button)c).BackColor = secondary;// naranja
                            ((Button)c).ForeColor = primary;// gris
                            ((Button)c).FlatStyle = FlatStyle.Flat;
                            ((Button)c).Font = new Font(
                                new FontFamily("OCR A Extended"),
                                12,
                                FontStyle.Bold);
                        }
                    }
                  
                }
            }
        }
        

    }
}
