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
                                    
                                    // El fondo del data grid cuando no hay registros
                                    ((DataGridView)tabPage).BackgroundColor = primary;

                                    // Le quito los bordes a las celdas
                                    ((DataGridView)tabPage).BorderStyle = BorderStyle.None;
                                    ((DataGridView)tabPage).CellBorderStyle = DataGridViewCellBorderStyle.None;
                                    ((DataGridView)tabPage).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                                    // Bloqueo poder hacer mas altas las celdas
                                    ((DataGridView)tabPage).ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                                    // Bloqueo poder hacer mas anchas las celdas
                                    ((DataGridView)tabPage).RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                                    // Hago que las columnas se expandan en todo el contenedor del datagrid
                                    ((DataGridView)tabPage).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    // Hago que las filas se expandas en todo el data grid view
                                    ((DataGridView)tabPage).AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

          
                                    // El color de cada celda
                                    ((DataGridView)tabPage).DefaultCellStyle.BackColor = primary;
                                    ((DataGridView)tabPage).DefaultCellStyle.ForeColor = secondary;

                                    // Para los encabezados de las filas (no se usa)
                                    //((DataGridView)tabPage).RowHeadersDefaultCellStyle.BackColor = primary;
                                    ((DataGridView)tabPage).RowHeadersVisible = false;// quita la columna con la flechita
                                    ((DataGridView)tabPage).RowHeadersVisible = false;

                                    // Estilo diferente a los encabezados de las columnas
                                    ((DataGridView)tabPage).ColumnHeadersDefaultCellStyle.BackColor = secondary;
                                    ((DataGridView)tabPage).ColumnHeadersDefaultCellStyle.ForeColor = primary;
                                    ((DataGridView)tabPage).EnableHeadersVisualStyles = false;// permite aplicar los cambios a los headers
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
