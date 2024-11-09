using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace cochinitoDeDulce.Estilos
{
    internal class EstilosGeneral
    {
        public static void CargarEstilosGeneral(Form Ventana)
        {
            // variables globales
            Color primary = Color.FromArgb(255,52,52,52);// gris
            Color secondary = Color.FromArgb(255,255,113,0);// naranja
            // para la ventana en general 
            Ventana.BackColor = primary;
            // para cada componente en la forma
            foreach (Control control in Ventana.Controls)
            {
                
                if(control is TabControl)
                {
                    // dentro del tab control
                  
                    foreach (Control tabControl in control.Controls)
                    {
                        // dentro de cada tab page
                        tabControl.BackColor = primary;
                        
                        if (tabControl is TabPage)
                        {
                            // ahora a cada componente dentro del tab page
                            foreach (Control tabPage in tabControl.Controls)
                            {
                                tabPage.BackColor = primary;
                                if(tabPage is Button)
                                {
                                    ((Button)tabPage).BackColor = secondary;// naranja
                                    ((Button)tabPage).ForeColor = primary;// gris
                                    ((Button)tabPage).FlatStyle = FlatStyle.Flat;
                                    ((Button)tabPage).Font = new Font(
                                        new FontFamily("OCR A Extended"),
                                        9,
                                        FontStyle.Bold);
                                }
                                else if (tabPage is Label)
                                {
                                    ((Label)tabPage).BackColor = primary;
                                    ((Label)tabPage).FlatStyle = FlatStyle.Flat;
                                    ((Label)tabPage).Font = new Font(
                                        new FontFamily("OCR A Extended"),
                                        9,
                                        FontStyle.Bold);
                                    ((Label)tabPage).ForeColor = secondary;

                                }
                                else if(tabPage is DataGridView)
                                {
                                    
                                    ((DataGridView)tabPage).BackColor = primary;
                                    ((DataGridView)tabPage).GridColor = primary;
                                    ((DataGridView)tabPage).BackgroundColor = primary;
                                }
                                else if(tabPage is TextBox)
                                {
                                    ((TextBox)tabPage).BackColor = primary;
                                    ((TextBox)tabPage).BorderStyle = BorderStyle.None;
                                    ((TextBox)tabPage).Font = new Font(
                                        new FontFamily("OCR A Extended"),
                                        11,
                                        FontStyle.Bold);
                                    ((TextBox)tabPage).ForeColor = secondary;
                                }

                            }
  
                        }
                    }
                }
                // botones
                if(control is Button)
                {
                    ((Button)control).BackColor = secondary;// naranja
                    ((Button)control).ForeColor = primary;// gris
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).Font = new Font(
                        new FontFamily("OCR A Extended"),
                        12,
                        FontStyle.Bold);
                }

               
            }
        }
    
    }
}
