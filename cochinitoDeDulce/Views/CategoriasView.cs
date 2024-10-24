using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cochinitoDeDulce.Views
{
    public partial class CategoriasView : Form, ICategoriasView
    {
        public CategoriasView()
        {
            // no se que hace esto jaja
            InitializeComponent();
            // asociamos los eventos con las acciones que suceden en la vista
            AsociarEventosDeLaVista();
            tbCategorias.TabPages.Remove(tpCategoriasAgregarEditar);

        }

        private void AsociarEventosDeLaVista()
        {
            btnAgregar.Click += delegate
            {
                AgregarNuevaCategoria_Event?.Invoke(this, EventArgs.Empty);
                tbCategorias.TabPages.Remove(tpCategoriasVer);
                tbCategorias.TabPages.Add(tpCategoriasAgregarEditar);
            };
        }

        public string IdCategoria {
            get { return txtIdCategoria.ToString(); }
            set { txtIdCategoria.Text = value; }
        }
        public string NombreCategorias {
            get { return txtNombreCategoria.ToString(); }
            set { txtNombreCategoria.Text = value; }
        }

        public event EventHandler AgregarNuevaCategoria_Event;

        // noooooooooooooooooooooooooooo
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
